using System;
using System.Diagnostics;
using ControllerScouting.Database;

namespace ControllerScouting.Utilities
{
    public class RobotState
    {
        public enum ROBOT_MODE { Prematch, Red, Neutral, Blue, Endgame };
        public enum CYCLE_DIRECTION { Up, Down }
        public enum MATCHEVENT_NAME { Match_Event, TrenchFeed, TippedOver, LostParts, GotStuck, BrokenDown, NoShow, JammedPiece, Other }
        public enum SCOUTER_NAME { Select_Name, Abel, Abhi_R, Abhi_V, Adel, Adrika, Aishani, Ananth, Andrew, Anh, Anshu, Arnav, Aryan, Ashley, Atharv, Avani, Avanti, Charlotte, Chris, Corey, Emma, Grace, Hasini, Isaac, Ishan, Jack, Jasmin, Jasmine, Jay, Liam, Manha, Maria, Noah, Parnitha, Ravena, Rddhima, Rishi, Rohan, Ruby, Ruchir, Saanvi, Sam_W, Sanchi, Sanvi, Sri, Suhrit, Tanay, Vaibhav, Varsha, Xander, Scouter1, Scouter2, Scouter3, Scouter4, Scouter5, Scouter6, Adnan, Alex, Alyssa, Charlie, Deven, Elliot, Grant, Josh, Katie, Kevin, Logan, Luke, Marcus, Max, Sam_B, Spencer, William }
        public enum BOOLEAN { Z, Yes, No }
        public enum COLOR { Red, Blue }
        // Year to Year ints
        public long ScouterError;
        public long prevScouterError;
        public int ScouterBox;
        public bool TransactionCheck;

        // Year to Year strings
        public COLOR color;

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
        private MATCHEVENT_NAME _MatchEvent;       //Match Event
        private ROBOT_MODE _RobotMode;              //Control

        public String TeamName
        {
            get { return _TeamName; }
            set { _TeamName = value; }
        }
        
        public ROBOT_MODE RobotMode
        {
            get { return _RobotMode; }
            set { _RobotMode = value; }
        }
        public SCOUTER_NAME GetScouterName()
        { return _ScouterName; }

        public MATCHEVENT_NAME MatchEvent
        {
            get { return _MatchEvent; }
            set { _MatchEvent = value; }
        }
        
        public ROBOT_MODE GetRobotMode()
        { return _RobotMode; }


        //Scouter Name
        public void ChangeStudentScouterName(CYCLE_DIRECTION CycleDirection)
        {
            var values = (SCOUTER_NAME[])Enum.GetValues(typeof(SCOUTER_NAME));
            int start = 0;
            int end = 55;
            int currentIndex = Array.IndexOf(values, _ScouterName);

            if (currentIndex < start || currentIndex > end)
                currentIndex = start;

            int rangeLength = end - start + 1;

            if (CycleDirection == CYCLE_DIRECTION.Up)
                currentIndex = start + ((currentIndex - start + 1) % rangeLength);
            else
                currentIndex = start + ((currentIndex - start - 1 + rangeLength) % rangeLength);

            _ScouterName = values[currentIndex];
        }
        public void ChangeMentorScouterName(CYCLE_DIRECTION CycleDirection)
        {
            var values = (SCOUTER_NAME[])Enum.GetValues(typeof(SCOUTER_NAME));
            int mentorStart = 54;
            int mentorEnd = values.Length - 1;
            int currentIndex = Array.IndexOf(values, _ScouterName);

            if (currentIndex == 0)
            {
                if (CycleDirection == CYCLE_DIRECTION.Up)
                {
                    currentIndex = mentorStart;
                }
                else // Down from 0 goes to last mentor
                {
                    currentIndex = mentorEnd;
                }
            }
            else if (currentIndex >= mentorStart && currentIndex <= mentorEnd)
            {
                if (CycleDirection == CYCLE_DIRECTION.Up)
                {
                    if (currentIndex == mentorEnd)
                        currentIndex = 0; // wrap to Select_Name
                    else
                        currentIndex++;
                }
                else
                {
                    if (currentIndex == mentorStart)
                        currentIndex = 0; // wrap to Select_Name
                    else
                        currentIndex--;
                }
            }
            else
            {
                // If not in mentor range or 0, reset to 0
                currentIndex = 0;
            }

            _ScouterName = values[currentIndex];
        }

