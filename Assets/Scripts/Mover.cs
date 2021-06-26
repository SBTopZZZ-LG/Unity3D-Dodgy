using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public bool enableControls = true;
    [SerializeField] private float playerSpeed = 8;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        Update_Movement();
    }

    void Update_Movement()
    {
        if (!enableControls)
            return;

        float xValue = Input.GetAxis("Horizontal") * -playerSpeed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * -playerSpeed * Time.deltaTime;

        transform.Translate(xValue, 0, zValue);
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to our Game!");
        Debug.Log("Use WASD, or the arrow keys, or your movement keys to move player.");
        Debug.Log("Your task is to reach B as soon as possible!");
        Debug.Log("However, you will face obstacles on your path so try to avoid hitting them, unless you want to reduce your score in the end.");
    }
}
