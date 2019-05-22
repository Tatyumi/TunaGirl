using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Common;


public class WaveDirector : MonoBehaviour
{
    /// <summary>ゲームの進行度</summary>
    public static int progressCount;
    /// <summary>背景画像オブジェクト</summary>
    public GameObject BackGround;
    /// <summary>ツナボーイオブジェクト</summary>
    public GameObject TunaBoy;
    /// <summary>ガイドテキストオブジェクト</summary>
    public GameObject GuideText;
    /// <summary>背景画像のリスト</summary>
    private Transform backGrounds;
    /// <summary>ツナボーイのリスト</summary>
    private Transform tunaBoies;
    /// <summary>オーディオマネージャー</summary>
    private AudioManager audioManager;
    /// <summary>ガイドテキスト</summary>
    private Text guideText;
    /// <summary>次のステージ名</summary>
    private string nextStageName;
    /// <summary>待機時間</summary>
    private float waitTime = 300.0f;
    /// <summary>計測時間</summary>
    private float delta = 0.0f;

    /// <summary>ゲームの進捗度合い</summary>
    private enum Progress
    {
        None = -1,
        StageOne,
        StageTwo,
    }

    private void Awake()
    {
        // 全背景画像の取得
        backGrounds = BackGround.GetComponentInChildren<Transform>();

        //　全ツナボーイの取得
        tunaBoies = TunaBoy.GetComponentInChildren<Transform>();

        // ガイドテキストの取得
        guideText = GuideText.GetComponent<Text>();

        // オーディオマネージャー取得
        audioManager = AudioManager.Instance;
    }

    // Use this for initialization
    void Start()
    {
        // BGMの再生
        audioManager.PlaySound(Common.AudioName.WAVE_BGM);

        // 待機時間初期化
        waitTime = audioManager.WaveBGM.length;

        // 画像初期化
        for (int i = 0; i < backGrounds.childCount; i++)
        {
            // 背景画像を非表示
            backGrounds.GetChild(i).gameObject.SetActive(false);

            // ツナボーイを非表示
            tunaBoies.GetChild(i).gameObject.SetActive(false);
        }

        // 指定の背景画像を表示
        backGrounds.GetChild(WaveDirector.progressCount).gameObject.SetActive(true);

        // 指定のツナボーイを表示
        tunaBoies.GetChild(WaveDirector.progressCount).gameObject.SetActive(true);


        string guideComment = null;
        // ゲームの進捗を判別
        if (progressCount == (int)Progress.StageOne)
        {
            guideComment = "STAGE1 !";
            nextStageName = Common.SceneName.GAME_SCENE;
        }
        else if (progressCount == (int)Progress.StageTwo)
        {
            guideComment = "STAGE2 !";
            nextStageName = Common.SceneName.STAGE_TWO_SCENE;
        }

        // ガイドテキストにコメントを代入
        guideText.text = guideComment;

    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        // 一定時間経過したか判別
        if (this.delta > waitTime)
        {
            // BGMの停止
            audioManager.StopSound();

            // 次のシーンに遷移
            SceneManager.LoadScene(nextStageName);
        }
    }

}