        //Cycle Event Name
        public void CycleMatchEvent(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
            {
                _MatchEvent = (MATCHEVENT_NAME)GetNextEnum<MATCHEVENT_NAME>(_MatchEvent);
            }
            else
            {
                _MatchEvent = (MATCHEVENT_NAME)GetPreviousEnum<MATCHEVENT_NAME>(_MatchEvent);
            }
        }
        
        //Cycle Robot Mode
        public void CycleRobotMode(CYCLE_DIRECTION CycleDirection)
        {
            if (CycleDirection == CYCLE_DIRECTION.Up)
            {
                _RobotMode = (ROBOT_MODE)GetNextEnum<ROBOT_MODE>(_RobotMode);
            }
            else
            {
                _RobotMode = (ROBOT_MODE)GetPreviousEnum<ROBOT_MODE>(_RobotMode);
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
        public TimeSpan ClimbTime;
        public bool ClimbedTime;

        public TimeSpan NearRedZoneTime = TimeSpan.Zero;
        public Stopwatch NearRedZoneTime_StopWatch;
        public TimeSpan FarRedZoneTime = TimeSpan.Zero;
        public Stopwatch FarRedZoneTime_StopWatch;

        public TimeSpan NearNeutralZoneTime = TimeSpan.Zero;
        public Stopwatch NearNeutralZoneTime_StopWatch;
        public TimeSpan FarNeutralZoneTime = TimeSpan.Zero;
        public Stopwatch FarNeutralZoneTime_StopWatch;

        public TimeSpan NearBlueZoneTime = TimeSpan.Zero;
        public Stopwatch NearBlueZoneTime_StopWatch;
        public TimeSpan FarBlueZoneTime = TimeSpan.Zero;
        public Stopwatch FarBlueZoneTime_StopWatch;


        public TimeSpan DefenseTime = TimeSpan.Zero;
        public Stopwatch DefenseTime_StopWatch;

        public TimeSpan FuelIntakingTime = TimeSpan.Zero;
        public Stopwatch FuelIntakingTime_StopWatch;

        public TimeSpan FuelShootingTime = TimeSpan.Zero;
        public Stopwatch FuelShootingTime_StopWatch;

        public TimeSpan FeedingTime = TimeSpan.Zero;
        public Stopwatch FeedingTime_StopWatch;

        public int BumpTraversal = 0;
        public int prevBumpTraversal = 0;
        public int TrenchTraversal = 0;
        public bool DisplayClimbSuccess = false;
        public enum STARTING_LOCATION { None, Far_Trench, Far_Bump, Hub, Near_Bump, Near_Trench }
        public enum LADDER_LOCATION { None, Outpost, Center, Depot };
        public enum DEFENSE_STRATEGY { Select, None, Lane, Neutral_Zone, Hub, Pinning, Counter };
        public enum AVOIDANCE_STRATEGY { Select, None, Lane, Neutral_Zone, Hub, Pinning, Counter };
        public enum STRATEGY { Select, None, Shooting, Feeding, Defense, Climb };
        public enum CLIMB_LEVEL { No_Climb, L1, L2, L3 };
        public enum NEAR_FAR { Near, Far };


        private NEAR_FAR _NearFar;
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


        public NEAR_FAR NearFar
        {
            get { return _NearFar; }
            set { _NearFar = value; }
        }
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
            if (_Starting_Location == STARTING_LOCATION.None) CycleStartingLocation(CycleDirection);
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
            if (_Defense_Strategy == DEFENSE_STRATEGY.Select) CycleDefenseStrategy(CycleDirection);
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
            if (_Avoidance_Strategy == AVOIDANCE_STRATEGY.Select) CycleAvoidanceStrategy(CycleDirection);
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
            if (_Strategy == STRATEGY.Select) CycleStrategy(CycleDirection);
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
            if (_End_Match == BOOLEAN.Z) CycleEndMatch(CycleDirection);
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

            if (_Climb_Success == BOOLEAN.Z) CycleClimbSuccess(CycleDirection);
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