using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer.Mechanics.Mobile
{
    /// <summary>
    /// Gets user input for horizontal movement
    /// </summary>
    public class HorizontalInput : BaseInput
    {
        public bool positiveInput;
        public override void OnPointerEnter(UnityEngine.EventSystems.PointerEventData pointer)
        {
            if (positiveInput)
                JoystickInput.Instance.MoveRight();
            else
                JoystickInput.Instance.MoveLeft();

            base.OnPointerEnter(pointer);
        }

        public override void OnPointerExit(UnityEngine.EventSystems.PointerEventData pointer)
        {
            JoystickInput.Instance.NoMove();
            base.OnPointerExit(pointer);
        }
    }
}