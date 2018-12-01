using UnityEngine;
using System.Collections;

public class tekiBullet : MonoBehaviour
{
    // 移動スピード
    // Use this for initialization
    GameObject Teki;
    GameObject Teki1;
    GameObject Teki2;
    GameObject Teki3;
    public int speed = 10;

    private Rigidbody2D rb2d;
    public tekiHantei tekihantei;
    tekiHantei1 tekihantei1;
    public tekiHantei2 tekihantei2;
    public tekiHantei3 tekihantei3;
    public HpBarCtrl hpbar;
    GameObject HpBar;





    void Start()
    {
        HpBar = GameObject.Find("Player");

        hpbar = HpBar.GetComponent<HpBarCtrl>();

        Teki = GameObject.Find("TEKI_9/hanteiM");
        Teki1 = GameObject.Find("TEKI_9/hanteiS");
        Teki2 = GameObject.Find("TEKI_9/hanteiH");
        Teki3 = GameObject.Find("TEKI_9/hanteiU");

        tekihantei = Teki.GetComponent<tekiHantei>();
        tekihantei1 = Teki1.GetComponent<tekiHantei1>();
        tekihantei2 = Teki2.GetComponent<tekiHantei2>();
        tekihantei3 = Teki3.GetComponent<tekiHantei3>();

        int m = tekihantei.migi;

        int h = tekihantei2.hidari;
        int u = tekihantei3.ue;


        int s = tekihantei1.sita;

        if (s == 1)
            GetComponent<Rigidbody2D>().velocity = -transform.up.normalized * speed;
        if (u == 1)
            GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed;
        if (m == 1)
            GetComponent<Rigidbody2D>().velocity = transform.right.normalized * speed;
        if (h == 1)
            GetComponent<Rigidbody2D>().velocity = -transform.right.normalized * speed;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag != "teki")
        {

            Destroy(this.gameObject);
        }
        if (col.gameObject.tag == "player")
        {
        }
    }
}