
// 共通するものを一元管理
namespace Common
{
    // シーン名
    public class SceneName
    {
        /// <summary>タイトルシーン名</summary>
        public const string TITLE_SCENE = "TitleScene";
        /// <summary>ゲームシーン名</summary>
        public const string GAME_SCENE = "GameScene";
        /// <summary>ゲームクリアシーン名</summary>
        public const string GAME_CLEAR_SCENE = "GameClear";
        /// <summary>ゲームオーバーシーン名</summary>
        public const string GAME_OVER_SCENE = "GameOverScene";
        /// <summary>ウェイブシーン</summary>
        public const string WAVVE_SCENE = "WaveScene";
    }

    // タグ名
    public class TagName
    {
        /// <summary>ターゲットタグ名</summary>
        public const string TARGET_TAG = "Target";
        /// <summary>エネミータグ名</summary>
        public const string ENEMY_TAG = "Enemy";
    }

    // Audioファイル名
    public class AudioName
    {
        /// <summary>タイトルシーンBGM名</summary>
        public const string TITLE_SCENE_BGM = "TitleSceneBgm";
        /// <summary>ゲームシーンBGM名</summary>
        public const string GAME_SCENE_BGM = "GameSceneBGM";
        /// <summary>ゲームオーバーシーンBGM名</summary>
        public const string GAME_OVER_SCENE_BGM = "GameOverSceneBGM";
        /// <summary>ゲームクリアシーンBGM名</summary>
        public const string GAME_CLEAR_SCENE_BGM = "GameClearSceneBGM";
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
    }

    // オブジェクト名
    public class ObjectName
    {
        /// <summary>オーディオマネージャー</summary>
        public const string AUDIO_MANAGER = "AudioManager";
    }
}