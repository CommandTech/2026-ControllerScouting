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

            if (!robot.NoSho)
            {
                //If the stopwatch does not exist, creates it
                robot.TimeOfClimb_StopWatch ??= new Stopwatch();
                robot.DefenseTime_StopWatch ??= new Stopwatch();
                robot.FuelIntakingTime_StopWatch ??= new Stopwatch();
                robot.FuelShootingTime_StopWatch ??= new Stopwatch();
                robot.FeedingTime_StopWatch ??= new Stopwatch();

                gamepad.Update();

                //***********************************
                //CHANGE SCOUTER NAME
                //***********************************
                if (robot.GetRobotMode() == RobotState.ROBOT_MODE.Auto)
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
                //CHANGE MATCH EVENT
                //***********************************
                if (robot.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name)
                {
                    if (gamepad.RightStickRight_Press)
                    {
                        robot.CycleEventName(RobotState.CYCLE_DIRECTION.Up);
                    }
                    else if (gamepad.RightStickLeft_Press)
                    {
                        robot.CycleEventName(RobotState.CYCLE_DIRECTION.Down);
                    }

                    if (gamepad.R3_Press && robot.MatchEvent != RobotState.MATCHEVENT_NAME.Match_Event)
                    {
                        DatabaseCode.SaveToRecord(robot, "Match_Event");
                    }
                }

                //***********************************
                //AUTO MODE
                //***********************************
                if (robot.GetRobotMode() == RobotState.ROBOT_MODE.Auto && robot.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name)
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
                        robot.Auto_Climb = RobotState.BOOLEAN.Yes;
                    }
                    else if (gamepad.DpadDown_Press)
                    {
                        robot.Auto_Climb = RobotState.BOOLEAN.No;
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

                    if (gamepad.StartButton_Press)
                    {
                        DatabaseCode.SaveToRecord(robot, "EndAuto");
                        robot.CycleRobotMode(RobotState.CYCLE_DIRECTION.Up);
                    }
                }
                //***********************************
                //TELEOP MODE
                //***********************************
                else if (robot.GetRobotMode() == RobotState.ROBOT_MODE.Teleop && robot.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name)
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

                    if (gamepad.YButton_Down)
                    {
                        robot.FeedingTime_StopWatch.Start();
                        robot.FeedingTime = robot.FeedingTime_StopWatch.Elapsed;
                    }
                    else if (gamepad.YButton_Release)
                    {
                        robot.FeedingTime_StopWatch.Stop();
                        robot.FeedingTime = robot.FeedingTime_StopWatch.Elapsed;
                    }

                    if (gamepad.StartButton_Press)
                    {
                        robot.CycleRobotMode(RobotState.CYCLE_DIRECTION.Up);
                        robot.TimeOfClimb_StopWatch.Start(); // starts the time
                    }
                }

                //***********************************
                //ENDGAME MODE
                //***********************************
                else if (robot.GetRobotMode() == RobotState.ROBOT_MODE.Endgame && robot.GetScouterName() != RobotState.SCOUTER_NAME.Select_Name)
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
                    else if (gamepad.LeftStickLeft_Press)
                    {
                        robot.CycleStrategy(RobotState.CYCLE_DIRECTION.Up);
                    }
                    else if (gamepad.LeftStickRight_Press)
                    {
                        robot.CycleStrategy(RobotState.CYCLE_DIRECTION.Down);
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

                    if (gamepad.DpadLeft_Press)
                    {
                        robot.CycleDefenseStrategy(RobotState.CYCLE_DIRECTION.Up);
                    }
                    else if (gamepad.DpadRight_Press)
                    {
                        robot.CycleAvoidanceStrategy(RobotState.CYCLE_DIRECTION.Up);
                    }
                    else if (gamepad.DpadUp_Press) {
                        robot.Climb_Success = RobotState.BOOLEAN.Yes;
                    } 
                    else if (gamepad.DpadDown_Press) {
                        robot.Climb_Success = RobotState.BOOLEAN.No;
                    }

                    if (gamepad.StartButton_Press && !robot.ClimbedTime && robot.TimeOfClimb_StopWatch.IsRunning)
                    {
                        robot.CycleRobotMode(RobotState.CYCLE_DIRECTION.Down);
                        robot.TimeOfClimb_StopWatch.Stop();
                        robot.TimeOfClimb_StopWatch.Reset();
                    }

                }

                // Values if robot is NoSho
                else if (robot.NoSho)
                {

                }
            }
        }
    }
}