using UnityEngine;
using UnityEngine.SceneManagement;
using Common;

public class TitleDirector : MonoBehaviour
{
    /// <summary>オーディオソース</summary>
    private AudioManager audioManager;

    private void Awake()
    {
        // オーディオマネージャー取得
        audioManager = AudioManager.Instance;
    }

    private void Start()
    {
        // BGM再生
        audioManager.PlaySound(AudioName.TITLE_SCENE_BGM);
    }

    void Update()
    {
        // 画面がタップされた場合
        if (Input.GetMouseButtonDown(0))
        {
            // 音楽停止
            audioManager.StopSound();

            // ゲームシーンに移動
            SceneManager.LoadScene(SceneName.GAME_SCENE);
        }
    }
}
