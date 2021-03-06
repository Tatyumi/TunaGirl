﻿// 共通するものを一元管理
namespace Common
{
    // シーン名
    public sealed class SceneName
    {
        /// <summary>タイトルシーン名</summary>
        public const string TITLE_SCENE = "TitleScene";
        /// <summary>ゲームシーン名</summary>
        public const string GAME_SCENE = "GameScene";
        /// <summary>ゲームエンドシーン名</summary>
        public const string GAME_END_SCENE = "GameEndScene";
        /// <summary>ゲームオーバーシーン名</summary>
        public const string GAME_OVER_SCENE = "GameOverScene";
        /// <summary>ウェイブシーン</summary>
        public const string WAVE_SCENE = "WaveScene";
        /// <summary>ゲームクリアシーン名</summary>
        public const string GAME_CLEAR_SCENE = "GameClearScene";
        /// <summary>ステージ2シーン名</summary>
        public const string STAGE_TWO_SCENE = "StageTwoScene";
    }

    // タグ名
    public sealed class TagName
    {
        /// <summary>ターゲットタグ名</summary>
        public const string TARGET_TAG = "Target";
        /// <summary>エネミータグ名</summary>
        public const string ENEMY_TAG = "Enemy";
    }

    // Audioファイル名
    public sealed class AudioName
    {
        /// <summary>タイトルシーンBGM名</summary>
        public const string TITLE_SCENE_BGM = "TitleSceneBgm";
        /// <summary>ゲームシーンBGM名</summary>
        public const string GAME_SCENE_BGM = "GameSceneBGM";
        /// <summary>ゲームオーバーシーンBGM名</summary>
        public const string GAME_OVER_SCENE_BGM = "GameOverSceneBGM";
        /// <summary>ゲームエンドシーンBGM名</summary>
        public const string GAME_END_SCENE_BGM = "GameEndSceneBGM";
        /// <summary>チュートリアルBGM名</summary>
        public const string TUTORIAL_BGM = "TutorialBGM";
        /// <summary>ボタンSE名</summary>
        public const string BUTTON_SE = "ButtonSE";
        /// <summary>クラゲSE名</summary>
        public const string KURAGE_SE = "KurageSE";
        /// <summary>ネットSE名</summary>
        public const string NET_SE = "NetSE";
        /// <summary>オクトパスSE名</summary>
        public const string OCTPUS_SE = "OctpusSE";
        /// <summary>ウェイブシーンのBGM名</summary>
        public const string WAVE_BGM = "WaveBGM";
        /// <summary>ゲームクリアシーンBGM名</summary>
        public const string GAME_CLEAR_SCENE_BGM = "GameClearSceneBGM";
        /// <summary>ステージ2シーンBGM名</summary>
        public const string STAGE_TWO_SCENE_BGM = "StageTwoBGM";
        /// <summary>イカSE名</summary>
        public const string IKA_SE = "IkaSE";
        /// <summary>カニSE名</summary>
        public const string KANI_SE = "KaniSE";
    }
}