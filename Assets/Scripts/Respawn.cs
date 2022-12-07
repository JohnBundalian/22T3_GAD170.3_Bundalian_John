using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JohnBundalian
{
    public class Respawn : MonoBehaviour
    {

        // When subscribed to the event.
        private void OnEnable()
        {
            EventsManager.OnRespawning += Respawning;
        }

        // When unsubsribed to the event.
        private void OnDisable()
        {
            EventsManager.OnRespawning -= Respawning;
        }

        // Player will relocate to allocated position imitating respawn.

        private void Respawning()
        {
            transform.position = new Vector3(0, 0.5f, 0);
            Debug.Log("Respawn");
        }

    }
}
