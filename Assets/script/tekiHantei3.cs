using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tekiHantei3 : MonoBehaviour
{
    public int ue = 0;
    public tekiHantei tekihantei;
    public tekiHantei2 tekihantei2;
    public tekiHantei1 tekihantei1;
    GameObject Teki;
    GameObject Teki1;
    GameObject Teki2;
    GameObject Teki3;

    int m = 0;
    int h = 0;
    int s = 0;





    void Start()
    {
        Teki = GameObject.Find("TEKI_9/hanteiM");

        Teki2 = GameObject.Find("TEKI_9/hanteiH");
        Teki1 = GameObject.Find("TEKI_9/hanteiS");

        tekihantei = Teki.GetComponent<tekiHantei>();
        tekihantei2 = Teki2.GetComponent<tekiHantei2>();
        tekihantei1 = Teki1.GetComponent<tekiHantei1>();

        m = tekihantei.migi;
        h = tekihantei2.hidari;
        s = tekihantei1.sita;
    }

    void Update()
    {
        if (ue == 1)
        {
            tekihantei.count += 1;
        }
     
        //  sita = 0;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "player" && tekihantei.count > 300)
        {
           
                ue = 1;
                tekihantei.migi = 0;
                tekihantei2.hidari = 0;
                tekihantei1.sita = 0;
            tekihantei.count = 0;
           
        }
    }

}