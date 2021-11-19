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
        static int lastChat = 1;
        static List<Member> flins = new List<Member>() { new Member("TheMainHedgehog", 2, true) };
        static List<Chat> ListOfChats = new List<Chat>() { new Chat(0, "Общий ёжечат", flins, false) };
        static List<Message> ListOfMessages = new List<Message>();
        static List<User> ListOfUsers = new List<User>();
        //static List<string> ListOfPasswords = new List<string>();

        // GET api/<MessangerController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    string OutputString = "Not found";
        //    if ((id < ListOfMessages.Count) && (id >= 0))
        //    {
        //        OutputString = JsonConvert.SerializeObject(ListOfMessages[id]);
        //    }
        //    Console.WriteLine(String.Format("Запрошено сообщение № {0} : {1}", id, OutputString));
        //    return OutputString;
        //}


        //Запрошено сообщение из чата
        [HttpGet("get/message/{idC}/{idM}")]
        public string GetMessage(int idC, int idM)
        {
            string OutputString = "Not found";
            if ((idM < ListOfChats[idC].ChatMsgs.Count) && (idM >= 0))
            {
                OutputString = JsonConvert.SerializeObject(ListOfChats[idC].ChatMsgs[idM]);
            }
            Console.WriteLine(String.Format("Запрошено сообщение № {1} из чата № {0} : {2}", idC, idM, OutputString));
            return OutputString;
        }

        //Запрошены чаты
        [HttpGet("get/chats/{nick}")]
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

        //Получить чат по id
        [HttpGet("get/chat/{id}")]
        public string GetChatInfo(int id)
        {
            string OutputString;
            OutputString = JsonConvert.SerializeObject(ListOfChats[id]);
            return OutputString;
        }


        //Получить статус онлайн
        [HttpGet("get/online/{nick}")]
        public string GetOnline(string nick)
        {
            string OutputString = "No info";
            for (int i = 0; i < ListOfUsers.Count; i++)
            {
                if (ListOfUsers[i].CompareName(nick))
                {
                    //OutputString = JsonConvert.SerializeObject(ListOfUsers[i].Status);
                    OutputString = ListOfUsers[i].Status.ToString("O");
                    Console.WriteLine("Выдано");
                    break;
                }
            }
            //OutputString = JsonConvert.SerializeObject(ListOfChats[id]);
            return OutputString;
        }


        // POST api/<MessangerController>

        //Регистрация
        [HttpPost("post/sign")]
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


        //Вход
        [HttpPost("post/log")]
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

        //Создание чата
        [HttpPost("post/createchat")]
        public IActionResult CreateChat([FromBody] Chat chat)
        {
            if (chat == null)
            {
                return BadRequest();
            }
            chat.IdChat = lastChat++;
            ListOfChats.Add(chat);
            Console.WriteLine(String.Format("Добавлен новый чат №{0}", lastChat - 1));
            int numberOfMembers = chat.ChatMmbrs.Count;
            for (int i = 0; i < numberOfMembers; i++)
            {
                for (int j = 0; j < ListOfUsers.Count; j++)
                {
                    if (ListOfUsers[j].CompareName(chat.ChatMmbrs[i].Nick))
                    {
                        Console.WriteLine("Пользователя " + chat.ChatMmbrs[i].Nick + " присоединили к новому чату");
                        ListOfUsers[j].Chats.Add(chat.IdChat);
                        break;
                    }
                }
            }
            return new OkResult();
        }


        //Получить отправленное сообщение
        [HttpPost("post/send/{idChat}")]
        public IActionResult SendMessage(int idChat, [FromBody] Message msg)
        {
            if (msg == null)
            {
                return BadRequest();
            }
            ListOfChats[idChat].ChatMsgs.Add(msg);
            Console.WriteLine(String.Format("Всего сообщений в чате № {2}: {0} Посланное сообщение: {1}", ListOfChats[idChat].ChatMsgs.Count, msg, idChat));
            return new OkResult();
        }



    }
}
