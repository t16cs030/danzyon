using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Clear : MonoBehaviour {

   
    public text textt;
    public bool finish=false;
    public bool test = false;
    int flag = 0;
    int flagg = 300;
    public Music music;
    

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "player")
        {
            textt.hime = true;
            flagg = 0;
            music.endplay();
        }
    }
  

    // Update is called once per frame
    void Update()
    {
    
   


        if (finish == true)
        {

             ChangeScene();
        }
    }
    void ChangeScene()
    {
       music.OnDisable();
       SceneManager.LoadScene("gameclea");
        
    }

}
