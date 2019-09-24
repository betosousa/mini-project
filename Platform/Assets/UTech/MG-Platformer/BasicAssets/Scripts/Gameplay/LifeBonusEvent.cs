using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platformer.Core;
using Platformer.Mechanics;

namespace Platformer.Gameplay
{
    /// <summary>
    /// Event that gives an extra life to the player
    /// </summary>
    public class LifeBonusEvent : Simulation.Event<LifeBonusEvent>
    {
        public PlayerController player;
        public LifeBonus bonus;

        public override void Execute()
        {
            LifeCounter.Instance.GainLife();
            GameStats.Instance.CountBonusLifes();
            AudioSource.PlayClipAtPoint(bonus.audio, bonus.transform.position);
            bonus.gameObject.SetActive(false);
        }
    }
}