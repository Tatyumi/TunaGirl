using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Common;

public class StageTwoDirector : MonoBehaviour
{
    /// <summary>オーディオソース</summary>
    private AudioManager audioManager;

    private void Awake()
    {
        // オーディオマネージャー取得
        audioManager = AudioManager.Instance;
    }

    // Use this for initialization
    private void Start()
    {
        // BGMの再生
        audioManager.PlaySound(AudioName.STAGE_TWO_SCENE_BGM);
    }
}
