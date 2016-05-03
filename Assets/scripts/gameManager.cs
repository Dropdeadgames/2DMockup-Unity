using UnityEngine;
using UnityEngine.UI;
using System.Collections;

// Control the game

public class gameManager : MonoBehaviour
{
    public static float levelTimer = 300f;

	void Update ()
    {
        levelTimer -= Time.deltaTime;  // Decrease timer by the time in game

        if (Input.GetKeyDown("x"))
        {
            Application.LoadLevel(Application.loadedLevel);  // Reload the level after Game Over
        }

	}

    void OnGUI ()
    {
        int intLevelTimer = (int) levelTimer;  // Cast the timer to an int to make it easier to read in the GUI

        GUI.Box(new Rect(110, 10, 100, 30), intLevelTimer.ToString()); // Display the time for the level

        if (levelTimer <= 0)
        {
            levelTimer = 0; // Stop timer from counting negatives
            Time.timeScale = 0; // Stop time movement in level
            GUI.Box(new Rect(300, 200, 300, 100), "Game Over! Please press X to restart"); // Display game over message, prompt to restart game
        }
    }

    public void changeTimer (float timer)
    {
        levelTimer = timer;
    }
}
