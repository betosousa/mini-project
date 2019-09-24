using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Platformer.Mechanics
{
    public class GameStats : MonoBehaviour
    {
        public static GameStats Instance;

        public GameObject statsPanel;
        
        public TextMeshProUGUI statsText;

        protected int tokens;
        protected int bonusTokens;
        protected int bonusLifes;
        protected int boxes;
        protected int enemies;

        protected int deathsCount;
        protected int tokensCount;
        protected int bonusTokensCount;
        protected int foundBonusLifes;
        protected int openedBoxes;
        protected int enemiesKilled;

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
        }

        public void AddToken(int value)
        {
            if (value == 1) tokens++;
            else bonusTokens++;
        }

        public void AddBonusLifes() => bonusLifes++;
        public void AddBoxes() => boxes++;
        public void AddEnemy() => enemies++;

        public void CountToken(int value)
        {
            if (value == 1) tokensCount++;
            else bonusTokensCount++;
        }

        public void CountBonusLifes() => foundBonusLifes++;
        public void CountBoxes() => openedBoxes++;
        public void CountDeaths() => deathsCount++;
        public void CountKills() => enemiesKilled++;

        public void ShowStats()
        {
            string str = "Token: " + tokensCount + " / " + tokens + "\n";
            str += "Bonus Token: " + bonusTokensCount + " / " + bonusTokens + "\n";
            str += "Bonus Life: " + foundBonusLifes + " / " + bonusLifes + "\n";
            str += "Boxes: " + openedBoxes + " / " + boxes + "\n";
            str += "Enemies killed: " + enemiesKilled + " / " + enemies + "\n";
            str += "Deaths: " + deathsCount ;
            Debug.Log(str);

            statsText.text = str;
            statsPanel.SetActive(true);
        }

        void Update()
        {
            if(Input.GetKeyUp(KeyCode.X))
            ShowStats();
        }
    }
}