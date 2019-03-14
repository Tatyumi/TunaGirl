using UnityEngine;

public class EnemyController : MonoBehaviour
{
    /// <summary>左側画面外のX座標</summary>
    private readonly int offScreenPositionX = (Screen.width / 2) * -1;

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
