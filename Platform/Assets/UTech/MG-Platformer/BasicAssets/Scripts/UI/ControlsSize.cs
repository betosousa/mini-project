using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Platformer.UI
{
    public class ControlsSize : MonoBehaviour
    {
        public Slider slider;
        public RectTransform axis, jumpButton;

        public void UpdateSize()
        {
            float size = slider.value;
            
            axis.localScale = new Vector3(size, size, 1f);
            jumpButton.localScale = new Vector3 (size, size, 1f);
        }

        public void Default()
        {
            slider.value = 1f;
            UpdateSize();
        }
    }
}