using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace Platformer.Mechanics.Mobile
{
    /// <summary>
    /// Gets user input for jumps
    /// </summary>

    public class JumpInput : BaseInput
    {
        protected bool jumpPressed;
        public bool JumpPressed { get { return jumpPressed; } }

        public static JumpInput Instance;

        void Awake()
        {
            if(Instance == null)
            {
                Instance = this;
            }
            else if(Instance != this)
            {
                Destroy(gameObject);
            }
        }

        public override void OnPointerEnter(PointerEventData pointerEventData)
        {
            jumpPressed = true;
            base.OnPointerEnter(pointerEventData);
        }

        public override void OnPointerExit(PointerEventData pointerEventData)
        {
            jumpPressed = false;
            base.OnPointerExit(pointerEventData);
        }

    }
}