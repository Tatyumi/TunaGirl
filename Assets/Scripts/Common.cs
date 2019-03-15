
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
        /// <summary>ゲームクリアシーンBGM</summary>
        public const string GAME_CLEAR_SCENE_BGM = "GameClearSceneBGM";
        /// <summary>チュートリアルBGM</summary>
        public const string TUTORIAL_BGM = "TutorialBGM";
        /// <summary>ボタンSE</summary>
        public const string BUTTON_SE = "ButtonSE";
    }

    // オブジェクト名
    public class ObjectName
    {
        /// <summary>オーディオマネージャー</summary>
        public const string AUDIO_MANAGER = "AudioManager";
    }
}