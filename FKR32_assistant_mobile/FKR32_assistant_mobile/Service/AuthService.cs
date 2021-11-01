namespace FKR32_assistant_mobile.Service
{
    public class AuthService
    {
        private readonly string _loginName = "Pavel";

        public bool CheckLogin(string login)
        {
            bool result = false;
            
            if (login == _loginName)
            {
                result = true;
            }

            return result;
        }

        public string Authorization(string login)
        {
            string result;

            if (CheckLogin(login))
                result = "Authorization completed";
            else
                result = "Authorization not completed";

            return result;
        }

    }
}
