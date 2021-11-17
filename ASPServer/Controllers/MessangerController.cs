using CourseMessenger;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessangerController : ControllerBase
    {
        static List<Member> flins = new List<Member>() { new Member("TheMainHedgehog", 2, true) };
        static List<Chat> ListOfChats = new List<Chat>() { new Chat(0, "Общий ёжечат", flins, false) };
        static List<Message> ListOfMessages = new List<Message>();
        static List<User> ListOfUsers = new List<User>();
        //static List<string> ListOfPasswords = new List<string>();
        // GET api/<MessangerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            string OutputString = "Not found";
            if ((id < ListOfMessages.Count) && (id >= 0))
            {
                OutputString = JsonConvert.SerializeObject(ListOfMessages[id]);
            }
            Console.WriteLine(String.Format("Запрошено сообщение № {0} : {1}", id, OutputString));
            return OutputString;
        }

        [HttpGet("chats/{nick}")]
        public string CheckSign(string nick)
        {
            Console.WriteLine("Пользователь " + nick + " запросил доступ к своим чатам");
            string OutputString = "Not found";
            for (int i = 0; i < ListOfUsers.Count; i++)
            {
                if (ListOfUsers[i].CompareName(nick))
                {
                    OutputString = JsonConvert.SerializeObject(ListOfUsers[i].Chats);
                    Console.WriteLine("Выдано");
                    break;
                }
            }
            return OutputString;
        }

        [HttpGet("chat/{id}")]
        public string GetChatInfo(int id)
        {
            string OutputString;
            OutputString = JsonConvert.SerializeObject(ListOfChats[id]);
            return OutputString;
        }


        // POST api/<MessangerController>

        [HttpPost("sign")]
        public string SendSigningUp([FromBody] LogPass lgp)
        {
            if (lgp == null)
            {
                return "Err400";
            }
            Console.WriteLine(String.Format("На регистрацию принят логин: {0} и пароль: {1}", lgp.Login, lgp.HashPass));
            if (lgp.Login == "everyone")
            {
                Console.WriteLine("Отказано в регистрации. Служебное имя");
                return "ErrWR";
            }
            for (int i = 0; i < ListOfUsers.Count; i++)
            {
                if (ListOfUsers[i].CompareName(lgp.Login))
                {
                    Console.WriteLine("Отказано в регистрации. Существующий пользователь");
                    return "ErrReg";
                }
            }
            User user = new User(lgp.Login, lgp.HashPass); 
            ListOfUsers.Add(user);
            ListOfChats[0].ChatMmbrs.Add(new Member(user.Nickname, 0, false));
            Console.WriteLine("Зарегистрирован");
            return "ok";
        }

        [HttpPost("log")]
        public string SendLoggingIn([FromBody] LogPass lgp)
        {
            if (lgp == null)
            {
                return "Err400";
            }
            int req = -1;
            int i;
            Console.WriteLine(String.Format("Пользователь, логин: {0}, пароль: {1}, пытается войти", lgp.Login, lgp.HashPass));
            for (i = 0; i < ListOfUsers.Count; i++)
            {
                if (ListOfUsers[i].CompareName(lgp.Login))
                {
                    if (ListOfUsers[i].Password == lgp.HashPass)
                    {
                        Console.WriteLine("Вход разрешён");
                        return "ok";
                    }
                    else
                    {
                        Console.WriteLine("Вход не разрешён");
                        return "ErrPass";
                    }
                }
            }
            char toSend;
            return "ErrLog";
        }


        [HttpPost]
        public IActionResult SendMessage([FromBody] Message msg)
        {
            if (msg == null)
            {
                return BadRequest();
            }
            ListOfMessages.Add(msg);
            Console.WriteLine(String.Format("Всего сообщений: {0} Посланное сообщение: {1}", ListOfMessages.Count, msg));
            return new OkResult();
        }



    }
}
