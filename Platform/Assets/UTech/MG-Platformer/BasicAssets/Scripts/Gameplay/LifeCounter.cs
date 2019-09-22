using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


namespace Platformer.Gameplay
{
    /// <summary>
    /// Counts how many lifes the player has
    /// </summary>
    public class LifeCounter : MonoBehaviour
    {
        protected int lifes = 3;
        protected TextMeshProUGUI countText;
        public static LifeCounter Instance;

        public int Lifes { get { return lifes; } }

        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else if (Instance != this)
            {
                Destroy(gameObject);
            }

            countText = GetComponent<TextMeshProUGUI>();
        }

        void Start()
        {
            UpdateCounter();
        }

        public void GainLife()
        {
            lifes++;
            UpdateCounter();
        }

        public void LooseLife()
        {
            lifes--;
            UpdateCounter();
        }

        void UpdateCounter()
        {
            countText.text = lifes.ToString();
        }
    }
}