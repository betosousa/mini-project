using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer.Mechanics.Mobile
{
    /// <summary>
    /// Overrides PlayerController with mobile input
    /// </summary>
    public class MobilePlayerController : PlayerController
    {
        public JoystickInput joystick;

        protected override float HorizontalInput()
        {
            return joystick.HorizontalAxis;
        }


    }
}