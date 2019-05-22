using Common;
using UnityEngine;

public class GomiGenerator : MonoBehaviour {

    /// <summary>キャンバス</summary>
    public GameObject Canvas;
    /// <summary>ゴミプレファブ </summary>
    public GameObject GomiPrefab;
    /// <summary>出現間隔</summary>
    private float span = 5.0f;
    /// <summary></summary>
    private float delta = 0.0f;
    /// <summary>生成時のゴミの最大Y座標</summary>
    private int maxGomiPositionY = 0;
    /// <summary>生成時のゴミの最小Y座標</summary>
    private int minGomiPositionY = 0;
    /// <summary>ゴミプレファブ生成時のX座標</summary>
    private float GomiPositionX;
    /// <summary>オーディオマネージャー</summary>
    public AudioManager audioManager;

    void Awake()
    {
        audioManager = AudioManager.Instance;
    }

    void Start()
    {
        // 画面右端の座標を取得
        GomiPositionX = Screen.width / 2;

        // ゴミ生成時のY座標を代入
        maxGomiPositionY = Screen.height / 2 - 100;
        minGomiPositionY = (Screen.height / 2 - 100) * -1;
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        // 一定時間たったか判別
        if (this.delta > span)
        {
            this.delta = 0.0f;
            GameObject gameObject = Instantiate(GomiPrefab) as GameObject;

            // 生成するオブジェクトをCanVasの子にする
            gameObject.transform.SetParent(Canvas.transform, false);

            // 指定の範囲内の値を代入
            int kuragePositionY = Random.Range(minGomiPositionY, maxGomiPositionY);

            // プレファブを生成
            gameObject.transform.localPosition = new Vector2(GomiPositionX, kuragePositionY);

            // ゴミ生成時のSeを再生
            audioManager.PlaySound(AudioName.KURAGE_SE);
        }
    }
}
