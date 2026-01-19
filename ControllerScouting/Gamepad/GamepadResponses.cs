using ControllerScouting.Database;
using ControllerScouting.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ControllerScouting.Gamepad
{
    partial class Controllers
    {
        public static void ReadStick(GamePad gamepad, int controllerNumber)
        {
            RobotState robot = BackgroundCode.Robots[controllerNumber];

            if (!robot.NoSho)
            {
                //If the stopwatch does not exist, creates it
                robot.ClimbT_StopWatch ??= new Stopwatch();
                robot.DefTime_StopWatch ??= new Stopwatch();

                gamepad.Update();

                //***********************************
                //CHANGE SCOUTER NAME
                //***********************************
                if (robot.Current_Mode == RobotState.ROBOT_MODE.Auto)
                {
                    //Select Scouter Name
                    if (gamepad.AButton_Down && gamepad.LeftStickLeft_Press)
                    {
                        robot.ChangeScouterName(RobotState.CYCLE_DIRECTION.Up);
                    }
                    else if (gamepad.AButton_Down && gamepad.LeftStickRight_Press)
                    {
                        robot.ChangeScouterName(RobotState.CYCLE_DIRECTION.Down);
                    }
                }
                //***********************************
                //AUTO MODE
                //***********************************
                if (robot.Current_Mode == RobotState.ROBOT_MODE.Auto && robot.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name)
                {
                    if (gamepad.LeftTrigger_Press)
                    {
                        robot.bumpCounter++;
                    }
                    else if (gamepad.RightTrigger_Press)
                    {
                        DatabaseCode.SaveToRecord(robot, "Activities", controllerNumber);
                    }
                    else if (gamepad.XButton_Press)
                    {
                        robot.CycleStartingLocation(RobotState.CYCLE_DIRECTION.Up);
                    }
                    else if (gamepad.BButton_Press)
                    {
                        robot.CycleStartingLocation(RobotState.CYCLE_DIRECTION.Down);
                    }
                    else if (gamepad.DpadUp_Press) {
                        robot.Climb_Level = RobotState.CLIMB_LEVEL.L1;
                    }
                    else if (gamepad.DpadDown_Press)
                    {
                        robot.Climb_Level = RobotState.CLIMB_LEVEL.No_Climb;
                    }

                    if (gamepad.LeftButton_Down)
                    {
                        robot.IntakingT_StopWatch.Start();
                        robot.IntakingT = robot.IntakingT_StopWatch.Elapsed;
                    }
                    else if (gamepad.RightButton_Release)
                    {
                        robot.IntakingT_StopWatch.Stop();
                        robot.IntakingT = robot.IntakingT_StopWatch.Elapsed;
                    }

                    if (gamepad.RightButton_Down)
                    {
                        robot.ShootingT_StopWatch.Start();
                        robot.ShootingT = robot.ShootingT_StopWatch.Elapsed;
                    }
                    else if (gamepad.RightButton_Release) {
                        robot.IntakingT_StopWatch.Stop();
                        robot.IntakingT = robot.IntakingT_StopWatch.Elapsed;
                    }
                }
                //***********************************
                //TELEOP MODE
                //***********************************
                else if (robot.Current_Mode == RobotState.ROBOT_MODE.Teleop && robot.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name)
                {
                    if (gamepad.L3_Down) {
                        robot.DefTime_StopWatch.Start();
                        robot.DefTime_StopWatch_running = true;
                        robot.DefTime = robot.DefTime_StopWatch.Elapsed;
                    } else if (gamepad.L3_Release) {
                        robot.DefTime_StopWatch.Stop();
                        robot.DefTime_StopWatch_running = false;
                        robot.DefTime = robot.DefTime_StopWatch.Elapsed;
                    }

                    if (gamepad.LeftTrigger_Press)
                    {
                        robot.bumpCounter++;
                    }
                    else if (gamepad.RightTrigger_Press)
                    {
                        DatabaseCode.SaveToRecord(robot, "Activities", controllerNumber);
                    }
                    if (gamepad.LeftButton_Down)
                    {
                        robot.IntakingT_StopWatch.Start();
                        robot.IntakingT = robot.IntakingT_StopWatch.Elapsed;
                    }
                    else if (gamepad.RightButton_Release)
                    {
                        robot.IntakingT_StopWatch.Stop();
                        robot.IntakingT = robot.IntakingT_StopWatch.Elapsed;
                    }

                    if (gamepad.RightButton_Down)
                    {
                        robot.ShootingT_StopWatch.Start();
                        robot.ShootingT = robot.ShootingT_StopWatch.Elapsed;
                    }
                    else if (gamepad.RightButton_Release)
                    {
                        robot.IntakingT_StopWatch.Stop();
                        robot.IntakingT = robot.IntakingT_StopWatch.Elapsed;
                    }
                }

                //***********************************
                //ENDGAME MODE
                //***********************************
                else if (robot.Current_Mode == RobotState.ROBOT_MODE.Endgame && robot.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name)
                {
                    robot.ClimbT_StopWatch.Start(); // starts the time
                   robot.ClimbT_StopWatch_running = true;

                    if (gamepad.AButton_Down)
                    {
                        robot.CycleLadderLocation(RobotState.CYCLE_DIRECTION.Up);
                    }

                    if (gamepad.YButton_Press)
                    {
                        robot.Climb_Level = RobotState.CLIMB_LEVEL.L3;
                    }
                    else if (gamepad.XButton_Press)
                    {
                        robot.Climb_Level = RobotState.CLIMB_LEVEL.L2;
                    }
                    else if (gamepad.BButton_Press)
                    {
                        robot.Climb_Level = RobotState.CLIMB_LEVEL.L1;
                    }
                    else if (gamepad.LeftStickLeft_Press)
                    {
                        robot.CycleStrategy(RobotState.CYCLE_DIRECTION.Up);
                    }
                    else if (gamepad.LeftStickRight_Press)
                    {
                        robot.CycleStrategy(RobotState.CYCLE_DIRECTION.Down);
                    }
                    else if (gamepad.LeftTrigger_Press)
                    {
                        robot.ClimbT_StopWatch.Reset();
                        robot.ClimbT = robot.ClimbT_StopWatch.Elapsed;
                        robot.ClimbT_StopWatch_running = false;
                    }
                    else if (gamepad.RightButton_Press) {
                        robot.ClimbT = robot.ClimbT_StopWatch.Elapsed;
                        robot.ClimbTDouble = robot.ClimbT.TotalSeconds;
                        robot.CycleClimbSuccessEndgame(RobotState.CYCLE_DIRECTION.Up);

                    }
                    else if (gamepad.RightButton_Press && robot.ClimbTDouble>0)
                    {
                        robot.ClimbT_StopWatch.Stop();
                        robot.ClimbT = robot.ClimbT_StopWatch.Elapsed;
                        robot.EndmatchTimeDouble = robot.ClimbT.TotalSeconds;
                        robot.ClimbT_StopWatch_running = false;
                        robot.CycleEndMatch(RobotState.CYCLE_DIRECTION.Up);
                    }

                    if (gamepad.DpadLeft_Press)
                    {
                        robot.CycleDefenseStrategy(RobotState.CYCLE_DIRECTION.Up);
                    }
                    else if (gamepad.DpadRight_Press)
                    {
                        robot.CycleAvoidanceStrategy(RobotState.CYCLE_DIRECTION.Up);
                    }
                    else if (gamepad.DpadUp_Press) {
                        robot.CycleClimbSuccessEndgame(RobotState.CYCLE_DIRECTION.Up);
                    } else if (gamepad.DpadDown_Press) {
                        robot.CycleClimbSuccessEndgame(RobotState.CYCLE_DIRECTION.Down);
                    }

                }

                //***********************************
                //Any mode
                //***********************************
                if (robot.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name)
                {
                }

                // Values if robot is NoSho
                else if (robot.NoSho)
                {

                }
            }
        }
    }
}