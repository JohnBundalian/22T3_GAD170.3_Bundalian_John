using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JohnBundalian
{
    public class Imposter : MonoBehaviour
    {
       
        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Debug.Log("Imposter Killed Player Character.");
            }
            
        }

    }
}

