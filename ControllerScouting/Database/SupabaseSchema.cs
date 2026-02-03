using ControllerScouting.Utilities;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static ControllerScouting.Utilities.RobotState;

namespace ControllerScouting.Database
{
    [Table("Activity")]
    public class SupabaseActivity : BaseModel
    {
        [PrimaryKey("Id", true)]
        public long Id { get; set; }

        [Column("Team")]
        public string Team { get; set; }

        [Column("Match")]
        public int Match { get; set; }

        [Column("Time")]
        public DateTime Time { get; set; }

        [Column("RecordType")]
        public string RecordType { get; set; }

        [Column("Mode")]
        public string Mode { get; set; }

        [Column("DriveStation")]
        public string DriveStation { get; set; }

        [Column("Defense")]
        public string Defense { get; set; }

        [Column("DefenseTime")]
        public double DefenseTime { get; set; }

        [Column("Avoidance")]
        public string Avoidance { get; set; }

        [Column("ScouterName")]
        public string ScouterName { get; set; }

        [Column("ScouterError")]
        public long ScouterError { get; set; }

        [Column("MatchEvent")]
        public string MatchEvent { get; set; }

        [Column("Strategy")]
        public string Strategy { get; set; }

        [Column("StartingLocation")]
        public string StartingLocation { get; set; }

        [Column("ClimbTime")]
        public double ClimbTime { get; set; }
        
        [Column("FuelIntakingTime")]
        public double FuelIntakingTime { get; set; }

        [Column("FuelShootingTime")]
        public double FuelShootingTime { get; set; }

        [Column("FeedingTime")]
        public double FeedingTime { get; set; }
        
        [Column("TimeOfClimb")]
        public double TimeOfClimb { get; set; }

        [Column("EndState")]
        public string EndState { get; set; }

        [Column("AttemptClimb")]
        public string AttemptClimb { get; set; }

        [Column("LadderLocation")]
        public string LadderLocation { get; set; }

        [Column("AutoClimb")]
        public string AutoClimb { get; set; }
        
        [Column("BumpTraversal")]
        public int BumpTraversal { get; set; }

        public static async Task WriteToSupabase()
        {
            if (BackgroundCode.supabase == null || BackgroundCode.activitiesQueue.Count == 0)
            {
                return;
            }

            while(BackgroundCode.activitiesQueue.Count != 0)
            {
                Activity activity = BackgroundCode.activitiesQueue.Dequeue();
                try
                {
                    var record = new SupabaseActivity
                    {
                        Team = activity.Team,
                        Match = activity.Match,
                        Time = activity.Time,
                        RecordType = activity.RecordType,
                        Mode = activity.Mode,
                        DriveStation = activity.DriveStation,
                        StartingLocation = activity.StartingLocation,
                        BumpTraversal = activity.BumpTraversal,
                        Defense = activity.Defense,
                        Avoidance = activity.Avoidance,
                        DefenseTime = activity.DefenseTime,
                        FuelIntakingTime = activity.FuelIntakingTime,
                        FuelShootingTime = activity.FuelShootingTime,
                        FeedingTime = activity.FeedingTime,
                        ClimbTime = activity.ClimbTime,
                        TimeOfClimb = activity.TimeOfClimb,
                        LadderLocation = activity.LadderLocation,
                        AutoClimb = activity.AutoClimb,
                        ScouterName = activity.ScouterName,
                        ScouterError = activity.ScouterError,
                        MatchEvent = activity.MatchEvent,
                        AttemptClimb = activity.AttemptClimb,
                        EndState = activity.EndState,
                        Strategy = activity.Strategy
                    };

                    // Determine table name from BackgroundCode.loadedEvent, sanitize for Postgres table naming
                    string raw = BackgroundCode.loadedEvent;
                    string tableName = string.IsNullOrWhiteSpace(raw) ? "activity" : raw.Trim();
                    // Trim common surrounding characters and sanitize non-word characters to underscores
                    tableName = tableName.Trim('[', ']', ' ').ToLowerInvariant();
                    tableName = Regex.Replace(tableName, @"[^\w]", "_");

                    // Try dynamic From(string).Insert(...) first.
                    var supabaseClient = BackgroundCode.supabase;
                    MethodInfo fromMethod = supabaseClient?.GetType().GetMethod("From", [typeof(string)]);
                    if (fromMethod != null)
                    {
                        var tableInstance = fromMethod.Invoke(supabaseClient, [tableName]);
                        if (tableInstance != null)
                        {
                            // Try to find an Insert(object) or Insert(dynamic) overload
                            MethodInfo insertMethod = tableInstance.GetType().GetMethod("Insert", [typeof(object)])
                                                      ?? tableInstance.GetType().GetMethod("Insert", [typeof(SupabaseActivity)])
                                                      ?? tableInstance.GetType().GetMethod("Insert", Type.EmptyTypes);

                            if (insertMethod != null)
                            {
                                // Invoke and await returned Task
                                var insertResult = insertMethod.Invoke(tableInstance, insertMethod.GetParameters().Length == 0 ? null : new object[] { record });
                                if (insertResult is Task task)
                                {
                                    await task;
                                }
                                else
                                {
                                    // As a fallback, call the generic API
                                    await BackgroundCode.supabase.From<SupabaseActivity>().Insert(record);
                                }
                            }
                            else
                            {
                                // Fallback to generic when Insert signature not found
                                await BackgroundCode.supabase.From<SupabaseActivity>().Insert(record);
                            }
                        }
                        else
                        {
                            await BackgroundCode.supabase.From<SupabaseActivity>().Insert(record);
                        }
                    }
                    else
                    {
                        // If dynamic From(string) is not available, use the generic approach
                        await BackgroundCode.supabase.From<SupabaseActivity>().Insert(record);
                    }
                }
                catch (Supabase.Postgrest.Exceptions.PostgrestException ex)
                {
                    var httpStatus = ex.Response?.StatusCode;
                    var codeText = httpStatus.HasValue ? $"{(int)httpStatus} ({httpStatus})" : "Unknown";
                    _ = Logger.Log($"Supabase insert failed: {codeText} - {ex.Message}");
                }
                catch (Exception ex)
                {
                    _ = Logger.Log($"Supabase insert failed: {ex.Message}");
                }
            }
        }
    }
}