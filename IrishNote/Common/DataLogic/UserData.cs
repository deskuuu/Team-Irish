namespace Common.DataLogic
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;

    using Constants;

    public static class UserData
    {
        public static void AddUser(string username, string password)
        {
            var doc = XDocument.Load(AppConstants.UserLoginDataPath);
            doc.Document.Element(AppConstants.RootTag).Add(new XElement(
                                    new XElement(AppConstants.NodeTag,
                                       new XElement(AppConstants.UsernameTag, username),
                                       new XElement(AppConstants.PasswordTag, password))));

            doc.Save(AppConstants.UserLoginDataPath);
        }

        public static IDictionary<string, string> GetAllUsers()
        {
            var loginData = new Dictionary<string, string>();
            var data = XDocument.Load(AppConstants.UserLoginDataPath);

            var users = data.Root.Elements().Select(x => x.Element(AppConstants.UsernameTag)).ToList();
            var passwords = data.Root.Elements().Select(x => x.Element(AppConstants.PasswordTag)).ToList();
            var length = users.Count();

            for (int index = 0; index < length; index++)
            {
                loginData.Add($"{users[index].Value}", $"{passwords[index].Value}");
            }

            return loginData;
        }
    }
}
