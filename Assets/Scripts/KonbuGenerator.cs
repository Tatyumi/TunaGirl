using UnityEngine;

public class KonbuGenerator : Generator
{
    /// <summary>出現間隔</summary>
    private float span = 1.0f;
    /// <summary></summary>
    private float delta = 0.0f;
    /// <summary>コンブプレファブのY座標</summary>
    private float konbPositionY;

    private void Awake()
    {
        // 初期化
        Initialize();
    }

    private void Start()
    {
        // コンブ画像の下辺が画面下と重なるよう計算
        konbPositionY = (Screen.height / 2 * -1) + prefab.GetComponent<RectTransform>().sizeDelta.y / 2;
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
            GenerateGameobject(konbPositionY);
        }
    }
}
