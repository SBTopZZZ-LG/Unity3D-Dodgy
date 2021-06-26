using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    [SerializeField] private GameObject finishPlatform;
    private List<GameObject> playersTriggered = new List<GameObject>();

    private void Update()
    {
        foreach (GameObject player in playersTriggered)
        {
            if (player.transform.position != finishPlatform.transform.position)
                player.transform.position = Vector3.MoveTowards(player.transform.position,
                new Vector3(finishPlatform.transform.position.x, player.transform.position.y, finishPlatform.transform.position.z), 3 * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player" && !playersTriggered.Contains(other.gameObject))
        {
            Debug.Log("You Won!");

            playersTriggered.Add(other.gameObject);

            Mover m = other.transform.GetComponent<Mover>();
            m.enableControls = false;

            Vector3 start = other.transform.position;
            Vector3 end = finishPlatform.transform.position;
        }
    }
}
