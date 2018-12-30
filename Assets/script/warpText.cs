using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class warpText : MonoBehaviour
{
    public string[] scenarios;
    [SerializeField] Text uiText;

    [SerializeField]
    [Range(0.001f, 0.3f)]
    float intervalForCharacterDisplay = 0.05f;
    private string currentText = string.Empty;
    private float timeUntilDisplay = 0;
    private float timeElapsed = 1;
   public int currentLine = 0;
    private int lastUpdateCharacter = -1;

  
    public GameObject Text;
    public GameObject Waku;
    public text textt;
    public Music_Clic musicc;
   
    public player playerr;

    public int warp=0;

    public int warpp=0;
    // 文字の表示が完了しているかどうか
    public bool IsCompleteDisplayText
    {
        get { return Time.time > timeElapsed + timeUntilDisplay; }
    }

    void Start()
    {
        SetNextLine();
        textt.Text_Flag = true;
    }

    void Update()
    {
        if (warp == 1||warp==2||warp==3||warp==4)
        {

            // if (hime == true)
            //{
           
            textt.Text_Flag = true;
            Text.SetActive(true);
            Waku.SetActive(true);

            //     hime = false;

            //     }

            // 文字消す。非表示
            if (IsCompleteDisplayText)
            {
                        
                
                    if (currentLine < scenarios.Length && Input.GetKeyDown(KeyCode.Return))
                {
                    musicc.clickplay();
                    if (warp == 1) { warpp = 1; }
                    if (warp == 2) { warpp = 2; }
                    if (warp == 3) { warpp = 3; }
                    if (warp == 4) { warpp = 4; }


                    Invoke("No_Seen", 0.2f);
                    }
                }
            

            else
            {
                // 完了してないなら文字をすべて表示する
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    timeUntilDisplay = 0;
                }
            }

            int displayCharacterCount = (int)(Mathf.Clamp01((Time.time - timeElapsed) / timeUntilDisplay) * currentText.Length);
            if (displayCharacterCount != lastUpdateCharacter)
            {

                uiText.text = currentText.Substring(0, displayCharacterCount);
                lastUpdateCharacter = displayCharacterCount;

            }
        }
    }

    void SetNextLine()
    {
        currentText = scenarios[currentLine];
        timeUntilDisplay = currentText.Length * intervalForCharacterDisplay;
        timeElapsed = Time.time;
        currentLine++;
        lastUpdateCharacter = -1;
    }

    void No_Seen()
    {
        Text.SetActive(false);
        Waku.SetActive(false);
        textt.Text_Flag = false;
        warp = 0;
        warpp = 0;
      
    }
   
}