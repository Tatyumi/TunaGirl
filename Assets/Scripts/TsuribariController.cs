﻿using UnityEngine.SceneManagement;
using Common;
using UnityEngine;

public class TsuribariController : EnemyController, IKillablePlayer
{

    /// <summary>移動速度</summary>
    private const float moveSpeed = 15.0f;

    void Update()
    {
        //少しずつ左に移動
        this.transform.position = new Vector3(transform.position.x - moveSpeed, transform.position.y);

        // 画面外か判別
        base.CheckOffScreen(this.transform.localPosition.x);
    }

    /// <summary>
    /// ゲーム終了処理
    /// </summary>
    public void KillPlayer()
    {
        base.DetectAttackEnemy((int)EnemyCategory.Tsuribari);
        SceneManager.LoadScene(SceneName.GAME_OVER_SCENE);
    }
}