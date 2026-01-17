using ControllerScouting.Utilities;
using SharpDX.DirectInput;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ControllerScouting.Gamepad
{
    /// <summary>
    /// THIS IS CODE TO DEFINE A GAMEPAD AND ITS BUTTONS, ONLY MODIFY IF YOU KNOW WHAT YOU ARE DOING
    /// </summary>
    public class GamePad
    {
        //currentValue values
        private bool _a = false;
        private bool _b = false;
        private bool _x = false;
        private bool _y = false;
        private bool _rt = false;
        private bool _lt = false;
        private bool _rb = false;
        private bool _lb = false;
        private bool _dpadup = false;
        private bool _dpaddown = false;
        private bool _dpadleft = false;
        private bool _dpadright = false;
        private bool _leftStickUp = false;
        private bool _leftStickDown = false;
        private bool _leftStickLeft = false;
        private bool _leftStickRight = false;
        private bool _rightStickUp = false;
        private bool _rightStickDown = false;
        private bool _rightStickLeft = false;
        private bool _rightStickRight = false;
        private bool _backButton = false;
        private bool _startButton = false;
        private bool _r3 = false;
        private bool _l3 = false;
        private string _deviceInfo;

        //previous values

        private bool _aPrev = false;
        private bool _bPrev = false;
        private bool _xPrev = false;
        private bool _yPrev = false;
        private bool _rtPrev = false;
        private bool _ltPrev = false;
        private bool _rbPrev = false;
        private bool _lbPrev = false;
        private bool _dpadupPrev = false;
        private bool _dpaddownPrev = false;
        private bool _dpadleftPrev = false;
        private bool _dpadrightPrev = false;
        private bool _leftStickUpPrev = false;
        private bool _leftStickDownPrev = false;
        private bool _leftStickLeftPrev = false;
        private bool _leftStickRightPrev = false;
        private bool _rightStickUpPrev = false;
        private bool _rightStickDownPrev = false;
        private bool _rightStickLeftPrev = false;
        private bool _rightStickRightPrev = false;
        private bool _backButtonPrev = false;
        private bool _startButtonPrev = false;
        private bool _r3Prev = false;
        private bool _l3Prev = false;

        readonly Joystick _js;

        public GamePad(Joystick js)
        {
            _js = js;
            this.Update();
        }

        public void Update()
        {
            //save old values before overwritten.
            RecordOldValues();

            try
            {
                //reads all digital buttons
                _a = _js.GetCurrentState().Buttons[0];
                _b = _js.GetCurrentState().Buttons[1];
                _x = _js.GetCurrentState().Buttons[2];
                _y = _js.GetCurrentState().Buttons[3];
                _lb = _js.GetCurrentState().Buttons[4];
                _rb = _js.GetCurrentState().Buttons[5];
                _startButton = _js.GetCurrentState().Buttons[7];
                _backButton = _js.GetCurrentState().Buttons[6];

                _l3 = _js.GetCurrentState().Buttons[8];
                _r3 = _js.GetCurrentState().Buttons[9];

                //reads which dpad directions are pressed
                int pov = _js.GetCurrentState().PointOfViewControllers[0];
                _dpadup = ((pov > 27000 || pov < 9000) && pov != -1);
                _dpaddown = (9000 < pov && pov < 27000);
                _dpadright = (0 < pov && pov < 18000);
                _dpadleft = (18000 < pov);

                //reads the direction of the left hand anolog stick
                int X = _js.GetCurrentState().X;
                int Y = _js.GetCurrentState().Y;
                _leftStickUp = (-100 < X) && (X < 100) && (Y < -90);
                _leftStickDown = (-100 < X) && (X < 100) && (Y > 90);
                _leftStickRight = (-100 < Y) && (Y < 100) && (X < 90);
                _leftStickLeft = (-100 < Y) && (Y < 100) && (X > -90);

                //reads direction of left hand analog stick
                int RotationX = _js.GetCurrentState().RotationX;
                int RotationY = _js.GetCurrentState().RotationY;
                _rightStickUp = (-100 < RotationX) && (RotationX < 100) && (RotationY < -90);
                _rightStickDown = (-100 < RotationX) && (RotationX < 190) && (RotationY > 90);
                _rightStickLeft = (-100 < RotationY) && (RotationY < 100) && (RotationX < -90);
                _rightStickRight = (-100 < RotationY) && (RotationY < 100) && (RotationX > 90);

                //reads which trigger is pressed
                int Z = _js.GetCurrentState().Z;
                _rt = (Z < -99);
                _lt = (Z > 98);

                //read device info
                _deviceInfo = _js.Information.InstanceName;
            }
            catch (Exception)
            {

            }

        }

        public JoystickState GetCurrentState()
        { return _js.GetCurrentState(); }

        //Pressed State - Only triggers once per button press
        public bool AButton_Press
        { get { return IsPressed(_a, _aPrev); } }

        public bool BButton_Press
        { get { return IsPressed(_b, _bPrev); } }

        public bool XButton_Press
        { get { return IsPressed(_x, _xPrev); } }

        public bool YButton_Press
        { get { return IsPressed(_y, _yPrev); } }

        public bool R3_Press
        { get { return IsPressed(_r3, _r3Prev); } }

        public bool L3_Press
        { get { return IsPressed(_l3, _l3Prev); } }

        public bool RightTrigger_Press
        { get { return IsPressed(_rt, _rtPrev); } }

        public bool LeftTrigger_Press
        { get { return IsPressed(_lt, _ltPrev); } }

        public bool RightButton_Press
        { get { return IsPressed(_rb, _rbPrev); } }

        public bool LeftButton_Press
        { get { return IsPressed(_lb, _lbPrev); } }

        public bool DpadUp_Press
        { get { return IsPressed(_dpadup, _dpadupPrev); } }

        public bool DpadRight_Press
        { get { return IsPressed(_dpadright, _dpadrightPrev); } }

        public bool DpadDown_Press
        { get { return IsPressed(_dpaddown, _dpaddownPrev); } }

        public bool DpadLeft_Press
        { get { return IsPressed(_dpadleft, _dpadleftPrev); } }

        public bool LeftStickUp_Press
        { get { return IsPressed(_leftStickUp, _leftStickUpPrev); } }

        public bool LeftStickRight_Press
        { get { return IsPressed(_leftStickRight, _leftStickRightPrev); } }

        public bool LeftStickDown_Press
        { get { return IsPressed(_leftStickDown, _leftStickDownPrev); } }

        public bool LeftStickLeft_Press
        { get { return IsPressed(_leftStickLeft, _leftStickLeftPrev); } }

        public bool RightStickUp_Press
        { get { return IsPressed(_rightStickUp, _rightStickUpPrev); } }

        public bool RightStickRight_Press
        { get { return IsPressed(_rightStickRight, _rightStickRightPrev); } }

        public bool RightStickDown_Press
        { get { return IsPressed(_rightStickDown, _rightStickDownPrev); } }

        public bool RightStickLeft_Press
        { get { return IsPressed(_rightStickLeft, _rightStickLeftPrev); } }

        public bool BackButton_Press
        { get { return IsPressed(_backButton, _backButtonPrev); } }

        public bool StartButton_Press
        { get { return IsPressed(_startButton, _startButtonPrev); } }

        // Released only triggers once per state
        public bool AButton_Release
        { get { return IsReleased(_a, _aPrev); } }

        public bool BButton_Release
        { get { return IsReleased(_b, _bPrev); } }

        public bool XButton_Release
        { get { return IsReleased(_x, _xPrev); } }

        public bool YButton_Release
        { get { return IsReleased(_y, _yPrev); } }

        public bool R3_Release
        { get { return IsReleased(_r3, _r3Prev); } }

        public bool L3_Release
        { get { return IsReleased(_l3, _l3Prev); } }

        public bool RightTrigger_Release
        { get { return IsReleased(_rt, _rtPrev); } }

        public bool LeftTrigger_Release
        { get { return IsReleased(_lt, _ltPrev); } }

        public bool RightButton_Release
        { get { return IsReleased(_rb, _rbPrev); } }

        public bool LeftButton_Release
        { get { return IsReleased(_lb, _lbPrev); } }

        public bool DpadUp_Release
        { get { return IsReleased(_dpadup, _dpadupPrev); } }

        public bool DpadRight_Release
        { get { return IsReleased(_dpadright, _dpadrightPrev); } }

        public bool DpadDown_Release
        { get { return IsReleased(_dpaddown, _dpaddownPrev); } }

        public bool DpadLeft_Release
        { get { return IsReleased(_dpadleft, _dpadleftPrev); } }

        public bool leftStickUp_Release
        { get { return IsReleased(_leftStickUp, _leftStickUpPrev); } }

        public bool leftStickRight_Release
        { get { return IsReleased(_leftStickRight, _leftStickRightPrev); } }

        public bool leftStickDown_Release
        { get { return IsReleased(_leftStickDown, _leftStickDownPrev); } }

        public bool leftStickLeft_Release
        { get { return IsReleased(_leftStickLeft, _leftStickLeftPrev); } }

        public bool rightStickUp_Release
        { get { return IsReleased(_rightStickUp, _rightStickUpPrev); } }

        public bool rightStickRight_Release
        { get { return IsReleased(_rightStickRight, _rightStickRightPrev); } }

        public bool rightStickDown_Release
        { get { return IsReleased(_rightStickDown, _rightStickDownPrev); } }

        public bool rightStickLeft_Release
        { get { return IsReleased(_rightStickLeft, _rightStickLeftPrev); } }

        public bool BackButton_Release
        { get { return IsReleased(_backButton, _backButtonPrev); } }

        public bool StartButton_Release
        { get { return IsReleased(_startButton, _startButtonPrev); } }

        //Down State - Triggers any time the button is held down (more than once per button press)
        public bool AButton_Down
        { get { return _a; } }

        public bool BButton_Down
        { get { return _b; } }

        public bool XButton_Down
        { get { return _x; } }

        public bool YButton_Down
        { get { return _y; } }

        public bool R3_Down
        { get { return _r3; } }

        public bool L3_Down
        { get { return _l3; } }

        public bool RightTrigger_Down
        { get { return _rt; } }

        public bool LeftTrigger_Down
        { get { return _lt; } }

        public bool RightButton_Down
        { get { return _rb; } }

        public bool LeftButton_Down
        { get { return _lb; } }

        public bool DpadUp_Down
        { get { return _dpadup; } }

        public bool DpadRight_Down
        { get { return _dpadright; } }

        public bool DpadDown_Down
        { get { return _dpaddown; } }

        public bool DpadLeft_Down
        { get { return _dpadleft; } }

        public bool leftStickUp_Down
        { get { return _leftStickUp; } }

        public bool leftStickRight_Down
        { get { return _leftStickRight; } }

        public bool leftStickDown_Down
        { get { return _leftStickDown; } }

        public bool leftStickLeft_Down
        { get { return _leftStickLeft; } }

        public bool rightStickUp_Down
        { get { return _rightStickUp; } }

        public bool rightStickRight_Down
        { get { return _rightStickRight; } }

        public bool rightStickDown_Down
        { get { return _rightStickDown; } }

        public bool rightStickLeft_Down
        { get { return _rightStickLeft; } }

        public bool BackButton_Down
        { get { return _backButton; } }

        public bool StartButton_Down
        { get { return _startButton; } }
        public string DeviceInfo
        { get { return _deviceInfo; } }

        private void RecordOldValues()
        {
            _aPrev = _a;
            _bPrev = _b;
            _xPrev = _x;
            _yPrev = _y;
            _rtPrev = _rt;
            _ltPrev = _lt;
            _rbPrev = _rb;
            _lbPrev = _lb;
            _dpadupPrev = _dpadup;
            _dpadleftPrev = _dpadleft;
            _dpadrightPrev = _dpadright;
            _dpaddownPrev = _dpaddown;
            _leftStickUpPrev = _leftStickUp;
            _leftStickDownPrev = _leftStickDown;
            _leftStickLeftPrev = _leftStickLeft;
            _leftStickRightPrev = _leftStickRight;
            _rightStickUpPrev = _rightStickUp;
            _rightStickDownPrev = _rightStickDown;
            _rightStickLeftPrev = _rightStickLeft;
            _rightStickRightPrev = _rightStickRight;
            _backButtonPrev = _backButton;
            _startButtonPrev = _startButton;
            _r3Prev = _r3;
            _l3Prev = _l3;
        }

        private static bool IsPressed(bool currentValue, bool prevValue)
        {
            if (prevValue == false && currentValue == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsReleased(bool currentValue, bool prevValue)
        {
            if (prevValue == true && currentValue == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    partial class Controllers
    {
        public Stopwatch stopwatch = new();
        public TimeSpan Zero { get; private set; }
        private static bool IsAxis(Guid objectType)
        {
            return objectType == ObjectGuid.XAxis ||
                   objectType == ObjectGuid.YAxis ||
                   objectType == ObjectGuid.ZAxis ||
                   objectType == ObjectGuid.RxAxis ||
                   objectType == ObjectGuid.RyAxis ||
                   objectType == ObjectGuid.RzAxis;
        }
        private static Joystick[] GetSticks(DirectInput input)
        {
            List<Joystick> sticks = [];
            foreach (DeviceInstance device in input.GetDevices(DeviceClass.GameControl, DeviceEnumerationFlags.AttachedOnly))
            {
                try
                {
                    var stick = new Joystick(input, device.InstanceGuid);
                    //Work on identifying controllers when getting the sticks, helps when a controller is disconnected
                    //and reconnected, try to not change the other controllers when this happens

                    stick.Acquire();

                    foreach (DeviceObjectInstance deviceObject in stick.GetObjects())
                    {
                        if (IsAxis(deviceObject.ObjectType))
                        {
                            var properties = stick.GetObjectPropertiesById(deviceObject.ObjectId);
                            if (properties != null)
                            {
                                properties.Range = new InputRange(-100, 100);
                            }
                        }
                    }

                    sticks.Add(stick);
                }
                catch (Exception) { }
            }
            return [.. sticks];
        }
        public static GamePad[] GetGamePads()
        {
            DirectInput input = new();
            List<GamePad> gamepads = [];

            foreach (var stick in GetSticks(input))
            {
                gamepads.Add(new GamePad(stick));
                _ = Logger.Log(stick.Information.InstanceName);
            }
            while (gamepads.Count < 6)
            {
                gamepads.Add(null);
            }
            return [.. gamepads];
        }
    }
}