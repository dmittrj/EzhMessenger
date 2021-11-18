using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CourseMessenger
{
    class MessangerClientAPI
    {
        private static readonly HttpClient client = new HttpClient();
        public void TestNewtonsoftJson()
        {
            Message msg = new Message("Dmitry", "Привет!", DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);
            Message dMsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(dMsg);
        }

        public Message GetMessage(int MessageId)
        {
            WebRequest request = WebRequest.Create("http://localhost:5000/api/Messanger/" + MessageId.ToString());
            request.Method = "Get";
            WebResponse response = request.GetResponse();
            string status = ((HttpWebResponse)response).StatusDescription;
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
            if ((status.ToLower() == "ok") && (responseFromServer != "Not found"))
            {
                Message deserializeMsg = JsonConvert.DeserializeObject<Message>(responseFromServer);
                return deserializeMsg;
            }
            return null;
        }

        public Message GetMessageRestSharp(int MessageId)
        {
            string ServiceUrl = "http://localhost:5000";
            var client = new RestClient(ServiceUrl);
            var request = new RestRequest("/api/Messanger/" + MessageId.ToString(), Method.GET);
            IRestResponse<Message> Response = client.Execute<Message>(request);
            string ResponseContent = Response.Content;
            Message deserializedMsg = JsonConvert.DeserializeObject<Message>(ResponseContent);
            return deserializedMsg;
        }

        //Получить список чатов
        public List<int> GetChats(string userName)
        {
            string ServiceUrl = "http://localhost:5000";
            var client = new RestClient(ServiceUrl);
            var request = new RestRequest("/api/Messanger/get/chats/" + userName, Method.GET);
            IRestResponse<List<int>> Response = client.Execute<List<int>>(request);
            string ResponseContent = Response.Content;
            ResponseContent = ResponseContent.Substring(1, ResponseContent.Length - 2);
            List<int> deserializedMsg = JsonConvert.DeserializeObject<List<int>>(ResponseContent);
            return deserializedMsg;
        }


        //Получить статус
        public DateTime GetOnline(string userName)
        {
            string ServiceUrl = "http://localhost:5000";
            var client = new RestClient(ServiceUrl);
            var request = new RestRequest("/api/Messanger/get/online/" + userName, Method.GET);
            IRestResponse<DateTime> Response = client.Execute<DateTime>(request);
            string ResponseContent = Response.Content;
            ResponseContent = ResponseContent.Substring(3, ResponseContent.Length - 6);
            DateTime deserializedMsg = JsonConvert.DeserializeObject<DateTime>(ResponseContent);
            return deserializedMsg;
        }


        //Получить инфу о чате
        public Chat GetAllAboutCha(int id)
        {
            string ServiceUrl = "http://localhost:5000";
            var client = new RestClient(ServiceUrl);
            var request = new RestRequest("/api/Messanger/chat/" + id.ToString(), Method.GET);
            IRestResponse<Chat> Response = client.Execute<Chat>(request);
            string ResponseContent = Response.Content;
            //ResponseContent = ResponseContent.Substring(1, ResponseContent.Length - 2);
            Chat deserializedMsg = JsonConvert.DeserializeObject<Chat>(ResponseContent);
            return deserializedMsg;
        }

        //public Message GetSigning(string UserNick)
        //{
        //    string ServiceUrl = "http://localhost:5000";
        //    var client = new RestClient(ServiceUrl);
        //    var request = new RestRequest("/api/Messanger/checksign/" + UserNick, Method.GET);
        //    IRestResponse<Message> Response = client.Execute<Message>(request);
        //    string ResponseContent = Response.Content;
        //    Message deserializedMsg = JsonConvert.DeserializeObject<Message>(ResponseContent);
        //    return deserializedMsg;
        //}

        //Отправить сообщение
        public bool SendMessageRestSharp(Message msg, int idC)
        {
            string ServiceUrl = "http://localhost:5000";
            var client = new RestClient(ServiceUrl);
            var request = new RestRequest("/api/Messanger/post/send/" + idC.ToString(), Method.POST);

            string jsonToSend = JsonConvert.SerializeObject(msg);
            request.AddParameter("application/json; charset=utf-8", jsonToSend, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;
            bool ExitIsTrue = false;
            try
            {
                client.ExecuteAsync(request, response =>
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        ExitIsTrue = true;
                    }
                    else
                    {
                        ExitIsTrue = false;
                    }
                });
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
            return ExitIsTrue;
        }

        //Создать новый чат
        public bool CreateNewChat(Chat chat)
        {
            string ServiceUrl = "http://localhost:5000";
            var client = new RestClient(ServiceUrl);
            var request = new RestRequest("/api/Messanger/post/createchat", Method.POST);

            string jsonToSend = JsonConvert.SerializeObject(chat);
            request.AddParameter("application/json; charset=utf-8", jsonToSend, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;
            bool ExitIsTrue = false;
            try
            {
                client.ExecuteAsync(request, response =>
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        ExitIsTrue = true;
                    }
                    else
                    {
                        ExitIsTrue = false;
                    }
                });
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
            return ExitIsTrue;
        }



        //Регистрация
        public async Task<string> SendForSignUp(LogPass lgp)
        {
            string ServiceUrl = "http://localhost:5000";
            var client = new RestClient(ServiceUrl);
            var request = new RestRequest("/api/Messanger/post/sign", Method.POST);
            //var resetEvent = new ManualResetEvent(false);

            string jsonToSend = JsonConvert.SerializeObject(lgp);
            request.AddParameter("application/json; charset=utf-8", jsonToSend, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;
            bool ExitIsTrue = false;
            string res = "ErrGet";
            try
            {
                var result = await client.ExecuteAsync<string>(request);
                return result.Content;
                //resetEvent.WaitOne();
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                return "ErrGet";
            }
            //return res;
        }

        //Вход
        public async Task<string> SendForLogIn(LogPass lgp)
        {
            string ServiceUrl = "http://localhost:5000";
            var client = new RestClient(ServiceUrl);
            var request = new RestRequest("/api/Messanger/post/log", Method.POST);
            //var resetEvent = new ManualResetEvent(false);

            string jsonToSend = JsonConvert.SerializeObject(lgp);
            request.AddParameter("application/json; charset=utf-8", jsonToSend, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;
            bool ExitIsTrue = false;
            string res = "ErrGet";
            try
            {
                var result = await client.ExecuteAsync<string>(request);
                return result.Content;
                //resetEvent.WaitOne();
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                return "ErrGet";
            }
            //return res;
        }
        
        
        public async Task<Message> GetMessageHTTPAsync(int MessageId)
        {
            var responseString = await client.GetStringAsync("http://localhost:5000/api/Messanger/" + MessageId.ToString());
            if (responseString != null)
            {
                Message deserializedMsg = JsonConvert.DeserializeObject<Message>(responseString);
                return deserializedMsg;
            }
            return null;
        }

        //Запросить сообщение из чата
        public async Task<Message> GetMessageChatHTTPAsync(int ChatId, int MessageId)
        {
            var responseString = await client.GetStringAsync("http://localhost:5000/api/Messanger/get/message/" + ChatId.ToString() + "/" + MessageId.ToString());
            if (responseString != null)
            {
                Message deserializedMsg = JsonConvert.DeserializeObject<Message>(responseString);
                return deserializedMsg;
            }
            return null;
        }







        //Получить чат по id
        public async Task<Chat> GetAllAboutChat(int id)
        {
            var responseString = await client.GetStringAsync("http://localhost:5000/api/Messanger/get/chat/" + id.ToString());
            if (responseString != null)
            {
                Chat deserializedMsg = JsonConvert.DeserializeObject<Chat>(responseString);
                return deserializedMsg;
            }
            return null;
        }











        public bool SendMessage(Message msg)
        {
            WebRequest request = WebRequest.Create("http://localhost:5000/api/Messanger");
            request.Method = "POST";
            string postData = JsonConvert.SerializeObject(msg);
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/json";
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            WebResponse response = request.GetResponse();
            dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
            return true;
        }

    }
}
