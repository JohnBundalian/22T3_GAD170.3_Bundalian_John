using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JohnBundalian
{
    public class KillPlayerCharacter : MonoBehaviour
    {
        // Varible required to trigger respawn
        bool PlayerKilled = false;

        // Colliding with gameObject that contains script will allow on collision trigger to action.
        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                PlayerKilled = true;
                Debug.Log("Private void OnCollisionEnter - Harzard Killed Player Character.");
            }            
        }
        private void OnCollisionExit(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
            { 
                PlayerKilled = false;
                Debug.Log("Private void OnCollisionEnter - Hazard Killed Player Character.");
                // When leaving area giving instructions to impact the named boolian variable to false not allowing
                // the Button to be interacted with any more while outside of area.
                // Informs to see if Trigger Area is left.
            }

        }
        private void Update()
        {
            // Input key for button interation that is conditioned to a boolian.
            if (PlayerKilled == true)
            {
                // Required input from Player to identify appropiate Key has been pressed by Player.
                EventsManager.OnRespawning?.Invoke();
                Debug.Log("Private Void Update - BOOL==TRUE = Hazard Killed Player");
            }

        }
    }
}

