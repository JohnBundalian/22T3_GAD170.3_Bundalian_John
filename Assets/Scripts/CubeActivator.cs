using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace JohnBundalian
{
    public class CubeActivator : MonoBehaviour
    {
        // Have bool events for triger activator
        [SerializeField] private bool PlayerCharacterInTriggerArea = false;
        // If Player is killed by Imposter - TESTING
        [SerializeField] bool PlayerKilled = false;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name == "Player")
            {
                PlayerCharacterInTriggerArea = true;
            }

        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.name == "Player")
            {
                PlayerCharacterInTriggerArea = false;
            }

        }

        // points to note conidtionals 

        //update is called once per frame.
        public void Update()
        {
            // If Player is killed by Imposter - TESTING
            if (PlayerKilled == true)
            {
                EventsManager.OnRespawning?.Invoke();
            }

            // If the player Presses E and Is in the area this bool conditnal will allow the certain switch to be activated.
            if (Input.GetKeyDown(KeyCode.E) && PlayerCharacterInTriggerArea == true)
            {
                EventsManager.OnTransientBlockActivatorEvent?.Invoke();
                Debug.Log("Trigger - Events Manager called Event - OnTransientBlockActivatorEvent");
            }

            // if (Input.GetKeyDown(KeyCode.E)) if pressed down will count during frames.
            // if (Input.GetKeyUp(KeyCode.E)) if releaseed will count during frames.
            // if (Input.GetKeyHeld(KeyCode.E)) if held down will count during frames.
            // if (Input.GetKey(KeyCode.E)) combines Down and held together during the frames.

            // If player presses E
            if (Input.GetKeyDown(KeyCode.P))
            {
                // Announces the events for the cubes.
                // ? required if its calling the event.
                EventsManager.OnColourChangeEvent?.Invoke();
                EventsManager.OnTeleportEvent?.Invoke();
                Debug.Log("P has been pressed");
            }

            if (Input.GetKeyUp(KeyCode.P))
            {
                // Announces the events for the cubes.
                // ? required if its calling the event.
                EventsManager.OnColourChangeEvent?.Invoke();
                EventsManager.OnTeleportEvent?.Invoke();
                Debug.Log("P has been released");
            }

            if (Input.GetKey(KeyCode.P))
            {
                // Announces the events for the cubes.
                // ? required if its calling the event.
                EventsManager.OnColourChangeEvent?.Invoke();
                EventsManager.OnTeleportEvent?.Invoke();
                Debug.Log("P Pressed");
            }



        }

    }
}