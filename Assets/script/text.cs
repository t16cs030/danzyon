using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    public string[] scenarios;
    [SerializeField] Text uiText;

    [SerializeField]
    [Range(0.001f, 0.3f)]
    float intervalForCharacterDisplay = 0.05f;
    private string currentText = string.Empty;
    private float timeUntilDisplay = 0;
    private float timeElapsed = 1;
    private int currentLine = 0;
    private int lastUpdateCharacter = -1;
    int Start_finish_talk = 2;
    int Hebi_start_talk = 3;
    int Hebi_finish_talk = 5;
    public bool Text_Flag=false;
    public GameObject Text;
    public GameObject Waku;
    public GameObject baria;
    public player playerr;
    public hebi hebii;
   public  bool Hebi= true;

    // 文字の表示が完了しているかどうか
    public bool IsCompleteDisplayText
    {
        get { return Time.time > timeElapsed + timeUntilDisplay; }
    }

    void Start()
    {
        SetNextLine();
        Text_Flag = true;
    }

    void Update()
    {
        if (Hebi==true)
        {
            currentLine = Hebi_start_talk;
            Text_Flag = true;
            Text.SetActive(true);
            Waku.SetActive(true);
            
            Hebi = false;
        }


        // 文字消す。非表示
        if (IsCompleteDisplayText)
        {
            if ((currentLine == Start_finish_talk && Input.GetKeyDown(KeyCode.Return))|| (currentLine == Hebi_finish_talk && Input.GetKeyDown(KeyCode.Return)))
            {
                Invoke("No_Seen", 0.5f);

            }
            // 文字の表示が完了してるならクリック時に次の行を表示する
            else
            { 
            if (currentLine < scenarios.Length && Input.GetKeyDown(KeyCode.Return))
            {
                SetNextLine();
            }
        } }

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
        Text_Flag = false;
        if (currentLine == Hebi_finish_talk)
        {
            hebii.Kougeki = true;

            Destroy(baria);
        }
    }
}