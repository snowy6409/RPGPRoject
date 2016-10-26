using UnityEngine;
using UnityEngine.UI;
using System.Collections;

// The good thing about this is that you can design the hunger bar however you want (you need a background bar and a nar to overlap it e.g. a green rectangle)

// This script could be attached to a scene manager

public class StaminaBar : MonoBehaviour {

	public float currentStamina = 100f;
	public float maxStamina = 100f;
	public float staminaRate = 1f;
    public float staminaLevel = 5f;
    public float StaminaXP = 0;
	public Image staminaBar;
	public Text text;

	void Update ()
	{
        staminaRate = staminaLevel / 2;

  
		// update the hunger bar each frame
		UpdateStaminaBar ();
	}

	void UpdateStaminaBar()
	{
        if (StaminaXP >= 100)
        {
            staminaLevel += 1;
            StaminaXP = 0;
        }
        float ratio = currentStamina / maxStamina; // how much stamina the player has left;

		if (ratio <= 0) {
			ratio = 0; // ensure the hunger bar doesn't overlap and go the wrong direction (going into the negatives)
		}

		text.text = Mathf.RoundToInt(ratio*100).ToString() + "%";

		staminaBar.rectTransform.localScale = new Vector3(ratio, 1, 1); // Update the width of the hunger bar
	}

}
