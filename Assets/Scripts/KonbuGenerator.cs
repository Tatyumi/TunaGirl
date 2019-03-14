using UnityEngine;

public class KonbuGenerator : MonoBehaviour
{
    /// <summary>キャンバス</summary>
    public GameObject Canvas;
    /// <summary>コンブプレファブ </summary>
    public GameObject KonbuPrefab;
    /// <summary>出現間隔</summary>
    private float span = 1.0f;
    /// <summary></summary>
    private float delta = 0.0f;
    /// <summary>コンブプレファブのX座標</summary>
    private float konbPositionX;
    /// <summary>コンブプレファブのY座標</summary>
    private float konbPositionY;

    private void Awake()
    {
        // 画面右端の座標を取得
        konbPositionX = Screen.width / 2;

        // コンブ画像の下辺が画面下と重なるよう計算
        konbPositionY = (Screen.height / 2 * -1) + KonbuPrefab.GetComponent<RectTransform>().sizeDelta.y / 2;
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        // 一定時間たったか判別
        if (this.delta > span)
        {
            this.delta = 0.0f;
            GameObject gameObject = Instantiate(KonbuPrefab) as GameObject;

            // 生成するオブジェクトをCanVasの子にする
            gameObject.transform.SetParent(Canvas.transform, false);

            // プレファブを生成
            gameObject.transform.localPosition = new Vector2(konbPositionX, konbPositionY);
        }
    }
}
