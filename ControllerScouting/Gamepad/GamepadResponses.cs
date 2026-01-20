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
                robot.TimeOfClimb_StopWatch ??= new Stopwatch();
                robot.DefenseTime_StopWatch ??= new Stopwatch();

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
                        robot.BumpTraversal++;
                    }
                    else if (gamepad.RightTrigger_Press)
                    {
                        DatabaseCode.SaveToRecord(robot, "Activities");
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
                        robot.FuelIntakingTime_StopWatch.Start();
                        robot.FuelIntakingTime = robot.FuelIntakingTime_StopWatch.Elapsed;
                    }
                    else if (gamepad.LeftButton_Release)
                    {
                        robot.FuelIntakingTime_StopWatch.Stop();
                        robot.FuelIntakingTime = robot.FuelIntakingTime_StopWatch.Elapsed;
                    }

                    if (gamepad.RightButton_Down)
                    {
                        robot.FuelShootingTime_StopWatch.Start();
                        robot.FuelShootingTime = robot.FuelShootingTime_StopWatch.Elapsed;
                    }
                    else if (gamepad.RightButton_Release) {
                        robot.FuelShootingTime_StopWatch.Stop();
                        robot.FuelShootingTime = robot.FuelShootingTime_StopWatch.Elapsed;
                    }
                }
                //***********************************
                //TELEOP MODE
                //***********************************
                else if (robot.Current_Mode == RobotState.ROBOT_MODE.Teleop && robot.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name)
                {
                    if (gamepad.L3_Down) {
                        robot.DefenseTime_StopWatch.Start();
                        robot.DefenseTime_StopWatch_Running = true;
                        robot.DefenseTime = robot.DefenseTime_StopWatch.Elapsed;
                    } else if (gamepad.L3_Release) {
                        robot.DefenseTime_StopWatch.Stop();
                        robot.DefenseTime_StopWatch_Running = false;
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
                }

                //***********************************
                //ENDGAME MODE
                //***********************************
                else if (robot.Current_Mode == RobotState.ROBOT_MODE.Endgame && robot.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name)
                {
                    robot.TimeOfClimb_StopWatch.Start(); // starts the time
                    robot.TimeOfClimb_StopWatch_Running = true;

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
                        robot.TimeOfClimb_StopWatch.Reset();
                        robot.TimeOfClimb = robot.TimeOfClimb_StopWatch.Elapsed;
                        robot.TimeOfClimb_StopWatch_Running = false;
                    }
                    else if (gamepad.RightButton_Press) {
                        robot.TimeOfClimb = robot.TimeOfClimb_StopWatch.Elapsed;
                        robot.TimeOfClimbDouble = robot.TimeOfClimb.TotalSeconds;

                    }
                    else if (gamepad.RightButton_Press && robot.TimeOfClimbDouble>0)
                    {
                        robot.TimeOfClimb_StopWatch.Stop();
                        robot.TimeOfClimb = robot.TimeOfClimb_StopWatch.Elapsed;
                        robot.TimeOfClimbDouble = robot.TimeOfClimb.TotalSeconds;
                        robot.TimeOfClimb_StopWatch_Running = false;
                        robot.End_Match = RobotState.BOOLEAN.Yes;
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
                        robot.CycleClimbSuccess(RobotState.CYCLE_DIRECTION.Up);
                    } 
                    else if (gamepad.DpadDown_Press) {
                        robot.CycleClimbSuccess(RobotState.CYCLE_DIRECTION.Down);
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