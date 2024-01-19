namespace UserLoginLib
{
    public class UserLogin
    {
        public string Login(string username, string password)
        {
            string result = "";
            if(username=="abc" && password == "abc@123")
            {
                result = "Login Successful";
            }
            else
            {
                result = "Login Failed";
            }
            return result;
        }
    }
}