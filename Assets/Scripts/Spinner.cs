using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float spinX = 1, spinY = 0, spinZ = 1;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(spinX * Time.deltaTime, spinY * Time.deltaTime, spinZ * Time.deltaTime);
    }
}
