using UnityEngine;

public class EnemyController : MonoBehaviour
{
    /// <summary>プレイヤーに当たったエネミー</summary>
    public static int AttackEnemy = 0;
    /// <summary>左側画面外のX座標</summary>
    private readonly int offScreenPositionX = (Screen.width / 2) * -1;

    // 敵キャラのカテゴリ
    public enum EnemyCategory
    {
        None,   // 該当なし
        Kurage, // クラゲ
        Konbu,  // コンブ
        Net     // ネット
    }

    /// <summary>
    /// オブジェクトが画面外かどうか
    /// </summary>
    /// <param name="objectXposition">オブジェクトのX座標</param>
    protected void CheckOffScreen(float objectXposition)
    {
        // 画面外か判別
        if (objectXposition < offScreenPositionX)
        {
            // オブジェクト破棄
            Destroy(this.gameObject);
        }
    }
}
