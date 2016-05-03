using UnityEngine;
using UnityEngine.UI;
using System.Collections;

// Handle the slider value and actions needed to use it

public class sliderValue : MonoBehaviour
{
    public Text sliderLabel;
    public Slider labelValue;

	void Update ()
    {
        sliderLabel.text = labelValue.GetComponent<Slider>().value.ToString(); // Display slider value as String on on the Text UI element defined
        gameManager.levelTimer = labelValue.GetComponent<Slider>().value; // Set the value of levelTimer in the gameManager script to the value of the slider
	}

    void startGame ()
    {

        Application.LoadLevel("TestLevel");  // Load game on Button press. Called from OnClick defined on the Button UI element in Editor
    }
}
