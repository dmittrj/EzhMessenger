using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseMessenger
{
    [Serializable]
    public class LogPass
    {
        public string Login { get; set; }
        public int HashPass { get; set; }
        public LogPass(string login, int hashPass)
        {
            Login = login;
            HashPass = hashPass;
        }

        public LogPass()
        {
            Login = "User";
            HashPass = 1234;
        }

        public override string ToString()
        {
            string output = String.Format("Попытка зарегистрировать нового пользователя {0} с хэш-паролем {1}", Login, HashPass);
            return output;
        }
    }
}
