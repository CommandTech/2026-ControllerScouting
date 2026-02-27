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
            robot.BlueZoneTime_StopWatch ??= new Stopwatch();
            robot.NeutralZoneTime_StopWatch ??= new Stopwatch();
            robot.RedZoneTime_StopWatch ??= new Stopwatch();


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
                        }
                        else if (gamepad.BButton_Press)
                        {
                            robot.CycleStartingLocation(RobotState.CYCLE_DIRECTION.Down);
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
                        if (robot.GetRobotMode() == RobotState.ROBOT_MODE.Red)
                        {
                            robot.RedZoneTime_StopWatch.Start();
                            robot.RedZoneTime = robot.RedZoneTime_StopWatch.Elapsed;

                            if (robot.BumpTraversal == robot.prevBumpTraversal)
                            {
                                robot.TrenchTraversal++;
                            }
                            robot.prevBumpTraversal = robot.BumpTraversal;

                            if ((gamepad.DpadLeft_Press && BackgroundCode.redRight) || (gamepad.DpadRight_Press && !BackgroundCode.redRight))
                            {
                                robot.RobotMode = RobotState.ROBOT_MODE.Neutral;

                                robot.BlueZoneTime_StopWatch.Stop();
                                robot.BlueZoneTime = robot.BlueZoneTime_StopWatch.Elapsed;
                            }
                        }
                        else if (robot.GetRobotMode() == RobotState.ROBOT_MODE.Blue)
                        {
                            robot.BlueZoneTime_StopWatch.Start();
                            robot.BlueZoneTime = robot.BlueZoneTime_StopWatch.Elapsed;

                            if (robot.BumpTraversal == robot.prevBumpTraversal)
                            {
                                robot.TrenchTraversal++;
                            }
                            robot.prevBumpTraversal = robot.BumpTraversal;

                            if ((gamepad.DpadRight_Press && BackgroundCode.redRight) || (gamepad.DpadLeft_Press && !BackgroundCode.redRight))
                            {
                                robot.RobotMode = RobotState.ROBOT_MODE.Neutral;

                                robot.BlueZoneTime_StopWatch.Stop();
                                robot.BlueZoneTime = robot.BlueZoneTime_StopWatch.Elapsed;
                            }
                        } 
                        else if (robot.GetRobotMode() == RobotState.ROBOT_MODE.Neutral)
                        {
                            robot.NeutralZoneTime_StopWatch.Start();
                            robot.NeutralZoneTime = robot.NeutralZoneTime_StopWatch.Elapsed;

                            if (robot.BumpTraversal == robot.prevBumpTraversal)
                            {
                                robot.TrenchTraversal++;
                            }
                            robot.prevBumpTraversal = robot.BumpTraversal;

                            if ((gamepad.DpadRight_Press && BackgroundCode.redRight) || (gamepad.DpadLeft_Press && !BackgroundCode.redRight))
                            {
                                robot.RobotMode = RobotState.ROBOT_MODE.Red;

                                robot.NeutralZoneTime_StopWatch.Stop();
                                robot.NeutralZoneTime = robot.NeutralZoneTime_StopWatch.Elapsed;
                            }
                            else if ((gamepad.DpadLeft_Press && BackgroundCode.redRight) || (gamepad.DpadRight_Press && !BackgroundCode.redRight))
                            {
                                robot.RobotMode = RobotState.ROBOT_MODE.Blue;

                                robot.NeutralZoneTime_StopWatch.Stop();
                                robot.NeutralZoneTime = robot.NeutralZoneTime_StopWatch.Elapsed;
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

                            if (gamepad.BButton_Press && robot.AUTO)
                            {
                                robot.Auto_Climb = RobotState.BOOLEAN.Yes;
                            }
                            else if (gamepad.AButton_Press)
                            {
                                robot.Auto_Climb = RobotState.BOOLEAN.No;
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

                        if (gamepad.StartButton_Press)
                        {
                            DatabaseCode.SaveToRecord(robot, "EndAuto");
                            robot.AUTO = false;
                        }

                        if (gamepad.BackButton_Down)
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
                        if (gamepad.LeftTrigger_Press && robot.TimeOfClimb_StopWatch.IsRunning)
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

                        if (gamepad.StartButton_Press && !robot.ClimbedTime && robot.TimeOfClimb_StopWatch.IsRunning)
                        {
                            robot.RobotMode = (RobotState.ROBOT_MODE)robot.color;
                            robot.TimeOfClimb_StopWatch.Stop();
                            robot.TimeOfClimb_StopWatch.Reset();
                        }

                    }
                }
            }
        }
    }
}