using ControllerScouting.Database;
using ControllerScouting.Gamepad;
using ControllerScouting.Properties;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace ControllerScouting.Utilities
{
    internal class BackgroundCode
    {
        public static GamePad[] gamePads;                           //List of all the gamepads connected to the computer
        public static Controllers controllers = new();              //The controller class that handles all the gamepad stuff
        public static readonly List<Thread> controllerThreads = [];
        public static readonly List<CancellationTokenSource> controllerCancellationTokens = [];

        public static RobotState[] Robots = new RobotState[6];      //Contains the state of each Scout's match tracking

        public static List<Match> InMemoryMatchList = [];           //The list of all the matches at the selected event.
        public static List<Match> UnSortedMatchList = [];           //This is just the list of all matches, not yet sorted
        public static List<int> MatchNumbers = [];                  //The list of match numbers for the event selected

        public static List<string> teamlist = [];                   //The list of teams for the event selected

        public static Queue<Activity> activitiesQueue = new();      //The queue of activities to be sent to the database
        public static Activity[] activity_record = new Activity[6]; //The activity record being sent to the database
        public static SeasonContext seasonframework = new();        //The database context

        public static List<string> teamPrio = [];                   //List of teams to prioritize scouting
        public static string homeTeam = "frc842";                   //Your team number
        public static List<string> homePrio = [];                   //List of teams to prioritize based on who you play with next

        public static List<List<string>> manualMatchList = null;    //The list of matches inputed manually
        public static bool redRight = false;                        //Is red alliance on your right?
        public static int currentMatch = 0;                         //The current match number
        public static string loadedEvent = "";                      //The event currently loaded
        public static bool practiceMode = false;                    //Is the scouting system in practice mode?
        public static int practiceTeam = 0;

        public static ComboBox loadRegionalData = new();

        public static readonly string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        public static readonly string projectBaseDirectory = System.IO.Path.GetFullPath(System.IO.Path.Combine(baseDirectory, @"..\..\"));
        public static readonly string iniPath = System.IO.Path.Combine(projectBaseDirectory, "config.ini");
        public static readonly INIFile iniFile = new(iniPath);
        public enum EXPORT_TYPE { CSV, SQLlocal, SQLonline}
        public static EXPORT_TYPE dataExport = EXPORT_TYPE.CSV;
        public BackgroundCode()
        {

        }

        public static void Initialize()
        {
            if (Enum.TryParse<EXPORT_TYPE>(iniFile.Read("ProgramSettings", "exportType", ""), out var exportType))
            {
                dataExport = exportType;
            }
            else
            {
                dataExport = EXPORT_TYPE.CSV;
            }
            Settings.Default.CSVLocation = iniFile.Read("ProgramSettings", "csvLocation", "");

            if (dataExport == EXPORT_TYPE.CSV)
            {
                Settings.Default.csvExists = DatabaseCode.DoesCSVExist(Settings.Default.CSVLocation);
            }

            //Sets the default values for the robots
            for (int i = 0; i < 6; i++)
            {
                Robots[i] = new RobotState
                {
                    ScouterBox = i,
                    _ScouterName = RobotState.SCOUTER_NAME.Select_Name,
                    color = i < 3 ? "Red" : "Blue"
                };

                activity_record[i] = new Activity();
            }

            gamePads = Controllers.GetGamePads();
            // Create and start a new thread for each controller
            StartControllerThreads();

            InitalizeDB();
        }
        public static void CheckSQLExists()
        {
            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView);
            RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
            if (instanceKey != null)
            {
                foreach (var instanceName in instanceKey.GetValueNames())
                {
                    _ = Logger.Log(Environment.MachineName + @"\" + instanceName);
                }
            }
            Settings.Default.sqlExists = instanceKey != null;

            if (!Settings.Default.sqlExists)
            {
                dataExport = EXPORT_TYPE.CSV;
            }
        }
        private static void ControllerThreadMethod(GamePad gamePad, CancellationToken token)
        {
            // Logic to handle the controller
            while (!token.IsCancellationRequested)
            {
                // Read and process the controller input
                if (gamePad != null) Controllers.ReadStick(gamePad, Array.IndexOf(gamePads, gamePad));
            }
        }

        private static void InitalizeDB()
        {
            if (Settings.Default.sqlExists)
            {
                // Sets the connection string to the database
                seasonframework.Database.Connection.ConnectionString = Settings.Default._scoutingdbConnectionString;

                // initializes the database
                seasonframework.Database.Initialize(true);
            }
        }
        public static void StartControllerThreads()
        {
            foreach (GamePad gamePad in gamePads)
            {
                if (gamePad != null)
                {
                    var cts = new CancellationTokenSource();
                    Thread controllerThread = new(() => ControllerThreadMethod(gamePad, cts.Token));
                    controllerThread.Start();
                    controllerThreads.Add(controllerThread);
                    controllerCancellationTokens.Add(cts);
                }
            }
        }
        public static void SaveData()
        {
            if ((loadedEvent != null || manualMatchList != null) && currentMatch != 0)
            {
                try
                {
                    // Write data to INI file
                    if (loadedEvent == null)
                    {
                        iniFile.Write("MatchData", "event", "manualEvent");
                    }
                    else
                    {
                        iniFile.Write("MatchData", "event", loadedEvent);
                    }
                    iniFile.Write("MatchData", "match_number", currentMatch.ToString());
                    iniFile.Write("MatchData", "redRight", redRight.ToString());
                    iniFile.Write("MatchData", "teamPrio", string.Join(",", teamPrio));
                    iniFile.Write("MatchData", "homeTeam", homeTeam);
                    string scouterNames = "";
                    string scouterLocations = "";
                    foreach (var robot in Robots)
                    {
                        if (scouterNames.Length != 0)
                        {
                            scouterNames += ",";
                        }
                        scouterNames += robot.GetScouterName();

                        if (scouterLocations.Length != 0)
                        {
                            scouterLocations += ",";
                        }
                        scouterLocations += robot.ScouterBox;
                    }
                    iniFile.Write("MatchData", "scouterNames", scouterNames);
                    iniFile.Write("MatchData", "scouterLocations", scouterLocations);

                    string matches = "";
                    foreach (var match in InMemoryMatchList)
                    {
                        if (matches.Length != 0)
                        {
                            matches += ",";
                        }
                        matches += $"{match.Blueteam1};{match.Blueteam2};{match.Blueteam3};{match.Redteam1};{match.Redteam2};{match.Redteam3}";
                    }
                    iniFile.Write("EventData", "Matches", matches);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving data: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No data to save.");
            }
        }
    }
}
