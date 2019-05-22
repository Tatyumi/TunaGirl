using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : SingletonMonoBehaviour<AudioManager>
{
    /// <summary>タイトルシーンBGM</summary>
    public AudioClip TitleSceneBGM;
    /// <summary>ゲームシーンBGM</summary>
    public AudioClip GameSceneBGM;
    /// <summary>ゲームオーバーシーンBGM</summary>
    public AudioClip GameOverSceneBGM;
    /// <summary>ゲームクリアシーンBGM</summary>
    public AudioClip GameClearSceneBGM;
    /// <summary>チュートリアルBGM</summary>
    public AudioClip TutorialBGM;
    /// <summary>ボタンSE</summary>
    public AudioClip ButtonSE;
    /// <summary>クラゲSE</summary>
    public AudioClip KurageSE;
    /// <summary>ネットSE</summary>
    public AudioClip NetSE;
    /// <summary>オクトパスSE</summary>
    public AudioClip OctpusSE;
    /// <summary>ウェイブシーンBGM</summary>
    public AudioClip WaveBGM;

    /// <summary>オーディオソース</summary>
    AudioSource audioSource;
    /// <summary>全オーディオ保持ディクショナリ</summary>
    private Dictionary<string, AudioClip> AudioDic;

    private void Awake()
    {
        // 存在確認
        if (this != Instance)
        {
            Destroy(this);
            return;
        }

        audioSource = gameObject.GetComponent<AudioSource>();

        // オーディオを格納
        AudioDic = new Dictionary<string, AudioClip> {
            { TitleSceneBGM.name, TitleSceneBGM},
            { GameSceneBGM.name, GameSceneBGM},
            { GameOverSceneBGM.name, GameOverSceneBGM},
            { GameClearSceneBGM.name, GameClearSceneBGM},
            { TutorialBGM.name, TutorialBGM},
            { ButtonSE.name, ButtonSE},
            { KurageSE.name, KurageSE},
            { NetSE.name, NetSE},
            { OctpusSE.name, OctpusSE},
            { WaveBGM.name, WaveBGM},
        };
    }

    /// <summary>
    /// 音を流す
    /// </summary>
    /// <param name="soundName">音の名前</param>
    public void PlaySound(string soundName)
    {
        // 名前のチェック
        if (!AudioDic.ContainsKey(soundName))
        {
            Debug.Log(soundName + "という名前のSEがありません");
            return;
        }
        audioSource.PlayOneShot(AudioDic[soundName]);
    }

    /// <summary>
    /// 音を停止
    /// </summary>
    public void StopSound()
    {
        audioSource.Stop();
    }

}
