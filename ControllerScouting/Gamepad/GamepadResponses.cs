using ControllerScouting.Database;
using ControllerScouting.Utilities;
using System.Diagnostics;

namespace ControllerScouting.Gamepad
{
    partial class Controllers
    {
        public static void ReadStick(GamePad gamepad, int controllerNumber)
        {
            RobotState robot = BackgroundCode.Robots[controllerNumber];

            //If the stopwatch does not exist, creates it
            robot.TimeOfClimb_StopWatch ??= new Stopwatch();
            robot.DefenseTime_StopWatch ??= new Stopwatch();
            robot.FuelIntakingTime_StopWatch ??= new Stopwatch();
            robot.FuelShootingTime_StopWatch ??= new Stopwatch();
            robot.FeedingTime_StopWatch ??= new Stopwatch();
            robot.NearBlueZoneTime_StopWatch ??= new Stopwatch();
            robot.FarBlueZoneTime_StopWatch ??= new Stopwatch();
            robot.NearNeutralZoneTime_StopWatch ??= new Stopwatch();
            robot.FarNeutralZoneTime_StopWatch ??= new Stopwatch();
            robot.NearRedZoneTime_StopWatch ??= new Stopwatch();
            robot.FarRedZoneTime_StopWatch ??= new Stopwatch();


            if (!robot.NoSho)
            {
                gamepad.Update();

                //***********************************
                //CHANGE SCOUTER NAME
                //***********************************
                if (robot.GetRobotMode() == RobotState.ROBOT_MODE.Prematch)
                {
                    //Select Scouter Name for Student names
                    if (gamepad.AButton_Down && gamepad.LeftStickLeft_Press)
                    {
                        robot.ChangeStudentScouterName(RobotState.CYCLE_DIRECTION.Down);
                    }
                    else if (gamepad.AButton_Down && gamepad.LeftStickRight_Press)
                    {
                        robot.ChangeStudentScouterName(RobotState.CYCLE_DIRECTION.Up);
                    }

                    // For Mentor Scouter Name
                    else if (gamepad.YButton_Down && gamepad.LeftStickLeft_Press)
                    {
                        robot.ChangeMentorScouterName(RobotState.CYCLE_DIRECTION.Down);
                    }
                    else if (gamepad.YButton_Down && gamepad.LeftStickRight_Press)
                    {
                        robot.ChangeMentorScouterName(RobotState.CYCLE_DIRECTION.Up);
                    }
                }

                //***********************************
                //CHANGE MATCH EVENT
                //***********************************
                if (robot.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name)
                {
                    if (gamepad.RightStickRight_Press)
                    {
                        robot.CycleMatchEvent(RobotState.CYCLE_DIRECTION.Up);
                    }
                    else if (gamepad.RightStickLeft_Press)
                    {
                        robot.CycleMatchEvent(RobotState.CYCLE_DIRECTION.Down);
                    }

                    if (gamepad.R3_Press && robot.MatchEvent != RobotState.MATCHEVENT_NAME.Match_Event)
                    {
                        DatabaseCode.SaveToRecord(robot, "Match_Event");
                    }
                }

                if (robot.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name)
                {
                    //***********************************
                    //PREMATCH MODE
                    //***********************************
                    if (robot.GetRobotMode() == RobotState.ROBOT_MODE.Prematch)
                    {
                        if (gamepad.XButton_Press)
                        {
                            robot.CycleStartingLocation(RobotState.CYCLE_DIRECTION.Up);
                            if (robot.GetStartingLocation() == RobotState.STARTING_LOCATION.Far_Trench || robot.GetStartingLocation() == RobotState.STARTING_LOCATION.Far_Bump)
                            {
                                robot.NearFar = RobotState.NEAR_FAR.Far;
                            }
                            else
                            {
                                robot.NearFar = RobotState.NEAR_FAR.Near;
                            }
                        }
                        else if (gamepad.BButton_Press)
                        {
                            robot.CycleStartingLocation(RobotState.CYCLE_DIRECTION.Down);
                            if (robot.GetStartingLocation() == RobotState.STARTING_LOCATION.Far_Trench || robot.GetStartingLocation() == RobotState.STARTING_LOCATION.Far_Bump)
                            {
                                robot.NearFar = RobotState.NEAR_FAR.Far;
                            }
                            else
                            {
                                robot.NearFar = RobotState.NEAR_FAR.Near;
                            }
                        }

                        if (gamepad.StartButton_Press)
                        {
                            if (robot.color == RobotState.COLOR.Red)
                            {
                                robot.RobotMode = RobotState.ROBOT_MODE.Red;
                            }
                            else
                            {
                                robot.RobotMode = RobotState.ROBOT_MODE.Blue;
                            }
                        }
                    }
                    //***********************************
                    //ZONES MODE
                    //***********************************
                    else if (robot.GetRobotMode() == RobotState.ROBOT_MODE.Red ||
                             robot.GetRobotMode() == RobotState.ROBOT_MODE.Neutral ||
                             robot.GetRobotMode() == RobotState.ROBOT_MODE.Blue)
                    {
                        if (gamepad.YButton_Press)
                        {
                            robot.NearFar = RobotState.NEAR_FAR.Far;
                        }
                        else if (gamepad.AButton_Press)
                        {
                            robot.NearFar = RobotState.NEAR_FAR.Near;
                        }

                        if (robot.GetRobotMode() == RobotState.ROBOT_MODE.Red)
                        {
                            if (robot.NearFar == RobotState.NEAR_FAR.Far)
                            {
                                robot.FarRedZoneTime_StopWatch.Start();
                                robot.FarRedZoneTime = robot.FarRedZoneTime_StopWatch.Elapsed;
                            }
                            else
                            {
                                robot.NearRedZoneTime_StopWatch.Start();
                                robot.NearRedZoneTime = robot.NearRedZoneTime_StopWatch.Elapsed;
                            }

                            if ((gamepad.DpadLeft_Press && BackgroundCode.redRight) || (gamepad.DpadRight_Press && !BackgroundCode.redRight))
                            {
                                robot.RobotMode = RobotState.ROBOT_MODE.Neutral;

                                if (robot.BumpTraversal == robot.prevBumpTraversal)
                                {
                                    robot.TrenchTraversal++;
                                }
                                robot.prevBumpTraversal = robot.BumpTraversal;

                                if (robot.NearFar == RobotState.NEAR_FAR.Far)
                                {
                                    robot.FarRedZoneTime_StopWatch.Stop();
                                    robot.FarRedZoneTime = robot.FarRedZoneTime_StopWatch.Elapsed;
                                }
                                else
                                {
                                    robot.NearRedZoneTime_StopWatch.Stop();
                                    robot.NearRedZoneTime = robot.NearRedZoneTime_StopWatch.Elapsed;
                                }
                            }
                        }
                        else if (robot.GetRobotMode() == RobotState.ROBOT_MODE.Blue)
                        {
                            if (robot.NearFar == RobotState.NEAR_FAR.Far)
                            {
                                robot.FarBlueZoneTime_StopWatch.Start();
                                robot.FarBlueZoneTime = robot.FarBlueZoneTime_StopWatch.Elapsed;
                            }
                            else
                            {
                                robot.NearBlueZoneTime_StopWatch.Start();
                                robot.NearBlueZoneTime = robot.NearBlueZoneTime_StopWatch.Elapsed;
                            }

                            if ((gamepad.DpadRight_Press && BackgroundCode.redRight) || (gamepad.DpadLeft_Press && !BackgroundCode.redRight))
                            {
                                robot.RobotMode = RobotState.ROBOT_MODE.Neutral;

                                if (robot.BumpTraversal == robot.prevBumpTraversal)
                                {
                                    robot.TrenchTraversal++;
                                }
                                robot.prevBumpTraversal = robot.BumpTraversal;

                                if (robot.NearFar == RobotState.NEAR_FAR.Far)
                                {
                                    robot.FarBlueZoneTime_StopWatch.Stop();
                                    robot.FarBlueZoneTime = robot.FarBlueZoneTime_StopWatch.Elapsed;
                                }
                                else
                                {
                                    robot.NearBlueZoneTime_StopWatch.Stop();
                                    robot.NearBlueZoneTime = robot.NearBlueZoneTime_StopWatch.Elapsed;
                                }
                            }
                        }
                        else if (robot.GetRobotMode() == RobotState.ROBOT_MODE.Neutral)
                        {
                            if (robot.NearFar == RobotState.NEAR_FAR.Far)
                            {
                                robot.FarNeutralZoneTime_StopWatch.Start();
                                robot.FarNeutralZoneTime = robot.FarNeutralZoneTime_StopWatch.Elapsed;
                            }
                            else
                            {
                                robot.NearNeutralZoneTime_StopWatch.Start();
                                robot.NearNeutralZoneTime = robot.NearNeutralZoneTime_StopWatch.Elapsed;
                            }

                            if ((gamepad.DpadRight_Press && BackgroundCode.redRight) || (gamepad.DpadLeft_Press && !BackgroundCode.redRight))
                            {
                                robot.RobotMode = RobotState.ROBOT_MODE.Red;

                                if (robot.BumpTraversal == robot.prevBumpTraversal)
                                {
                                    robot.TrenchTraversal++;
                                }
                                robot.prevBumpTraversal = robot.BumpTraversal;

                                if (robot.NearFar == RobotState.NEAR_FAR.Far)
                                {
                                    robot.FarNeutralZoneTime_StopWatch.Stop();
                                    robot.FarNeutralZoneTime = robot.FarNeutralZoneTime_StopWatch.Elapsed;
                                }
                                else
                                {
                                    robot.NearNeutralZoneTime_StopWatch.Stop();
                                    robot.NearNeutralZoneTime = robot.NearNeutralZoneTime_StopWatch.Elapsed;
                                }
                            }
                            else if ((gamepad.DpadLeft_Press && BackgroundCode.redRight) || (gamepad.DpadRight_Press && !BackgroundCode.redRight))
                            {
                                robot.RobotMode = RobotState.ROBOT_MODE.Blue;

                                if (robot.BumpTraversal == robot.prevBumpTraversal)
                                {
                                    robot.TrenchTraversal++;
                                }
                                robot.prevBumpTraversal = robot.BumpTraversal;

                                if (robot.NearFar == RobotState.NEAR_FAR.Far)
                                {
                                    robot.FarNeutralZoneTime_StopWatch.Stop();
                                    robot.FarNeutralZoneTime = robot.FarNeutralZoneTime_StopWatch.Elapsed;
                                }
                                else
                                {
                                    robot.NearNeutralZoneTime_StopWatch.Stop();
                                    robot.NearNeutralZoneTime = robot.NearNeutralZoneTime_StopWatch.Elapsed;
                                }
                            }
                        }

                        if ((robot.GetRobotMode() == RobotState.ROBOT_MODE.Red && robot.color == RobotState.COLOR.Red) ||
                            (robot.GetRobotMode() == RobotState.ROBOT_MODE.Blue && robot.color == RobotState.COLOR.Blue))
                        {
                            if (gamepad.RightButton_Down)
                            {
                                robot.FuelShootingTime_StopWatch.Start();
                                robot.FuelShootingTime = robot.FuelShootingTime_StopWatch.Elapsed;
                            }
                            else if (gamepad.RightButton_Release)
                            {
                                robot.FuelShootingTime_StopWatch.Stop();
                                robot.FuelShootingTime = robot.FuelShootingTime_StopWatch.Elapsed;
                            }

                            if (gamepad.XButton_Press && robot.AUTO)
                            {
                                robot.CycleAutoClimb(RobotState.CYCLE_DIRECTION.Up);
                            }
                        } 
                        else
                        {
                            if (gamepad.RightButton_Down)
                            {
                                robot.FeedingTime_StopWatch.Start();
                                robot.FeedingTime = robot.FeedingTime_StopWatch.Elapsed;
                            }
                            else if (gamepad.RightButton_Release)
                            {
                                robot.FeedingTime_StopWatch.Stop();
                                robot.FeedingTime = robot.FeedingTime_StopWatch.Elapsed;
                            }

                        }

                        if (gamepad.L3_Down && !robot.AUTO)
                        {
                            robot.DefenseTime_StopWatch.Start();
                            robot.DefenseTime = robot.DefenseTime_StopWatch.Elapsed;
                        }
                        else if (gamepad.L3_Release)
                        {
                            robot.DefenseTime_StopWatch.Stop();
                            robot.DefenseTime = robot.DefenseTime_StopWatch.Elapsed;
                        }

                        if (gamepad.LeftTrigger_Press)
                        {
                            robot.BumpTraversal++;
                        }
                        else if (gamepad.RightTrigger_Press)
                        {
                            DatabaseCode.SaveToRecord(robot, "Activities");
                        }

                        if (gamepad.LeftButton_Down)
                        {
                            robot.FuelIntakingTime_StopWatch.Start();
                            robot.FuelIntakingTime = robot.FuelIntakingTime_StopWatch.Elapsed;
                        }
                        else if (gamepad.LeftButton_Release)
                        {
                            robot.FuelIntakingTime_StopWatch.Stop();
                            robot.FuelIntakingTime = robot.FuelIntakingTime_StopWatch.Elapsed;
                        }

                        if (gamepad.StartButton_Press && robot.AUTO)
                        {
                            DatabaseCode.SaveToRecord(robot, "EndAuto");
                            robot.AUTO = false;
                        }

                        if (gamepad.BackButton_Down && !robot.AUTO)
                        {
                            robot.RobotMode = RobotState.ROBOT_MODE.Endgame;
                            robot.TimeOfClimb_StopWatch.Start(); // starts the time
                        }
                    }
                    //***********************************
                    //ENDGAME MODE
                    //***********************************
                    else if (robot.GetRobotMode() == RobotState.ROBOT_MODE.Endgame)
                    {
                        robot.NearBlueZoneTime_StopWatch.Stop();
                        robot.FarBlueZoneTime_StopWatch.Stop();
                        robot.NearNeutralZoneTime_StopWatch.Stop();
                        robot.FarNeutralZoneTime_StopWatch.Stop();
                        robot.NearRedZoneTime_StopWatch.Stop();
                        robot.FarRedZoneTime_StopWatch.Stop();


                        if (!robot.ClimbedTime)
                        {
                            robot.ClimbTime = robot.TimeOfClimb_StopWatch.Elapsed;
                        }

                        if (gamepad.AButton_Press)
                        {
                            robot.CycleLadderLocation(RobotState.CYCLE_DIRECTION.Up);
                        }
                        if (gamepad.YButton_Press && robot.Climb_Level != RobotState.CLIMB_LEVEL.L3)
                        {
                            robot.Climb_Level = RobotState.CLIMB_LEVEL.L3;
                        }
                        else if (gamepad.YButton_Press)
                        {
                            robot.Climb_Level = RobotState.CLIMB_LEVEL.No_Climb;
                        }
                        else if (gamepad.XButton_Press && robot.Climb_Level != RobotState.CLIMB_LEVEL.L2)
                        {
                            robot.Climb_Level = RobotState.CLIMB_LEVEL.L2;
                        }
                        else if (gamepad.XButton_Press)
                        {
                            robot.Climb_Level = RobotState.CLIMB_LEVEL.No_Climb;
                        }
                        else if (gamepad.BButton_Press && robot.Climb_Level != RobotState.CLIMB_LEVEL.L1)
                        {
                            robot.Climb_Level = RobotState.CLIMB_LEVEL.L1;
                        }
                        else if (gamepad.BButton_Press)
                        {
                            robot.Climb_Level = RobotState.CLIMB_LEVEL.No_Climb;
                        }

                        if (gamepad.LeftButton_Press)
                        {
                            robot.TimeOfClimb_StopWatch.Start();
                        }
                        if (gamepad.LeftTrigger_Press)
                        {
                            robot.TimeOfClimb_StopWatch.Reset();
                            robot.TimeOfClimb_StopWatch.Stop();
                            robot.ClimbTime = robot.TimeOfClimb_StopWatch.Elapsed;
                            robot.ClimbedTime = false;
                        }
                        if (gamepad.RightButton_Press && robot.ClimbedTime)
                        {
                            robot.TimeOfClimb_StopWatch.Stop();
                            robot.TimeOfClimb = robot.TimeOfClimb_StopWatch.Elapsed;
                            robot.End_Match = RobotState.BOOLEAN.Yes;
                        }
                        else if (gamepad.RightButton_Press) {
                            robot.ClimbedTime = true;
                            robot.ClimbTime = robot.TimeOfClimb_StopWatch.Elapsed;
                        }
                        
                        if (gamepad.DpadUp_Press) {
                            robot.Climb_Success = RobotState.BOOLEAN.Yes;
                        } 
                        else if (gamepad.DpadDown_Press) {
                            robot.Climb_Success = RobotState.BOOLEAN.No;
                        }
                        else if (gamepad.DpadLeft_Press) {
                            robot.CycleDefenseStrategy(RobotState.CYCLE_DIRECTION.Up);
                        }
                        else if (gamepad.DpadRight_Press)
                        {
                            robot.CycleAvoidanceStrategy(RobotState.CYCLE_DIRECTION.Up);
                        }

                        if (gamepad.LeftStickLeft_Press)
                        {
                            robot.CycleStrategy(RobotState.CYCLE_DIRECTION.Down);
                        }
                        else if (gamepad.LeftStickRight_Press)
                        {
                            robot.CycleStrategy(RobotState.CYCLE_DIRECTION.Up);
                        }

                        if (gamepad.StartButton_Press && !robot.ClimbedTime && robot.TimeOfClimb_StopWatch.IsRunning)
                        {
                            if (robot.color == RobotState.COLOR.Red)
                            {
                                robot.RobotMode = RobotState.ROBOT_MODE.Red;
                            }
                            else
                            {
                                robot.RobotMode = RobotState.ROBOT_MODE.Blue;
                            }
                            robot.TimeOfClimb_StopWatch.Stop();
                            robot.TimeOfClimb_StopWatch.Reset();
                        }

                    }
                }
            }
        }
    }
}