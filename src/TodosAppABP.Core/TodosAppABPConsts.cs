using TodosAppABP.Debugging;

namespace TodosAppABP
{
    public class TodosAppABPConsts
    {
        public const string LocalizationSourceName = "TodosAppABP";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "2d774ebd2ca2463aa0c784f9bc5ac5ec";
    }
}
