using UnityEngine;
using Common;

public sealed class NetGenerator : Generator
{
    /// <summary>出現間隔</summary>
    private float span = 15.0f;
    /// <summary></summary>
    private float delta = 0.0f;
    /// <summary>ネットプレファブのY座標</summary>
    private float netPositionY;

    private void Awake()
    {
        // 初期化
        Initialize();
    }

    // Use this for initialization
    private void Start()
    {
        // ネット画像の上辺が画面上と重なるよう計算
        netPositionY = (Screen.height / 2) - prefab.GetComponent<RectTransform>().sizeDelta.y / 2;
    }

    // Update is called once per frame
    private void Update()
    {
        this.delta += Time.deltaTime;

        // 一定時間たったか判別
        if (this.delta > span)
        {
            // 初期化
            this.delta = 0.0f;

            // ゲームオブジェクトを生成
            GenerateGameobject(netPositionY,AudioName.NET_SE);
        }
    }
}
