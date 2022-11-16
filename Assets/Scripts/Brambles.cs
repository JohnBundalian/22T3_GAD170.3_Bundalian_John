using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JohnBundalian
{
    public class Brambles : MonoBehaviour
    {
        // Start is called before the first frame update
        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log("Brambles Has Been Collided with.");
        }
        
        // Update is called once per frame
        void Update()
        {

        }
    }
}

