using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace Platformer.Mechanics.Mobile
{
    /// <summary>
    /// Controls user input for movement
    /// </summary>
    public class JoystickInput : MonoBehaviour
    {
        private float horizontal;

        public float HorizontalAxis { get { return horizontal; } }

        public static JoystickInput Instance;

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

        public void MoveRight() => horizontal = +1f;

        public void MoveLeft() => horizontal = -1f;

        public void NoMove() => horizontal = 0f;

    }
}