using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Common;

public sealed class KaniGenerator : Generator
{

    /// <summary>出現間隔</summary>
    private float span = 3.0f;
    /// <summary>経過時間</summary>
    private float delta = 0.0f;
    /// <summary>カニプレファブのY座標</summary>
    private float kaniPositionY;

    private void Awake()
    {
        // 初期化
        Initialize();
    }

    // Use this for initialization
    private void Start()
    {
        // カニ画像の下辺が画面下と重なるよう計算
        kaniPositionY = (Screen.height / 2 * -1) + prefab.GetComponent<RectTransform>().sizeDelta.y / 2;
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
            GenerateGameobject(kaniPositionY,AudioName.KANI_SE);
        }
    }
}
