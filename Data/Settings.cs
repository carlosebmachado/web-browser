using System.IO;
using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace Browser
{
    public class Settings
    {
        private static readonly string FILE_NAME = "settings";
        private static readonly string FILE_PATH = Path.Combine(Data.DATA_PATH, FILE_NAME);

        public static readonly string KEY_HOME_PAGE_URL = "HomePageURL";
        public static readonly string KEY_SEARCH_ENGINE_URL = "SearchEngineURL";

        private static readonly char SEP_CHAR = '=';

        public static Dictionary<string, string> data;

        static Settings()
        {
            Directory.CreateDirectory(Data.DATA_PATH);
            Load();
        }

        private static void Load()
        {
            data = new Dictionary<string, string>();
            try
            {
                var file = new StreamReader(FILE_PATH);
                while (!file.EndOfStream)
                {
                    var line = file.ReadLine();
                    var lineAux = line.Split(new char[] { SEP_CHAR }, 2);
                    data.Add(lineAux[0], lineAux[1]);
                }
                file.Close();
            }
            catch (Exception) { }

            if (!data.ContainsKey(KEY_SEARCH_ENGINE_URL))
            {
                data.Add(KEY_HOME_PAGE_URL, "duckduckgo.com");
            }
            if (!data.ContainsKey(KEY_SEARCH_ENGINE_URL))
            {
                data.Add(KEY_SEARCH_ENGINE_URL, "duckduckgo.com/?q=");
            }
        }

        public static void Set(string key, string value)
        {
            data[key] = value;
            Save();
        }

        private static void Save()
        {
            try
            {
                var file = new StreamWriter(FILE_PATH, false);
                foreach (var setting in data)
                {
                    file.WriteLine(setting.Key + SEP_CHAR + setting.Value);
                }
                file.Close();
            }
            catch (Exception) { }
        }
    }
}
