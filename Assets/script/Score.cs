using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    //点数を格納する変数
    public static int scoree = 0;
    public int score=0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Text>().text = "Score：" + score.ToString();
        scoree = score;
    }

    public static int getScore()
    {
        
        return scoree;
    }
}