using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Animator))]

public class hebi : MonoBehaviour {

    public float x = 0;
    public int count = 3000;
    public float _hp = 5f;
    public bool on_damage = false;//damageFlag
    private SpriteRenderer renderer;
   public bool Kougeki = false;
    Animator _animator;
    public bool Death_Anime=false;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (!on_damage && col.gameObject.tag == "tama")
        {

            OnDamageEffect();
            _hp -= 1f;

          
           
        }

    }
    // Use this for initialization

    public void changeAnimation()
    {

        //ele1->ele2に切り替える
        _animator.SetBool("Kougekii", true);


    }

    void Awake()
    {
        count = 3000;
        renderer = gameObject.GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Kougeki == true&&Death_Anime==false)
        {
            changeAnimation();
            count++;
            if (3000 <= count && count <= 3120)
                x = -1;
            else if (0 < count && count <= 240)
                x = 1;
            else if (240 < count && count < 480)

                x = -1;


            else count = 0;

            Vector2 direction = new Vector2(x, 0).normalized;

            GetComponent<Rigidbody2D>().velocity = direction * 1;

            if (on_damage)
            {
                float level = Mathf.Abs(Mathf.Sin(Time.time * 10));
                renderer.color = new Color(1f, 1f, 1f, level);
            }


            if (_hp <= 0f)
            {
                this.gameObject.GetComponent<Renderer>().material.color = new Color(0.3f, 0.4f, 0.9f, 0.3f);
            
          
                Invoke("Destroy", 2f);
                Death_Anime = true;
              
            }
        }
    }

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
    void Destroy()
    {
        Destroy(this.gameObject);
    }
}




