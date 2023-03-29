using System;
using System.IO;

namespace Browser
{
    public static class Data
    {
        public static readonly string USER_PATH = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        public static readonly string DATA_PATH = Path.Combine(USER_PATH, "AppData", "Roaming", "WebBrowser");

        static Data()
        {
            Directory.CreateDirectory(DATA_PATH);
        }
    }
}
