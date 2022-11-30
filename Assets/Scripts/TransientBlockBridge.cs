using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JohnBundalian
{
    public class TransientBlockBridge : MonoBehaviour
    {

        /* 
        Check what state the block is in
        If state is tangible, set to intangible.
        Disable Box Collider
        Change material to “Intangible” material.
        Else If state is intangible, set to tangible.
        Enable box collider component
        Change material “Tangible” material
        */

        [SerializeField] private GameObject block;
        [SerializeField] private Material tangibleMaterial;
        [SerializeField] private Material intangibleMaterial;

        private void Start()
        {
            InTurnTangible();
        }

        private void TurnTangible()
        {
            if (block.GetComponent<MeshCollider>().enabled == true)
            {
                // ... disable the box collider.
                block.GetComponent<MeshCollider>().enabled = false;

                // ... and change the material to "Intangible".
                block.GetComponent<MeshRenderer>().material = intangibleMaterial;

            }
        }

        private void InTurnTangible()
        {
            if (block.GetComponent<MeshCollider>().enabled == false)
            {
                // ... disable the box collider.
                block.GetComponent<MeshCollider>().enabled = true;

                // ... and change the material to "Intangible".
                block.GetComponent<MeshRenderer>().material = tangibleMaterial;

            }
        }
    }
}


