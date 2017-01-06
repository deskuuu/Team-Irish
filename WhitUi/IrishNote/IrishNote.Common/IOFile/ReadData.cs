namespace IrishNote.IOFile
{
    using System.Collections.Generic;
    using System.IO;

    using Constants;

    /// <summary>
    /// Read user data and return it in dictionary.
    /// </summary>
    public static class ReadData
    {
        private const int MaxWordsInLine = 3;
        private const char SeparatorNames = ' ';

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

                        // Check if the user has two names, because User.ToString() return lline with GetUserFullName().
                        if (userData.Length == MaxWordsInLine)
                        {
                            data.Add(userData[MaxWordsInLine - 3], userData[MaxWordsInLine - 2] + SeparatorNames + userData[MaxWordsInLine]);
                        }
                        else
                        {
                            data.Add(userData[MaxWordsInLine - 3], userData[MaxWordsInLine - 2]);
                        }
                    }
                }
            }

            return data;
        }
    }
}
