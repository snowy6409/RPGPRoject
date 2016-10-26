using UnityEngine;
using UnityEngine.UI;
using System.Collections;

// The good thing about this is that you can design the hunger bar however you want (you need a background bar and a nar to overlap it e.g. a green rectangle)

// This script could be attached to a scene manager

public class HungerBar : MonoBehaviour {

	public float currentHunger = 100f;
	public float maxHunger = 100f;
	public float hungerRate = 1f;
	public Image hungerBar;
	public Text text;

	void Update ()
	{
		// update the hunger bar each frame
		UpdateHungerBar ();
		currentHunger -= Time.deltaTime * hungerRate; // how fast does the hunger bar deplete (smaller --> takes longer & vice versa)
	}

	void UpdateHungerBar()
	{
		float ratio = currentHunger / maxHunger; // how much hunger the player has left;

		if (ratio <= 0) {
			ratio = 0; // ensure the hunger bar doesn't overlap and go the wrong direction (going into the negatives)
		}

		text.text = Mathf.RoundToInt(ratio*100).ToString() + "%";

		hungerBar.rectTransform.localScale = new Vector3(ratio, 1, 1); // Update the width of the hunger bar
	}

}
