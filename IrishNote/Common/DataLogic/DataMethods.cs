namespace Common.DataLogic
{
    using System.Linq;

    public static class DataMethods
    {
        public static bool CheckLoginData(string userName, string password = null)
        {
            var data = UserData.GetAllUsers();

            var isRegistered = data.Where(x => x.Key == userName).ToList();

            if (isRegistered.Count == 0)
            {
                return false;
            }
            else
            {
                var isCorrectData = data.Where(x => x.Value == password).ToList();

                return isCorrectData.Count != 0 ? true : false;
            }
        }
    }
}
