using UnityEngine;
using System.Collections;

// Handle flower instantiation

public class generateFlower : MonoBehaviour
{
    public GameObject flower;
    public int flowersToGrow;

    void Update ()
    {
        float xPosition = Random.Range(-5, 5); // Random position for x
        float yPosition = Random.Range(-3, 4); // Random position for y
        Vector3 flowerPosition = new Vector3(xPosition, yPosition, 0.0f);  // Set the position for the flowers

        if (GameObject.FindGameObjectsWithTag("flower").Length < flowersToGrow) // Create only as many flowers per level as defined
        {
            Instantiate(flower, flowerPosition, Quaternion.identity); // Create flowers
        }
    }
}
