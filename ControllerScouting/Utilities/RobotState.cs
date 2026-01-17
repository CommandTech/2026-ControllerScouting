using System;
using System.Diagnostics;
using ControllerScouting.Database;

namespace ControllerScouting.Utilities
{
    public class RobotState
    {
        public enum ROBOT_MODE { Auto, Teleop, Endgame };
        public enum CYCLE_DIRECTION { Up, Down }
        public enum MATCHEVENT_NAME { Match_Event, GotStuck, BrokeDown, CrossedCenter, LostParts, AdditionalPiece, MultiClimb, NoShow, TippedOver, JammedPiece, WentUnderCages }
        public enum SCOUTER_NAME { Select_Name, Scouter1, Scouter2, Scouter3, Scouter4, Scouter5, Scouter6 }

        public enum BOOLEAN { Z, Yes, No, Error}

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

        public int bumpCounter = 0;
        private BOOLEAN Climb_Success_Endgame = BOOLEAN.Error;
        private BOOLEAN Climb_Auto = BOOLEAN.Error;
        private BOOLEAN End_Match = BOOLEAN.Error;
        public bool DisplayClimbSuccess = false;
        public enum STARTING_LOCATION { Far_Trench, Far_Bump, Hub, Near_Bump, Near_Trench }
        public enum LADDER_LOCATION { Outpost, Center, Depot };
        public enum DEFENSE_STRATEGY { None, Trench, Bump, Neutral_Zone, Pushing };
        public enum AVOIDANCE_STRATEGY { None, Trench, Bump, Neutral_Zone, Pushing };
        public enum STRATEGY { None, Shooting, Feeding };
        public enum CLIMB_LEVEL { No_Climb, L1, L2, L3 };


        private STARTING_LOCATION _Starting_Location;
        private LADDER_LOCATION _Ladder_Location;
        private DEFENSE_STRATEGY _Defense_Strategy;
        private AVOIDANCE_STRATEGY _Avoidance_Strategy;
        private STRATEGY _Strategy;
        private CLIMB_LEVEL _Climb_Level;


        public STARTING_LOCATION GetStartingLocation()
        { return _Starting_Location; }

        public STARTING_LOCATION Starting_Location
        {
            get { return _Starting_Location; }
            set { _Starting_Location = value; }
        }

        public void CycleStartingLocation(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
            {
                _Starting_Location = (STARTING_LOCATION)GetNextEnum<STARTING_LOCATION>(_Starting_Location);
            }
            else
            {
                _Starting_Location = (STARTING_LOCATION)GetPreviousEnum<STARTING_LOCATION>(_Starting_Location);
            }
        }

        public LADDER_LOCATION GetLadderLocation()
        { return _Ladder_Location; }

        public LADDER_LOCATION Ladder_Location
        {
            get { return _Ladder_Location; }
            set { _Ladder_Location = value; }
        }

        public void CycleLadderLocation(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
            {
                _Ladder_Location = (LADDER_LOCATION)GetNextEnum<LADDER_LOCATION>(_Ladder_Location);
            }
            else
            {
                _Ladder_Location = (LADDER_LOCATION)GetPreviousEnum<LADDER_LOCATION>(_Ladder_Location);
            }
        }


        public DEFENSE_STRATEGY GetDefenseStrategy()
        { return _Defense_Strategy; }

        public DEFENSE_STRATEGY Defense_Strategy
        {
            get { return _Defense_Strategy; }
            set { _Defense_Strategy = value; }
        }

        public void CycleDefenseStrategy(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
            {
                _Defense_Strategy = (DEFENSE_STRATEGY)GetNextEnum<DEFENSE_STRATEGY>(_Defense_Strategy);
            }
            else
            {
                _Defense_Strategy = (DEFENSE_STRATEGY)GetPreviousEnum<DEFENSE_STRATEGY>(_Defense_Strategy);
            }
        }

        public AVOIDANCE_STRATEGY GetAvoidanceStrategy()
        { return _Avoidance_Strategy; }

        public AVOIDANCE_STRATEGY Avoidance_Strategy
        {
            get { return _Avoidance_Strategy; }
            set { _Avoidance_Strategy = value; }
        }

        public void CycleAvoidanceStrategy(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
            {
                _Avoidance_Strategy = (AVOIDANCE_STRATEGY)GetNextEnum<AVOIDANCE_STRATEGY>(_Avoidance_Strategy);
            }
            else
            {
                _Avoidance_Strategy = (AVOIDANCE_STRATEGY)GetPreviousEnum<AVOIDANCE_STRATEGY>(_Avoidance_Strategy);
            }
        }

        public STRATEGY GetStrategy()
        { return _Strategy; }

        public STRATEGY Strategy
        {
            get { return _Strategy; }
            set { _Strategy = value; }
        }

        public void CycleStrategy(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
            {
                _Strategy = (STRATEGY)GetNextEnum<STRATEGY>(_Strategy);
            }
            else
            {
                _Strategy = (STRATEGY)GetPreviousEnum<STRATEGY>(_Strategy);
            }
        }

        public CLIMB_LEVEL GetClimbLevel()
        { return _Climb_Level; }

        public CLIMB_LEVEL Climb_Level
        {
            get { return _Climb_Level; }
            set { _Climb_Level = value; }
        }

        public void CycleClimbLevel(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
            {
                _Climb_Level = (CLIMB_LEVEL)GetNextEnum<STRATEGY>(_Climb_Level);
            }
            else
            {
                _Climb_Level = (CLIMB_LEVEL)GetPreviousEnum<STRATEGY>(_Climb_Level);
            }
        }

        public BOOLEAN GetAutoClimb()
        { return _Climb_Auto; }

        public BOOLEAN _Climb_Auto
        {
            get { return _Climb_Auto; }
            set { _Climb_Auto = value; }
        }


        public void CycleAutoClimb(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
            {
                _Climb_Auto = (BOOLEAN)GetNextEnum<BOOLEAN>(_Climb_Auto);
            }
            else
            {
                _Climb_Auto = (BOOLEAN)GetPreviousEnum<BOOLEAN>(_Climb_Auto);
            }

            if (_Climb_Auto == BOOLEAN.Z)
            {
                CycleClimbSuccessEndgame(CycleDirection);
            }
        }

        public BOOLEAN GetEndMatch()
        { return _End_Match; }

        public BOOLEAN _End_Match
        {
            get { return _End_Match; }
            set { _End_Match = value; }
        }
        public void CycleEndMatch(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
            {
                _End_Match = (BOOLEAN)GetNextEnum<BOOLEAN>(_End_Match);
            }
            else
            {
                _End_Match = (BOOLEAN)GetPreviousEnum<BOOLEAN>(_End_Match);
            }

            if (_End_Match == BOOLEAN.Z)
            {
                CycleClimbSuccessEndgame(CycleDirection);
            }
        }
        public BOOLEAN GetClimbSuccessEndGame()
        { return _Climb_Success_Endgame; }

        public BOOLEAN _Climb_Success_Endgame
        {
            get { return _Climb_Success_Endgame; }
            set { _Climb_Success_Endgame = value; }
        }
        public void CycleClimbSuccessEndgame(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
            {
                _Climb_Success_Endgame = (BOOLEAN)GetNextEnum<BOOLEAN>(_Climb_Success_Endgame);
            }
            else
            {
                _Climb_Success_Endgame = (BOOLEAN)GetPreviousEnum<BOOLEAN>(_Climb_Success_Endgame);
            }

            if (_Climb_Success_Endgame == BOOLEAN.Z)
            {
                CycleClimbSuccessEndgame(CycleDirection);
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
