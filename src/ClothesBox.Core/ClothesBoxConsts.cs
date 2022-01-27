using ClothesBox.Debugging;

namespace ClothesBox
{
    public class ClothesBoxConsts
    {
        public const string LocalizationSourceName = "ClothesBox";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = false;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "678645e8c61a473ab9e589a541f8dfca";
    }
}
