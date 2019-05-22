using UnityEngine;
using UnityEngine.SceneManagement;
using Common;

public class GameOverDirector : MonoBehaviour
{
    /// <summary>クラゲによるゲームオーバーオブジェクト</summary>
    public GameObject KurageGameOver;
    /// <summary>コンブによるゲームオーバーオブジェクト</summary>
    public GameObject KonbuGameOver;
    /// <summary>ネットによるゲームオーバーオブジェクト</summary>
    public GameObject NetGameOver;
    /// <summary>オクトパスによるゲームオーバーオブジェクト</summary>
    public GameObject OctpusGameOver;
    /// <summary>カニによるゲームオーバーオブジェクト</summary>
    public GameObject KaniGameOver;
    /// <summary>ゴミによるゲームオーバーオブジェクト</summary>
    public GameObject GomiGameOver;


    /// <summary>オーディオソース</summary>
    private AudioManager audioManager;

    private void Awake()
    {
        // オーディオマネージャー取得
        audioManager = AudioManager.Instance;
    }

    // Use this for initialization
    void Start()
    {
        // BGM再生
        audioManager.PlaySound(AudioName.GAME_OVER_SCENE_BGM);

        // ゲームオーバ演出を全て非表示
        KurageGameOver.SetActive(false);
        KonbuGameOver.SetActive(false);
        NetGameOver.SetActive(false);
        OctpusGameOver.SetActive(false);
        KaniGameOver.SetActive(false);
        GomiGameOver.SetActive(false);

        // ゲームオーバー演出の表示
        ActiveGameOverPerformance(EnemyController.AttackEnemy);

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

    /// <summary>
    /// 該当するゲームオーバー演出を表示する
    /// </summary>
    /// <param name="category">敵キャラのカテゴリ</param>
    private void ActiveGameOverPerformance(int category)
    {
        // 衝突した敵キャラを判別
        if (category == (int)EnemyController.EnemyCategory.Konbu)
        {
            // コンブの場合
            KonbuGameOver.SetActive(true);
        }
        else if (category == (int)EnemyController.EnemyCategory.Kurage)
        {
            // クラゲの場合
            KurageGameOver.SetActive(true);
        }
        else if (category == (int)EnemyController.EnemyCategory.Net)
        {
            // ネットの場合
            NetGameOver.SetActive(true);
        }
        else if (category == (int)EnemyController.EnemyCategory.Octopus)
        {
            // オクトパスの場合
            OctpusGameOver.SetActive(true);
        }
        else if (category == (int)EnemyController.EnemyCategory.Kani)
        {
            // カニの場合
            KaniGameOver.SetActive(true);
        }
        else if (category == (int)EnemyController.EnemyCategory.Gomi)
        {
            // ゴミの場合
            GomiGameOver.SetActive(true);
        }
        else
        {
            // 該当しない場合
            Debug.LogFormat("番号{0}：該当しません", category);
        }
    }
}
