namespace Common.DataLogic
{
    using System.IO;

    public static class SaveTxt
    {
        private static void CheckForExcist(string path)
        {
            FileStream checkFile;

            if (!File.Exists(path))
            {
                checkFile = File.Create(path);
                checkFile.Close();
            }
        }

        public static void Save(string path, string text)
        {
            CheckForExcist(path);

            using (var file = new StreamWriter(path, true))
            {
                file.WriteLine(text);
            }
        }

        public static void Read(string path)
        {
            CheckForExcist(path);

            var file = File.ReadAllLines(path);

            var title = file[0];
            var text = file[1];
            var createdDateTime = file[2];
        }
    }
}

