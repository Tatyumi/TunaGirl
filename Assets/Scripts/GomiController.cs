using UnityEngine;

public class GomiController : EnemyController, IKillablePlayer
{
    /// <summary>移動速度</summary>
    private const float moveSpeed = 2.0f;

    // Update is called once per frame
    void Update()
    {
        // 上下に揺れながら左に移動
        this.transform.localPosition = new Vector2(transform.localPosition.x - moveSpeed, transform.localPosition.y + Mathf.Sin(Time.time));

        // 画面外か判別
        base.CheckOffScreen(this.transform.localPosition.x);
    }

    /// <summary>
    /// ゲーム終了処理
    /// </summary>
    public void KillPlayer()
    {
        base.DetectAttackEnemy((int)EnemyCategory.Gomi);
    }
}
