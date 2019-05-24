using UnityEngine;
using Common;

public sealed class OctopusGenerator : Generator
{
    /// <summary>プレイヤーオブジェクト</summary>
    public GameObject Player;
    /// <summary>出現間隔</summary>
    private float span = 8.0f;
    /// <summary></summary>
    private float delta = 0.0f;

    private void Awake()
    {
        // 初期化
        Initialize();
    }

    // Update is called once per frame
    private void Update()
    {
        // 時間加算
        this.delta += Time.deltaTime;

        // 一定時間たったか判別
        if (this.delta > span)
        {
            // 初期化
            this.delta = 0.0f;

            // ゲームオブジェクトを生成
            base.GenerateGameobject(Player.transform.localPosition.y, AudioName.OCTPUS_SE);
        }
    }
}
