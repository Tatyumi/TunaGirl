using UnityEngine;
using Common;

public class IkaGenerator : MonoBehaviour
{
    /// <summary>プレイヤーオブジェクト</summary>
    public GameObject Player;
    /// <summary>キャンバス</summary>
    public GameObject Canvas;
    /// <summary>イカプレファブ </summary>
    public GameObject IkaPrefab;
    /// <summary>出現間隔</summary>
    private float span = 6.0f;
    /// <summary></summary>
    private float delta = 0.0f;
    /// <summary>イカプレファブ生成時のX座標</summary>
    private float IkaPositionX;
    /// <summary>オーディオマネージャー</summary>
    public AudioManager audioManager;

    void Awake()
    {
        audioManager = AudioManager.Instance;
    }

    void Start()
    {
        // 画面右端の座標を取得
        IkaPositionX = Screen.width / 2;
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        // 一定時間たったか判別
        if (this.delta > span)
        {
            this.delta = 0.0f;
            GameObject gameObject = Instantiate(IkaPrefab) as GameObject;

            // 生成するオブジェクトをCanVasの子にする
            gameObject.transform.SetParent(Canvas.transform, false);


            // プレイヤーのY座標に合わせてプレファブを生成
            gameObject.transform.localPosition = new Vector2(IkaPositionX, Player.transform.localPosition.y);

            // イカ生成時のSeを再生
            audioManager.PlaySound(AudioName.IKA_SE);
        }
    }
}
