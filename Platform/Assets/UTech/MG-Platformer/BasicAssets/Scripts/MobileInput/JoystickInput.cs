using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace Platformer.Mechanics.Mobile
{
    /// <summary>
    /// Gets user input for horizontal movement
    /// </summary>
    public class JoystickInput : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        public RectTransform background;

        private float horizontal;
        private bool pointerOn;

        public float HorizontalAxis { get { return horizontal; } }

        public void OnPointerEnter(PointerEventData pointerEventData)
        {
            pointerOn = true;
        }

        public void OnPointerExit(PointerEventData pointerEventData)
        {
            pointerOn = false;
            horizontal = 0f;
        }

        void Update()
        {
            /// if pointer is inside joystick image area, try to move
            if (pointerOn)
            {
# if UNITY_EDITOR
                Move(Input.mousePosition);
# else
                foreach (Touch t in Input.touches)
                {
                    if (Move(t.position)) break;
                }
# endif
            }
        }

        /// <summary>
        /// Verifies if input is inside valid area and updates horizontal value
        /// </summary>
        /// <param name="touchPosition"></param>
        bool Move(Vector2 touchPosition)
        {
            bool isMove = false;

            if (background.rect.Contains(touchPosition))
            {
                horizontal = touchPosition.x > background.rect.width / 2 ? 1f : -1f;
                isMove = true;
            }
            return isMove;
        }
    }
}