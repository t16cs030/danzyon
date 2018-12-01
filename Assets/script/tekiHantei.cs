using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tekiHantei : MonoBehaviour
{
  
    public tekiHantei1 tekihantei1;
    public tekiHantei2 tekihantei2;
    public tekiHantei3 tekihantei3;
    GameObject Teki;
    GameObject Teki1;
    GameObject Teki2;
    GameObject Teki3;

    int s = 0;
    int h = 0;
    int u = 0;

   public int migi = 0;
    public int count = 300;


    void Start()
    {
        Teki1 = GameObject.Find("TEKI_9/hanteiS");

        Teki2 = GameObject.Find("TEKI_9/hanteiH");
        Teki3 = GameObject.Find("TEKI_9/hanteiU");

        tekihantei1 = Teki1.GetComponent<tekiHantei1>();
        tekihantei2 = Teki2.GetComponent<tekiHantei2>();
        tekihantei3 = Teki3.GetComponent<tekiHantei3>();

        s = tekihantei1.sita;
        h = tekihantei2.hidari;
        u = tekihantei3.ue;
    }

    void Update()
    {
        if (migi == 1)
        {
            count++;
        }
      
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "player"&&count>300)
        {

            migi = 1;
            tekihantei1.sita = 0;
            tekihantei2.hidari = 0;
            tekihantei3.ue = 0;
            count=0;
        }
    }

}