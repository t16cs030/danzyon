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
    public GameObject Teki1;
    public GameObject Teki2;
    GameObject obj1;
    GameObject obj2;
    GameObject obj3;
    GameObject obj4;
    GameObject obj5;
    GameObject obj6;
    public text textt;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (!on_damage && col.gameObject.tag == "tama")
        {

            OnDamageEffect();
            _hp -= 1f;

            if (_hp == 3)
            {
                 obj1 = Instantiate(Teki1, new Vector3(7.9f, 24.37f, 0.0f), Quaternion.identity);
                obj2 = Instantiate(Teki2, new Vector3(12.25f, 24.37f, 0.0f), Quaternion.identity);
                 obj3 = Instantiate(Teki1, new Vector3(11.51f, 25f, 0.0f), Quaternion.identity);
                obj4 = Instantiate(Teki2, new Vector3(7.4f, 26.0f, 0.0f), Quaternion.identity);
                obj5 = Instantiate(Teki1, new Vector3(9.71f, 22.2f, 0.0f), Quaternion.identity);
                obj6 = Instantiate(Teki2, new Vector3(10.4f, 21.8f, 0.0f), Quaternion.identity);
          
            }

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

                Invoke("Destroy", 1.5f);
                Invoke("Tesita", 0.1f);
                textt.Text_Flag = true;
                Death_Anime = true;
                Invoke("can_work", 1.5f);
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
    void Tesita()
    {
        Destroy(obj1);
        Destroy(obj2);
        Destroy(obj3);
        Destroy(obj4);
        Destroy(obj5);
        Destroy(obj6);
    }
    void can_work()
    {
        textt.Text_Flag = false;
    }
}




