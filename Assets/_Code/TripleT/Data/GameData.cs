namespace Data
{
    public static class GameData
    {

        #region GameData

        private static string _playerChar;

        #endregion

        #region SettingsData
        
        private static bool _isPlayAudio;
        private static float _audiVolume;
        private static bool _isTapticOn;
        
        #endregion


        #region Fields

        public static string PlayerChar
        {
            get => _playerChar;
            set => _playerChar = value;
        }

        public static bool IsPlayAudio
        {
            get => _isPlayAudio;
            set => _isPlayAudio = value;
        }

        public static float AudiVolume
        {
            get => _audiVolume;
            set => _audiVolume = value;
        }

        public static bool IsTapticOn
        {
            get => _isTapticOn;
            set => _isTapticOn = value;
        }
        #endregion

        
    }
}