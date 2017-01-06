namespace IrishNote.IOFile
{
    using System.Collections.Generic;
    using System.IO;

    using Constants;

    public static class ReadData
    {
        public static IDictionary<string, string> GetData()
        {
            var data = new Dictionary<string, string>();
            var path = AppConstants.DatabasePath;
            FileStream checkFile;

            if (!File.Exists(path))
            {
                checkFile = File.Create(path);
                checkFile.Close();
            }
            else
            {
                using (var reader = new StreamReader(path))
                {
                    string line;

                    while (!(line = reader.ReadLine()).Contains(AppConstants.DataUserSeparator))
                    {
                        var userData = line.Split(AppConstants.LineSplitChar);
                        if (userData.Length == 3)
                        {
                            data.Add(userData[0], userData[1] + ' ' + userData[2]);
                        }
                        else
                        {
                            data.Add(userData[0], userData[1]);
                        }
                    }
                }
            }

            return data;
        }
    }
}
