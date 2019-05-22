using Common;
using UnityEngine;

public class TsuribariGenerator : MonoBehaviour {

    /// <summary>キャンバス</summary>
    public GameObject Canvas;
    /// <summary>釣り針プレファブ </summary>
    public GameObject TsuribariPrefab;
    /// <summary>出現間隔</summary>
    private float span = 20.0f;
    /// <summary></summary>
    private float delta = 0.0f;
    /// <summary>生成時の釣り針の最大Y座標</summary>
    private int maxTsuribariPositionY = 0;
    /// <summary>生成時の釣り針の最小Y座標</summary>
    private int minTsuribariPositionY = 0;
    /// <summary>釣り針プレファブ生成時のX座標</summary>
    private float TsuribariPositionX;
    /// <summary>オーディオマネージャー</summary>
    public AudioManager audioManager;

    void Awake()
    {
        audioManager = AudioManager.Instance;
    }

    void Start()
    {
        // 画面右端の座標を取得
        TsuribariPositionX = Screen.width / 2;

        // 釣り針生成時のY座標を代入
        maxTsuribariPositionY = Screen.height / 2 - 150;
        minTsuribariPositionY = maxTsuribariPositionY * -1;
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        // 一定時間たったか判別
        if (this.delta > span)
        {
            this.delta = 0.0f;
            GameObject gameObject = Instantiate(TsuribariPrefab) as GameObject;

            // 生成するオブジェクトをCanVasの子にする
            gameObject.transform.SetParent(Canvas.transform, false);

            // 指定の範囲内の値を代入
            int kuragePositionY = Random.Range(minTsuribariPositionY, maxTsuribariPositionY);

            // プレファブを生成
            gameObject.transform.localPosition = new Vector2(TsuribariPositionX, kuragePositionY);

            // 釣り針生成時のSeを再生
            audioManager.PlaySound(AudioName.KURAGE_SE);
        }
    }
}
