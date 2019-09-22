using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Platformer.Gameplay
{
    /// <summary>
    /// Counts the total points acquired by the player
    /// </summary>
    public class PointsCounter : MonoBehaviour
    {
        public static PointsCounter Instance;
        
        protected TextMeshProUGUI countText;

        protected int points = 0;

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
            UpdatePoints();
        }

        void UpdatePoints()
        {
            countText.text = points.ToString();
        }

        public void AddPoints(int value)
        {
            points += value;
            UpdatePoints();
        }
    }
}