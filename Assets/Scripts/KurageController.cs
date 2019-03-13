using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class KurageController : EnemyController {

    /// <summary>移動速度</summary>
    private const float moveSpeed = 2.0f;
    
    // Update is called once per frame
    void Update ()
    {
        // 上下に揺れながら左に移動
        this.transform.localPosition = new Vector2(transform.localPosition.x - moveSpeed, transform.localPosition.y + Mathf.Sin(Time.time));

        // 画面外か判別
        base.CheckOffScreen(this.transform.localPosition.x);
    }
}
