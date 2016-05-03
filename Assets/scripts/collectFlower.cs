using UnityEngine;
using System.Collections;

// Handle flower collection

public class collectFlower : MonoBehaviour
{

    void OnTriggerEnter (Collider coll)
    {
        if (coll.gameObject.tag == "Player") // Attached to flower, looking for collision from player.
        {
            GameObject.FindWithTag("gameManager").GetComponent<score>().SendMessage("collect"); // When a flower is collected, call the gameManager function to record the score
            Destroy(gameObject); // Destroy the flower when it has been picked up
        }
    }
}
