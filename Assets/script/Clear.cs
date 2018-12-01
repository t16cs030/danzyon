using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour {


    void OnCollisionStay2D(Collision2D col)
    {

        //  on damage

        if (Input.GetKey(KeyCode.Return))
        {

            ChangeScene();

        }


    }


    // Update is called once per frame
    void Update () {
    
    }
    void ChangeScene()
    {
        SceneManager.LoadScene("gameclea");
    }

}
