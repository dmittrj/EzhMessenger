using CourseMessenger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClient
{
    
    public partial class FormMessanger : Form
    {
        private static List<int> MessageID = new List<int>();
        private static string UserName;
        private static MessangerClientAPI API = new MessangerClientAPI();
        private static bool hl = false;
        private static int shift = 0;
        private static string YourName = "";
        private List<Chat> myChats = new List<Chat>();
        private List<string> abonents = new List<string>();
        private List<string> msgs = new List<string>();
        private List<string> sups = new List<string>();
        private List<DateTime> dates = new List<DateTime>();

        public FormMessanger()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string UserName = UserNameTB.Text;
            string Message = MessageTB.Text;
            if ((UserName.Length > 1) && (Message.Length > 1))
            {
                CourseMessenger.Message msg = new CourseMessenger.Message(UserName, Message, DateTime.Now);
                API.SendMessageRestSharp(msg, chatsLB.SelectedIndex); 
                Error_label.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((!MessageTB.Focused) && (MessageTB.Text == ""))
            {
                MessageTB.ForeColor = Color.Gray;
                MessageTB.Text = "Введите ёжесообщение...";
                hl = false;
            }
            if (chatsLB.SelectedItem == null) return;
            var getMessage = new Func<Task>(async () =>
            {
                CourseMessenger.Message msg = await API.GetMessageChatHTTPAsync(myChats[chatsLB.SelectedIndex].IdChat, MessageID[chatsLB.SelectedIndex]);
                while (msg != null)
                {
                    //MessagesList.Items.Add(msg);
                    //CourseMessenger.Message tmpMsg = new CourseMessenger.Message(msg.UserName, msg.MessageText, msg.TimeStamp);
                    abonents.Add(msg.UserName);
                    msgs.Add(msg.MessageText);
                    dates.Add(msg.TimeStamp);
                    if (Regex.IsMatch(msg.MessageText, @"@everyone"))
                    {
                        msg.ClientNotify = "@everyone";
                        //sups.Add("@everyone");
                    }
                    else if (Regex.IsMatch(msg.MessageText, $@"@{YourName}"))
                    {
                        msg.ClientNotify = $@"@{YourName}";
                        //sups.Add($@"@{YourName}");
                    }
                    else msg.ClientNotify = "";
                    //sups.Add("");
                    MessageID[chatsLB.SelectedIndex]++;
                    myChats[chatsLB.SelectedIndex].ChatMsgs.Add(msg);
                    msg = await API.GetMessageChatHTTPAsync(myChats[chatsLB.SelectedIndex].IdChat, MessageID[chatsLB.SelectedIndex]);
                }
            });
            getMessage.Invoke();

            if (chatsLB.SelectedItem != null)
            if (MessageID[chatsLB.SelectedIndex] <= 4) FixScrollBar.Visible = false;
            else
            {
                FixScrollBar.Height = panel_messages.Height / (msgs.Count - 3);
                FixScrollBar.Location = new Point(FixScrollBar.Location.X, panel_messages.Height - (FixScrollBar.Height) * (shift + 1));
                FixScrollBar.Visible = true;
            }

            if (myChats[chatsLB.SelectedIndex].ChatMsgs.Count > 0)
            {
                nameMsg_1.Text = myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 1 - shift].UserName;
                textMsg_1.Text = myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 1 - shift].MessageText;
                notifyMsg_1.Location = new Point(nameMsg_1.Location.X + nameMsg_1.Width + 3, nameMsg_1.Location.Y);
                notifyMsg_1.Text = myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 1 - shift].ClientNotify;
                if (myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 1 - shift].TimeStamp.Date == DateTime.Today)
                timeMsg_1.Text = myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 1 - shift].TimeStamp.ToString("t");
                else timeMsg_1.Text = myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 1 - shift].TimeStamp.ToString("f");
                if (nameMsg_1.Text == YourName) nameMsg_1.ForeColor = Color.FromArgb(240, 220, 102);
                else nameMsg_1.ForeColor = Color.FromArgb(255, 255, 255);
                panelMsg_1.Visible = true;
            }
            else panelMsg_1.Visible = false;
            if (myChats[chatsLB.SelectedIndex].ChatMsgs.Count > 1)
            {
                nameMsg_2.Text = myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 2 - shift].UserName;
                textMsg_2.Text = myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 2 - shift].MessageText;
                notifyMsg_2.Location = new Point(nameMsg_2.Location.X + nameMsg_2.Width + 3, nameMsg_2.Location.Y);
                notifyMsg_2.Text = myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 2 - shift].ClientNotify;
                if (myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 2 - shift].TimeStamp.Date == DateTime.Today)
                    timeMsg_2.Text = myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 2 - shift].TimeStamp.ToString("t");
                else timeMsg_2.Text = myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 2 - shift].TimeStamp.ToString("f");
                if (nameMsg_2.Text == YourName) nameMsg_2.ForeColor = Color.FromArgb(240, 220, 102);
                else nameMsg_2.ForeColor = Color.FromArgb(255, 255, 255);
                panelMsg_2.Visible = true;
            }
            else panelMsg_2.Visible = false;
            if (myChats[chatsLB.SelectedIndex].ChatMsgs.Count > 2)
            {
                nameMsg_3.Text = myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 3 - shift].UserName;
                textMsg_3.Text = myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 3 - shift].MessageText;
                notifyMsg_3.Location = new Point(nameMsg_3.Location.X + nameMsg_3.Width + 3, nameMsg_3.Location.Y);
                notifyMsg_3.Text = myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 3 - shift].ClientNotify;
                if (myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 3 - shift].TimeStamp.Date == DateTime.Today)
                    timeMsg_3.Text = myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 3 - shift].TimeStamp.ToString("t");
                else timeMsg_3.Text = myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 3 - shift].TimeStamp.ToString("f");
                if (nameMsg_3.Text == YourName) nameMsg_3.ForeColor = Color.FromArgb(240, 220, 102);
                else nameMsg_3.ForeColor = Color.FromArgb(255, 255, 255);
                panelMsg_3.Visible = true;
            }
            else panelMsg_3.Visible = false;
            if (myChats[chatsLB.SelectedIndex].ChatMsgs.Count > 3)
            {
                nameMsg_4.Text = myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 4 - shift].UserName;
                textMsg_4.Text = myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 4 - shift].MessageText;
                notifyMsg_4.Location = new Point(nameMsg_4.Location.X + nameMsg_4.Width + 3, nameMsg_4.Location.Y);
                notifyMsg_4.Text = myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 4 - shift].ClientNotify;
                if (myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 4 - shift].TimeStamp.Date == DateTime.Today)
                    timeMsg_4.Text = myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 4 - shift].TimeStamp.ToString("t");
                else timeMsg_4.Text = myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 4 - shift].TimeStamp.ToString("f");
                if (nameMsg_4.Text == YourName) nameMsg_4.ForeColor = Color.FromArgb(240, 220, 102);
                else nameMsg_4.ForeColor = Color.FromArgb(255, 255, 255);
                panelMsg_4.Visible = true;
            }
            else panelMsg_4.Visible = false;
            if (chatsLB.SelectedItem != null)
            if (MessageID[chatsLB.SelectedIndex] == 0) panel_emptyChat.Visible = true; 
            else panel_emptyChat.Visible = false;
        }

        private void MessagesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SendButt_Click(object sender, EventArgs e)
        {
            if (SendButt.Text == "Прикрепить")
            {
                MessageBox.Show("Пока нельзя прикреплять :(",
                "Ой",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
            } 
            else
            {
                string UserName = YourName;
                string Message = MessageTB.Text;
                if (chatsLB.SelectedItem == null)
                {
                    MessageBox.Show("Вы не выбрали чат для отправки. Выберите его в левом меню",
                        "Ёжесообщение хотело уйти без ёжечата",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                if ((UserName.Length > 0) && (Message.Length > 0))
                {
                    if (myChats[chatsLB.SelectedIndex].Secret)
                        UserName = "Ёжик";
                    CourseMessenger.Message msg = new CourseMessenger.Message(UserName, Message, DateTime.Now);
                    API.SendMessageRestSharp(msg, chatsLB.SelectedIndex);
                    MessageTB.Text = "";
                }
                label_notify1.Visible = false;
                label_notify2.Visible = false;
                label_notify3.Visible = false;
                label_notify4.Visible = false;
                label_notifymore.Visible = false;
                timer1.Interval = 300;
                timerFastUpdate.Start();
            }
        }

        private void EnterMessage_label_Click(object sender, EventArgs e)
        {
            //EnterMessage_label.Visible = false;
            MessageTB.Width = 5;
            MessageTB.Visible = true;
            MessageTB.Focus();
            timer_wighter.Start();
        }

        private void timer_wighter_Tick(object sender, EventArgs e)
        {
            if (MessageTB.Width < 532)
            {
                MessageTB.Width += 15;
            } else
            {
                timer_wighter.Stop();
                MessageTB.Width = 547;
            }
        }

        private void MessageTB_Click(object sender, EventArgs e)
        {
            if (hl)
            {

            } else
            {
                hl = true;
                MessageTB.Text = "";
                MessageTB.ForeColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void MessageTB_TextChanged(object sender, EventArgs e)
        {
            if (MessageTB.Text.Length == 0)
            {
                SendButt.Text = "Прикрепить";
            } 
            else
            {
                SendButt.Text = "Отправить";
                if (Regex.IsMatch(MessageTB.Text, @".{0,}[@]\w{1,}\s{1,}")) {
                    //label_notify.Text = Regex.Matches(MessageTB.Text, @"[@]\w{1,}\s{1,}").ToString();
                    MatchCollection notifies;
                    notifies = Regex.Matches(MessageTB.Text, @"[@]\w{1,}\s{1,}");
                    Label[] not = { label_notify1, label_notify2, label_notify3, label_notify4, label_notifymore };
                    for (int i = 0; i < 5; i++)
                    {
                        if (notifies.Count > i)
                        {
                            if (i != 4) not[i].Text = notifies[i].ToString(); 
                            else not[i].Text = "и ещё " + (notifies.Count - 4);
                            if (i > 0) not[i].Location = new Point(not[i - 1].Location.X + not[i - 1].Width + 7, not[i].Location.Y);
                            not[i].Visible = true;
                        } else
                        {
                            not[i].Visible = false;
                        }
                        
                    }
                    label_notify1.Visible = true;
                    //MessageTB.Text = Regex.Replace(MessageTB.Text, @"[@]\w{1,}\s{1,}", "");
                } else
                {
                    label_notify1.Visible = false;
                    label_notify2.Visible = false;
                    label_notify3.Visible = false;
                    label_notify4.Visible = false;
                }
            }
        }

        private void timerChangeColor_tick(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_messages_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void panel_messages_MouseEnter(object sender, EventArgs e)
        {
            panel_messages.Focus();
        }

        private void panel_messages_MouseLeave(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void panel_messages_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                if (abonents.Count - 5 - shift >= 0) shift++;
            } else
            {
                if (shift - 1 >= 0) shift--;
            }
            timer1_Tick(this, null);
        }

        private void UserNameTB_TextChanged(object sender, EventArgs e)
        {
            //YourName = UserNameTB.Text;
        }

        private void CreateChat_butt_Click(object sender, EventArgs e)
        {
            panelCreateChat.Visible = true;
            head_lbl.Text = "Создание ёжечата";
        }

        private void deleteChat_context_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нельзя удалить ОБЩИЙ ЁЖЕЧАТ",
                "Ошибка удаления чата",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
        }

        private void ShowPassword_CB_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword_CB.Checked) LogPass_TB.PasswordChar = '\0';
            else LogPass_TB.PasswordChar = '*';
        }

        private async void LogIn_Butt_Click(object sender, EventArgs e)
        {
            YourName = LogInNick_TB.Text;
            YourName = YourName.Remove(0, 1);
            if ((YourName.Length > 0))
            {
                string result;
                CourseMessenger.LogPass lp = new CourseMessenger.LogPass(YourName, LogPass_TB.Text.GetHashCode());
                result = await API.SendForLogIn(lp);
                if (result == "\"ok\"")
                {
                    //Успешно вошли в аккаунт
                    YourName = lp.Login;
                    panel_registration.Visible = false;
                    chatsLB.Items.Clear();
                    List<int> tmp = API.GetChats(YourName);
                    for (int i = 0; i < tmp.Count; i++)
                    {
                        Chat tmpChat = await API.GetAllAboutChat(tmp[i]);
                        myChats.Add(tmpChat);
                        MessageID.Add(tmpChat.ChatMsgs.Count);
                        chatsLB.Items.Add(tmpChat.ChatName);
                    }
                    
                    head_lbl.Text = "Ёжечаты";
                }
                else if (result == "\"ErrPass\"")
                {
                    LogUserPass_label.Text = "Неверный пароль";
                    LogUserPass_label.Visible = true;
                }
                else if (result == "\"ErrLog\"")
                {
                    LogUserPass_label.Text = "Неизвестный пользователь";
                    LogUserPass_label.Visible = true;
                }
                MessageTB.Text = "";
            }
            timer1.Start();
            timerChats.Start();
        }

        private void LogInNick_TB_TextChanged(object sender, EventArgs e)
        {
            if (LogInNick_TB.Text.Length > 0) if (LogInNick_TB.Text[0] != '@') LogInNick_TB.Text = "@" + LogInNick_TB.Text;
        }

        private async void SignUp_Butt_Click(object sender, EventArgs e)
        {
            YourName = LogInNick_TB.Text;
            YourName = YourName.Remove(0, 1);
            if ((YourName.Length > 0))
            {
                string result;
                CourseMessenger.LogPass lp = new CourseMessenger.LogPass(YourName, LogPass_TB.Text.GetHashCode());
                result = await API.SendForSignUp(lp);
                if (result == "\"ok\"")
                {
                    LogIn_Butt_Click(sender, e);
                } 
                else if (result == "\"ErrReg\"")
                {
                    LogUserName_label.Text = "Это имя пользователя уже занято";
                    LogUserName_label.Visible = true;
                }
                else if (result == "\"ErrWR\"")
                {
                    LogUserName_label.Text = "Нельзя использовать имя @everyone";
                    LogUserName_label.Visible = true;
                }
                MessageTB.Text = "";
            }
        }

        private void panel_registr_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_registr_Click(object sender, EventArgs e)
        {
            //panel_registr.Visible = false;
        }

        private void MembList_CM_Opening(object sender, CancelEventArgs e)
        {
            if (Members_LB.SelectedItem == null)
            {
                MemberName_CMP.Text = "Участник не выделен";
                MembList_CM.Close();
                return;
            }
            else
            {
                MemberStatus_CMP.Visible = false;
                //string stat;
                //myChats[chatsLB.SelectedIndex].ChatMmbrs[Members_LB.SelectedIndex].
                MemberName_CMP.Text = "@" + Members_LB.SelectedItem.ToString();
            }
            int i;
            for (i = 0; i < myChats[chatsLB.SelectedIndex].ChatMmbrs.Count; i++)
            {
                if (myChats[chatsLB.SelectedIndex].ChatMmbrs[i].Nick == YourName) break;
            }

            switch (myChats[chatsLB.SelectedIndex].ChatMmbrs[i].Role)
            {
                case 0:
                    BlockUser_CMP.Visible = false;
                    AwayUser_CMP.Visible = false;
                    MakeAdmin_CMP.Visible = false;
                    break;
                case 1:
                    BlockUser_CMP.Visible = true;
                    AwayUser_CMP.Visible = false;
                    if (myChats[chatsLB.SelectedIndex].ChatMmbrs[Members_LB.SelectedIndex].Role == 1)
                    MakeAdmin_CMP.Visible = true; else MakeAdmin_CMP.Visible = false;
                    if (myChats[chatsLB.SelectedIndex].ChatMmbrs[Members_LB.SelectedIndex].Role == 1)
                    {
                        DemoteModer_CMP.Visible = true;
                        DemoteMemb_CMP.Visible = true;
                    }
                    else DemoteModer_CMP.Visible = false; 
                    break;
                case 2:
                    BlockUser_CMP.Visible = true;
                    AwayUser_CMP.Visible = true;
                    if (myChats[chatsLB.SelectedIndex].ChatMmbrs[Members_LB.SelectedIndex].Role == 1)
                        MakeAdmin_CMP.Visible = true;
                    else MakeAdmin_CMP.Visible = false;
                    if (myChats[chatsLB.SelectedIndex].ChatMmbrs[Members_LB.SelectedIndex].Role == 1)
                    {
                        DemoteModer_CMP.Visible = true;
                        DemoteMemb_CMP.Visible = true;
                    }
                    break;
            }
            DateTime wasOnline;
            wasOnline = API.GetOnline(Members_LB.SelectedItem.ToString());
            if (wasOnline == DateTime.Now)
            {
                MemberStatus_CMP.Text = "онлайн";
            } else if (wasOnline.Date == DateTime.Now.Date)
            {
                MemberStatus_CMP.Text = "был в сети сегодня в " + wasOnline.ToString("t");
            }
            else
            {
                MemberStatus_CMP.Text = "был в сети " + wasOnline.ToString("M") + " в " + wasOnline.ToString("t");
            }
            MemberStatus_CMP.Visible = true;
        }

        private void notify_CMP_Click(object sender, EventArgs e)
        {
            if (hl)
            {
                MessageTB.Text = "@" + Members_LB.SelectedItem.ToString() + " " + MessageTB.Text;
            }
            else
            {
                hl = true;
                MessageTB.Text = "@" + Members_LB.SelectedItem.ToString() + " ";
                MessageTB.ForeColor = Color.FromArgb(255, 255, 255);
            }
            PanelChatMembers.Visible = false;
        }

        private void ConfirmCreateChat_Butt_Click(object sender, EventArgs e)
        {
            panelCreateChat.Visible = false;
            List<Member> tmpMember = new List<Member>();
            tmpMember.Add(new Member(YourName, 2, false));
            string[] spls = ChatMembersTB.Text.Split(' ');
            foreach (string tempMemb in spls)
            {
                string coolstr = tempMemb;
                if (tempMemb != "") if (tempMemb[0] == '@') coolstr = tempMemb.Substring(1, tempMemb.Length - 1);
                tmpMember.Add(new Member(coolstr, 0, false));
            }
            Chat tmpChat = new Chat(0, ChatNameTB.Text, tmpMember, SecretChat_CB.Checked);
            API.CreateNewChat(tmpChat);
            ChatNameTB.Text = "";
            ChatMembersTB.Text = "";
            SecretChat_CB.Checked = false;
            head_lbl.Text = "Ёжечаты";
        }

        private void ChatListCM_Opening(object sender, CancelEventArgs e)
        {
            if (chatsLB.SelectedItem == null) ChatListCM.Close();
            else
            {
                ChatNameCMP.Text = chatsLB.SelectedItem.ToString();
            }
        }

        private void ChatMembers_CMP_Click(object sender, EventArgs e)
        {
            Members_LB.Items.Clear();
            int j = myChats[chatsLB.SelectedIndex].ChatMmbrs.Count;
            for (int i = 0; i < j; i++)
            {
                Members_LB.Items.Add(myChats[chatsLB.SelectedIndex].ChatMmbrs[i].Nick);
            }
            PanelChatMembers.Location = new Point(PanelChatMembers.Location.X, chatsLB.Location.Y + chatsLB.SelectedIndex * chatsLB.ItemHeight);
            PanelChatMembers.Visible = true;
        }

        private async void timerChats_Tick(object sender, EventArgs e)
        {
            
            List<int> tmp = API.GetChats(YourName);
            if (tmp.Count != chatsLB.Items.Count)
            {
                chatsLB.Items.Clear();
                myChats.Clear();
                MessageID.Clear();
                for (int i = 0; i < tmp.Count; i++)
                {
                    Chat tmpChat = await API.GetAllAboutChat(tmp[i]);
                    myChats.Add(tmpChat);
                    MessageID.Add(tmpChat.ChatMsgs.Count);
                    chatsLB.Items.Add(tmpChat.ChatName);
                }
            }
        }

        private void LeaveChat_CMP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите покинуть чат \"" + chatsLB.SelectedItem.ToString() + "\"? Вернуться в этот чат вы сможете только по приглашению другого участника чата",
                "Покинуть ёжечат",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                API.LeaveChat(YourName, myChats[chatsLB.SelectedIndex].IdChat);
            }
        }

        private void ChatRolesLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChatRolesLB_DrawItem(object sender, DrawItemEventArgs e)
        {
            this.Text += "a";
            //ChatRolesLB.TopIndex
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void ChatRolesLB_MouseDown(object sender, MouseEventArgs e)
        {
            this.Text += "a";
        }

        private void ChatRolesLB_MouseMove(object sender, MouseEventArgs e)
        {
            //int visibleItems = ChatRolesLB.ClientSize.Height / ChatRolesLB.ItemHeight;
            //Members_LB.TopIndex = Math.Max(ChatRolesLB.Items.Count - visibleItems + 1, 0);
        }

        private void chatsLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CloseMembersButt_Click(object sender, EventArgs e)
        {
            PanelChatMembers.Visible = false;
        }

        private void timerFastUpdate_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timerFastUpdate.Stop();
        }

        private void LogOut_Butt_Click(object sender, EventArgs e)
        {
            timerFastUpdate.Stop();
            timer1.Stop();
            timerChats.Stop();
            LogInNick_TB.Text = "";
            LogPass_TB.Text = "";
            panel_registration.Visible = true;
        }

        private void CreateChat_CMP_Click(object sender, EventArgs e)
        {
            SecretChat_CB.Checked = false;
            CreateChat_butt_Click(sender, e);
        }

        private void CreateSecret_CMP_Click(object sender, EventArgs e)
        {
            SecretChat_CB.Checked = true;
            CreateChat_butt_Click(sender, e);
        }

        private void InviteChat_CMP_Click(object sender, EventArgs e)
        {
            int j = myChats[chatsLB.SelectedIndex].ChatMmbrs.Count;
            for (int i = 0; i < j; i++)
            {
                Members_LB.Items.Add(myChats[chatsLB.SelectedIndex].ChatMmbrs[i].Nick);
            }
            panel_invite.Location = new Point(panel_invite.Location.X, chatsLB.Location.Y + chatsLB.SelectedIndex * chatsLB.ItemHeight);
            panel_invite.Visible = true;
        }
    }

  
}
