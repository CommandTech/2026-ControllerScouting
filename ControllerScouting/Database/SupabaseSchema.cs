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

        [Column("Strategy")]
        public string Strategy { get; set; }

        [Column("Coop")]
        public int Coop { get; set; }

        [Column("DZTime")]
        public double DZTime { get; set; }

        [Column("Del_Near_Far")]
        public string Del_Near_Far { get; set; }

        [Column("AcqAlgae_Near_Far")]
        public string AcqAlgae_Near_Far { get; set; }

        [Column("AcqCoral_Near_Far")]
        public string AcqCoral_Near_Far { get; set; }

        [Column("Starting_Loc")]
        public string Starting_Loc { get; set; }

        [Column("Leave")]
        public string Leave { get; set; }

        [Column("AcqCoralS")]
        public int AcqCoralS { get; set; }

        [Column("AcqCoralF")]
        public int AcqCoralF { get; set; }

        [Column("AcqAlgaeR")]
        public int AcqAlgaeR { get; set; }

        [Column("AcqAlgaeF")]
        public int AcqAlgaeF { get; set; }

        [Column("DelCoralL1")]
        public int DelCoralL1 { get; set; }

        [Column("DelCoralL2")]
        public int DelCoralL2 { get; set; }

        [Column("DelCoralL3")]
        public int DelCoralL3 { get; set; }

        [Column("DelCoralL4")]
        public int DelCoralL4 { get; set; }

        [Column("DelCoralF")]
        public int DelCoralF { get; set; }

        [Column("DelAlgaeP")]
        public int DelAlgaeP { get; set; }

        [Column("DelAlgaeN")]
        public int DelAlgaeN { get; set; }

        [Column("DelAlgaeF")]
        public int DelAlgaeF { get; set; }

        [Column("ClimbT")]
        public double ClimbT { get; set; }

        [Column("EndState")]
        public string EndState { get; set; }

        [Column("CageAttempt")]
        public string CageAttempt { get; set; }

        [Column("PointScored")]
        public string PointScored { get; set; }

        [Column("DisAlg")]
        public int DisAlg { get; set; }

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
                        Match_event = activity.Match_event,
                        Strategy = activity.Strategy,
                        Coop = activity.Coop,
                        DZTime = activity.DZTime,
                        Del_Near_Far = activity.Del_Near_Far,
                        AcqAlgae_Near_Far = activity.AcqAlgae_Near_Far,
                        AcqCoral_Near_Far = activity.AcqCoral_Near_Far,
                        Starting_Loc = activity.Starting_Loc,
                        Leave = activity.Leave,
                        AcqCoralS = activity.AcqCoralS,
                        AcqCoralF = activity.AcqCoralF,
                        AcqAlgaeR = activity.AcqAlgaeR,
                        AcqAlgaeF = activity.AcqAlgaeF,
                        DelCoralL1 = activity.DelCoralL1,
                        DelCoralL2 = activity.DelCoralL2,
                        DelCoralL3 = activity.DelCoralL3,
                        DelCoralL4 = activity.DelCoralL4,
                        DelCoralF = activity.DelCoralF,
                        DelAlgaeP = activity.DelAlgaeP,
                        DelAlgaeN = activity.DelAlgaeN,
                        DelAlgaeF = activity.DelAlgaeF,
                        ClimbT = activity.ClimbT,
                        EndState = activity.EndState,
                        CageAttempt = activity.CageAttempt,
                        PointScored = activity.PointScored,
                        DisAlg = activity.DisAlg
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