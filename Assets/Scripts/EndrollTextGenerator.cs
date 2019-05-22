using UnityEngine;
using UnityEngine.UI;

public class EndrollTextGenerator : MonoBehaviour
{
    /// <summary>テキスト表示回数</summary>
    public static int TextCount;
    /// <summary>エンドロールテキスト破棄ポジション</summary>
    public static float DestroyEndrollPositionX;
    /// <summary>キャンバス</summary>
    public GameObject Canvas;
    /// <summary>エンドテキスト </summary>
    public GameObject EndrollText;
    /// <summary>出現間隔</summary>
    private float span = 10.0f;
    /// <summary></summary>
    private float delta = 0.0f;
    /// <summary>エンドロールテキスト生成時のX座標</summary>
    private float EndrollPositionX;
    /// <summary>エンドロールテキスト生成時のY座標</summary>
    private float EndrollPositionY;
    /// <summary>エンドロールテキスト</summary>
    private string[] endrollTexts = new string[8];
    private Vector2 endrollTextSize;


    private void Awake()
    {
        endrollTextSize = EndrollText.GetComponent<RectTransform>().sizeDelta;

    }

    void Start()
    {
        // エンドロール破棄座標を取得
        DestroyEndrollPositionX = (Screen.width / 2 + endrollTextSize.x / 2) * -1;

        // 画面右端の座標を取得
        EndrollPositionX = Screen.width / 2 + endrollTextSize.x / 2;

        // 画面下部の座標を取得
        EndrollPositionY = Screen.height / 3 * -1;

        // 初期化
        TextCount = 0;

        // エンドロールテキストを設定
        SetEndrollText();
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        // 一定時間たったか判別
        if (this.delta > span)
        {
            this.delta = 0.0f;
            
            // エンドロールテキストをすべて表示したか判別
            if(TextCount < endrollTexts.Length)
            {
                GameObject gameObject = Instantiate(EndrollText) as GameObject;

                // 生成するオブジェクトをCanVasの子にする
                gameObject.transform.SetParent(Canvas.transform, false);

                // プレファブを生成
                gameObject.transform.localPosition = new Vector2(EndrollPositionX, EndrollPositionY);

                gameObject.GetComponent<Text>().text = endrollTexts[TextCount];
                TextCount++;
            }
            else
            {
                GameEndDirector.isEndroll = true;
                this.gameObject.SetActive(false);
            }
        }
    }

    /// <summary>
    /// エンドロールテキスト設定メソッド
    /// </summary>
    private void SetEndrollText()
    {
        endrollTexts[0] = "Programer : Tatyumi";
        endrollTexts[1] = "Designer : Tatyumi";
        endrollTexts[2] = "Music : MaouDamashi";
        endrollTexts[3] = "Music : MusMus";
        endrollTexts[4] = "Music : taira - komori";
        endrollTexts[5] = "Music : soundeffect - lab";
        endrollTexts[6] = "Music : DOVA - SYNDROME";
        endrollTexts[7] = "Good Bye!";
    }
}
