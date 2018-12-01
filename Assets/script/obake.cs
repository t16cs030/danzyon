using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obake : MonoBehaviour {

    public float x = 0;
    public int count = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        count++;
        if (0 < count && count < 31)
            x = 1;
        else if (30 < count && count < 60)

            x = -1;
        else count = 0;

        Vector2 direction = new Vector2(x, 0).normalized;

        GetComponent<Rigidbody2D>().velocity = direction * 1;
    }
}