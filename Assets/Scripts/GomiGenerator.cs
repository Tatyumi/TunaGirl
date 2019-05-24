using Common;
using UnityEngine;

public sealed class GomiGenerator : Generator
{
    /// <summary>出現間隔</summary>
    private float span = 5.0f;
    /// <summary></summary>
    private float delta = 0.0f;
    /// <summary>生成時のゴミの最大Y座標</summary>
    private int maxGomiPositionY = 0;
    /// <summary>生成時のゴミの最小Y座標</summary>
    private int minGomiPositionY = 0;

    private void Awake()
    {
        // 初期化
        Initialize();
    }

    private void Start()
    {
        // ゴミ生成時のY座標を代入
        maxGomiPositionY = Screen.height / 2 - 100;
        minGomiPositionY = (Screen.height / 2 - 100) * -1;
    }

    // Update is called once per frame
    private void Update()
    {
        this.delta += Time.deltaTime;

        // 一定時間たったか判別
        if (this.delta > span)
        {
            // 時間加算
            this.delta += Time.deltaTime;

            // 一定時間たったか判別
            if (this.delta > span)
            {
                //　初期化
                this.delta = 0.0f;

                // ゲームオブジェクトを生成
                base.GenerateGameobject(minGomiPositionY, maxGomiPositionY, AudioName.KURAGE_SE);
            }
        }
    }
}
