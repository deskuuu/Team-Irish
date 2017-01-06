namespace IrishNote.IOFile
{
    using System.IO;

    using Constants;
    using Contracts;

    public static class SaveData
    {
        public static void Save(IUser user)
        {
            var path = AppConstants.DatabasePath;
            FileStream checkFile;

            if (!File.Exists(path))
            {
                checkFile = File.Create(path);
                checkFile.Close();
            }
            else
            {
                var writer = new StreamWriter(path, true);

                using (writer)
                {
                    writer.Write(user.ToString());
                    writer.WriteLine(AppConstants.DataUserSeparator);
                }
            }
        }
    }
}
