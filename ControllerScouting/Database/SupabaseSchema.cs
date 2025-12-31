using ControllerScouting.Utilities;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;
using System.Threading.Tasks;

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

        [Column("DriveSta")]
        public string DriveSta { get; set; }

        [Column("Defense")]
        public string Defense { get; set; }

        [Column("DefenseValue")]
        public string DefenseValue { get; set; }

        [Column("Avoidance")]
        public string Avoidance { get; set; }

        [Column("ScouterName")]
        public string ScouterName { get; set; }

        [Column("ScouterError")]
        public long ScouterError { get; set; }

        [Column("Match_event")]
        public string Match_event { get; set; }

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
                    var test = new SupabaseActivity
                    {
                        Team = activity.Team,
                        Match = activity.Match,
                        Time = activity.Time,
                        RecordType = activity.RecordType,
                        Mode = activity.Mode,
                        DriveSta = activity.DriveSta,
                        Defense = activity.Defense,
                        DefenseValue = activity.DefenseValue,
                        Avoidance = activity.Avoidance,
                        ScouterName = activity.ScouterName,
                        ScouterError = activity.ScouterError,
                        Match_event = activity.Match_event
                    };

                    var insertResponse = await BackgroundCode.supabase.From<SupabaseActivity>().Insert(test);
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