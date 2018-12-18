using UnityEngine;
using System.Collections;

public class TekiBullet : MonoBehaviour
{
    // 移動スピード
    // Use this for initialization
    GameObject Teki;

    public int speed = 10;

    private Rigidbody2D rb2d;
    public TekiHantei tekihantei;

    public HpBarCtrl hpbar;
    GameObject HpBar;





    void Start()
    {
        HpBar = GameObject.Find("Player");

        hpbar = HpBar.GetComponent<HpBarCtrl>();






       GetComponent<Rigidbody2D>().velocity = -transform.up.normalized * speed;

    }
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag != "tama" && col.gameObject.tag != "teki"&& col.gameObject.tag != "serf")
        {

            Destroy(this.gameObject);
        }
        if (col.gameObject.tag == "player")
        {
        }
    }
    
}