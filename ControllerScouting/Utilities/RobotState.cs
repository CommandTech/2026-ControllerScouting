using System;
using System.Diagnostics;
using ControllerScouting.Database;

namespace ControllerScouting.Utilities
{
    public class RobotState
    {
        public enum ROBOT_MODE { Auto, Teleop, Defense, Surfacing };
        public enum CYCLE_DIRECTION { Up, Down }
        public enum MATCHEVENT_NAME { Match_Event, GotStuck, BrokeDown, CrossedCenter, LostParts, AdditionalPiece, MultiClimb, NoShow, TippedOver, JammedPiece, WentUnderCages }
        public enum SCOUTER_NAME { Select_Name, Scouter1, Scouter2, Scouter3, Scouter4, Scouter5, Scouter6 }

        // Year to Year ints
        public long ScouterError;
        public long prevScouterError;
        public int ScouterBox;
        public bool TransactionCheck;

        // Year to Year strings
        public string color;

        // Year to Year bools
        public bool RTHUP_Lock;
        public bool AUTO = true;
        public bool NoSho = false;

        public bool Flag = false;
        
  
        
        // These are the standard types...

        public ROBOT_MODE Desired_Mode;         //Desired Mode

        //LOCAL VARIABLES SECTION.  All underscored variables indicate local variables for one controller/scouter

        public SCOUTER_NAME _ScouterName;          //ScouterName
        private string _TeamName;                   //TeamName
        private MATCHEVENT_NAME _match_event;       //Match Event
        private ROBOT_MODE _RobotMode;              //Control

        public ROBOT_MODE Current_Mode
        {
            get { return _RobotMode; }
            set { _RobotMode = value; }
        }

        public String TeamName
        {
            get { return _TeamName; }
            set { _TeamName = value; }
        }
        public MATCHEVENT_NAME Match_event
        {
            get { return _match_event; }
            set { _match_event = value; }
        }

        //public SCOUTER_NAME ScouterName
        //{
        //    get { return _ScouterName; }
        //    set { _ScouterName = value; }
        //}
        public SCOUTER_NAME GetScouterName()
        { return _ScouterName; }


        //Scouter Name
        public void ChangeScouterName(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
                _ScouterName = (SCOUTER_NAME)GetNextEnum<SCOUTER_NAME>(_ScouterName);
            else
            {
                _ScouterName = (SCOUTER_NAME)GetPreviousEnum<SCOUTER_NAME>(_ScouterName);
            }
        }

        //Cycle Event Name
        public void CycleEventName(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
            {
                _match_event = (MATCHEVENT_NAME)GetNextEnum<MATCHEVENT_NAME>(_match_event);
            }
            else
            {
                _match_event = (MATCHEVENT_NAME)GetPreviousEnum<MATCHEVENT_NAME>(_match_event);
            }
        }

        private static Enum GetNextEnum<T>(object currentlySelectedEnum)
        {
            Type enumList = typeof(T);
            if (!enumList.IsEnum)
                throw new InvalidOperationException("Object is not an Enum.");

            Array enums = Enum.GetValues(enumList);
            int index = Array.IndexOf(enums, currentlySelectedEnum);
            index = (index + 1) % enums.Length;
            return (Enum)enums.GetValue(index);
        }

        private static Enum GetPreviousEnum<T>(object currentlySelectedEnum)
        {
            Type enumList = typeof(T);
            if (!enumList.IsEnum)
                throw new InvalidOperationException("Object is not an Enum.");

            Array enums = Enum.GetValues(enumList);
            int index = Array.IndexOf(enums, currentlySelectedEnum);
            index = (((index == 0) ? enums.Length : index) - 1);
            return (Enum)enums.GetValue(index);
        }

        //2026
        //private LEAVE _Leave;

        //2026
        //public LEAVE GetLeave()
        //{ return _Leave; }


        //2026
        //public LEAVE Leave
        //{
        //    get { return _Leave; }
        //    set { _Leave = value; }
        //}


        //2026 cycles
        //public void CycleLeave(CYCLE_DIRECTION CycleDirection)
        //{
        //    if (CycleDirection == CYCLE_DIRECTION.Up)
        //    {
        //        _Leave = (LEAVE)GetNextEnum<LEAVE>(_Leave);
        //    }
        //    else
        //    {
        //        _Leave = (LEAVE)GetPreviousEnum<LEAVE>(_Leave);
        //    }
        //    if (_Leave == LEAVE.Z)
        //    {
        //        CycleLeave(CycleDirection);
        //    }
        //}


        //2026 Enum

        public TimeSpan ClimbT = TimeSpan.Zero;
        public Stopwatch ClimbT_StopWatch;
        public bool ClimbT_StopWatch_running;
        public double ClimbTDouble;

        public TimeSpan TimeOfClimbT = TimeSpan.Zero;
        public Stopwatch TimeOfClimbT_StopWatch;
        public bool TimeOfClimbT_StopWatch_running;
        public double TimeOfClimbTDouble;

        public TimeSpan DefTime = TimeSpan.Zero;
        public Stopwatch DefTime_StopWatch;
        public bool DefTime_StopWatch_running;
        public double DefTimeDouble;

        public TimeSpan IntakingT = TimeSpan.Zero;
        public Stopwatch IntakingT_StopWatch;
        public bool IntakingT_StopWatch_running;
        public double IntakingTDouble;

        public TimeSpan FeedingT = TimeSpan.Zero;
        public Stopwatch FeedingT_StopWatch;
        public bool FeedingT_StopWatch_running;
        public double FeedingTDouble;

        public TimeSpan ShootingT = TimeSpan.Zero;
        public Stopwatch ShootingT_StopWatch;
        public bool ShootingT_StopWatch_running;
        public double ShootingTDouble;

        public enum STARTING_LOCATION { Far_Trench, Far_Bump, Hub, Near_Bump, Near_Trench}

        public int bumpCounter = 0;
        public enum CLIMB_LEVEL { No_Climb, L1, L2, L3};
        public bool climbSuccess = false;
        public bool DisplayClimbSuccess = false;
        public enum LADDER_LOCATION { Outpost, Center, Depot};

        public enum DEFENSE_STRATEGY { None, Trench, Bump, Neutral_Zone, Pushing };

        public enum AVOIDANCE_STRATEGY { None, Trench, Bump, Neutral_Zone, Pushing };

        public enum STRATEGY { None, Shooting, Feeding };


        public void Transact(int controllerNumber, bool isMatchEevent)
        {
            if (isMatchEevent)
            {
                if (Match_event == MATCHEVENT_NAME.Match_Event)
                {
                    ScouterError += 100000;
                }
                else
                {
                    DatabaseCode.SaveToRecord(this, "Match_Event", controllerNumber);
                    if (Match_event == MATCHEVENT_NAME.NoShow)
                    {
                        NoSho = true;
                    }
                    Match_event = MATCHEVENT_NAME.Match_Event;
                }
            }
            else
            {
                DatabaseCode.SaveToRecord(this, "Activities", controllerNumber);
            }
        }

        public RobotState GetRobotState()
        {
            return this;
        }

        public static RobotState ResetScouter(RobotState state)
        {
            return new RobotState
            {
                ScouterBox = state.ScouterBox,
                _ScouterName = state._ScouterName,
                color = state.color
            };
        }
    }
}
