using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace JohnBundalian
{
    public class OnTriggerEntry : MonoBehaviour
    {
     // Player Character Will not be able to intially interact with button.
        public bool Panel = false;
  
        // Trigger area that requies Player Character to be near the button
        // to interact with button to be pressed with associated keybinding.
        private void OnTriggerEnter(Collider other)
        {
            // Informs to see if Trigger Area is entered.
            Debug.Log("On Collision Enter");
            // When in area giving instructions to impact the named boolian
            // variable to true allowing Button to be interacted with.
            Panel = true;
        }
        
        private void Update()
        {
            // Input key for button interation that is conditioned to a boolian.
            if (Input.GetKeyDown(KeyCode.E) && Panel==true) // && boolian==true )
            {
                // Required input from Player to identify appropiate Key has been pressed by Player.
                EventsManager.OnTransientBlockActivatorEvent?.Invoke();
                Debug.Log("E Pressed to action");
            }
        }

        // Player Character Will not be able to interact with button even if intially enter area.
        private void OnTriggerExit(Collider other)
        {
            // Informs to see if Trigger Area is left.
            Debug.Log("Off Collision Exit");
            // When leaving area giving instructions to impact the named boolian variable to false not allowing
            // the Button to be interacted with any more while outside of area.
            Panel = false;
        }
    }
}