using UnityEngine;
using Common;

public class PlayerController : MonoBehaviour
{
    /// <summary>ゲームディレクターオブジェクト</summary>
    public GameObject GameDirector;
    /// <summary>移動速度</summary>
    private const float moveSpeed = 7.0f;
    /// <summary>ゲームディレクター</summary>
    private GameDirector gameDirector;
    /// <summary>移動できるY座標の最大値</summary>
    private float maxMovePositionY;
    /// <summary>移動できるY座標の最小値</summary>
    private float minMovePositionY;

    private void Awake()
    {
        gameDirector = GameDirector.GetComponent<GameDirector>();
    }

    private void Start()
    {
        // 初期位置
        this.transform.localPosition = new Vector2((Screen.width / 2) * -1
            + this.gameObject.GetComponent<RectTransform>().sizeDelta.x / 2, 0);

        maxMovePositionY = Screen.height / 2 - this.gameObject.GetComponent<RectTransform>().sizeDelta.y / 2;
        minMovePositionY = maxMovePositionY * -1;
    }

    void Update()
    {
        // キーボードの↑キーが押されているか判別
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // プレイヤーを上に移動
            this.transform.position = new Vector2(transform.position.x, transform.position.y + moveSpeed);
        }

        // キーボードの↓キーが押されているか判別
        if (Input.GetKey(KeyCode.DownArrow))
        {
            // プレイヤーを下に移動
            this.transform.position = new Vector2(transform.position.x, transform.position.y - moveSpeed);
        }

        // 画面外に移動してないか判別
        if(this.transform.localPosition.y > maxMovePositionY)
        {
            this.transform.localPosition = new Vector2(transform.localPosition.x, maxMovePositionY);
        }
        else if(this.transform.localPosition.y < minMovePositionY)
        {
            this.transform.localPosition = new Vector2(transform.localPosition.x, minMovePositionY);
        }
    }

    /// <summary>
    /// 衝突判定
    /// </summary>
    /// <param name="other">衝突したオブジェクト</param>
    private void OnTriggerEnter2D(Collider2D other)
    {
        // BGMの停止
        gameDirector.audioManager.StopSound();

        // TargetTunaに衝突した場合
        if (other.gameObject.tag == TagName.TARGET_TAG)
        {
            // GameClearシーンに遷移する
            gameDirector.ClearGame();
        }
        else
        {
            var obj = other.gameObject.GetComponent<IKillablePlayer>();

            // 存在チェック
            if (obj != null)
            {
                // ゲーム終了処理
                obj.KillPlayer();
            }
        }
    }
}
