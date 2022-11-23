using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JohnBundalian
{
    public class BuzzSaw : MonoBehaviour
    {
        // Start is called before the first frame update
        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log("Buzz kills Character");
        }
        
        // Update is called once per frame
        void Update()
        {

        }
    }
}

