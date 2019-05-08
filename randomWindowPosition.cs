/*spawn window at random position. 
 * Have to change position vectors regarding main scene window positions.
 * Have to find window asset and frame asset (frame is for fake)
 * Have to add action opening the window onTrigger interaction*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Let's make just one window!

public class randomWindowPosition : MonoBehaviour {
    public GameObject[] spawnee;    //0 window 1 frame
    Vector3[] pos = new Vector3[4] { new Vector3(9f, 3.6f, 2f), new Vector3(9f, 3.6f, -2.2f),
                                    new Vector3(-9f, 3.6f, 2f), new Vector3(-9f, 3.6f, -2.2f) };

	// Use this for initialization
	void Start () {
        Quaternion rot = Quaternion.Euler(new Vector3(0, 90f, 0));
        int randomWindowInt = Random.Range(1, 4);  //from 1 to 4 position
        Instantiate(spawnee[0], pos[randomWindowInt], rot);     //set at least one window at random position
        for (int i = 0; i < 4; i++)
        {
            if (i != randomWindowInt)
            {
                Instantiate(spawnee[1], pos[i], rot);
            }//set frame at all poistions except for first window position
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
