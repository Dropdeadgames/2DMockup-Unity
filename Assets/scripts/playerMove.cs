using UnityEngine;
using System.Collections;

// Handle player movement

public class playerMove : MonoBehaviour
{
    public float speed = 1.0f; // Default setting, changed in editor

    void Update ()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f) * speed * Time.deltaTime;  // Move Player
    }

    void OnTriggerEnter (Collider coll)
    {
        if (coll.gameObject.tag == "wall") // Find a collision with a member tagged as "wall"
        {
            speed = 0.0f; // "Kill" player if they hit the wall
        }
    }
}
