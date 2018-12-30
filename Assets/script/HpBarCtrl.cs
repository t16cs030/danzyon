
using UnityEngine;
using System.Collections;
using UnityEngine.UI; // ←※これを忘れずに入れる
using UnityEngine.SceneManagement;
using System.Collections.Generic;



public class HpBarCtrl : MonoBehaviour
{
    int i = 0;
  public  Image heart5;
    public Image heart4;
    public Image heart3;
    public Image heart2;
    public Image heart1;
   
    public  float _hp = 5f;
    public bool on_damage = false;//damageFlag
    private SpriteRenderer renderer;
    public hebi hebii;
    public Music music;
    public Music_damage musicd;



    Image[] views;

    void OnCollisionStay2D(Collision2D col)
    {
        
        //  on damage
        
        if (!on_damage && (col.gameObject.tag == "teki"||col.gameObject.tag == "tekitama" || col.gameObject.tag == "boss"))
        {
            if (hebii.Death_Anime == false)
            {
                OnDamageEffect();
                _hp -= 1f;
                musicd.damageplay();

                Destroy(views[i]);
                i++;
            }
        }


    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (!on_damage && (col.gameObject.tag == "teki" || col.gameObject.tag == "tekitama"))
        {

            OnDamageEffect();
            _hp -= 1f;
            musicd.damageplay();
            Destroy(views[i]);
            i++;

        }

    }

    void Start()
    {
        // スライダーを取得する
        
        heart1 = GameObject.Find("Heart1").GetComponent<UnityEngine.UI.Image>();
        heart2 = GameObject.Find("Heart2").GetComponent<UnityEngine.UI.Image>();
        heart3 = GameObject.Find("Heart3").GetComponent<UnityEngine.UI.Image>();
        heart4 = GameObject.Find("Heart4").GetComponent<UnityEngine.UI.Image>();
        heart5 = GameObject.Find("Heart5").GetComponent<UnityEngine.UI.Image>();

        views = new Image[] { heart1, heart2,heart3,heart4,heart5 };



        //点滅処理の為に呼び出しておく
        renderer = gameObject.GetComponent<SpriteRenderer>();

        

    }


   
    void Update()
    {
        
        if (on_damage)
        {
            float level = Mathf.Abs(Mathf.Sin(Time.time * 10));
            renderer.color = new Color(1f, 1f, 1f, level);
        }

     
        if (_hp <= 0f)
        {
            ChangeScene();
        }
      

    }
//　ダメージを受けた際の動き
void OnDamageEffect()
    {
        // ダメージフラグON
        on_damage = true;

      

        // コルーチン開始
        StartCoroutine("WaitForIt");
    }

    IEnumerator WaitForIt()
    {
        // 1秒間処理を止める
        yield return new WaitForSeconds(1);

        // １秒後ダメージフラグをfalseにして点滅を戻す
        on_damage = false;
        renderer.color = new Color(1f, 1f, 1f, 1f);
    }
    void ChangeScene()
    {
        SceneManager.LoadScene("gameover");
        music.Stop();
    }


}