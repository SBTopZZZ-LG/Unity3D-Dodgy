using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private uint bumpCount = 0;

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("You have bumped the wall ( " + other.transform.name + ") " + ++bumpCount + " times.");
    }
}
