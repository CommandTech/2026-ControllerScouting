using ControllerScouting.Properties;
using ControllerScouting.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Windows.Forms;

namespace ControllerScouting.Database
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
    }

    internal class SeasonContext : DbContext
    {
        public SeasonContext()
            : base(Settings.Default._scoutingdbConnectionString)
        { }

        public EventSummary Eventset { get; set; }
        public TeamSummary Teamset { get; set; }
        public Match Matchset { get; set; }
        public DbSet<Activity> ActivitySet { get; set; }
        public DbSet<UpdatePreview> UpdatePreviewSet { get; set; }
    }

    public class Activity : BaseEntity
    {
        //Data elements used in multiple modes (Auto, Auto and/or Showtime)
        //Record Type = Transaction

        //2025
        public string Team { get; set; }
        public int Match { get; set; }
        public DateTime Time { get; set; }
        public string RecordType { get; set; }
        public string Mode { get; set; }
        public string DriveSta { get; set; }
        public string Defense { get; set; }
        public string DefenseValue { get; set; }
        public string Avoidance { get; set; }
        public string ScouterName { get; set; }
        public long ScouterError { get; set; }
        public string Match_event { get; set; }


        //Examples from previous years
        //public TimeSpan Cycle { get; set; }
        //public DateTime AcquireTime { get; set; }
        //public DateTime DeliverTime { get; set; }
        //public Decimal score_contribution { get; set; }



        public string ToCSV()
        {
            var values = new[]
            {
                Team,
                Match.ToString(),
                Time.ToString(),
                RecordType,
                Mode,
                DriveSta,
                Defense,
                DefenseValue,
                Avoidance,
                ScouterName,
                ScouterError.ToString(),
                Match_event
            };

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] != null)
                {
                    values[i] = $"\"{values[i].Replace("\"", "\"\"")}\"";
                }
                else
                {
                    values[i] = "\"\"";
                }
            }

            return string.Join(",", values);
        }
    }

    public class UpdatePreview : BaseEntity
    {
        //2025
        public string Team { get; set; }
        public int Match { get; set; }
        public DateTime Time { get; set; }
        public string RecordType { get; set; }
        public string Mode { get; set; }
        public string DriveSta { get; set; }
        public string Defense { get; set; }
        public string DefenseValue { get; set; }
        public string Avoidance { get; set; }
        public string ScouterName { get; set; }
        public long ScouterError { get; set; }
        public string Match_event { get; set; }

        public string Strategy { get; set; }
        public int Coop { get; set; }
        public double DZTime { get; set; }
        public string Del_Near_Far { get; set; }
        public string AcqAlgae_Near_Far { get; set; }
        public string AcqCoral_Near_Far { get; set; }

        public string Starting_Loc { get; set; }
        public string Leave { get; set; }

        public int AcqCoralS { get; set; }
        public int AcqCoralF { get; set; }
        public int AcqAlgaeR { get; set; }
        public int AcqAlgaeF { get; set; }

        public int DelCoralL1 { get; set; }
        public int DelCoralL2 { get; set; }
        public int DelCoralL3 { get; set; }
        public int DelCoralL4 { get; set; }
        public int DelCoralF { get; set; }

        public int DelAlgaeP { get; set; }
        public int DelAlgaeN { get; set; }
        public int DelAlgaeF { get; set; }

        public double ClimbT { get; set; }
        public string EndState { get; set; }
        public string CageAttempt { get; set; }
        public string PointScored { get; set; }
        public int DisAlg { get; set; }
    }
    public class EventSummary
    {
        public string Key { get; set; }
        public string Website { get; set; }
        public bool Official { get; set; }
        public string End_date { get; set; }
        public string Name { get; set; }
        public string Short_name { get; set; }
        public string Facebook_eid { get; set; }
        public string Event_district_string { get; set; }
        public string Venue_address { get; set; }
        public int Event_district { get; set; }
        public string Week { get; set; }
        public string Location { get; set; }
        public string Event_code { get; set; }
        public int Year { get; set; }
        public List<object> Webcast { get; set; }
        public string Timezone { get; set; }
        public List<object> Alliances { get; set; }
        public string Event_type_string { get; set; }
        public string Start_date { get; set; }
        public int Event_type { get; set; }
    }

    public class TeamSummary
    {
        /* UNUSED DATA AVAILABLE FROM TBA
        public string address { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string gmaps_place_id { get; set; }
        public string gmaps_url { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
        public string location_name { get; set; }
        public string motto { get; set; }
        public string name { get; set; }
        public string nickname { get; set; }
        public string postal_code { get; set; }
        public string rookie_year { get; set; }
        public string school_name { get; set; }
        public string state_prov { get; set; }
        public string website { get; set; }         */
        public string Event_key { get; set; }
        public string Team_key { get; set; }
        public string Team_number { get; set; }
        public string Nickname { get; set; }
    }

    public class Match
    {
        public string Comp_level { get; set; }
        public int Match_number { get; set; }
        public List<object> Videos { get; set; }
        public object Time_string { get; set; }
        public int Set_number { get; set; }
        public string Key { get; set; }
        public string Time { get; set; }
        public string Blueteam1 { get; set; }
        public string Blueteam2 { get; set; }
        public string Blueteam3 { get; set; }
        public string Redteam1 { get; set; }
        public string Redteam2 { get; set; }
        public string Redteam3 { get; set; }
        public string Event_key { get; set; }
        public int Pointscorered { get; set; }
        public int Redfouls { get; set; }
        public int Pointscoreblue { get; set; }
        public int Bluefouls { get; set; }
        public int Blueauto { get; set; }
        public int Redauto { get; set; }
        public int Bluecharge { get; set; }
        public int Redcharge { get; set; }
        public int Bluetotaldel { get; set; }
        public int Redtotaldel { get; set; }
    }

    public static class DatabaseCode
    {
        public static List<Match> ListToMatch(string[] list)
        {
            List<Match> matches = [];
            for (int i = 0; i < list.Length; i++)
            {
                List<string> teams = [.. list[i].Split(';')];
                Match matchData = new()
                {
                    Match_number = i,
                    Set_number = i,
                    Key = BackgroundCode.loadedEvent,
                    Comp_level = "qm",
                    Event_key = BackgroundCode.loadedEvent,

                    Redteam1 = teams[3],
                    Redteam2 = teams[4],
                    Redteam3 = teams[5],
                    Blueteam1 = teams[0],
                    Blueteam2 = teams[1],
                    Blueteam3 = teams[2]
                };

                matches.Add(matchData);
            }
            return matches;
        }

        public const string databaseName = "database.csv";
        public static void LoadManualMatches()
        {

            string csvBaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string csvProjectBaseDirectory = Path.GetFullPath(Path.Combine(csvBaseDirectory, @"..\..\"));
            string csvPath = Path.Combine(csvProjectBaseDirectory, "ManualMatchList.csv");

            BackgroundCode.manualMatchList = ReadCsvFile(csvPath);
        }
        public static List<List<string>> ReadCsvFile(string filePath)
        {
            var records = new List<List<string>>();

            using (var reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var values = line.Split(',');
                    if (values.Length == 6)
                    {
                        records.Add([.. values]);
                    }
                }
            }

            return records;
        }
        internal static void SaveToRecord(RobotState controller, string recordtype, int controllerNumber)
        {
            Activity activity_record = BackgroundCode.activity_record[controllerNumber];
            switch (recordtype)
            {
                case "EndAuto":
                    activity_record.Time = DateTime.Now;
                    activity_record.Team = BackgroundCode.Robots[controller.ScouterBox].TeamName;
                    activity_record.Match = BackgroundCode.currentMatch;
                    activity_record.Mode = controller.Current_Mode.ToString();
                    activity_record.ScouterName = controller.GetScouterName().ToString();

                    activity_record.Match_event = "-";
                        
                    activity_record.ScouterError = controller.ScouterError;

                    activity_record.RecordType = recordtype;


                    controller.TransactionCheck = false;
                    break;
                case "Activities":
                    activity_record.Time = DateTime.Now;
                    activity_record.Team = BackgroundCode.Robots[controller.ScouterBox].TeamName;
                    activity_record.Match = BackgroundCode.currentMatch;
                    activity_record.Mode = controller.Current_Mode.ToString();
                    activity_record.ScouterName = controller.GetScouterName().ToString();

                    activity_record.Match_event = "-";

                    activity_record.ScouterError = controller.ScouterError;

                    activity_record.RecordType = recordtype;


                    controller.TransactionCheck = false;
                    break;
                case "EndMatch":
                    activity_record.Time = DateTime.Now;
                    activity_record.Team = BackgroundCode.Robots[controller.ScouterBox].TeamName;
                    activity_record.Match = BackgroundCode.currentMatch;
                    activity_record.Mode = controller.Current_Mode.ToString();
                    activity_record.ScouterName = controller.GetScouterName().ToString();

                    activity_record.Match_event = "-";

                    activity_record.ScouterError = controller.ScouterError;

                    activity_record.RecordType = recordtype;


                    controller.TransactionCheck = false;
                    break;
                case "Match_Event":
                    activity_record.Time = DateTime.Now;
                    activity_record.Team = BackgroundCode.Robots[controller.ScouterBox].TeamName;
                    activity_record.Match = BackgroundCode.currentMatch;
                    activity_record.Mode = controller.Current_Mode.ToString();
                    activity_record.ScouterName = controller.GetScouterName().ToString();

                    activity_record.Match_event = "-";

                    activity_record.ScouterError = controller.ScouterError;

                    activity_record.RecordType = recordtype;


                    controller.TransactionCheck = false;
                    break;
                default:
                    MessageBox.Show("Error: Record Type not found");
                    break;
            }

            Activity activityCopy = new()
            {
                Team = activity_record.Team,
                Match = activity_record.Match,
                Time = activity_record.Time,
                RecordType = activity_record.RecordType,
                Mode = activity_record.Mode,
                DriveSta = activity_record.DriveSta,
                Defense = activity_record.Defense,
                DefenseValue = activity_record.DefenseValue,
                Avoidance = activity_record.Avoidance,
                ScouterName = activity_record.ScouterName,
                ScouterError = activity_record.ScouterError,
                Match_event = activity_record.Match_event
            };
            BackgroundCode.activitiesQueue.Enqueue(activityCopy);
        }

        public static void SendToDatabase()
        {
            switch (BackgroundCode.dataExport)
            {
                case BackgroundCode.EXPORT_TYPE.CSV:
                    foreach (Activity activity in BackgroundCode.activitiesQueue)
                    {
                        //Save Record to the CSV file
                        string locationFixed = Settings.Default.CSVLocation.Replace(@"\", @"\\");
                        using StreamWriter sw = File.AppendText(locationFixed + "\\" + databaseName);
                        sw.WriteLine(activity.ToCSV());
                    }
                    break;
                case BackgroundCode.EXPORT_TYPE.SQLonline:
                    BackgroundCode.seasonframework.Database.Connection.Close();
                    BackgroundCode.seasonframework.Database.Connection.ConnectionString = Settings.Default._scoutingdbServerConnectionString;
                    BackgroundCode.seasonframework.Database.Connection.Open();

                    foreach (Activity activity in BackgroundCode.activitiesQueue)
                    {
                        //Save Record to the database
                        BackgroundCode.seasonframework.ActivitySet.Add(activity);
                        BackgroundCode.seasonframework.SaveChanges();
                    }
                    break;
                case BackgroundCode.EXPORT_TYPE.SQLlocal:
                    BackgroundCode.seasonframework.Database.Connection.Close();
                    BackgroundCode.seasonframework.Database.Connection.ConnectionString = Settings.Default._scoutingdbConnectionString;
                    BackgroundCode.seasonframework.Database.Connection.Open();

                    foreach (Activity activity in BackgroundCode.activitiesQueue)
                    {
                        //Save Record to the database
                        BackgroundCode.seasonframework.ActivitySet.Add(activity);
                        BackgroundCode.seasonframework.SaveChanges();
                    }
                    break;
                }

            BackgroundCode.activitiesQueue.Clear();

            for (int i = 0; i < BackgroundCode.gamePads.Length; i++)
            {
                if (BackgroundCode.gamePads[i] != null)
                {
                    BackgroundCode.Robots[i] = RobotState.ResetScouter(BackgroundCode.Robots[i]);
                }
            }
        }

        public static bool DoesCSVExist(string location)
        {
            static string DoubleBackslashesAndEnsureTrailing(string input)
            {
                string doubled = input.Replace(@"\", @"\\");
                if (!doubled.EndsWith(@"\\"))
                {
                    doubled += @"\\";
                }
                return doubled;
            }

            string locationCorrected = DoubleBackslashesAndEnsureTrailing(location);

            return File.Exists(locationCorrected + databaseName);
        }
        public static void CreateCSV(string location)
        {
            static string DoubleBackslashesAndEnsureTrailing(string input)
            {
                string doubled = input.Replace(@"\", @"\\");
                if (!doubled.EndsWith(@"\\"))
                {
                    doubled += @"\\";
                }
                return doubled;
            }

            string locationCorrected = DoubleBackslashesAndEnsureTrailing(location);
            
            string filePath = locationCorrected + databaseName;
            string directoryPath = Path.GetDirectoryName(filePath);
            Directory.CreateDirectory(directoryPath);
            File.Create(filePath).Close();

            Settings.Default.csvExists = true;
        }

        public static void MoveCSV(string oldLocation, string newLocation)
        {
            static string DoubleBackslashesAndEnsureTrailing(string input)
            {
                string doubled = input.Replace(@"\", @"\\");
                if (!doubled.EndsWith(@"\\"))
                {
                    doubled += @"\\";
                }
                return doubled;
            }

            string oldLocationCorrected = DoubleBackslashesAndEnsureTrailing(oldLocation);
            string newLocationCorrected = DoubleBackslashesAndEnsureTrailing(newLocation);

            string oldFilePath = oldLocationCorrected + databaseName;
            string newFilePath = newLocationCorrected + databaseName;

            string directoryPath = Path.GetDirectoryName(newFilePath);
            Directory.CreateDirectory(directoryPath);
            File.Move(oldFilePath, newFilePath);

            string dir = Path.GetDirectoryName(oldFilePath);
            while (!string.IsNullOrEmpty(dir) && Directory.Exists(dir) && Directory.GetFileSystemEntries(dir).Length == 0)
            {
                Directory.Delete(dir);
                dir = Path.GetDirectoryName(dir);
            }
        }
    }
}