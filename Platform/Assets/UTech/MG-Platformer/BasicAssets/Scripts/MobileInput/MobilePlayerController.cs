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
        protected override float HorizontalInput()
        {
            return JoystickInput.Instance.HorizontalAxis;
        }

        protected override bool JumpPressed()
        {
            return JumpInput.Instance.JumpPressed;
        }

        protected override bool JumpReleased()
        {
            return !JumpInput.Instance.JumpPressed;
        }
    }
}