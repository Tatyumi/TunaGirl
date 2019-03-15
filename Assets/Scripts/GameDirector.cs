using UnityEngine;
using UnityEngine.SceneManagement;
using Common;

public class GameDirector : MonoBehaviour
{
    /// <summary>ツナガールオブジェクト</summary>
    public GameObject TunaGirl;
    /// <summary>ツナボーイオブジェクト</summary>
    public GameObject TunaBoy;
    /// <summary>コンブオブジェクト</summary>
    public GameObject KonbuGenerator;
    /// <summary>クラゲジェネレータオブジェクト</summary>
    public GameObject KurageGenerator;
    /// <summary>ネットジェネレータオブジェクト</summary>
    public GameObject NetGenerator;
    /// <summary>チュートリアルパネルオブジェクト</summary>
    public GameObject TutorialPanel;

    private void Start()
    {
        OnTutorialMode();
    }
    
    /// <summary>
    /// ゲームクリア処理
    /// </summary>
    public void ClearGame()
    {
        SceneManager.LoadScene(SceneName.GAME_CLEAR_SCENE);
    }

    /// <summary>
    /// チュートリアルを表示
    /// </summary>
    public void OnTutorialMode()
    {
        // オブジェクト
        TunaGirl.SetActive(false);
        TunaBoy.SetActive(false);
        KonbuGenerator.SetActive(false);
        KurageGenerator.SetActive(false);
        NetGenerator.SetActive(false);

        TutorialPanel.SetActive(true);
    }

    /// <summary>
    /// ゲーム開始処理
    /// </summary>
    public void GameStart()
    {
        TunaGirl.SetActive(true);
        TunaBoy.SetActive(true);
        KonbuGenerator.SetActive(true);
        KurageGenerator.SetActive(true);
        NetGenerator.SetActive(true);

        TutorialPanel.SetActive(false);
    }
}
