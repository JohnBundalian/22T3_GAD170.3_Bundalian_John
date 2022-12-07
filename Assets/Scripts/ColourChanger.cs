using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JohnBundalian
{
    public class ColourChanger : MonoBehaviour
    {
        // This cube will CHANGE COLOUR when "activated" when the "OnChangeColourEvent" is announced.

        // When subscribed to the event.
        private void OnEnable()
        {
            EventsManager.OnColourChangeEvent += Activate;
        }

        // When unsubsribed to the event.
        private void OnDisable()
        {
            EventsManager.OnColourChangeEvent -= Activate;
        }

        private void Start()
        {
            Debug.Log("Colour Changed");
            Activate();
        }
        private void Activate()
        {

            float redValue = Random.Range(0, 1f);
            float greenValue = Random.Range(0, 1f);
            float blueValue = Random.Range(0, 1f);


            //GetComponent<Components> allows you to address references
            gameObject.GetComponent<MeshRenderer>().material.color = new Color(redValue,greenValue,blueValue);
        }
    }
}

