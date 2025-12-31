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
                //robot.ClimbT_StopWatch ??= new Stopwatch();
                //robot.DefTime_StopWatch ??= new Stopwatch();

                gamepad.Update();

                //***********************************
                //CHANGE SCOUTER NAME
                //***********************************
                if (robot.Current_Mode == RobotState.ROBOT_MODE.Auto)
                {
                    //Select Scouter Name
                    if (gamepad.BButton_Down && gamepad.LTHRight_Press)
                    {
                        robot.ChangeScouterName(RobotState.CYCLE_DIRECTION.Up);
                    }
                    else if (gamepad.BButton_Down && gamepad.LTHLeft_Press)
                    {
                        robot.ChangeScouterName(RobotState.CYCLE_DIRECTION.Down);
                    }
                }
                //***********************************
                //AUTO MODE
                //***********************************
                if (robot.Current_Mode == RobotState.ROBOT_MODE.Auto && robot.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name)
                {
                    
                }
                //***********************************
                //TELEOP MODE
                //***********************************
                else if (robot.Current_Mode == RobotState.ROBOT_MODE.Teleop && robot.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name)
                {
                    
                }
                //***********************************
                //ENDGAME MODE
                //***********************************
                else if (robot.Current_Mode == RobotState.ROBOT_MODE.Endgame && robot.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name)
                {
                    
                }
                //***********************************
                //Any mode
                //***********************************
                if (robot.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name)
                {
                    // Changing modes
                    //Leaving Auto
                    if (gamepad.StartButton_Press && robot.Current_Mode == RobotState.ROBOT_MODE.Auto)
                    {
                        robot.AUTO = false;
                        DatabaseCode.SaveToRecord(robot, "EndAuto", controllerNumber);
                        robot.Desired_Mode = RobotState.ROBOT_MODE.Endgame;
                        robot.Current_Mode = RobotState.ROBOT_MODE.Teleop;
                    }
                    //Leaving Teleop into Surfacing
                    else if (gamepad.StartButton_Press && robot.Current_Mode == RobotState.ROBOT_MODE.Teleop)

                    {
                        robot.Desired_Mode = RobotState.ROBOT_MODE.Teleop;
                        robot.Current_Mode = RobotState.ROBOT_MODE.Endgame;

                        //robot.ClimbT_StopWatch.Start();
                        //robot.ClimbT_StopWatch_running = true;
                        //robot.ClimbT = robot.ClimbT_StopWatch.Elapsed;
                    }
                    //Leaving Surfacing into Teleop
                    else if (gamepad.StartButton_Press && robot.Current_Mode == RobotState.ROBOT_MODE.Endgame)
                    {
                        robot.Desired_Mode = RobotState.ROBOT_MODE.Endgame;
                        robot.Current_Mode = RobotState.ROBOT_MODE.Teleop;

                        //robot.ClimbT_StopWatch.Stop();
                        //robot.ClimbT = robot.ClimbT_StopWatch.Elapsed;
                        //robot.ClimbT_StopWatch_running = false;
                        //robot.ClimbT_StopWatch.Reset();
                    }

                    //Flag
                    if (gamepad.RightButton_Down)
                    {
                        robot.Flag = true;
                    }
                    else
                    {
                        robot.Flag = false;
                    }


                    //Match Events
                    if (gamepad.RTHRight_Press)
                    {
                        robot.CycleEventName(RobotState.CYCLE_DIRECTION.Up);
                    }
                    else if (gamepad.RTHLeft_Press)
                    {
                        robot.CycleEventName(RobotState.CYCLE_DIRECTION.Down);
                    }
                    if (gamepad.R3_Press && robot.Match_event != RobotState.MATCHEVENT_NAME.Match_Event)
                    {
                        DatabaseCode.SaveToRecord(robot, "Match_Event", controllerNumber);
                        robot.Match_event = RobotState.MATCHEVENT_NAME.Match_Event;
                    }

                    //2025 Transaction
                    if (gamepad.RightTrigger_Press && robot.TransactionCheck)
                    {
                        DatabaseCode.SaveToRecord(robot, "Activities", controllerNumber);
                    }
                    else if (gamepad.RightTrigger_Press)
                    {
                        robot.ScouterError += 10000000000;
                    }
                }
            }

            // Values if robot is NoSho
            else if (robot.NoSho)
            {

            }
        }
    }
}