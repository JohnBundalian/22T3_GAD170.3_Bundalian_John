using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace JohnBundalian
{
    public class CubeActivator : MonoBehaviour
    {
        // Have bool events for triger activator
        [SerializeField] private bool isPlayerCharacterNearby = false;

        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.name == "Player Character")
            {
                isPlayerCharacterNearby = true;
            }

        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.name == "Player Character")
            {
                isPlayerCharacterNearby = false;
            }

        }

        // If the player Presses E and Is in the area this bool conditnal will allow the certain switch to be activated.
        /// <summary>
        /// 
        /// void update ()
        /// if (Input.GetKeyDown(KeyCode.E) && isPlayerCharacterNearby == true)
        /// {
        ///                 EventsManager.OnTransientBlockActivatorEvent?.Invoke();
        ///                 Debug.Log("E has been pressed");
        /// }
        /// 
        /// </summary>

        // points to note conidtionals 

        //update is called once per frame.
        private void Update()
        {
            // if (Input.GetKeyDown(KeyCode.E)) if pressed down will count during frames.
            // if (Input.GetKeyUp(KeyCode.E)) if releaseed will count during frames.
            // if (Input.GetKeyHeld(KeyCode.E)) if held down will count during frames.
            // if (Input.GetKey(KeyCode.E)) combines Down and held together during the frames.

            // If player presses E
            if (Input.GetKeyDown(KeyCode.E))
            {
                // Announces the events for the cubes.
                // ? required if its calling the event.
                EventsManager.OnColourChangeEvent?.Invoke();
                EventsManager.OnTeleportEvent?.Invoke();
                EventsManager.OnTransientBlockActivatorEvent?.Invoke();
                Debug.Log("E has been pressed");
            }

            if (Input.GetKeyUp(KeyCode.E))
            {
                // Announces the events for the cubes.
                // ? required if its calling the event.
                EventsManager.OnColourChangeEvent?.Invoke();
                EventsManager.OnTeleportEvent?.Invoke();
                EventsManager.OnTransientBlockActivatorEvent?.Invoke();
                Debug.Log("E has been released");
            }

            if (Input.GetKey(KeyCode.E))
            {
                // Announces the events for the cubes.
                // ? required if its calling the event.
                EventsManager.OnColourChangeEvent?.Invoke();
                EventsManager.OnTeleportEvent?.Invoke();
                EventsManager.OnTransientBlockActivatorEvent?.Invoke();
                Debug.Log("E Pressed");
            }
            


        }

    }
}

