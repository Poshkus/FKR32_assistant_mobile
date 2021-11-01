namespace FKR32_assistant_mobile.Models
{
    internal class AuthService
    {
        private readonly string _loginName = "Pavel";

        private bool CheckLogin(string log)
        {
            bool result = false;
            if (log == _loginName)
                result = true;
            return result;
        }

        public string Authorization(string log)
        {
            string result;

            if (CheckLogin(log) == true)
                result = "Authorization completed";
            else
                result = "Authorization not completed";

            return result;
        }

    }
}
