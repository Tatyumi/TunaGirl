using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndrollController : MonoBehaviour
{
    /// <summary>移動速度</summary>
    private float moveSpeed = 3.0f;
    /// <summary>破棄座標</summary>
    private float destroyPositionX;

    // Use this for initialization
    private void Start()
    {
        destroyPositionX = EndrollTextGenerator.DestroyEndrollPositionX;
    }

    // Update is called once per frame
    private void Update()
    {
        //少しずつ左に移動
        this.transform.position = new Vector2((transform.position.x - moveSpeed), transform.position.y);

        // 破棄座標に達したかどうか
        if (this.transform.localPosition.x < destroyPositionX)
        {
            // オブジェクト破棄
            Destroy(this.gameObject);
        }
    }
}
