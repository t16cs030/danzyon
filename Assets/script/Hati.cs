using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hati : MonoBehaviour {
 
  public  float y=0;
 public   int count = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        count++;
        if (0 < count && count < 31)
            y =1;
        else if (30 < count && count < 60)

            y = -1;
        else count = 0;

        Vector2 direction = new Vector2(0, y).normalized;

        GetComponent<Rigidbody2D>().velocity = direction * 2;
    }
}
