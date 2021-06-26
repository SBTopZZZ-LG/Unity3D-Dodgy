using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropperTrigger : MonoBehaviour
{
    [SerializeField] private GameObject dropper;
    private bool hasTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player" && !hasTriggered)
        {
            Debug.Log("Player collided");

            hasTriggered = true;

            MeshRenderer mr = dropper.transform.GetComponent<MeshRenderer>();
            Rigidbody rb = dropper.transform.GetComponent<Rigidbody>();

            mr.enabled = true;
            rb.useGravity = true;
        }
    }

    private void OnCollisionEnter(Collision other)
    {

    }
}
