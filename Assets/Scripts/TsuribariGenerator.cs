using Common;
using UnityEngine;

public class TsuribariGenerator : Generator
{
    /// <summary>出現間隔</summary>
    private float span = 20.0f;
    /// <summary></summary>
    private float delta = 0.0f;
    /// <summary>生成時の釣り針の最大Y座標</summary>
    private int maxTsuribariPositionY = 0;
    /// <summary>生成時の釣り針の最小Y座標</summary>
    private int minTsuribariPositionY = 0;

    private void Awake()
    {
        // 初期化
        Initialize();
    }

    private void Start()
    {
        // 釣り針生成時のY座標を代入
        maxTsuribariPositionY = Screen.height / 2 - 150;
        minTsuribariPositionY = maxTsuribariPositionY * -1;
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
            base.GenerateGameobject(minTsuribariPositionY, maxTsuribariPositionY);
        }
    }
}
