using UnityEngine;
using UnityEngine.SceneManagement;
using Common;

public class GameDirector : MonoBehaviour
{
    /// <summary>ツナガールオブジェクト</summary>
    public GameObject TunaGirl;
    /// <summary>ツナボーイオブジェクト</summary>
    public GameObject TunaBoy;
    /// <summary>コンブオブジェクト</summary>
    public GameObject KonbuGenerator;
    /// <summary>クラゲジェネレータオブジェクト</summary>
    public GameObject KurageGenerator;
    /// <summary>ネットジェネレータオブジェクト</summary>
    public GameObject NetGenerator;
    /// <summary>チュートリアルパネルオブジェクト</summary>
    public GameObject TutorialPanel;
    /// <summary>オクトパスジェネレータオブジェクト</summary>
    public GameObject OctpusGenerator;

    /// <summary>オーディオソース</summary>
    public AudioManager audioManager;

    private void Awake()
    {
        // オーディオマネージャー取得
        audioManager = GameObject.Find(ObjectName.AUDIO_MANAGER).GetComponent<AudioManager>();
    }

    private void Start()
    {
        // チュートリアル画面を表示
        OnTutorialMode();
    }
    
    /// <summary>
    /// ゲームクリア処理
    /// </summary>
    public void ClearGame()
    {
        // ゲームクリアシーンに遷移
        SceneManager.LoadScene(SceneName.GAME_CLEAR_SCENE);
    }

    /// <summary>
    /// チュートリアルを表示
    /// </summary>
    public void OnTutorialMode()
    {
        // チュートリアルのBGMを再生
        audioManager.PlaySound(AudioName.TUTORIAL_BGM);

        TunaGirl.SetActive(false);
        TunaBoy.SetActive(false);
        KonbuGenerator.SetActive(false);
        KurageGenerator.SetActive(false);
        NetGenerator.SetActive(false);
        OctpusGenerator.SetActive(false);

        TutorialPanel.SetActive(true);
    }

    /// <summary>
    /// ゲーム開始処理
    /// </summary>
    public void GameStart()
    {
        // 音を停止
        audioManager.StopSound();

        // BGM再生
        audioManager.PlaySound(AudioName.GAME_SCENE_BGM);

        TunaGirl.SetActive(true);
        TunaBoy.SetActive(true);
        KonbuGenerator.SetActive(true);
        KurageGenerator.SetActive(true);
        NetGenerator.SetActive(true);
        OctpusGenerator.SetActive(true);

        TutorialPanel.SetActive(false);
    }

    /// <summary>
    /// スタートボタンクリック処理
    /// </summary>
    public void ClickStartButton()
    {
        audioManager.PlaySound(AudioName.BUTTON_SE);
    }
}
