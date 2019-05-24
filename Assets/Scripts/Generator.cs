using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    /// <summary>キャンバス</summary>
    public GameObject Canvas;
    /// <summary>オーディオマネージャー</summary>
    private AudioManager audioManager;
    /// <summary>ゲームオブジェクトを配置するX座標</summary>
    protected float positionX;
    /// <summary>プレファブ</summary>
    public GameObject prefab;

    /// <summary>
    /// 初期化
    /// </summary>
    public void Initialize()
    {
        // オーディオマネージャーの取得
        audioManager = AudioManager.Instance;

        // 画面右端の座標を取得
        positionX = Screen.width / 2;
    }

    /// <summary>
    /// ゲームオブジェクト生成処理
    /// </summary>
    /// <param name="positionY">ゲームオブジェクトを配置するY座標</param>
    protected virtual void GenerateGameobject(float positionY)
    {
        // 生成するプレファブをゲームオブジェクトに変換
        GameObject gameObject = Instantiate(prefab) as GameObject;

        // ゲームオブジェクトをCanVasの子にする
        gameObject.transform.SetParent(Canvas.transform, false);

        // プレイヤーのY座標に合わせてゲームオブジェクトを配置
        gameObject.transform.localPosition = new Vector2(positionX, positionY);
    }

    /// <summary>
    /// ゲームオブジェクト生成処理
    /// </summary>
    /// <param name="positionY">ゲームオブジェクトを配置するY座標</param>
    /// <param name="seName">再生するSE名</param>
    protected virtual void GenerateGameobject(float positionY, string seName)
    {
        // 生成するプレファブをゲームオブジェクトに変換
        GameObject gameObject = Instantiate(prefab) as GameObject;

        // ゲームオブジェクトをCanVasの子にする
        gameObject.transform.SetParent(Canvas.transform, false);

        // プレイヤーのY座標に合わせてゲームオブジェクトを配置
        gameObject.transform.localPosition = new Vector2(positionX, positionY);

        // SEを再生
        audioManager.PlaySound(seName);
    }

    /// <summary>
    /// ゲームオブジェクト生成処理
    /// </summary>
    /// <param name="minPositionY">ゲームオブジェクトを配置する最小のY座標</param>
    /// <param name="maxPositionY">ゲームオブジェクトを配置する最大のY座標</param>
    protected virtual void GenerateGameobject(int minPositionY, int maxPositionY)
    {
        // 生成するプレファブをゲームオブジェクトに変換
        GameObject gameObject = Instantiate(prefab) as GameObject;

        // ゲームオブジェクトをCanVasの子にする
        gameObject.transform.SetParent(Canvas.transform, false);

        // 配置する座標Yの値を代入
        int positionY = Random.Range(minPositionY, maxPositionY);

        // プレイヤーのY座標に合わせてゲームオブジェクトを配置
        gameObject.transform.localPosition = new Vector2(positionX, positionY);
    }

    /// <summary>
    /// ゲームオブジェクト生成処理
    /// </summary>
    /// <param name="minPositionY">ゲームオブジェクトを配置する最小のY座標</param>
    /// <param name="maxPositionY">ゲームオブジェクトを配置する最大のY座標</param>
    /// <param name="seName">再生するSE名</param>
    protected virtual void GenerateGameobject(int minPositionY, int maxPositionY, string seName)
    {
        // 生成するプレファブをゲームオブジェクトに変換
        GameObject gameObject = Instantiate(prefab) as GameObject;

        // ゲームオブジェクトをCanVasの子にする
        gameObject.transform.SetParent(Canvas.transform, false);

        // 配置する座標Yの値を代入
        int positionY = Random.Range(minPositionY, maxPositionY);

        // プレイヤーのY座標に合わせてゲームオブジェクトを配置
        gameObject.transform.localPosition = new Vector2(positionX, positionY);

        // SEを再生
        audioManager.PlaySound(seName);
    }
}
