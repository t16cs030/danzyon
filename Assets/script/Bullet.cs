

using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    // 移動スピード
    // Use this for initialization

    public int speed = 10;
    public GameObject Player;
    
    public player playerr;
    public int xx;
    public int yy;
    public float timer = 0.044f;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag != "player")
        {
            if(col.gameObject.tag != "serf")
            Destroy(this.gameObject,timer);
        }
        if (col.gameObject.tag == "teki")
            Destroy(col.gameObject);
    }


    void Start()
    {

        Player = GameObject.Find("Player");
        playerr = Player.GetComponent<player>();
        xx = playerr.xx;
        yy = playerr.yy;

        if (xx == 0 && yy == 0)
            GetComponent<Rigidbody2D>().velocity =-transform.up.normalized * speed;
        if (xx == 0 && yy == 1)
            GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed;
        if (xx == 0 && yy == -1)
            GetComponent<Rigidbody2D>().velocity =- transform.up.normalized * speed;
        if (xx == 1 && yy == 0)
            GetComponent<Rigidbody2D>().velocity = transform.right.normalized * speed;
        if (xx == -1 && yy == 0)
            GetComponent<Rigidbody2D>().velocity = -transform.right.normalized * speed;
    }
    void Update()
    {
            float dist = Vector2.Distance(this.transform.position, Player.transform.position);
        if (dist > 4.8f) {
            Destroy(gameObject);
}
    }
}