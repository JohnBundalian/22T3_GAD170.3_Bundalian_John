using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JohnBundalian
{
    public class Teleporter : MonoBehaviour
    {

        // When subscribed to the event.
        private void OnEnable()
        {
            EventsManager.OnTeleportEvent += Activate;
        }

        // When unsubsribed to the event.
        private void OnDisable()
        {
            EventsManager.OnTeleportEvent -= Activate;
        }

        // This cube will TELEPORT when "activated" when the "OnTeleportEvent" is announced.
        // TELEPORT means to move the cube to a random position on the Y axis.

        private void Start()
        {
            Debug.Log("Teleport");
            Activate();
        }

        private void Activate()
        {
            transform.position = new Vector3(2, Random.Range(0.5f, 4f), 0);
        }

    }
}
