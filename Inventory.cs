using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {

    public string[] Items;
    public string[] Potions;
    public int Currency;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.I))
        { 
        
            foreach (var item in Items)
            {
               Debug.Log(item.ToString());
            }
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            foreach (var item in Potions)
            {
                Debug.Log(item.ToString());
            }
        }
        if (Input.GetKeyDown(KeyCode.C))
        {

                Debug.Log(Currency + " Credits" );
            
        }

    }
}
