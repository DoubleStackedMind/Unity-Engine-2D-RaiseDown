using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryToLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
    }
    private void OnBecameVisible()
    {
        print("yeeeey");
      
        GameObject.Find("Sheild").GetComponent<Rigidbody2D>().AddForce(new Vector2(-4000, 2));

    }
}
