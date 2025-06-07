namespace TestMyApp.WebApp
{
    public class LoginHelper
    {
        public bool ValidateLogin(string email, string password)
        {
            // Hardcoded credentials for now
            return email == "admin@test.com" && password == "Pass123";
        }
    }
}
