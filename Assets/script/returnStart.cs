﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class returnStart : MonoBehaviour {

  

    void Start()
    {
        int resultScore = Score.getScore();
        this.GetComponent<Text>().text = "Score：" + resultScore.ToString();
    }


    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.Return))
        {
            ChangeScene();
        }
    }
    void ChangeScene()
    {
        SceneManager.LoadScene("start");
      
    }

}
