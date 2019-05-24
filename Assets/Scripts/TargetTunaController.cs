using UnityEngine;

public class TargetTunaController : MonoBehaviour
{
    /// <summary>移動速度</summary>
    private const float moveSpeed = 0.2f;

    private void Start()
    {
        // 初期位置
        this.transform.localPosition = new Vector2(Screen.width / 2, 0);
    }

    private void Update()
    {
        //少しずつ左に移動
        this.transform.position = new Vector3(transform.position.x - moveSpeed, transform.position.y);
    }
}
