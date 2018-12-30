

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
    public camera cameran;
    public int xx;
    public int yy;
   public bool Hebi_Talk=false;
    public GameObject bariaRial;
    public text textt;
    GameObject[] tagObjects;
    public int taman=0;
    public hebi hebii;
    public Music music;

    void Start()
    {
       music.Startplay();
    }


    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "baria")
        {
            Hebi_Talk = true;
            textt.Hebi = true;
            bariaRial.SetActive(true);
        }

        if (col.gameObject.tag == "ort")
        {
           animee. Camera_Flag = true;
            cameran.Camera_Stop_Flag = true;
            music.OnDisable();

        }
        else {}

      
    }

    void Update()
    {
        Player = GameObject.Find("Player");
        animee = Player.GetComponent<anime>();

        if (Input.GetKey(KeyCode.Space) &&textt.Text_Flag==false&& hebii.Death_Anime==false)
        {
            if (count == 0)
            {
               
                if (taman <= 2 ) {
                    taman++;
                    xx = animee.xx;
                yy = animee.yy;
                Instantiate(bullet, transform.position, transform.rotation);
                 
                  

                }
            else {
                   
                }





                count++;
          }
            else { }
            if (taman <= 0)
            {
                taman = 0;
            }
        }
        else { count = 0; }
   }

  

    }
