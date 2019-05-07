using UnityEngine;
using Common;

public class KurageGenerator : MonoBehaviour
{
    /// <summary>ゲームディレクターオブジェクト</summary>
    public GameObject GameDirector;
    /// <summary>キャンバス</summary>
    public GameObject Canvas;
    /// <summary>クラゲプレファブ </summary>
    public GameObject KuragePrefab;
    /// <summary>出現間隔</summary>
    private float span = 5.0f;
    /// <summary></summary>
    private float delta = 0.0f;
    /// <summary>生成時のクラゲの最大Y座標</summary>
    private int maxKuaregePositionY = 0;
    /// <summary>生成時のクラゲの最小Y座標</summary>
    private int minKuaregePositionY = 0;
    /// <summary>クラゲプレファブ生成時のX座標</summary>
    private float kuragePositionX;
    /// <summary>オーディオマネージャー</summary>
    public AudioManager audioManager;

    void Awake()
    {
        audioManager = AudioManager.Instance;
    }

    void Start()
    {
        // 画面右端の座標を取得
        kuragePositionX = Screen.width / 2;

        // クラゲ生成時のY座標を代入
        maxKuaregePositionY = Screen.height / 2 - 100;
        minKuaregePositionY = (Screen.height / 2 -100) * -1;
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        // 一定時間たったか判別
        if (this.delta > span)
        {
            this.delta = 0.0f;
            GameObject gameObject = Instantiate(KuragePrefab) as GameObject;

            // 生成するオブジェクトをCanVasの子にする
            gameObject.transform.SetParent(Canvas.transform, false);

            // 指定の範囲内の値を代入
            int kuragePositionY = Random.Range(minKuaregePositionY, maxKuaregePositionY);

            // プレファブを生成
            gameObject.transform.localPosition = new Vector2(kuragePositionX, kuragePositionY);

            // クラゲ生成時のSeを再生
            audioManager.PlaySound(AudioName.KURAGE_SE);
        }
    }
}
