using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {
  
    public GameObject player;
    public bool Camera_Stop_Flag = false;
    private player playerr;
    public GameObject Player;
   
    float y = 18.66f;


    // Use this for initialization
    void Start () {
        Player = GameObject.Find("Player");
        playerr = Player.GetComponent<player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (y >= 25f)
        {
            transform.position = new Vector3(10f, 25f, -10);
        }

       else if (Camera_Stop_Flag == true)
        {
           
            transform.position = new Vector3(player.transform.position.x, y, -10);
            y+=0.18f;
        }
        

        else
        {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
        }
    }
}
