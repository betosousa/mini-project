using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platformer.Core;
using Platformer.Gameplay;

namespace Platformer.Mechanics
{
    /// <summary>
    /// Class for triggering the life bonus event
    /// </summary>
    [RequireComponent(typeof(Collider2D))]
    public class LifeBonus : MonoBehaviour
    {
        public AudioClip audio;

        void Start()
        {
            GameStats.Instance.AddBonusLifes();
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            var player = other.gameObject.GetComponent<PlayerController>();
            if (player != null)
            {
                var evnt = Simulation.Schedule<LifeBonusEvent>();
                evnt.bonus = this;
                evnt.player = player;
            }
        }
    }
}