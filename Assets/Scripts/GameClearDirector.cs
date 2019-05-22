using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Common;

public class GameClearDirector : MonoBehaviour
{
    /// <summary>背景画像オブジェクト</summary>
    public GameObject BackGround;
    /// <summary>ツナボーイオブジェクト</summary>
    //public GameObject TunaBoy;
    /// <summary>背景画像のリスト</summary>
    private Transform backGrounds;
    /// <summary>ツナボーイのリスト</summary>
    private Transform tunaBoies;
    /// <summary>オーディオマネージャー</summary>
    private AudioManager audioManager;
    /// <summary>待機時間</summary>
    private float waitTime = 0.0f;
    /// <summary>計測時間</summary>
    private float delta = 0.0f;

    private void Awake()
    {
        // 全背景画像の取得
        backGrounds = BackGround.GetComponentInChildren<Transform>();

        // オーディオマネージャー取得
        audioManager = AudioManager.Instance;
    }


    // Use this for initialization
    void Start()
    {
        // BGM再生
        audioManager.PlaySound(Common.AudioName.GAME_CLEAR_SCENE_BGM);

        // 待機時間初期化
        waitTime = audioManager.GameClearSceneBGM.length;

        // 画像初期化
        for (int i = 0; i < backGrounds.childCount; i++)
        {
            // 背景画像を非表示
            backGrounds.GetChild(i).gameObject.SetActive(false);
        }
        
        // 指定の背景画像を表示
        backGrounds.GetChild(WaveDirector.progressCount).gameObject.SetActive(true);
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

            // ゲーム進捗の更新
            WaveDirector.progressCount++;

            // 次のシーンに遷移
            SceneManager.LoadScene(Common.SceneName.WAVE_SCENE);
        }

    }
}
