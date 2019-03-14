using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// シーン遷移処理のインターフェイス
public interface IMovableScene
{
    /// <summary>
    /// シーンを遷移する
    /// </summary>
    void MoveScene();
}
