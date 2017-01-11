namespace Common.IOFile
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;

    using Constants;

    public static class UserData
    {
        public static void CreateData(string username, string password)
        {
            var doc = XDocument.Load(AppConstants.UserLoginDataPath);
            doc.Document.Element(AppConstants.RootTag).Add(new XElement(
                                    new XElement(AppConstants.NodeTag,
                                       new XElement(AppConstants.usernameTag, username),
                                       new XElement(AppConstants.passwordTag, password))));

            doc.Save(AppConstants.UserLoginDataPath);
        }

        public static IDictionary<string, string> GetLoginData()
        {
            var loginData = new Dictionary<string, string>();
            var data = XDocument.Load(AppConstants.UserLoginDataPath);

            var users = data.Root.Elements().Select(x => x.Element(AppConstants.usernameTag)).ToList();
            var passwords = data.Root.Elements().Select(x => x.Element(AppConstants.passwordTag)).ToList();
            var length = users.Count();

            for (int index = 0; index < length; index++)
            {
                loginData.Add($"{users[index].Value}", $"{passwords[index].Value}");
            }

            return loginData;
        }
    }
}
