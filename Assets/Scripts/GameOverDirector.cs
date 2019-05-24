using UnityEngine;
using UnityEngine.SceneManagement;
using Common;

public sealed class GameOverDirector : MonoBehaviour
{
    /// <summary>ゲームオーバーオブジェクト</summary>
    public GameObject GameOver;
    /// <summary>ゲームオーバーリスト</summary>
    private Transform gameOvers;

    /// <summary>オーディオソース</summary>
    private AudioManager audioManager;

    private void Awake()
    {
        // オーディオマネージャー取得
        audioManager = AudioManager.Instance;

        // 全ゲームオーバオブジェクトの取得
        gameOvers = GameOver.GetComponentInChildren<Transform>();
    }

    // Use this for initialization
    void Start()
    {
        // BGM再生
        audioManager.PlaySound(AudioName.GAME_OVER_SCENE_BGM);

        // ゲームオーバ演出を全て非表示
        for(int i = 0; i < gameOvers.childCount; i++)
        {
            // ゲームオーバー画像を非表示
            gameOvers.GetChild(i).gameObject.SetActive(false);
        }

        // ゲームオーバー演出の表示
        gameOvers.GetChild(EnemyController.AttackEnemy).gameObject.SetActive(true);
    }

    void Update()
    {
        // 画面がタップされた場合
        if (Input.GetMouseButtonDown(0))
        {
            // BGM停止
            audioManager.StopSound();

            // ゲームシーンに移動
            SceneManager.LoadScene(SceneName.TITLE_SCENE);
        }
    }
}
