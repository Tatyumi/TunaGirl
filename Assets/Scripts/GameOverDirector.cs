using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverDirector : MonoBehaviour
{
    /// <summary>クラゲによるゲームオーバーオブジェクト</summary>
    public GameObject KurageGameOver;
    /// <summary>コンブによるゲームオーバーオブジェクト</summary>
    public GameObject KonbuGameOver;
    /// <summary>ネットによるゲームオーバーオブジェクト</summary>
    public GameObject NetGameOver;

    // Use this for initialization
    void Start()
    {
        // ゲームオーバ演出を全て非表示
        KurageGameOver.SetActive(false);
        KonbuGameOver.SetActive(false);
        NetGameOver.SetActive(false);

        // ゲームオーバー演出の表示
        ActiveGameOverPerformance(EnemyController.AttackEnemy);
    }

    /// <summary>
    /// 該当するゲームオーバー演出を表示する
    /// </summary>
    /// <param name="category">敵キャラのカテゴリ</param>
    private void ActiveGameOverPerformance(int category)
    {
        // 衝突した敵キャラを判別
        if (category == (int)EnemyController.EnemyCategory.Konbu)
        {
            // コンブの場合
            KonbuGameOver.SetActive(true);
        }
        else if (category == (int)EnemyController.EnemyCategory.Kurage)
        {
            // クラゲの場合
            KurageGameOver.SetActive(true);
        }
        else if (category == (int)EnemyController.EnemyCategory.Net)
        {
            // ネットの場合
            NetGameOver.SetActive(true);
        }
        else
        {
            // 該当しない場合
            Debug.LogFormat("番号{0}：該当しません", category);
        }
    }
}
