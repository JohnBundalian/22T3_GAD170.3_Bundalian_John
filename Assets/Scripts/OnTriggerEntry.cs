using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JohnBundalian
{
    public class OnTriggerEntry : MonoBehaviour
    {
        // Start is called before the first frame update
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("On Trigger Enter");
        }


        // Update is called once per frame
        void Update()
        {

        }
    }
}

