using CourseMessenger;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
        //static List<Message> ListOfMessages = new List<Message>();
        static List<User> ListOfUsers = new List<User>();

        public MessangerController()
        {
            try
            {
                ServInfo dsp = new ServInfo();
                FileStream fs = new FileStream("Info.data", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                BinaryReader reader = new BinaryReader(fs);
                string a = reader.ReadString();
                dsp = JsonConvert.DeserializeObject<ServInfo>(a);
                lastChat = dsp.LastChat;
                ListOfChats = dsp.Chats;
                ListOfUsers = dsp.Users;
                Console.WriteLine("Сервер восстановил данные с момента последнего закрытия");
                fs.Close();
            } catch
            {

            }

        }

        private static void SaveMe()
        {
            ServInfo sp = new ServInfo(ListOfUsers, ListOfChats, lastChat);
            FileStream fs = new FileStream("Info.data", FileMode.Create);
            //BinaryFormatter bf = new BinaryFormatter();
            BinaryWriter writer = new BinaryWriter(fs);
            writer.Write(JsonConvert.SerializeObject(sp));
            fs.Close();
        }

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
            if (id == -1)
            {
                for (int i = 0; i < ListOfUsers.Count; i++)
                    ListOfUsers[i].DeleteEmptyChats();
                return JsonConvert.SerializeObject(new Chat(-1, "", flins, false));
            }
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

        //Пользователь сообщает, что он в сети
        [HttpGet("get/me/online/{nick}")]
        public string MarkOnline(string nick)
        {
            string OutputString = "No info";
            for (int i = 0; i < ListOfUsers.Count; i++)
            {
                if (ListOfUsers[i].CompareName(nick))
                {
                    ListOfUsers[i].Status = DateTime.Now;
                    Console.WriteLine("Пользователь " + nick + " онлайн");
                    break;
                }
            }
            SaveMe();
            return OutputString;
        }





        //Кто-то покинул чат
        [HttpGet("get/leave/{nick}/{id}")]
        public string LeaveChat(string nick, int id)
        {
            string OutputString = "No info";
            Console.WriteLine("\nЕго песенка спета\nКолонки молчат\n" + nick + " сделал(а) больно\nИ покинул(а) чат\n");
            for (int i = 0; i < ListOfUsers.Count; i++)
            {
                if (ListOfUsers[i].CompareName(nick))
                {
                    //OutputString = JsonConvert.SerializeObject(ListOfUsers[i].Status);
                    //OutputString = ListOfUsers[i].Status.ToString("O");
                    for (int j = 0; j < ListOfUsers[i].Chats.Count; j++)
                        if (ListOfUsers[i].Chats[j] == id)
                            ListOfUsers[i].Chats.RemoveAt(j);
                    Console.WriteLine("Чат удалён из списка чатов пользователя");
                    break;
                }
                for (int j = 0; j < ListOfChats[id].ChatMmbrs.Count; j++)
                    if (ListOfChats[id].ChatMmbrs[j].Nick == nick)
                        ListOfChats[id].ChatMmbrs.RemoveAt(j);
                Console.WriteLine("Пользователь удалён из списка участников чата");
            }
            OutputString = "deleted";
            SaveMe();
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
            SaveMe();
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
            //int req = -1;
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
            //char toSend;
            SaveMe();
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
            SaveMe();
            return new OkResult();
        }

        //Приглашение в чат
        [HttpPost("post/invite")]
        public IActionResult Invite([FromBody] Chat chat)
        {
            if (chat == null)
            {
                return BadRequest();
            }
            //chat.IdChat = lastChat++;
            //ListOfChats.Add(chat);
            Console.WriteLine("Приглашение в чат...");
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
            SaveMe();
            return new OkResult();
        }


        //Событие
        [HttpPost("post/event/{idChat}")]
        public IActionResult SendEvent(int idChat, [FromBody] Event ev)
        {
            if (ev == null)
            {
                return BadRequest();
            }
            for (int i = 0; i < ListOfChats[idChat].ChatMmbrs.Count; i++)
                if (ListOfChats[idChat].ChatMmbrs[i].Nick == ev.E_Object)
                    switch (ev.Happening)
                    {
                        case 0:
                            ListOfChats[idChat].ChatMmbrs[i].Role = 2;
                            break;
                        case 1:
                        case 3:
                            ListOfChats[idChat].ChatMmbrs[i].Role = 1;
                            break;
                        case 2:
                        case 4:
                            ListOfChats[idChat].ChatMmbrs[i].Role = 0;
                            break;
                        case 5:
                            ListOfChats[idChat].ChatMmbrs.RemoveAt(i);
                            for (int j = 0; j < ListOfChats[idChat].ChatMmbrs.Count; j++)
                                if (ListOfChats[idChat].ChatMmbrs[j].Nick == ev.E_Object)
                                    ListOfChats[idChat].ChatMmbrs.RemoveAt(j);
                            break;
                        case 6:
                            ListOfChats[idChat].ChatMmbrs[i].Blocked = !ListOfChats[idChat].ChatMmbrs[i].Blocked;
                            Console.WriteLine("Участник чата №" + idChat.ToString() + " " + ListOfChats[idChat].ChatMmbrs[i].Nick + " заблокирован или разблокирован");
                            break;
                    }
            for (int j = 0; j < ListOfUsers.Count; j++)
                if (ListOfUsers[j].CompareName(ev.E_Object))
                    ListOfUsers[j].Chats.Add(-1);
            SaveMe();
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
            SaveMe();
            return new OkResult();
        }



    }
}
