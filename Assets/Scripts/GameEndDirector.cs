using UnityEngine;
using UnityEngine.SceneManagement;
using Common;

public class GameEndDirector : MonoBehaviour
{

    /// <summary>オーディオソース</summary>
    public AudioManager audioManager;
    /// <summary>ガイドテキストオブジェクト</summary>
    public GameObject GuideText;
    /// <summary>エンドロール終了フラグ</summary>
    public static bool isEndroll = false;

    private void Awake()
    {
        // オーディオマネージャー取得
        audioManager = AudioManager.Instance;
    }

    // Use this for initialization
    void Start()
    {
        audioManager.PlaySound(AudioName.GAME_CLEAR_SCENE_BGM);

        // ガイドテキストを無効
        GuideText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // エンドロールが流れ終わったか判別
        if (isEndroll)
        {
            // ガイドテキストを表示
            GuideText.SetActive(true);

            // 画面がタップされた場合
            if (Input.GetMouseButtonDown(0))
            {
                // 音楽停止
                audioManager.StopSound();

                // ゲームシーンに移動
                SceneManager.LoadScene(SceneName.TITLE_SCENE);
            }
        }
    }
}
