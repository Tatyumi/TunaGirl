using UnityEngine;

public class TargetTunaController : MonoBehaviour
{
    /// <summary>移動速度</summary>
    private const float moveSpeed = 0.2f;

    void Update()
    {
        //少しずつ左に移動
        this.transform.position = new Vector3(transform.position.x - moveSpeed, transform.position.y);
    }
}
