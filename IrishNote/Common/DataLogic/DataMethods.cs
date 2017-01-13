namespace Common.DataLogic
{
    using System.Linq;

    public static class DataMethods
    {
        public static bool CheckLoginUsername(string username)
        {
            var data = UserData.GetAllUsers();
            var isRegistered = data.Where(x => x.Key == username).ToList().Count();

            return isRegistered != 0;
        }

        public static bool CheckLoginData(string username, string password)
        {
            var isCorrectData = 0;

            if (CheckLoginUsername(username))
            {
                var data = UserData.GetAllUsers();
                isCorrectData = data.Where(x => x.Value == password).ToList().Count();
            }

            return isCorrectData != 0;
        }
    }
}
