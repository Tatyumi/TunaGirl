using UnityEngine;
using Common;

public class NetGenerator : MonoBehaviour
{
    /// <summary>ゲームディレクターオブジェクト</summary>
    public GameObject GameDirector;
    /// <summary>キャンバス</summary>
    public GameObject Canvas;
    /// <summary>ネットプレファブ </summary>
    public GameObject NetPrefab;
    /// <summary>出現間隔</summary>
    private float span = 15.0f;
    /// <summary></summary>
    private float delta = 0.0f;
    /// <summary>ネットプレファブのX座標</summary>
    private float netPositionX;
    /// <summary>ネットプレファブのY座標</summary>
    private float netPositionY;
    /// <summary>ゲームディレクター</summary>
    private GameDirector gameDirector;

    void Awake()
    {
        gameDirector = GameDirector.GetComponent<GameDirector>();
    }

    // Use this for initialization
    void Start()
    {
        // 画面右端の座標を取得
        netPositionX = Screen.width / 2;

        // ネット画像の上辺が画面上と重なるよう計算
        netPositionY = (Screen.height / 2) - NetPrefab.GetComponent<RectTransform>().sizeDelta.y / 2;
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        // 一定時間たったか判別
        if (this.delta > span)
        {
            this.delta = 0.0f;
            GameObject gameObject = Instantiate(NetPrefab) as GameObject;

            // 生成するオブジェクトをCanVasの子にする
            gameObject.transform.SetParent(Canvas.transform, false);

            // プレファブを生成
            gameObject.transform.localPosition = new Vector2(netPositionX, netPositionY);

            // ネット生成時のSEを再生
            gameDirector.audioManager.PlaySound(AudioName.NET_SE);
        }
    }
}
