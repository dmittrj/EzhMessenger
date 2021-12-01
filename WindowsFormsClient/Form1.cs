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
        //private static string UserName;
        private static MessangerClientAPI API = new MessangerClientAPI();
        private static bool hl = false;
        private static int shift = 0;
        private static string YourName = "";
        private List<Chat> myChats = new List<Chat>();
        //private List<DateTime> dates = new List<DateTime>();
        int wx = 0, wy = 0; bool cursh = false;

        /// <summary>
        /// This function creates a "microwindow" that has been repesented with Panel
        /// </summary>
        /// <param name="obj">The panel to be unfold</param>
        /// <param name="y_start">Y start position</param>
        /// <param name="y_finish">Y finish position</param>
        /// <param name="h_start">Initial height</param>
        /// <param name="h_finish">Final height</param>
        /// <param name="speed">Relative speed</param>
        /// <param name="freeze">If true, all the other elements of window will be unenabled</param>
        public async void Unfold(Panel obj, int y_start, int y_finish, int h_start, int h_finish, int speed, bool freeze)
        {
            int y_speed = (y_finish - y_start) / speed;
            int h_speed = (h_finish - h_start) / speed;
            obj.Visible = false;
            obj.Height = h_start;
            obj.Location = new Point(obj.Location.X, y_start);
            obj.Visible = true;
            if (freeze)
            {
                CreateChat_butt.Enabled = false;
                SendButt.Enabled = false;
                chatsLB.Enabled = false;
                MessageTB.Enabled = false;
                CreateChat_butt.Cursor = Cursors.Default;
                SendButt.Cursor = Cursors.Default;
                PictureTriangle.Visible = false;
            }
            for (int ani_y = y_start, ani_h = h_start; (ani_y < y_finish || ani_h < h_finish); ani_y += y_speed, ani_h += h_speed, await Task.Delay(10))
            {
                obj.Height = ani_h;
                obj.Location = new Point(obj.Location.X, ani_y);
                if (freeze)
                {
                    MessageTB.BackColor = this.BackColor = Color.FromArgb(this.BackColor.R + 1, this.BackColor.G + 1, this.BackColor.B + 1);
                    CreateChat_butt.ForeColor = SendButt.ForeColor = head_lbl.ForeColor = Color.FromArgb(head_lbl.ForeColor.R - 2, head_lbl.ForeColor.G - 2, head_lbl.ForeColor.B - 2);
                    panel_emptyChat.BackColor = Color.FromArgb(panel_emptyChat.BackColor.R + 1, panel_emptyChat.BackColor.G + 1, panel_emptyChat.BackColor.B + 1);
                    panel_messages.BackColor = Color.FromArgb(panel_messages.BackColor.R + 1, panel_messages.BackColor.G + 1, panel_messages.BackColor.B + 1);

                    chatsLB.BackColor = Color.FromArgb(chatsLB.BackColor.R + 1, chatsLB.BackColor.G + 1, chatsLB.BackColor.B + 1);
                }
            }
            obj.Height = h_finish;
            obj.Location = new Point(obj.Location.X, y_finish);
        }

        public async void Fold(Panel obj, int y_start, int y_finish, int h_start, int h_finish, int speed, bool freeze)
        {
            int y_speed = (y_finish - y_start) / speed;
            int h_speed = (h_finish - h_start) / speed;
            if (freeze)
            {
                CreateChat_butt.Enabled = true;
                SendButt.Enabled = true;
                chatsLB.Enabled = true;
                MessageTB.Enabled = true;
                CreateChat_butt.Cursor = Cursors.Hand;
                SendButt.Cursor = Cursors.Hand;
                PictureTriangle.Visible = true;
            }
            for (int ani_y = y_finish, ani_h = h_finish; (ani_y > y_start || ani_h > h_start); ani_y -= y_speed, ani_h -= h_speed, await Task.Delay(10))
            {
                obj.Height = ani_h;
                obj.Location = new Point(obj.Location.X, ani_y);
                if (freeze)
                {
                    MessageTB.BackColor = this.BackColor = Color.FromArgb(this.BackColor.R - 1, this.BackColor.G - 1, this.BackColor.B - 1);
                    if (SendButt.ForeColor.R < 254)
                        CreateChat_butt.ForeColor = SendButt.ForeColor = head_lbl.ForeColor = Color.FromArgb(head_lbl.ForeColor.R + 2, head_lbl.ForeColor.G + 2, head_lbl.ForeColor.B + 2);

                    panel_emptyChat.BackColor = Color.FromArgb(panel_emptyChat.BackColor.R - 1, panel_emptyChat.BackColor.G - 1, panel_emptyChat.BackColor.B - 1);
                    panel_messages.BackColor = Color.FromArgb(panel_messages.BackColor.R - 1, panel_messages.BackColor.G - 1, panel_messages.BackColor.B - 1);

                    chatsLB.BackColor = Color.FromArgb(chatsLB.BackColor.R - 1, chatsLB.BackColor.G - 1, chatsLB.BackColor.B - 1);
                }
            }
            obj.Visible = false;

            
            panel_emptyChat.BackColor = panel_messages.BackColor = this.BackColor = Color.FromArgb(35, 35, 35);
            MessageTB.BackColor = Color.FromArgb(35, 35, 35);
            chatsLB.BackColor = Color.FromArgb(18, 18, 18);
            CreateChat_butt.ForeColor = SendButt.ForeColor = head_lbl.ForeColor = Color.White;
        }

        public FormMessanger()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Point[] p_triangle = new Point[3];
            p_triangle[0].X = 0; p_triangle[0].Y = 0;
            p_triangle[1].X = 0; p_triangle[1].Y = 14;
            p_triangle[2].X = 8; p_triangle[2].Y = 7;

            Bitmap bmp = new Bitmap(PictureTriangle.Width, PictureTriangle.Height);
            using (Graphics grfx = Graphics.FromImage(bmp))
            {
                grfx.Clear(Color.FromArgb(35, 35, 35));
                grfx.FillPolygon(Brushes.White, p_triangle);
            }
            PictureTriangle.Visible = false;
            PictureTriangle.Image = bmp;


            this.BackColor = Color.FromArgb(52, 52, 52);
            MessageTB.BackColor = Color.FromArgb(52, 52, 52);
            chatsLB.BackColor = Color.FromArgb(37, 37, 37);
            chatsLB.Enabled = false;
            panel_registration.Height = 100;
            panel_registration.Location = new Point(panel_registration.Location.X, -50);
            head_lbl.ForeColor = Color.DarkGray;
            CreateChat_butt.ForeColor = Color.DarkGray;
            CreateChat_butt.Enabled = false;
            CreateChat_butt.Cursor = Cursors.Default;
            SendButt.ForeColor = Color.DarkGray;
            SendButt.Enabled = false;
            SendButt.Cursor = Cursors.Default;
            MessageTB.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((!MessageTB.Focused) && (MessageTB.Text == ""))
            {
                MessageTB.ForeColor = Color.Gray;
                MessageTB.Text = "Введите ёжесообщение...";
                SendButt.Enabled = false;
                hl = false;
            }
            
            if (chatsLB.SelectedItem == null) return;


            for (int i = 0; i < myChats[chatsLB.SelectedIndex].ChatMmbrs.Count; i++)
                if (myChats[chatsLB.SelectedIndex].ChatMmbrs[i].Nick == YourName)
                    if (myChats[chatsLB.SelectedIndex].ChatMmbrs[i].Blocked)
                    {
                        MessageTB.ForeColor = Color.Gray;
                        MessageTB.Text = "Вы заблокированы";
                        MessageTB.Cursor = Cursors.Default;
                        MessageTB.Enabled = false;
                        SendButt.Enabled = false;
                    }
                    else
                    {
                        MessageTB.Cursor = Cursors.IBeam;
                        if (MessageTB.Text == "Вы заблокированы")
                            MessageTB.Text = "Введите ёжесообщение...";
                        SendButt.Enabled = true;
                        MessageTB.Enabled = true;
                    }



            var getMessage = new Func<Task>(async () =>
            {
                CourseMessenger.Message msg = await API.GetMessageChatHTTPAsync(myChats[chatsLB.SelectedIndex].IdChat, MessageID[chatsLB.SelectedIndex]);
                
                while (msg != null)
                {
                    if (Regex.IsMatch(msg.MessageText, @"@everyone"))
                    {
                        msg.ClientNotify = "@everyone";
                    }
                    else if (Regex.IsMatch(msg.MessageText, $@"@{YourName}"))
                    {
                        msg.ClientNotify = $@"@{YourName}";
                    }
                    else msg.ClientNotify = "";
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
                FixScrollBar.Height = panel_messages.Height / (myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 3);
                FixScrollBar.Location = new Point(FixScrollBar.Location.X, panel_messages.Height - (FixScrollBar.Height) * (shift + 1));
                FixScrollBar.Visible = true;
            }

            if (myChats[chatsLB.SelectedIndex].ChatMsgs.Count > 0)
            {
                nameMsg_1.Text = myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 1 - shift].UserName;
                textMsg_1.Text = myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 1 - shift].MessageText;
                panelMsg_1.Height = textMsg_1.Height + textMsg_1.Location.Y + 16;
                panelMsg_1.Location = new Point(panelMsg_1.Location.X, panel_messages.Height - panelMsg_1.Height);
                notifyMsg_1.Location = new Point(nameMsg_1.Location.X + nameMsg_1.Width + 3, nameMsg_1.Location.Y);

                if (Regex.IsMatch(textMsg_1.Text, @"@everyone"))
                {
                    myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 1 - shift].ClientNotify = "@everyone";
                }
                else if (Regex.IsMatch(textMsg_1.Text, $@"@{YourName}"))
                {
                    myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 1 - shift].ClientNotify = $@"@{YourName}";
                }
                else myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 1 - shift].ClientNotify = "";

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
                panelMsg_2.Height = textMsg_2.Height + textMsg_2.Location.Y + 16;
                panelMsg_2.Location = new Point(panelMsg_2.Location.X, panelMsg_1.Location.Y - panelMsg_2.Height);
                notifyMsg_2.Location = new Point(nameMsg_2.Location.X + nameMsg_2.Width + 3, nameMsg_2.Location.Y);

                if (Regex.IsMatch(textMsg_2.Text, @"@everyone"))
                {
                    myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 2 - shift].ClientNotify = "@everyone";
                }
                else if (Regex.IsMatch(textMsg_2.Text, $@"@{YourName}"))
                {
                    myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 2 - shift].ClientNotify = $@"@{YourName}";
                }
                else myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 2 - shift].ClientNotify = "";

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
                panelMsg_3.Height = textMsg_3.Height + textMsg_3.Location.Y + 16;
                panelMsg_3.Location = new Point(panelMsg_3.Location.X, panelMsg_2.Location.Y - panelMsg_3.Height);
                notifyMsg_3.Location = new Point(nameMsg_3.Location.X + nameMsg_3.Width + 3, nameMsg_3.Location.Y);

                if (Regex.IsMatch(textMsg_3.Text, @"@everyone"))
                {
                    myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 3 - shift].ClientNotify = "@everyone";
                }
                else if (Regex.IsMatch(textMsg_3.Text, $@"@{YourName}"))
                {
                    myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 3 - shift].ClientNotify = $@"@{YourName}";
                }
                else myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 3 - shift].ClientNotify = "";

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
                panelMsg_4.Height = textMsg_4.Height + textMsg_4.Location.Y + 16;
                panelMsg_4.Location = new Point(panelMsg_4.Location.X, panelMsg_3.Location.Y - panelMsg_4.Height);
                notifyMsg_4.Location = new Point(nameMsg_4.Location.X + nameMsg_4.Width + 3, nameMsg_4.Location.Y);

                if (Regex.IsMatch(textMsg_4.Text, @"@everyone"))
                {
                    myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 4 - shift].ClientNotify = "@everyone";
                }
                else if (Regex.IsMatch(textMsg_4.Text, $@"@{YourName}"))
                {
                    myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 4 - shift].ClientNotify = $@"@{YourName}";
                }
                else myChats[chatsLB.SelectedIndex].ChatMsgs[myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 4 - shift].ClientNotify = "";

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
                API.SendMessageRestSharp(msg, myChats[chatsLB.SelectedIndex].IdChat, Error_label);
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

        private void EnterMessage_label_Click(object sender, EventArgs e)
        {
            MessageTB.Width = 5;
            MessageTB.Visible = true;
            MessageTB.Focus();
        }

        private void timer_wighter_Tick(object sender, EventArgs e)
        {
        }

        private void MessageTB_Click(object sender, EventArgs e)
        {
            if (hl)
            {

            } else if (MessageTB.Enabled)
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
                SendButt.Enabled = false;
            } 
            else
            {
                SendButt.Enabled = true;
                if (Regex.IsMatch(MessageTB.Text, @".{0,}[@]\w{1,}\s{1,}")) {
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
                if (myChats[chatsLB.SelectedIndex].ChatMsgs.Count - 5 - shift >= 0) shift++;
            } else
            {
                if (shift - 1 >= 0) shift--;
            }
            timer1_Tick(this, null);
        }

        private void UserNameTB_TextChanged(object sender, EventArgs e)
        {
        }

        private void CreateChat_butt_Click(object sender, EventArgs e)
        {
            Unfold(panelCreateChat, -50, 36, 50, 246, 21, true);
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
                    chatsLB.Items.Clear();
                    List<int> tmp = API.GetChats(YourName);
                    if (tmp.Count == 0)
                    {
                        Unfold(Panel_NoConnection, -50, 36, 34, 64, 15, true);
                        timerChats.Stop();
                        timer1.Stop();
                    } else if (Panel_NoConnection.Visible)
                    {
                        Fold(Panel_NoConnection, -50, 36, 34, 64, 15, true);
                    }
                    //if (tmp == null) { }
                    for (int i = 0; i < tmp.Count; i++)
                    {
                        try
                        {
                            Chat tmpChat = await API.GetAllAboutChat(tmp[i]);
                            myChats.Add(tmpChat);
                            MessageID.Add(tmpChat.ChatMsgs.Count);
                            chatsLB.Items.Add(tmpChat.ChatName);
                        } catch
                        {
                            Unfold(Panel_NoConnection, -50, 36, 34, 64, 21, true);
                        }
                        
                    }
                    for (int ani_y = 36, ani_h = 200; ani_y > -50; ani_y -= 4, ani_h -= 6, await Task.Delay(1))
                    {
                        panel_registration.Height = ani_h;
                        panel_registration.Location = new Point(panel_registration.Location.X, ani_y);
                        this.BackColor = Color.FromArgb(this.BackColor.R - 1, this.BackColor.G - 1, this.BackColor.B - 1);
                    }
                    panel_registration.Height = 40;
                    panel_registration.Location = new Point(panel_registration.Location.X, -50);
                    chatsLB.Enabled = true;
                    chatsLB.BackColor = Color.FromArgb(18, 18, 18);
                    this.BackColor = Color.FromArgb(35, 35, 35);
                    MessageTB.BackColor = Color.FromArgb(35, 35, 35);
                    head_lbl.ForeColor = Color.White;
                    CreateChat_butt.ForeColor = Color.White;
                    CreateChat_butt.Enabled = true;
                    CreateChat_butt.Cursor = Cursors.Hand;
                    SendButt.ForeColor = Color.White;
                    SendButt.Enabled = true;
                    SendButt.Cursor = Cursors.Hand;
                    MessageTB.Enabled = true;
                    timer1.Start();
                    timerChats.Start();
                    TimerOnline_Tick(sender, e);
                    TimerOnline.Start();

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

            
        }

        private async void LogInNick_TB_TextChanged(object sender, EventArgs e)
        {
            if (LogInNick_TB.Text.Length > 0) if (LogInNick_TB.Text[0] != '@') LogInNick_TB.Text = "@" + LogInNick_TB.Text;
            for (int ani_h = PanelRegName.Height; ani_h > 38; ani_h -= 2, await Task.Delay(10))
            {
                PanelRegName.Height = ani_h;
                PanelRegPass.Location = new Point(PanelRegPass.Location.X, PanelRegName.Height + PanelRegName.Location.Y);
                SignUp_Butt.Location = new Point(SignUp_Butt.Location.X, PanelRegPass.Height + PanelRegPass.Location.Y + 11);
                LogIn_Butt.Location = new Point(LogIn_Butt.Location.X, PanelRegPass.Height + PanelRegPass.Location.Y + 11);
                panel_registration.Height = SignUp_Butt.Location.Y + 39;
            }
            PanelRegName.Height = 38;
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
                    LogUserName_label.Text = "Это имя уже занято";
                    LogUserName_label.Visible = true;
                    for (int ani_h = PanelRegName.Height; ani_h < 60; ani_h += 2, await Task.Delay(10))
                    {
                        PanelRegName.Height = ani_h;
                        PanelRegPass.Location = new Point(PanelRegPass.Location.X, PanelRegName.Height + PanelRegName.Location.Y);
                        SignUp_Butt.Location = new Point(SignUp_Butt.Location.X, PanelRegPass.Height + PanelRegPass.Location.Y + 11);
                        LogIn_Butt.Location = new Point(LogIn_Butt.Location.X, PanelRegPass.Height + PanelRegPass.Location.Y + 11);
                        panel_registration.Height = SignUp_Butt.Location.Y + 39;
                    }
                    PanelRegName.Height = 60;
                }
                else if (result == "\"ErrWR\"")
                {
                    LogUserName_label.Text = "Это имя недоступно";
                    LogUserName_label.Visible = true;
                    for (int ani_h = PanelRegName.Height; ani_h < 60; ani_h += 2, await Task.Delay(10))
                    {
                        PanelRegName.Height = ani_h;
                        PanelRegPass.Location = new Point(PanelRegPass.Location.X, PanelRegName.Height + PanelRegName.Location.Y);
                        SignUp_Butt.Location = new Point(SignUp_Butt.Location.X, PanelRegPass.Height + PanelRegPass.Location.Y + 11);
                        LogIn_Butt.Location = new Point(LogIn_Butt.Location.X, PanelRegPass.Height + PanelRegPass.Location.Y + 11);
                        panel_registration.Height = SignUp_Butt.Location.Y + 39;
                    }
                    PanelRegName.Height = 60;
                }
                MessageTB.Text = "";
            }
        }

        private void panel_registr_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_registr_Click(object sender, EventArgs e)
        {

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
                MemberName_CMP.Text = "@" + Members_LB.SelectedItem.ToString();
            }

            if (myChats[chatsLB.SelectedIndex].ChatMmbrs[Members_LB.SelectedIndex].Blocked)
                BlockUser_CMP.Text = "Разблокировать";
            else BlockUser_CMP.Text = "Заблокировать";

            int i;
            for (i = 0; i < myChats[chatsLB.SelectedIndex].ChatMmbrs.Count; i++)
            {
                if (myChats[chatsLB.SelectedIndex].ChatMmbrs[i].Nick == YourName) break;
            }

            if (MemberName_CMP.Text == "@" + YourName)
            {
                MemberName_CMP.Text += " (я)";
                notify_CMP.Visible = false;
                BlockUser_CMP.Visible = false;
                AwayUser_CMP.Visible = false;
                MakeAdmin_CMP.Visible = false;
                DemoteAdmin_CMP.Visible = false;
                MakeModer_CMP.Visible = false;
                DemoteModer_CMP.Visible = false;
                BecomeAdmin_CMP.Visible = false;
                BecomeModer_CMP.Visible = false;
                BecomeMemb_CMP.Visible = false;
            } else

            switch (myChats[chatsLB.SelectedIndex].ChatMmbrs[i].Role)
            {
                case 0:
                    BlockUser_CMP.Visible = false;
                    AwayUser_CMP.Visible = false;
                    MakeAdmin_CMP.Visible = false;
                    DemoteAdmin_CMP.Visible = false;
                    MakeModer_CMP.Visible = false;
                    BecomeAdmin_CMP.Visible = false;
                    BecomeModer_CMP.Visible = false;
                    BecomeMemb_CMP.Visible = false;
                    if (myChats[chatsLB.SelectedIndex].ChatMmbrs[Members_LB.SelectedIndex].Role == 1)
                    {
                        DemoteModer_CMP.Visible = false;
                    } else DemoteModer_CMP.Visible = false;
                    break;
                case 1:
                    BecomeAdmin_CMP.Visible = false;
                    BecomeModer_CMP.Visible = false;
                    BecomeMemb_CMP.Visible = false;
                    if (myChats[chatsLB.SelectedIndex].ChatMmbrs[Members_LB.SelectedIndex].Role == 2)
                    {
                        BlockUser_CMP.Visible = false;
                        AwayUser_CMP.Visible = false;
                        MakeAdmin_CMP.Visible = false;
                        DemoteAdmin_CMP.Visible = false;
                        MakeModer_CMP.Visible = false;
                        DemoteModer_CMP.Visible = false;
                    } else
                    if (myChats[chatsLB.SelectedIndex].ChatMmbrs[Members_LB.SelectedIndex].Role == 1)
                    {
                        BlockUser_CMP.Visible = true;
                        AwayUser_CMP.Visible = true;
                        MakeAdmin_CMP.Visible = false;
                        DemoteAdmin_CMP.Visible = false;
                        MakeModer_CMP.Visible = false;
                        DemoteModer_CMP.Visible = true;
                    }
                    else
                    {
                        BlockUser_CMP.Visible = true;
                        AwayUser_CMP.Visible = true;
                        MakeAdmin_CMP.Visible = false;
                        DemoteAdmin_CMP.Visible = false;
                        MakeModer_CMP.Visible = true;
                        DemoteModer_CMP.Visible = false;
                    }
                    break;
                case 2:
                    BlockUser_CMP.Visible = true;
                    AwayUser_CMP.Visible = true;
                    BecomeAdmin_CMP.Visible = false;
                    BecomeModer_CMP.Visible = false;
                    BecomeMemb_CMP.Visible = false;
                    if (myChats[chatsLB.SelectedIndex].ChatMmbrs[Members_LB.SelectedIndex].Role == 2)
                    {
                        MakeAdmin_CMP.Visible = false;
                        DemoteAdmin_CMP.Visible = true;
                        MakeModer_CMP.Visible = false;
                        DemoteModer_CMP.Visible = false;
                    }
                    else
                    if (myChats[chatsLB.SelectedIndex].ChatMmbrs[Members_LB.SelectedIndex].Role == 1)
                    {
                        MakeAdmin_CMP.Visible = true;
                        DemoteAdmin_CMP.Visible = false;
                        MakeModer_CMP.Visible = false;
                        DemoteModer_CMP.Visible = true;
                    }
                    else
                    {
                        MakeAdmin_CMP.Visible = false;
                        DemoteAdmin_CMP.Visible = false;
                        MakeModer_CMP.Visible = true;
                        DemoteModer_CMP.Visible = false;
                    }
                    break;
            }
            DateTime wasOnline;
            wasOnline = API.GetOnline(Members_LB.SelectedItem.ToString());
            if ((wasOnline.Date == DateTime.Today) && (wasOnline.Hour == DateTime.Now.Hour) && ((wasOnline.Minute == DateTime.Now.Minute) || (wasOnline.Minute == DateTime.Now.Minute - 1)))
            {
                MemberStatus_CMP.Text = "онлайн";
            }
            else if (wasOnline.Date == DateTime.Now.Date)
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
            CloseCreateChat_Click(sender, e);
        }

        private void ChatListCM_Opening(object sender, CancelEventArgs e)
        {
            if (chatsLB.SelectedItem == null) ChatListCM.Close();
            else
            {
                ChatNameCMP.Text = chatsLB.SelectedItem.ToString();
            }
        }

        private async void ChatMembers_CMP_Click(object sender, EventArgs e)
        {
            Members_LB.Items.Clear();
            Members_LB.Height = 147;
            Label_Updating.Visible = true;
            int j = myChats[chatsLB.SelectedIndex].ChatMmbrs.Count;
            for (int i = 0; i < j; i++)
            {
                Members_LB.Items.Add(myChats[chatsLB.SelectedIndex].ChatMmbrs[i].Nick);
            }

            
            PanelChatMembers.Location = new Point(PanelChatMembers.Location.X, chatsLB.Location.Y + chatsLB.SelectedIndex * chatsLB.ItemHeight - 56);
            PanelChatMembers.Visible = true;
            for (int ani_y = chatsLB.Location.Y + chatsLB.SelectedIndex * chatsLB.ItemHeight - 56, ani_h = 0; ani_h < 168; ani_y += 2, ani_h += 6, await Task.Delay(10))
            {
                PanelChatMembers.Height = ani_h;
                PanelChatMembers.Location = new Point(PanelChatMembers.Location.X, ani_y);
            }

            Chat tmpChat = await API.GetAllAboutChat(myChats[chatsLB.SelectedIndex].IdChat);
            myChats[chatsLB.SelectedIndex].ChatMmbrs.Clear();
            j = tmpChat.ChatMmbrs.Count;
            Members_LB.Items.Clear();
            for (int i = 0; i < j; i++)
            {
                myChats[chatsLB.SelectedIndex].ChatMmbrs.Add(tmpChat.ChatMmbrs[i]);
                Members_LB.Items.Add(tmpChat.ChatMmbrs[i].Nick);
            }

            Label_Updating.Visible = false;
            Members_LB.Height = 168;
            
        }

        private async void timerChats_Tick(object sender, EventArgs e)
        {
            try
            {
                List<int> tmp = API.GetChats(YourName);
                if (tmp.Count == 0) {
                    Unfold(Panel_NoConnection, -50, 36, 34, 64, 15, true);
                    timerChats.Stop();
                    timer1.Stop();
                }
                else if (Panel_NoConnection.Visible)
                {
                    Fold(Panel_NoConnection, -50, 36, 34, 64, 15, true);
                }
                if (tmp.Count != chatsLB.Items.Count)
                {
                    chatsLB.Items.Clear();
                    myChats.Clear();
                    MessageID.Clear();
                    for (int i = 0; i < tmp.Count; i++)
                    {
                        Chat tmpChat = await API.GetAllAboutChat(tmp[i]);
                        if (tmpChat.IdChat == -1) continue;
                        myChats.Add(tmpChat);
                        MessageID.Add(tmpChat.ChatMsgs.Count);
                        chatsLB.Items.Add(tmpChat.ChatName);
                    }
                }
            }
            catch
            {
                Unfold(Panel_NoConnection, -50, 36, 34, 64, 21, true);
            }
            
            //if (tmp == null) { }
            
        }

        private void LeaveChat_CMP_Click(object sender, EventArgs e)
        {
            if (myChats[chatsLB.SelectedIndex].Secret)
            {
                TextAttentionLeaving.Text = "Внимание! Покидая секретный ёжечат, вы больше никогда не сможете в него вернуться\nВы действительно хотите покинуть чат \"" + chatsLB.SelectedItem.ToString() + "\"?";
            } else
            {
                TextAttentionLeaving.Text = "Вы действительно хотите покинуть чат \"" + chatsLB.SelectedItem.ToString() + "\"? Вернуться вы сможете только по приглашению другого участника";
            }

            Unfold(PanelLeavingChat, -50, 36, 50, 172, 14, true);
            
        }

        private void ChatRolesLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChatRolesLB_DrawItem(object sender, DrawItemEventArgs e)
        {
            this.Text += "a";
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
            
        }

        private async void chatsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!PictureTriangle.Visible)
            {
                PictureTriangle.Location = new Point(PictureTriangle.Location.X, chatsLB.SelectedIndex * chatsLB.ItemHeight + 96);
                PictureTriangle.Visible = true;
            }
            else if (PictureTriangle.Location.Y > chatsLB.SelectedIndex * chatsLB.ItemHeight + 96)
            {
                for (int ani_y = PictureTriangle.Location.Y; ani_y > chatsLB.SelectedIndex * chatsLB.ItemHeight + 96; ani_y -= 4, await Task.Delay(10))
                {
                    PictureTriangle.Location = new Point(PictureTriangle.Location.X, ani_y);
                }
            }
            else if (PictureTriangle.Location.Y < chatsLB.SelectedIndex * chatsLB.ItemHeight + 96)
            {
                for (int ani_y = PictureTriangle.Location.Y; ani_y < chatsLB.SelectedIndex * chatsLB.ItemHeight + 96; ani_y += 4, await Task.Delay(10))
                {
                    PictureTriangle.Location = new Point(PictureTriangle.Location.X, ani_y);
                }

            }
            PictureTriangle.Location = new Point(PictureTriangle.Location.X, chatsLB.SelectedIndex * chatsLB.ItemHeight + 96);

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
            Unfold(panel_invite, -50, 36, 50, 172, 20, true);
        }

        private void InviteRename_Butt_Click(object sender, EventArgs e)
        {

        }

        private void TimerOnline_Tick(object sender, EventArgs e)
        {
            API.ImOnline(YourName);
        }

        private void Members_LB_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private async void BlockUser_CMP_Click(object sender, EventArgs e)
        {
            Event q = new Event(YourName, Members_LB.SelectedItem.ToString(), 6, true, DateTime.Now);
            await API.SendEvent(q, myChats[chatsLB.SelectedIndex].IdChat);
        }

        private void RenameChat_CMP_Click(object sender, EventArgs e)
        {
            panel_invite.Location = new Point(panel_invite.Location.X, chatsLB.Location.Y + chatsLB.SelectedIndex * chatsLB.ItemHeight);
            InviteRename_TB.Text = "Введите новое имя..";
            panel_invite.Visible = true;
        }

        private void CloseInvite_Click(object sender, EventArgs e)
        {
            panel_invite.Visible = false;
        }

        private void SignIn_popup_MouseHover(object sender, EventArgs e)
        {

        }

        private void TimerBoxZoom_Tick(object sender, EventArgs e)
        {

        }

        private void SignUp_Butt_MouseHover(object sender, EventArgs e)
        {

        }

        private void SignUp_Butt_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void SignIn_popup_MouseLeave(object sender, EventArgs e)
        {

        }

        private void TimerBoxOut_Tick(object sender, EventArgs e)
        {

        }

        private void NavigationBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (cursh)
            {
                this.Location = new Point(this.Location.X + Cursor.Position.X - wx, this.Location.Y + Cursor.Position.Y - wy);
                wx = Cursor.Position.X;
                wy = Cursor.Position.Y;
            }
        }

        private void NavigationBar_MouseUp(object sender, MouseEventArgs e)
        {
            cursh = false;
        }

        private void CloseWindowButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureTriangle_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseCreateChat_Click(object sender, EventArgs e)
        {
            Fold(panelCreateChat, -50, 36, 50, 246, 19, true);
        }

        private void PinBrowse_Butt_Click(object sender, EventArgs e)
        {

        }

        private void PicturePinPreview_Click(object sender, EventArgs e)
        {

        }

        private void LogPass_TB_TextChanged(object sender, EventArgs e)
        {
            LogUserPass_label.Visible = false;
        }

        private void Invite_Butt_Click(object sender, EventArgs e)
        {
            List<Member> tmpMember = new List<Member>();
            string[] spls = InviteRename_TB.Text.Split(' ');
            foreach (string tempMemb in spls)
            {
                string coolstr = tempMemb;
                if (tempMemb != "") if (tempMemb[0] == '@') coolstr = tempMemb.Substring(1, tempMemb.Length - 1);
                tmpMember.Add(new Member(coolstr, 0, false));
            }
            Chat tmpChat = new Chat(myChats[chatsLB.SelectedIndex].IdChat, chatsLB.SelectedItem.ToString(), tmpMember, false);
            API.Invite(tmpChat);
            CloseInviteWindow_Click(sender, e);
        }

        private void CloseInviteWindow_Click(object sender, EventArgs e)
        {
            Fold(panel_invite, -50, 36, 50, 172, 20, true);
        }

        private void StayChat_Butt_Click(object sender, EventArgs e)
        {
            Fold(PanelLeavingChat, -50, 36, 50, 172, 14, true);
        }

        private void FormMessanger_Shown(object sender, EventArgs e)
        {
            Unfold(panel_registration, -50, 36, 100, 200, 19, false);
        }

        private void LeaveChat_Butt_Click(object sender, EventArgs e)
        {
            API.LeaveChat(YourName, myChats[chatsLB.SelectedIndex].IdChat);
            StayChat_Butt_Click(sender, e);
        }

        private async void AwayUser_CMP_Click(object sender, EventArgs e)
        {
            Event q = new Event(YourName, Members_LB.SelectedItem.ToString(), 5, true, DateTime.Now);
            await API.SendEvent(q, myChats[chatsLB.SelectedIndex].IdChat);
        }

        private async void MakeAdmin_CMP_Click(object sender, EventArgs e)
        {
            Event q = new Event(YourName, Members_LB.SelectedItem.ToString(), 0, true, DateTime.Now);
            await API.SendEvent(q, myChats[chatsLB.SelectedIndex].IdChat);
        }

        private async void AdminToModer_CMP_Click(object sender, EventArgs e)
        {
            Event q = new Event(YourName, Members_LB.SelectedItem.ToString(), 1, true, DateTime.Now);
            await API.SendEvent(q, myChats[chatsLB.SelectedIndex].IdChat);
        }

        private async void AdminToMemb_CMP_Click(object sender, EventArgs e)
        {
            Event q = new Event(YourName, Members_LB.SelectedItem.ToString(), 2, true, DateTime.Now);
            await API.SendEvent(q, myChats[chatsLB.SelectedIndex].IdChat);
        }

        private async void MakeModer_CMP_Click(object sender, EventArgs e)
        {
            Event q = new Event(YourName, Members_LB.SelectedItem.ToString(), 3, true, DateTime.Now);
            await API.SendEvent(q, myChats[chatsLB.SelectedIndex].IdChat);
        }

        private async void DemoteModer_CMP_Click(object sender, EventArgs e)
        {
            Event q = new Event(YourName, Members_LB.SelectedItem.ToString(), 4, true, DateTime.Now);
            await API.SendEvent(q, myChats[chatsLB.SelectedIndex].IdChat);
        }

        private void Button_repeatConnection_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timerChats.Start();
        }

        private void NavigationBar_MouseDown(object sender, MouseEventArgs e)
        {
            wx = Cursor.Position.X;
            wy = Cursor.Position.Y;
            cursh = true;
        }
    }

  
}
