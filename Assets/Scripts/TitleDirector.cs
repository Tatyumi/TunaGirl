using UnityEngine;
using UnityEngine.SceneManagement;
using Common;

public class TitleDirector : MonoBehaviour
{
    void Update()
    {
        // 画面がタップされた場合
        if (Input.GetMouseButtonDown(0))
        {
            // ゲームシーンに移動
            SceneManager.LoadScene(SceneName.GAME_SCENE);
        }
    }
}
