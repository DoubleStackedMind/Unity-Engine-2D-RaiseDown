using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingVerticalLine : MonoBehaviour {

    Rigidbody2D Rg;

	// Use this for initialization
	void Start () {
        Rg = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
       
		
	}
     void OnBecameVisible()
    {
        print("neu");
        Rg.gravityScale = 0.6f;
    }
}
