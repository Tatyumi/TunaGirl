using UnityEngine;
using Common;

public sealed class KurageGenerator : Generator
{
    /// <summary>出現間隔</summary>
    private float span = 5.0f;
    /// <summary></summary>
    private float delta = 0.0f;
    /// <summary>生成時のクラゲの最大Y座標</summary>
    private int maxKuaregePositionY = 0;
    /// <summary>生成時のクラゲの最小Y座標</summary>
    private int minKuaregePositionY = 0;

    private void Awake()
    {
        // 初期化
        Initialize();
    }

    private void Start()
    {
        // クラゲ生成時のY座標を代入
        maxKuaregePositionY = Screen.height / 2 - 100;
        minKuaregePositionY = (Screen.height / 2 - 100) * -1;
    }

    // Update is called once per frame
    private void Update()
    {
        // 時間加算
        this.delta += Time.deltaTime;

        // 一定時間たったか判別
        if (this.delta > span)
        {
            //　初期化
            this.delta = 0.0f;

            // ゲームオブジェクトを生成
            base.GenerateGameobject(minKuaregePositionY, maxKuaregePositionY, AudioName.KURAGE_SE);
        }
    }
}
