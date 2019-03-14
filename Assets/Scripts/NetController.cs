using UnityEngine;

public class NetController : EnemyController
{
    /// <summary>移動速度</summary>
    private const float moveSpeed = 20.0f;
	
	// Update is called once per frame
	void Update ()
    {
        //少しずつ左に移動
        this.transform.position = new Vector3(transform.position.x - moveSpeed, transform.position.y);

        // 画面外か判別
        base.CheckOffScreen(this.transform.localPosition.x);

    }
}
