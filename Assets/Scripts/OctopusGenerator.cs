using UnityEngine;
using Common;

public class OctopusGenerator : MonoBehaviour
{
    /// <summary>ゲームディレクターオブジェクト</summary>
    public GameObject GameDirector;
    /// <summary>プレイヤーオブジェクト</summary>
    public GameObject Player;
    /// <summary>キャンバス</summary>
    public GameObject Canvas;
    /// <summary>オクトパスプレファブ </summary>
    public GameObject OctpusPrefab;
    /// <summary>出現間隔</summary>
    private float span = 8.0f;
    /// <summary></summary>
    private float delta = 0.0f;
    /// <summary>オクトパスプレファブ生成時のX座標</summary>
    private float octpusPositionX;
    /// <summary>ゲームディレクター</summary>
    private GameDirector gameDirector;

    void Awake()
    {
        gameDirector = GameDirector.GetComponent<GameDirector>();
    }

    void Start()
    {
        // 画面右端の座標を取得
        octpusPositionX = Screen.width / 2;
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        // 一定時間たったか判別
        if (this.delta > span)
        {
            this.delta = 0.0f;
            GameObject gameObject = Instantiate(OctpusPrefab) as GameObject;

            // 生成するオブジェクトをCanVasの子にする
            gameObject.transform.SetParent(Canvas.transform, false);


            // プレイヤーのY座標に合わせてプレファブを生成
            gameObject.transform.localPosition = new Vector2(octpusPositionX, Player.transform.localPosition.y);

            // オクトパス生成時のSeを再生
            gameDirector.audioManager.PlaySound(AudioName.OCTPUS_SE);
        }
    }
}
