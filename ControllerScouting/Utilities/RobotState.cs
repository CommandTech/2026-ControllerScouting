using System;
using System.Diagnostics;
using ControllerScouting.Database;

namespace ControllerScouting.Utilities
{
    public class RobotState
    {
        public enum ROBOT_MODE { Auto, Teleop, Endgame };
        public enum CYCLE_DIRECTION { Up, Down }
        public enum MATCHEVENT_NAME { Match_Event, GotStuck, BrokeDown, CrossedCenter, LostParts, AdditionalPiece, MultiClimb, NoShow, TippedOver, JammedPiece }
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
        public MATCHEVENT_NAME MatchEvent
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


        //2026 Enum

        public TimeSpan TimeOfClimb = TimeSpan.Zero;
        public Stopwatch TimeOfClimb_StopWatch;
        public bool TimeOfClimb_StopWatch_Running;
        public double TimeOfClimbDouble;
        public double ClimbTimeDouble;

        public TimeSpan DefenseTime = TimeSpan.Zero;
        public Stopwatch DefenseTime_StopWatch;
        public bool DefenseTime_StopWatch_Running;
        public double DefenseTimeDouble;

        public TimeSpan FuelIntakingTime = TimeSpan.Zero;
        public Stopwatch FuelIntakingTime_StopWatch;
        public bool FuelIntakingTime_StopWatch_Running;
        public double FuelIntakingTimeDouble;

        public TimeSpan FeedingTime = TimeSpan.Zero;
        public Stopwatch FeedingTime_StopWatch;
        public bool FeedingTime_StopWatch_Running;
        public double FeedingTimeDouble;

        public TimeSpan FuelShootingTime = TimeSpan.Zero;
        public Stopwatch FuelShootingTime_StopWatch;
        public bool FuelShootingTime_StopWatch_Running;
        public double FuelShootingTimeDouble;

        public int BumpTraversal = 0;
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
        private BOOLEAN _Auto_Climb;
        private BOOLEAN _Climb_Success;
        private BOOLEAN _End_Match;


        public STARTING_LOCATION GetStartingLocation()
        { return _Starting_Location; }
        public LADDER_LOCATION GetLadderLocation()
        { return _Ladder_Location; }
        public DEFENSE_STRATEGY GetDefenseStrategy()
        { return _Defense_Strategy; }
        public AVOIDANCE_STRATEGY GetAvoidanceStrategy()
        { return _Avoidance_Strategy; }
        public STRATEGY GetStrategy()
        { return _Strategy; }
        public CLIMB_LEVEL GetClimbLevel()
        { return _Climb_Level; }
        public BOOLEAN GetAutoClimb()
        { return _Auto_Climb; }
        public BOOLEAN GetEndMatch()
        { return _End_Match; }
        public BOOLEAN GetClimbSuccess()
        { return _Climb_Success; }


        public STARTING_LOCATION Starting_Location
        {
            get { return _Starting_Location; }
            set { _Starting_Location = value; }
        }
        public LADDER_LOCATION Ladder_Location
        {
            get { return _Ladder_Location; }
            set { _Ladder_Location = value; }
        }
        public DEFENSE_STRATEGY Defense_Strategy
        {
            get { return _Defense_Strategy; }
            set { _Defense_Strategy = value; }
        }
        public AVOIDANCE_STRATEGY Avoidance_Strategy
        {
            get { return _Avoidance_Strategy; }
            set { _Avoidance_Strategy = value; }
        }
        public STRATEGY Strategy
        {
            get { return _Strategy; }
            set { _Strategy = value; }
        }
        public CLIMB_LEVEL Climb_Level
        {
            get { return _Climb_Level; }
            set { _Climb_Level = value; }
        }
        public BOOLEAN Auto_Climb
        {
            get { return _Auto_Climb; }
            set { _Auto_Climb = value; }
        }
        public BOOLEAN Climb_Success
        {
            get { return _Climb_Success; }
            set { _Climb_Success = value; }
        }
        public BOOLEAN End_Match
        {
            get { return _End_Match; }
            set { _End_Match = value; }
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
        public void CycleAutoClimb(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
            {
                _Auto_Climb = (BOOLEAN)GetNextEnum<BOOLEAN>(_Auto_Climb);
            }
            else
            {
                _Auto_Climb = (BOOLEAN)GetPreviousEnum<BOOLEAN>(_Auto_Climb);
            }

            if (_Auto_Climb == BOOLEAN.Z)
            {
                CycleAutoClimb(CycleDirection);
            }
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
                CycleEndMatch(CycleDirection);
            }
        }
        public void CycleClimbSuccess(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
            {
                _Climb_Success = (BOOLEAN)GetNextEnum<BOOLEAN>(_Climb_Success);
            }
            else
            {
                _Climb_Success = (BOOLEAN)GetPreviousEnum<BOOLEAN>(_Climb_Success);
            }

            if (_Climb_Success == BOOLEAN.Z)
            {
                CycleClimbSuccess(CycleDirection);
            }
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
