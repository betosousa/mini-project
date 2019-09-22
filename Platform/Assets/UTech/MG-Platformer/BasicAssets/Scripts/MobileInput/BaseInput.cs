using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace Platformer.Mechanics.Mobile
{
    /// <summary>
    /// Base visual response for user input
    /// </summary>
    public class BaseInput : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        protected Color defaultColor;
        protected Image buttonImage;

        public Color pressedColor;

        void Start()
        {
            buttonImage = GetComponent<Image>();
            defaultColor = buttonImage.color;
        }

        public virtual void OnPointerEnter(PointerEventData pointer)
        {
            buttonImage.color = pressedColor;
        }

        public virtual void OnPointerExit(PointerEventData pointerEventData)
        {
            buttonImage.color = defaultColor;
        }
    }
}