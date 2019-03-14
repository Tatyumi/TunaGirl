using UnityEngine;
using UnityEngine.SceneManagement;
using Common;

public class GameDirector : MonoBehaviour
{
    /// <summary>
    /// ゲームクリア処理
    /// </summary>
    public void ClearGame()
    {
        SceneManager.LoadScene(SceneName.GAME_CLEAR_SCENE);
    }

    /// <summary>
    /// ゲーム失敗処理
    /// </summary>
    public void FailGame()
    {
        SceneManager.LoadScene(SceneName.GAME_OVER_SCENE);
    }
}
