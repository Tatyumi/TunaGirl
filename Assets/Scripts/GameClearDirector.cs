using UnityEngine;
using UnityEngine.SceneManagement;
using Common;

public class GameClearDirector : MonoBehaviour {

    /// <summary>オーディオソース</summary>
    public AudioManager audioManager;

    private void Awake()
    {
        // オーディオマネージャー取得
        audioManager = GameObject.Find(ObjectName.AUDIO_MANAGER).GetComponent<AudioManager>();
    }

    // Use this for initialization
    void Start () {
        audioManager.PlaySound(AudioName.GAME_CLEAR_SCENE_BGM);
	}
	
	// Update is called once per frame
	void Update ()
    {
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
