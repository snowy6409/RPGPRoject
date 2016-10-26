using UnityEngine;
using UnityEngine.UI;
using System.Collections;

// The good thing about this is that you can design the hunger bar however you want (you need a background bar and a nar to overlap it e.g. a green rectangle)

// This script could be attached to a scene manager

public class HealthBar : MonoBehaviour {

	public float currentHealth = 100f;
	public float maxHealth = 100f;
	public Image healthBar;
	public Text text;

	void Update ()
	{
		// update the hunger bar each frame
		UpdateHealthBar ();
	}

	void UpdateHealthBar()
	{
		float ratio = currentHealth / maxHealth; // how much hunger the player has left;

		if (ratio <= 0) {
			ratio = 0; // ensure the hunger bar doesn't overlap and go the wrong direction (going into the negatives)
		}

		text.text = Mathf.RoundToInt(ratio*100).ToString() + "%";

		healthBar.rectTransform.localScale = new Vector3(ratio, 1, 1); // Update the width of the health bar
	}

	public void TakeDamage (float dmg)
	{
		currentHealth -= dmg;

	}

}
