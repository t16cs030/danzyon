using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class warp : MonoBehaviour {
    private Animator Anim;
    public int keep = 0;
    public int riset = 0;
    public warpText wtextt;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update()
    {

        Vector2 ThisPosition;
        ThisPosition = this.transform.position;
        float x = ThisPosition.x;
        float y = ThisPosition.y;
        if (Input.GetKey(KeyCode.UpArrow) && y > 0.495 && y < 1 && -19.8 > x && x > -20.8 && riset == 0)
        {
            wtextt.warp = 1;

        }
        if (wtextt.warpp == 1)
        {
            riset = 1;
            keep = 1;

            Vector2 doukutu;
            doukutu.x = -15.5f;
            doukutu.y = 14.5f;
            this.transform.position = doukutu;
        }
        if (Input.GetKey(KeyCode.UpArrow) && y > 14.4 && y < 15 && -15.1 > x && x > -15.7 && riset == 0)
        {
            wtextt.warp = 2;

        }
        if (wtextt.warpp == 2)
        {
            riset = 1;

            keep = 1;

            Vector2 doukutu2;
            doukutu2.x = -20f;
            doukutu2.y = 0.495f;
            this.transform.position = doukutu2;


        }

        if (Input.GetKey(KeyCode.UpArrow) && y > 15.1 && y < 15.6 && -7.9 > x && x > -8.9 && riset == 0)
        {
            wtextt.warp = 3;

        }
        if (wtextt.warpp == 3)
        {
            riset = 1;

            keep = 1;

            Vector2 ido;
            ido.x = 18.4f;
            ido.y = 15.5f;
            this.transform.position = ido;

        }

        if (Input.GetKey(KeyCode.UpArrow) && y > 15.3 && y < 15.6 && 19 > x && x > 17.8 && riset == 0)
        {
            wtextt.warp = 4;

        }
        if (wtextt.warpp == 4)
        {
            riset = 1;

            keep = 1;

            Vector2 ido2;
            ido2.x = -8.436f;
            ido2.y = 15.46f;
            this.transform.position = ido2;









        }
    }
}

