using UnityEngine;
using System.Collections;

// Handle the scoring

public class score : MonoBehaviour
{
    private int flowers;

    public void collect()  // Called from the collectFlower.cs script.
    { 
        flowers += 1;
    }

    void OnGUI ()
    {
        GUI.Box(new Rect(10, 10, 100, 30), flowers.ToString()); // Display the score on the GUI of the game
    }
}
