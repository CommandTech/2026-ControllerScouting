using ControllerScouting.Properties;
using ControllerScouting.Screens;
using Microsoft.Win32;
using System;
using System.Text;
using System.Windows.Forms;
using Supabase;
using ControllerScouting.Database;

namespace ControllerScouting.Utilities
{
    static class Program
    {
        ///The main entry point for the application.
        [STAThread]
        static void Main()
        {
            //Handles code crashes, used for saving data when the code crashes during events
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Determines what functions to run when different exceptions are thrown
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            using var _ = Logger.Erase();
            
            BackgroundCode.Initialize();
            BackgroundCode.CheckSQLExists();
            Application.Run(new BaseScreen());
        }

        // Handle UI thread exceptions
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            HandleException(e.Exception);
        }

        // Handle non-UI thread exceptions
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            HandleException(e.ExceptionObject as Exception);
        }

        // Common exception handling method
        static void HandleException(Exception ex)
        {
            if (ex != null)
            {
                // Log the exception, show a message, or perform other actions
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                SaveDataOnCrash();
            }
        }

        // Method to save data or perform cleanup on crash
        static void SaveDataOnCrash()
        {
            try
            {
                //Determines if the loaded event is a manual event or a real event
                //Then saves the data to the config file
                if (BackgroundCode.loadedEvent == null)
                {
                    BackgroundCode.iniFile.Write("MatchData", "event", "manualEvent");
                }
                else
                {
                    BackgroundCode.iniFile.Write("MatchData", "event", BackgroundCode.loadedEvent);
                }
                BackgroundCode.iniFile.Write("MatchData", "match_number", BackgroundCode.currentMatch.ToString());
                BackgroundCode.iniFile.Write("MatchData", "redRight", BackgroundCode.redRight.ToString());
                BackgroundCode.iniFile.Write("MatchData", "teamPrio", string.Join(",", BackgroundCode.teamPrio));
                BackgroundCode.iniFile.Write("MatchData", "homeTeam", BackgroundCode.homeTeam);
                //Gets the current scouter names and locations to save
                var scouterNames = new StringBuilder();
                var scouterLocations = new StringBuilder();
                foreach (var robot in BackgroundCode.Robots)
                {
                    if (scouterNames.Length != 0) scouterNames.Append(',');
                    scouterNames.Append(robot.GetScouterName());
                    if (scouterLocations.Length != 0) scouterLocations.Append(',');
                    scouterLocations.Append(robot.ScouterBox);
                }
                BackgroundCode.iniFile.Write("MatchData", "scouterNames", scouterNames.ToString());
                BackgroundCode.iniFile.Write("MatchData", "scouterLocations", scouterLocations.ToString());

                var matches = new StringBuilder();
                foreach (var match in BackgroundCode.InMemoryMatchList)
                {
                    if (matches.Length != 0) matches.Append(',');
                    matches.Append($"{match.Blueteam1};{match.Blueteam2};{match.Blueteam3};{match.Redteam1};{match.Redteam2};{match.Redteam3}");
                }
                BackgroundCode.iniFile.Write("EventData", "Matches", matches.ToString());
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the save process
                MessageBox.Show("Error saving data on crash: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Environment.Exit(0);
        }
    }
}