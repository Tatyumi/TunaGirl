using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundController : MonoBehaviour {

    /// <summary>背景画像のリスト</summary>
    private Transform backGrounds;

    private void Awake()
    {
        // 全背景画像の取得
        backGrounds = this.gameObject.GetComponentInChildren<Transform>();
    }

    // Use this for initialization
    void Start () {

        // 初期化
        for (int i = 0; i < backGrounds.childCount; i++)
        {
            // 背景画像を非表示
            backGrounds.GetChild(i).gameObject.SetActive(false);
        }

        // 指定の背景画像を表示
        backGrounds.GetChild(WaveDirector.progressCount).gameObject.SetActive(true);
    }
	
}
