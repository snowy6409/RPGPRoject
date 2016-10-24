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


//Problem occurs after here array is skiping one and wont check to make sure that collision.gameobject.name is not a value allready
    void OnCollisionEnter(Collision collision)
    {
        

        if(string.IsNullOrEmpty(Items[19]))
        {
            for (int i = 0; i <= 19; i++)
            {
                Debug.Log("1");
                if(string.IsNullOrEmpty(Items[i]) && Items[i] != collision.gameObject.name)
                {
                    Debug.Log("2");
                    Items[i] = collision.gameObject.name;
                    return;
                }
                else
                {
                    Debug.Log("3");
                    i += 1;
                }




            }

        }
        else
        {

            Debug.Log("Inventory full");
            Debug.Log("Can't collect " + collision.gameObject.name);
            Debug.Log(Items[19]);

        }










    }
}
