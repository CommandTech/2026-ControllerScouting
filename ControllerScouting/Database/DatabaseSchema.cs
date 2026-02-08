using ControllerScouting.Properties;
using ControllerScouting.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;
using System.Reflection;

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

    public abstract class ActivityBase : BaseEntity
    {
        protected ActivityBase()
        {
            foreach (var prop in this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                if (prop.PropertyType == typeof(string) && prop.CanWrite)
                {
                    prop.SetValue(this, "-");
                }
                else if (prop.PropertyType == typeof(int) && prop.CanWrite)
                {
                    prop.SetValue(this, -1);
                }
                else if (prop.PropertyType == typeof(double) && prop.CanWrite)
                {
                    prop.SetValue(this, -1.0);
                }
                else if (prop.PropertyType == typeof(DateTime) && prop.CanWrite)
                {
                    prop.SetValue(this, DateTime.MinValue);
                }
                else if (prop.PropertyType == typeof(long) && prop.CanWrite)
                {
                    prop.SetValue(this, -1L);
                }
            }
        }

        //2026
        public string Team { get; set; }
        public int Match { get; set; }
        public DateTime Time { get; set; }
        public string RecordType { get; set; }
        public string Mode { get; set; }
        public string DriveStation { get; set; }
        public string StartingLocation { get; set; }
        public int BumpTraversal { get; set; }
        public string Defense { get; set; }
        public string Avoidance { get; set; }
        public double DefenseTime { get; set; }
        public double FuelIntakingTime { get; set; }
        public double FuelShootingTime { get; set; }
        public double FeedingTime { get; set; }
        public double ClimbTime { get; set; }
        public double TimeOfClimb { get; set; }
        public string LadderLocation { get; set; }
        public string AutoClimb { get; set; }
        public string ScouterName { get; set; }
        public long ScouterError { get; set; }
        public string MatchEvent { get; set; }
        public string AttemptClimb { get; set; }
        public string EndState { get; set; }
        public string Strategy { get; set; }

        //Examples from previous years
        //public TimeSpan Cycle { get; set; }
        //public DateTime AcquireTime { get; set; }
        //public DateTime DeliverTime { get; set; }
        //public Decimal score_contribution { get; set; }
    }

    public class Activity : ActivityBase
    {
        public Activity() : base() { }

        public Activity DeepCopy()
        {
            var json = JsonSerializer.Serialize(this);
            return JsonSerializer.Deserialize<Activity>(json);
        }

        public string ToCSV()
        {
            var values = new[]
            {
                Team,
                Match.ToString(),
                Time.ToString(),
                RecordType,
                Mode,
                DriveStation,
                StartingLocation,
                BumpTraversal.ToString(),
                Defense,
                Avoidance,
                DefenseTime.ToString(),
                FuelIntakingTime.ToString(),
                FuelShootingTime.ToString(),
                FeedingTime.ToString(),
                ClimbTime.ToString(),
                TimeOfClimb.ToString(),
                LadderLocation,
                AutoClimb,
                ScouterName,
                ScouterError.ToString(),
                MatchEvent,
                AttemptClimb,
                EndState,
                Strategy
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

    public class UpdatePreview : ActivityBase
    {
        public UpdatePreview() : base() { }
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
        internal static void SaveToRecord(RobotState controller, string recordtype)
        {

            if (controller.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name && controller.TeamName != null)
            {

                Activity activity_record = new()
                {
                    Time = DateTime.Now,
                    Team = BackgroundCode.Robots[controller.ScouterBox].TeamName,
                    Match = BackgroundCode.currentMatch,
                    Mode = controller.GetRobotMode().ToString(),
                    ScouterName = controller.GetScouterName().ToString(),
                    ScouterError = controller.ScouterError,
                    RecordType = recordtype
                };

                if (controller.ScouterBox == 0)
                {
                    activity_record.DriveStation = "red0";
                } 
                else if (controller.ScouterBox == 1)
                {
                    activity_record.DriveStation = "red1";
                }
                else if (controller.ScouterBox == 2)
                {
                    activity_record.DriveStation = "red2";
                }
                else if (controller.ScouterBox == 3)
                {
                    activity_record.DriveStation = "blue0";
                }
                else if (controller.ScouterBox == 4)
                {
                    activity_record.DriveStation = "blue1";
                }
                else if (controller.ScouterBox == 5)
                {
                    activity_record.DriveStation = "blue2";
                }

                switch (recordtype)
                {
                    case "EndAuto":
                        activity_record.AutoClimb = controller.GetAutoClimb().ToString();
                        activity_record.StartingLocation = controller.GetStartingLocation().ToString();

                        activity_record.BumpTraversal = controller.BumpTraversal;
                        activity_record.FuelShootingTime = controller.FuelShootingTime.TotalSeconds;
                        activity_record.FuelIntakingTime = controller.FuelIntakingTime.TotalSeconds;
                        activity_record.FeedingTime = controller.FeedingTime.TotalMinutes;

                        controller.FuelShootingTime_StopWatch.Reset();
                        controller.FuelShootingTime = controller.FuelShootingTime_StopWatch.Elapsed;
                        controller.FuelIntakingTime_StopWatch.Reset();
                        controller.FuelIntakingTime = controller.FuelIntakingTime_StopWatch.Elapsed;
                        controller.FeedingTime_StopWatch.Reset();
                        controller.FeedingTime = controller.FeedingTime_StopWatch.Elapsed;


                        break;
                    case "Activities":
                        activity_record.BumpTraversal = controller.BumpTraversal;
                        activity_record.FuelIntakingTime = controller.FuelIntakingTime.TotalSeconds;
                        activity_record.FuelShootingTime = controller.FuelShootingTime.TotalSeconds;
                        activity_record.DefenseTime = controller.DefenseTime.TotalSeconds;
                        activity_record.FeedingTime = controller.FeedingTime.TotalMinutes;

                        controller.FuelIntakingTime_StopWatch.Reset();
                        controller.FuelIntakingTime = controller.FuelIntakingTime_StopWatch.Elapsed;
                        controller.FuelShootingTime_StopWatch.Reset();
                        controller.FuelShootingTime = controller.FuelShootingTime_StopWatch.Elapsed;
                        controller.DefenseTime_StopWatch.Reset();
                        controller.DefenseTime = controller.DefenseTime_StopWatch.Elapsed;
                        controller.FeedingTime_StopWatch.Reset();
                        controller.FeedingTime = controller.FeedingTime_StopWatch.Elapsed;
                        break;
                    case "EndMatch":
                        activity_record.ClimbTime = controller.ClimbTime.TotalSeconds;
                        activity_record.TimeOfClimb = controller.TimeOfClimb.TotalSeconds;
                        activity_record.AttemptClimb = controller.GetClimbSuccess().ToString();
                        activity_record.Avoidance = controller.GetAvoidanceStrategy().ToString();
                        activity_record.Defense = controller.GetDefenseStrategy().ToString();
                        activity_record.EndState = controller.GetClimbLevel().ToString();
                        activity_record.LadderLocation = controller.GetLadderLocation().ToString();
                        activity_record.Strategy = controller.GetStrategy().ToString();

                        activity_record.DefenseTime = controller.DefenseTime.TotalSeconds;
                        activity_record.BumpTraversal = controller.BumpTraversal;
                        activity_record.FuelShootingTime = controller.FuelShootingTime.TotalSeconds;
                        activity_record.FuelIntakingTime = controller.FuelIntakingTime.TotalSeconds;
                        activity_record.FeedingTime = controller.FeedingTime.TotalSeconds;

                        break;
                    case "Match_Event":
                        activity_record.MatchEvent = controller.MatchEvent.ToString();

                        controller.MatchEvent = RobotState.MATCHEVENT_NAME.Match_Event;
                        break;
                    default:
                        MessageBox.Show("Error: Record Type not found");
                        break;
                }

                Activity activityCopy = activity_record.DeepCopy();
                BackgroundCode.activitiesQueue.Enqueue(activityCopy);
            }
        }
        public static void SendToDatabase(Activity activity)
        {
            switch (BackgroundCode.dataExport)
            {
                case BackgroundCode.EXPORT_TYPE.CSV:
                    {
                        //Save Record to the CSV file
                        string locationFixed = Settings.Default.CSVLocation.Replace(@"\", @"\\");
                        using StreamWriter sw = File.AppendText(locationFixed + "\\" + databaseName);
                        sw.WriteLine(activity.ToCSV());
                    }
                    break;
                case BackgroundCode.EXPORT_TYPE.SQLonline:

                    //Save Record to the database
                    BackgroundCode.localSeasonframework.ActivitySet.Add(activity);
                    BackgroundCode.localSeasonframework.SaveChanges();

                    //Save Record to the database
                    BackgroundCode.serverSeasonframework.ActivitySet.Add(activity);
                    BackgroundCode.serverSeasonframework.SaveChanges();

                    break;
                case BackgroundCode.EXPORT_TYPE.SQLlocal:

                    //Save Record to the database
                    BackgroundCode.localSeasonframework.ActivitySet.Add(activity);
                    BackgroundCode.localSeasonframework.SaveChanges();
                        
                    break;
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