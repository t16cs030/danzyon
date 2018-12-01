

using UnityEngine;
using System.Collections;

public class player : MonoBehaviour
{
    // 移動スピード
    // Use this for initialization
    int count = 0;
    public GameObject bullet;
    public int speed = 10;
    public GameObject Player;
    public anime animee;
    public int xx;
    public int yy;


   
    void Update()
    {
        Player = GameObject.Find("Player");
        animee = Player.GetComponent<anime>();
       
        if (Input.GetKey(KeyCode.Space) )
        {if (count == 0)
            {
               
                xx = animee.xx;
                yy = animee.yy;
                Instantiate(bullet, transform.position, transform.rotation);





                count++;
          }
            else { }
        }
        else { count = 0; }
   }

  

    }
