using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public sealed class KurageController : EnemyController,IMovableScene {

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

    /// <summary>
    /// シーン遷移
    /// </summary>
    public void MoveScene()
    {
        //ゲームオーバ画面に遷移
        SceneManager.LoadScene("");
    }
}
