using System;
using System.IO;
using System.Windows.Forms;

namespace Browser
{
    public static class History
    {
        private static readonly string FILE_NAME = "history";
        private static readonly string FILE_PATH = Path.Combine(Data.DATA_PATH, FILE_NAME);


        public static AutoCompleteStringCollection data;

        static History()
        {
            Directory.CreateDirectory(Data.DATA_PATH);
            Load();
        }

        private static void Load()
        {
            data = new AutoCompleteStringCollection();
            try
            {
                var file = new StreamReader(FILE_PATH);
                while (!file.EndOfStream)
                {
                    var line = file.ReadLine();
                    data.Add(line);
                }
                file.Close();
            }
            catch (Exception)
            {

            }
        }

        public static void Save(string data)
        {
            if (History.data.Contains(data)) return;
            History.data.Add(data);
            var file = new StreamWriter(FILE_PATH, true);
            file.WriteLine(data);
            file.Close();

        }
    }
}
