using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private Rigidbody dRigidbody;

    [SerializeField] private uint waitTime = 3;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        dRigidbody = GetComponent<Rigidbody>();

        meshRenderer.enabled = false;
        dRigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= waitTime)
        {
            if (!meshRenderer.enabled)
                meshRenderer.enabled = true;
            if (!dRigidbody.useGravity)
                dRigidbody.useGravity = true;
        }
    }
}
