using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /// <summary>移動速度</summary>
    private const float moveSpeed = 7.0f;

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
    }

    /// <summary>
    /// 衝突判定
    /// </summary>
    /// <param name="other">衝突したオブジェクト</param>
    private void OnTriggerEnter2D(Collider2D other)
    {
        // TargetTunaに衝突した場合
        if(other.gameObject.tag == "Target")
        {
            // GameClearシーンに遷移する
            Debug.Log("クリア");

        }
        else
        {
            // 各敵キャラのゲームオーバー処理を行う
            Debug.Log("いたい");
        }
    }

}
