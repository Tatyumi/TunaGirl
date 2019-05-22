using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Common;

public class KaniGenerator : MonoBehaviour {

    /// <summary>キャンバス</summary>
    public GameObject Canvas;
    /// <summary>カニプレファブ</summary>
    public GameObject KaniPrefab;
    /// <summary>出現間隔</summary>
    private float span = 3.0f;
    /// <summary>経過時間</summary>
    private float delta = 0.0f;
    /// <summary>カニプレファブのX座標</summary>
    private float kaniPositionX;
    /// <summary>カニプレファブのY座標</summary>
    private float kaniPositionY;
    /// <summary>オーディオマネージャー</summary>
    public AudioManager audioManager;

    void Awake()
    {
        audioManager = AudioManager.Instance;
    }


    // Use this for initialization
    void Start ()
    {
        // 画面右端の座標を取得
        kaniPositionX = Screen.width / 2;

        // カニ画像の下辺が画面下と重なるよう計算
        kaniPositionY = (Screen.height / 2 * -1) + KaniPrefab.GetComponent<RectTransform>().sizeDelta.y / 2;

    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        // 一定時間たったか判別
        if (this.delta > span)
        {
            this.delta = 0.0f;
            GameObject gameObject = Instantiate(KaniPrefab) as GameObject;

            // 生成するオブジェクトをCanVasの子にする
            gameObject.transform.SetParent(Canvas.transform, false);

            // プレファブを生成
            gameObject.transform.localPosition = new Vector2(kaniPositionX, kaniPositionY);

            // カニ生成時のSeを再生
            audioManager.PlaySound(AudioName.KANI_SE);
        }
    }
}
