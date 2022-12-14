using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace JohnBundalian
{
    public class KillPlayer : MonoBehaviour
    {
        // Variables
        private int respawnSceneIndex;
       
         void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Debug.Log("Killzone Triggered.");
                SceneManager.LoadScene(respawnSceneIndex);
            }
        }
    }
}

