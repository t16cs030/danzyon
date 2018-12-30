

using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    // 移動スピード
    // Use this for initialization

    public int speed = 10;
    public GameObject Player;
    public GameObject Score;
    public GameObject SoundManager4;
    public player playerr;
    public int xx;
    public Music_des musicd;
    public Score score;
    public int yy;
    public float timer = 0.044f;
    bool TazyuuBousi = false;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag != "player")
        {
            if (col.gameObject.tag != "serf" && col.gameObject.tag != "tekitama" && col.gameObject.tag != "baria" && col.gameObject.tag != "ort")
            {
                if (TazyuuBousi == false)
                {
                    playerr.taman -= 1;
                }

                Destroy(this.gameObject, timer);
                TazyuuBousi = true;

            }
        }
        if (col.gameObject.tag == "teki")
        {
            musicd.Desplay();
            Destroy(col.gameObject);
            score.score += 100;

        }
    }

    void Start()
    {

        Player = GameObject.Find("Player");
        playerr = Player.GetComponent<player>();
    SoundManager4 = GameObject.Find("SoundManager4");
       musicd = SoundManager4.GetComponent<Music_des>();
       Score= GameObject.Find("Score");
        score = Score.GetComponent<Score>();
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
      

        if (!GetComponent<SpriteRenderer>().isVisible)
        {
            Destroy(this.gameObject);
            playerr.taman -= 1;
        }

    }
    
}