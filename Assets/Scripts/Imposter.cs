using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JohnBundalian
{
    public class Imposter : MonoBehaviour
    {
        // Start is called before the first frame update
        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log("Imposter Killed Player Character.");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

