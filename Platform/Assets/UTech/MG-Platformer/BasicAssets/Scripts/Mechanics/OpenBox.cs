using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer.Mechanics
{
    /// <summary>
    /// Class for opening a box with bonus
    /// </summary>
    [RequireComponent(typeof(Collider2D))]
    public class OpenBox : MonoBehaviour
    {
        void Start()
        {
            GameStats.Instance.AddBoxes();
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            var player = other.gameObject.GetComponent<PlayerController>();
            if (player != null)
            {
                GameStats.Instance.CountBoxes();
                gameObject.SetActive(false);
            }
        }
    }
}