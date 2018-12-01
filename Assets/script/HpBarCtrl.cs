
using UnityEngine;
using System.Collections;
using UnityEngine.UI; // ←※これを忘れずに入れる
using UnityEngine.SceneManagement;



public class HpBarCtrl : MonoBehaviour
{

    Slider _slider;
  public  float _hp = 1f;
    public bool on_damage = false;//damageFlag
    private SpriteRenderer renderer;
    public Text HpText;
    private int hp = 100;


    void OnCollisionStay2D(Collision2D col)
    {

        //  on damage
        
        if (!on_damage && col.gameObject.tag == "teki")
        {
           
            OnDamageEffect();
            _hp -= 0.1f;
            hp -= 10;

        }


    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (!on_damage && col.gameObject.tag == "teki")
        {

            OnDamageEffect();
            _hp -= 0.1f;
            hp -= 10;

        }

    }

    void Start()
    {
        // スライダーを取得する
        _slider = GameObject.Find("Slider").GetComponent<Slider>();



        //点滅処理の為に呼び出しておく
        renderer = gameObject.GetComponent<SpriteRenderer>();


        HpText.text = "100/100";



    }


   
    void Update()
    {
        
        if (on_damage)
        {
            float level = Mathf.Abs(Mathf.Sin(Time.time * 10));
            renderer.color = new Color(1f, 1f, 1f, level);
        }

        // HPゲージに値を設定
        _slider.value = _hp;
        if (_hp <= 0f)
        {
            ChangeScene();
        }
        HpText.text = hp.ToString() + "/100";

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
    }


}