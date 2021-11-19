
using System;

namespace WindowsFormsClient
{
    partial class FormMessanger
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MessageTB = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.head_lbl = new System.Windows.Forms.Label();
            this.chatsLB = new System.Windows.Forms.ListBox();
            this.ChatListCM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ChatNameCMP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.InviteChat_CMP = new System.Windows.Forms.ToolStripMenuItem();
            this.ChatMembers_CMP = new System.Windows.Forms.ToolStripMenuItem();
            this.переименоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LeaveChat_CMP = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteChat_context = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.CreateChat_CMP = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateSecret_CMP = new System.Windows.Forms.ToolStripMenuItem();
            this.SendButt = new System.Windows.Forms.Label();
            this.timer_wighter = new System.Windows.Forms.Timer(this.components);
            this.label_notify1 = new System.Windows.Forms.Label();
            this.label_notify2 = new System.Windows.Forms.Label();
            this.label_notify3 = new System.Windows.Forms.Label();
            this.label_notify4 = new System.Windows.Forms.Label();
            this.label_notifymore = new System.Windows.Forms.Label();
            this.panel_messages = new System.Windows.Forms.Panel();
            this.FixScrollBar = new System.Windows.Forms.PictureBox();
            this.Error_label = new System.Windows.Forms.Label();
            this.panelMsg_4 = new System.Windows.Forms.Panel();
            this.timeMsg_4 = new System.Windows.Forms.Label();
            this.notifyMsg_4 = new System.Windows.Forms.Label();
            this.textMsg_4 = new System.Windows.Forms.Label();
            this.nameMsg_4 = new System.Windows.Forms.Label();
            this.panelMsg_3 = new System.Windows.Forms.Panel();
            this.timeMsg_3 = new System.Windows.Forms.Label();
            this.notifyMsg_3 = new System.Windows.Forms.Label();
            this.textMsg_3 = new System.Windows.Forms.Label();
            this.nameMsg_3 = new System.Windows.Forms.Label();
            this.panelMsg_2 = new System.Windows.Forms.Panel();
            this.timeMsg_2 = new System.Windows.Forms.Label();
            this.notifyMsg_2 = new System.Windows.Forms.Label();
            this.textMsg_2 = new System.Windows.Forms.Label();
            this.nameMsg_2 = new System.Windows.Forms.Label();
            this.panelMsg_1 = new System.Windows.Forms.Panel();
            this.timeMsg_1 = new System.Windows.Forms.Label();
            this.notifyMsg_1 = new System.Windows.Forms.Label();
            this.textMsg_1 = new System.Windows.Forms.Label();
            this.nameMsg_1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_emptyChat = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.CreateChat_butt = new System.Windows.Forms.Label();
            this.panelCreateChat = new System.Windows.Forms.Panel();
            this.ConfirmCreateChat_Butt = new System.Windows.Forms.Label();
            this.SecretChat_CB = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ChatMembersTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ChatNameTB = new System.Windows.Forms.TextBox();
            this.panel_registration = new System.Windows.Forms.Panel();
            this.SignUp_Butt = new System.Windows.Forms.Label();
            this.LogUserPass_label = new System.Windows.Forms.Label();
            this.LogIn_Butt = new System.Windows.Forms.Label();
            this.ShowPassword_CB = new System.Windows.Forms.CheckBox();
            this.LogUserName_label = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LogPass_TB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.LogInNick_TB = new System.Windows.Forms.TextBox();
            this.PanelChatMembers = new System.Windows.Forms.Panel();
            this.CloseMembersButt = new System.Windows.Forms.Label();
            this.Members_LB = new System.Windows.Forms.ListBox();
            this.MembList_CM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MemberName_CMP = new System.Windows.Forms.ToolStripMenuItem();
            this.MemberStatus_CMP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.notify_CMP = new System.Windows.Forms.ToolStripMenuItem();
            this.BlockUser_CMP = new System.Windows.Forms.ToolStripMenuItem();
            this.AwayUser_CMP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.MakeAdmin_CMP = new System.Windows.Forms.ToolStripMenuItem();
            this.разжаловатьАдминистратораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DemoteModer_CMP = new System.Windows.Forms.ToolStripMenuItem();
            this.DemoteMemb_CMP = new System.Windows.Forms.ToolStripMenuItem();
            this.назначитьМодераторомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разжаловатьМодератораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статьМодераторомToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.статьАдминистраторомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статьМодераторомToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.статьУчастникомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerChats = new System.Windows.Forms.Timer(this.components);
            this.timerFastUpdate = new System.Windows.Forms.Timer(this.components);
            this.LogOut_Butt = new System.Windows.Forms.Label();
            this.ChatListCM.SuspendLayout();
            this.panel_messages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FixScrollBar)).BeginInit();
            this.panelMsg_4.SuspendLayout();
            this.panelMsg_3.SuspendLayout();
            this.panelMsg_2.SuspendLayout();
            this.panelMsg_1.SuspendLayout();
            this.panel_emptyChat.SuspendLayout();
            this.panelCreateChat.SuspendLayout();
            this.panel_registration.SuspendLayout();
            this.PanelChatMembers.SuspendLayout();
            this.MembList_CM.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageTB
            // 
            this.MessageTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.MessageTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageTB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageTB.ForeColor = System.Drawing.Color.Gray;
            this.MessageTB.Location = new System.Drawing.Point(279, 455);
            this.MessageTB.Name = "MessageTB";
            this.MessageTB.Size = new System.Drawing.Size(547, 29);
            this.MessageTB.TabIndex = 3;
            this.MessageTB.Text = "Введите ёжесообщение...";
            this.MessageTB.Click += new System.EventHandler(this.MessageTB_Click);
            this.MessageTB.TextChanged += new System.EventHandler(this.MessageTB_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // head_lbl
            // 
            this.head_lbl.BackColor = System.Drawing.Color.Transparent;
            this.head_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.head_lbl.ForeColor = System.Drawing.Color.White;
            this.head_lbl.Location = new System.Drawing.Point(7, 9);
            this.head_lbl.Name = "head_lbl";
            this.head_lbl.Size = new System.Drawing.Size(633, 40);
            this.head_lbl.TabIndex = 4;
            this.head_lbl.Text = "Войдите или зарегистрируйтесь";
            // 
            // chatsLB
            // 
            this.chatsLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.chatsLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chatsLB.ContextMenuStrip = this.ChatListCM;
            this.chatsLB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chatsLB.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chatsLB.ForeColor = System.Drawing.Color.White;
            this.chatsLB.FormattingEnabled = true;
            this.chatsLB.ItemHeight = 25;
            this.chatsLB.Items.AddRange(new object[] {
            "Общий чат"});
            this.chatsLB.Location = new System.Drawing.Point(14, 62);
            this.chatsLB.Name = "chatsLB";
            this.chatsLB.Size = new System.Drawing.Size(225, 427);
            this.chatsLB.TabIndex = 5;
            this.chatsLB.SelectedIndexChanged += new System.EventHandler(this.chatsLB_SelectedIndexChanged);
            // 
            // ChatListCM
            // 
            this.ChatListCM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChatNameCMP,
            this.toolStripMenuItem1,
            this.InviteChat_CMP,
            this.ChatMembers_CMP,
            this.переименоватьToolStripMenuItem,
            this.LeaveChat_CMP,
            this.deleteChat_context,
            this.toolStripMenuItem2,
            this.CreateChat_CMP,
            this.CreateSecret_CMP});
            this.ChatListCM.Name = "contextMenuStrip1";
            this.ChatListCM.Size = new System.Drawing.Size(243, 214);
            this.ChatListCM.Opening += new System.ComponentModel.CancelEventHandler(this.ChatListCM_Opening);
            // 
            // ChatNameCMP
            // 
            this.ChatNameCMP.Enabled = false;
            this.ChatNameCMP.Name = "ChatNameCMP";
            this.ChatNameCMP.Size = new System.Drawing.Size(242, 22);
            this.ChatNameCMP.Text = "Идентификатор чата";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(239, 6);
            // 
            // InviteChat_CMP
            // 
            this.InviteChat_CMP.Name = "InviteChat_CMP";
            this.InviteChat_CMP.Size = new System.Drawing.Size(242, 22);
            this.InviteChat_CMP.Text = "Пригласить в ёжечат";
            // 
            // ChatMembers_CMP
            // 
            this.ChatMembers_CMP.Name = "ChatMembers_CMP";
            this.ChatMembers_CMP.Size = new System.Drawing.Size(242, 22);
            this.ChatMembers_CMP.Text = "Участники";
            this.ChatMembers_CMP.Click += new System.EventHandler(this.ChatMembers_CMP_Click);
            // 
            // переименоватьToolStripMenuItem
            // 
            this.переименоватьToolStripMenuItem.Name = "переименоватьToolStripMenuItem";
            this.переименоватьToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.переименоватьToolStripMenuItem.Text = "Переименовать";
            // 
            // LeaveChat_CMP
            // 
            this.LeaveChat_CMP.Name = "LeaveChat_CMP";
            this.LeaveChat_CMP.Size = new System.Drawing.Size(242, 22);
            this.LeaveChat_CMP.Text = "Покинуть ёжечат";
            this.LeaveChat_CMP.Click += new System.EventHandler(this.LeaveChat_CMP_Click);
            // 
            // deleteChat_context
            // 
            this.deleteChat_context.Name = "deleteChat_context";
            this.deleteChat_context.Size = new System.Drawing.Size(242, 22);
            this.deleteChat_context.Text = "Удалить ёжечат";
            this.deleteChat_context.Click += new System.EventHandler(this.deleteChat_context_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(239, 6);
            // 
            // CreateChat_CMP
            // 
            this.CreateChat_CMP.Name = "CreateChat_CMP";
            this.CreateChat_CMP.Size = new System.Drawing.Size(242, 22);
            this.CreateChat_CMP.Text = "Создать ёжечат...";
            this.CreateChat_CMP.Click += new System.EventHandler(this.CreateChat_CMP_Click);
            // 
            // CreateSecret_CMP
            // 
            this.CreateSecret_CMP.Name = "CreateSecret_CMP";
            this.CreateSecret_CMP.Size = new System.Drawing.Size(242, 22);
            this.CreateSecret_CMP.Text = "Создать ёжесекретный ёжечат";
            this.CreateSecret_CMP.Click += new System.EventHandler(this.CreateSecret_CMP_Click);
            // 
            // SendButt
            // 
            this.SendButt.BackColor = System.Drawing.Color.Transparent;
            this.SendButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendButt.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendButt.ForeColor = System.Drawing.Color.White;
            this.SendButt.Location = new System.Drawing.Point(845, 455);
            this.SendButt.Name = "SendButt";
            this.SendButt.Size = new System.Drawing.Size(145, 32);
            this.SendButt.TabIndex = 6;
            this.SendButt.Text = "Прикрепить";
            this.SendButt.Click += new System.EventHandler(this.SendButt_Click);
            // 
            // timer_wighter
            // 
            this.timer_wighter.Interval = 2;
            this.timer_wighter.Tick += new System.EventHandler(this.timer_wighter_Tick);
            // 
            // label_notify1
            // 
            this.label_notify1.AutoSize = true;
            this.label_notify1.BackColor = System.Drawing.Color.Transparent;
            this.label_notify1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_notify1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(199)))), ((int)(((byte)(254)))));
            this.label_notify1.Location = new System.Drawing.Point(285, 431);
            this.label_notify1.Name = "label_notify1";
            this.label_notify1.Size = new System.Drawing.Size(79, 21);
            this.label_notify1.TabIndex = 9;
            this.label_notify1.Text = "everyone";
            this.label_notify1.Visible = false;
            // 
            // label_notify2
            // 
            this.label_notify2.AutoSize = true;
            this.label_notify2.BackColor = System.Drawing.Color.Transparent;
            this.label_notify2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_notify2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(199)))), ((int)(((byte)(254)))));
            this.label_notify2.Location = new System.Drawing.Point(380, 431);
            this.label_notify2.Name = "label_notify2";
            this.label_notify2.Size = new System.Drawing.Size(79, 21);
            this.label_notify2.TabIndex = 10;
            this.label_notify2.Text = "everyone";
            this.label_notify2.Visible = false;
            // 
            // label_notify3
            // 
            this.label_notify3.AutoSize = true;
            this.label_notify3.BackColor = System.Drawing.Color.Transparent;
            this.label_notify3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_notify3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(199)))), ((int)(((byte)(254)))));
            this.label_notify3.Location = new System.Drawing.Point(475, 431);
            this.label_notify3.Name = "label_notify3";
            this.label_notify3.Size = new System.Drawing.Size(79, 21);
            this.label_notify3.TabIndex = 11;
            this.label_notify3.Text = "everyone";
            this.label_notify3.Visible = false;
            // 
            // label_notify4
            // 
            this.label_notify4.AutoSize = true;
            this.label_notify4.BackColor = System.Drawing.Color.Transparent;
            this.label_notify4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_notify4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(199)))), ((int)(((byte)(254)))));
            this.label_notify4.Location = new System.Drawing.Point(570, 431);
            this.label_notify4.Name = "label_notify4";
            this.label_notify4.Size = new System.Drawing.Size(79, 21);
            this.label_notify4.TabIndex = 12;
            this.label_notify4.Text = "everyone";
            this.label_notify4.Visible = false;
            // 
            // label_notifymore
            // 
            this.label_notifymore.AutoSize = true;
            this.label_notifymore.BackColor = System.Drawing.Color.Transparent;
            this.label_notifymore.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_notifymore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(199)))), ((int)(((byte)(254)))));
            this.label_notifymore.Location = new System.Drawing.Point(667, 431);
            this.label_notifymore.Name = "label_notifymore";
            this.label_notifymore.Size = new System.Drawing.Size(79, 21);
            this.label_notifymore.TabIndex = 13;
            this.label_notifymore.Text = "everyone";
            this.label_notifymore.Visible = false;
            // 
            // panel_messages
            // 
            this.panel_messages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_messages.Controls.Add(this.FixScrollBar);
            this.panel_messages.Controls.Add(this.Error_label);
            this.panel_messages.Controls.Add(this.panelMsg_4);
            this.panel_messages.Controls.Add(this.panelMsg_3);
            this.panel_messages.Controls.Add(this.panelMsg_2);
            this.panel_messages.Controls.Add(this.panelMsg_1);
            this.panel_messages.Location = new System.Drawing.Point(279, 62);
            this.panel_messages.Name = "panel_messages";
            this.panel_messages.Size = new System.Drawing.Size(714, 377);
            this.panel_messages.TabIndex = 14;
            this.panel_messages.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panel_messages_Scroll);
            this.panel_messages.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel_messages.MouseEnter += new System.EventHandler(this.panel_messages_MouseEnter);
            this.panel_messages.MouseLeave += new System.EventHandler(this.panel_messages_MouseLeave);
            this.panel_messages.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.panel_messages_MouseWheel);
            // 
            // FixScrollBar
            // 
            this.FixScrollBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FixScrollBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FixScrollBar.ErrorImage = null;
            this.FixScrollBar.InitialImage = null;
            this.FixScrollBar.Location = new System.Drawing.Point(701, -1);
            this.FixScrollBar.Name = "FixScrollBar";
            this.FixScrollBar.Size = new System.Drawing.Size(12, 86);
            this.FixScrollBar.TabIndex = 18;
            this.FixScrollBar.TabStop = false;
            this.FixScrollBar.Visible = false;
            // 
            // Error_label
            // 
            this.Error_label.BackColor = System.Drawing.Color.Transparent;
            this.Error_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Error_label.ForeColor = System.Drawing.Color.LightCoral;
            this.Error_label.Location = new System.Drawing.Point(3, 2);
            this.Error_label.Name = "Error_label";
            this.Error_label.Size = new System.Drawing.Size(715, 21);
            this.Error_label.TabIndex = 17;
            this.Error_label.Text = "Нет ёжесоединения";
            this.Error_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Error_label.Visible = false;
            // 
            // panelMsg_4
            // 
            this.panelMsg_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMsg_4.Controls.Add(this.timeMsg_4);
            this.panelMsg_4.Controls.Add(this.notifyMsg_4);
            this.panelMsg_4.Controls.Add(this.textMsg_4);
            this.panelMsg_4.Controls.Add(this.nameMsg_4);
            this.panelMsg_4.Location = new System.Drawing.Point(0, 39);
            this.panelMsg_4.Name = "panelMsg_4";
            this.panelMsg_4.Size = new System.Drawing.Size(702, 77);
            this.panelMsg_4.TabIndex = 3;
            this.panelMsg_4.Visible = false;
            // 
            // timeMsg_4
            // 
            this.timeMsg_4.BackColor = System.Drawing.Color.Transparent;
            this.timeMsg_4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeMsg_4.ForeColor = System.Drawing.Color.DarkGray;
            this.timeMsg_4.Location = new System.Drawing.Point(391, 41);
            this.timeMsg_4.Name = "timeMsg_4";
            this.timeMsg_4.Size = new System.Drawing.Size(301, 21);
            this.timeMsg_4.TabIndex = 17;
            this.timeMsg_4.Text = "12:30";
            this.timeMsg_4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // notifyMsg_4
            // 
            this.notifyMsg_4.AutoSize = true;
            this.notifyMsg_4.BackColor = System.Drawing.Color.Transparent;
            this.notifyMsg_4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notifyMsg_4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(199)))), ((int)(((byte)(254)))));
            this.notifyMsg_4.Location = new System.Drawing.Point(181, 10);
            this.notifyMsg_4.Name = "notifyMsg_4";
            this.notifyMsg_4.Size = new System.Drawing.Size(94, 21);
            this.notifyMsg_4.TabIndex = 16;
            this.notifyMsg_4.Text = "@everyone";
            // 
            // textMsg_4
            // 
            this.textMsg_4.AutoSize = true;
            this.textMsg_4.BackColor = System.Drawing.Color.Transparent;
            this.textMsg_4.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMsg_4.ForeColor = System.Drawing.Color.DarkGray;
            this.textMsg_4.Location = new System.Drawing.Point(18, 38);
            this.textMsg_4.Name = "textMsg_4";
            this.textMsg_4.Size = new System.Drawing.Size(290, 23);
            this.textMsg_4.TabIndex = 15;
            this.textMsg_4.Text = "Hello, hello again. I am writing you...";
            // 
            // nameMsg_4
            // 
            this.nameMsg_4.AutoSize = true;
            this.nameMsg_4.BackColor = System.Drawing.Color.Transparent;
            this.nameMsg_4.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameMsg_4.ForeColor = System.Drawing.Color.White;
            this.nameMsg_4.Location = new System.Drawing.Point(17, 10);
            this.nameMsg_4.Name = "nameMsg_4";
            this.nameMsg_4.Size = new System.Drawing.Size(163, 28);
            this.nameMsg_4.TabIndex = 14;
            this.nameMsg_4.Text = "Name of contact";
            // 
            // panelMsg_3
            // 
            this.panelMsg_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMsg_3.Controls.Add(this.timeMsg_3);
            this.panelMsg_3.Controls.Add(this.notifyMsg_3);
            this.panelMsg_3.Controls.Add(this.textMsg_3);
            this.panelMsg_3.Controls.Add(this.nameMsg_3);
            this.panelMsg_3.Location = new System.Drawing.Point(-1, 122);
            this.panelMsg_3.Name = "panelMsg_3";
            this.panelMsg_3.Size = new System.Drawing.Size(703, 77);
            this.panelMsg_3.TabIndex = 2;
            this.panelMsg_3.Visible = false;
            // 
            // timeMsg_3
            // 
            this.timeMsg_3.BackColor = System.Drawing.Color.Transparent;
            this.timeMsg_3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeMsg_3.ForeColor = System.Drawing.Color.DarkGray;
            this.timeMsg_3.Location = new System.Drawing.Point(415, 41);
            this.timeMsg_3.Name = "timeMsg_3";
            this.timeMsg_3.Size = new System.Drawing.Size(278, 21);
            this.timeMsg_3.TabIndex = 17;
            this.timeMsg_3.Text = "12:30";
            this.timeMsg_3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // notifyMsg_3
            // 
            this.notifyMsg_3.AutoSize = true;
            this.notifyMsg_3.BackColor = System.Drawing.Color.Transparent;
            this.notifyMsg_3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notifyMsg_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(199)))), ((int)(((byte)(254)))));
            this.notifyMsg_3.Location = new System.Drawing.Point(181, 10);
            this.notifyMsg_3.Name = "notifyMsg_3";
            this.notifyMsg_3.Size = new System.Drawing.Size(94, 21);
            this.notifyMsg_3.TabIndex = 16;
            this.notifyMsg_3.Text = "@everyone";
            // 
            // textMsg_3
            // 
            this.textMsg_3.AutoSize = true;
            this.textMsg_3.BackColor = System.Drawing.Color.Transparent;
            this.textMsg_3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMsg_3.ForeColor = System.Drawing.Color.DarkGray;
            this.textMsg_3.Location = new System.Drawing.Point(18, 38);
            this.textMsg_3.Name = "textMsg_3";
            this.textMsg_3.Size = new System.Drawing.Size(290, 23);
            this.textMsg_3.TabIndex = 15;
            this.textMsg_3.Text = "Hello, hello again. I am writing you...";
            // 
            // nameMsg_3
            // 
            this.nameMsg_3.AutoSize = true;
            this.nameMsg_3.BackColor = System.Drawing.Color.Transparent;
            this.nameMsg_3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameMsg_3.ForeColor = System.Drawing.Color.White;
            this.nameMsg_3.Location = new System.Drawing.Point(17, 10);
            this.nameMsg_3.Name = "nameMsg_3";
            this.nameMsg_3.Size = new System.Drawing.Size(163, 28);
            this.nameMsg_3.TabIndex = 14;
            this.nameMsg_3.Text = "Name of contact";
            // 
            // panelMsg_2
            // 
            this.panelMsg_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMsg_2.Controls.Add(this.timeMsg_2);
            this.panelMsg_2.Controls.Add(this.notifyMsg_2);
            this.panelMsg_2.Controls.Add(this.textMsg_2);
            this.panelMsg_2.Controls.Add(this.nameMsg_2);
            this.panelMsg_2.Location = new System.Drawing.Point(-1, 205);
            this.panelMsg_2.Name = "panelMsg_2";
            this.panelMsg_2.Size = new System.Drawing.Size(703, 77);
            this.panelMsg_2.TabIndex = 1;
            this.panelMsg_2.Visible = false;
            // 
            // timeMsg_2
            // 
            this.timeMsg_2.BackColor = System.Drawing.Color.Transparent;
            this.timeMsg_2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeMsg_2.ForeColor = System.Drawing.Color.DarkGray;
            this.timeMsg_2.Location = new System.Drawing.Point(411, 40);
            this.timeMsg_2.Name = "timeMsg_2";
            this.timeMsg_2.Size = new System.Drawing.Size(282, 21);
            this.timeMsg_2.TabIndex = 17;
            this.timeMsg_2.Text = "12:30";
            this.timeMsg_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // notifyMsg_2
            // 
            this.notifyMsg_2.AutoSize = true;
            this.notifyMsg_2.BackColor = System.Drawing.Color.Transparent;
            this.notifyMsg_2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notifyMsg_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(199)))), ((int)(((byte)(254)))));
            this.notifyMsg_2.Location = new System.Drawing.Point(181, 10);
            this.notifyMsg_2.Name = "notifyMsg_2";
            this.notifyMsg_2.Size = new System.Drawing.Size(94, 21);
            this.notifyMsg_2.TabIndex = 16;
            this.notifyMsg_2.Text = "@everyone";
            // 
            // textMsg_2
            // 
            this.textMsg_2.AutoSize = true;
            this.textMsg_2.BackColor = System.Drawing.Color.Transparent;
            this.textMsg_2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMsg_2.ForeColor = System.Drawing.Color.DarkGray;
            this.textMsg_2.Location = new System.Drawing.Point(18, 38);
            this.textMsg_2.Name = "textMsg_2";
            this.textMsg_2.Size = new System.Drawing.Size(290, 23);
            this.textMsg_2.TabIndex = 15;
            this.textMsg_2.Text = "Hello, hello again. I am writing you...";
            // 
            // nameMsg_2
            // 
            this.nameMsg_2.AutoSize = true;
            this.nameMsg_2.BackColor = System.Drawing.Color.Transparent;
            this.nameMsg_2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameMsg_2.ForeColor = System.Drawing.Color.White;
            this.nameMsg_2.Location = new System.Drawing.Point(17, 10);
            this.nameMsg_2.Name = "nameMsg_2";
            this.nameMsg_2.Size = new System.Drawing.Size(163, 28);
            this.nameMsg_2.TabIndex = 14;
            this.nameMsg_2.Text = "Name of contact";
            // 
            // panelMsg_1
            // 
            this.panelMsg_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMsg_1.Controls.Add(this.timeMsg_1);
            this.panelMsg_1.Controls.Add(this.notifyMsg_1);
            this.panelMsg_1.Controls.Add(this.textMsg_1);
            this.panelMsg_1.Controls.Add(this.nameMsg_1);
            this.panelMsg_1.Location = new System.Drawing.Point(-1, 288);
            this.panelMsg_1.Name = "panelMsg_1";
            this.panelMsg_1.Size = new System.Drawing.Size(703, 77);
            this.panelMsg_1.TabIndex = 0;
            this.panelMsg_1.Visible = false;
            // 
            // timeMsg_1
            // 
            this.timeMsg_1.BackColor = System.Drawing.Color.Transparent;
            this.timeMsg_1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeMsg_1.ForeColor = System.Drawing.Color.DarkGray;
            this.timeMsg_1.Location = new System.Drawing.Point(371, 40);
            this.timeMsg_1.Name = "timeMsg_1";
            this.timeMsg_1.Size = new System.Drawing.Size(322, 21);
            this.timeMsg_1.TabIndex = 17;
            this.timeMsg_1.Text = "12:30";
            this.timeMsg_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // notifyMsg_1
            // 
            this.notifyMsg_1.AutoSize = true;
            this.notifyMsg_1.BackColor = System.Drawing.Color.Transparent;
            this.notifyMsg_1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notifyMsg_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(199)))), ((int)(((byte)(254)))));
            this.notifyMsg_1.Location = new System.Drawing.Point(181, 10);
            this.notifyMsg_1.Name = "notifyMsg_1";
            this.notifyMsg_1.Size = new System.Drawing.Size(94, 21);
            this.notifyMsg_1.TabIndex = 16;
            this.notifyMsg_1.Text = "@everyone";
            // 
            // textMsg_1
            // 
            this.textMsg_1.AutoSize = true;
            this.textMsg_1.BackColor = System.Drawing.Color.Transparent;
            this.textMsg_1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMsg_1.ForeColor = System.Drawing.Color.DarkGray;
            this.textMsg_1.Location = new System.Drawing.Point(18, 38);
            this.textMsg_1.Name = "textMsg_1";
            this.textMsg_1.Size = new System.Drawing.Size(290, 23);
            this.textMsg_1.TabIndex = 15;
            this.textMsg_1.Text = "Hello, hello again. I am writing you...";
            // 
            // nameMsg_1
            // 
            this.nameMsg_1.AutoSize = true;
            this.nameMsg_1.BackColor = System.Drawing.Color.Transparent;
            this.nameMsg_1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameMsg_1.ForeColor = System.Drawing.Color.White;
            this.nameMsg_1.Location = new System.Drawing.Point(17, 10);
            this.nameMsg_1.Name = "nameMsg_1";
            this.nameMsg_1.Size = new System.Drawing.Size(163, 28);
            this.nameMsg_1.TabIndex = 14;
            this.nameMsg_1.Text = "Name of contact";
            // 
            // panel_emptyChat
            // 
            this.panel_emptyChat.Controls.Add(this.label5);
            this.panel_emptyChat.Location = new System.Drawing.Point(280, 63);
            this.panel_emptyChat.Name = "panel_emptyChat";
            this.panel_emptyChat.Size = new System.Drawing.Size(709, 372);
            this.panel_emptyChat.TabIndex = 15;
            this.panel_emptyChat.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(0, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(706, 237);
            this.label5.TabIndex = 16;
            this.label5.Text = "Этот чат ёжепуст";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateChat_butt
            // 
            this.CreateChat_butt.BackColor = System.Drawing.Color.Transparent;
            this.CreateChat_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateChat_butt.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateChat_butt.ForeColor = System.Drawing.Color.White;
            this.CreateChat_butt.Location = new System.Drawing.Point(12, 492);
            this.CreateChat_butt.Name = "CreateChat_butt";
            this.CreateChat_butt.Size = new System.Drawing.Size(197, 32);
            this.CreateChat_butt.TabIndex = 16;
            this.CreateChat_butt.Text = "Создать ёжечат";
            this.CreateChat_butt.Click += new System.EventHandler(this.CreateChat_butt_Click);
            // 
            // panelCreateChat
            // 
            this.panelCreateChat.Controls.Add(this.ConfirmCreateChat_Butt);
            this.panelCreateChat.Controls.Add(this.SecretChat_CB);
            this.panelCreateChat.Controls.Add(this.label9);
            this.panelCreateChat.Controls.Add(this.label8);
            this.panelCreateChat.Controls.Add(this.ChatMembersTB);
            this.panelCreateChat.Controls.Add(this.label6);
            this.panelCreateChat.Controls.Add(this.ChatNameTB);
            this.panelCreateChat.Location = new System.Drawing.Point(14, 62);
            this.panelCreateChat.Name = "panelCreateChat";
            this.panelCreateChat.Size = new System.Drawing.Size(993, 471);
            this.panelCreateChat.TabIndex = 18;
            this.panelCreateChat.Visible = false;
            // 
            // ConfirmCreateChat_Butt
            // 
            this.ConfirmCreateChat_Butt.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmCreateChat_Butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmCreateChat_Butt.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmCreateChat_Butt.ForeColor = System.Drawing.Color.White;
            this.ConfirmCreateChat_Butt.Location = new System.Drawing.Point(412, 358);
            this.ConfirmCreateChat_Butt.Name = "ConfirmCreateChat_Butt";
            this.ConfirmCreateChat_Butt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ConfirmCreateChat_Butt.Size = new System.Drawing.Size(197, 32);
            this.ConfirmCreateChat_Butt.TabIndex = 21;
            this.ConfirmCreateChat_Butt.Text = "Создать ёжечат";
            this.ConfirmCreateChat_Butt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ConfirmCreateChat_Butt.Click += new System.EventHandler(this.ConfirmCreateChat_Butt_Click);
            // 
            // SecretChat_CB
            // 
            this.SecretChat_CB.AutoSize = true;
            this.SecretChat_CB.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecretChat_CB.ForeColor = System.Drawing.Color.White;
            this.SecretChat_CB.Location = new System.Drawing.Point(397, 215);
            this.SecretChat_CB.Name = "SecretChat_CB";
            this.SecretChat_CB.Size = new System.Drawing.Size(229, 29);
            this.SecretChat_CB.TabIndex = 20;
            this.SecretChat_CB.Text = "Ёжесекретный ёжечат";
            this.SecretChat_CB.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(384, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(408, 34);
            this.label9.TabIndex = 19;
            this.label9.Text = "Перечислите никнеймы через пробел";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(105, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(277, 28);
            this.label8.TabIndex = 18;
            this.label8.Text = "Участники";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ChatMembersTB
            // 
            this.ChatMembersTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ChatMembersTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChatMembersTB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChatMembersTB.ForeColor = System.Drawing.Color.White;
            this.ChatMembersTB.Location = new System.Drawing.Point(388, 132);
            this.ChatMembersTB.Name = "ChatMembersTB";
            this.ChatMembersTB.Size = new System.Drawing.Size(367, 36);
            this.ChatMembersTB.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(105, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Имя ёжечата";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ChatNameTB
            // 
            this.ChatNameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ChatNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChatNameTB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChatNameTB.ForeColor = System.Drawing.Color.White;
            this.ChatNameTB.Location = new System.Drawing.Point(388, 78);
            this.ChatNameTB.Name = "ChatNameTB";
            this.ChatNameTB.Size = new System.Drawing.Size(367, 36);
            this.ChatNameTB.TabIndex = 4;
            // 
            // panel_registration
            // 
            this.panel_registration.Controls.Add(this.SignUp_Butt);
            this.panel_registration.Controls.Add(this.LogUserPass_label);
            this.panel_registration.Controls.Add(this.LogIn_Butt);
            this.panel_registration.Controls.Add(this.ShowPassword_CB);
            this.panel_registration.Controls.Add(this.LogUserName_label);
            this.panel_registration.Controls.Add(this.label12);
            this.panel_registration.Controls.Add(this.LogPass_TB);
            this.panel_registration.Controls.Add(this.label14);
            this.panel_registration.Controls.Add(this.LogInNick_TB);
            this.panel_registration.Location = new System.Drawing.Point(12, 52);
            this.panel_registration.Name = "panel_registration";
            this.panel_registration.Size = new System.Drawing.Size(995, 472);
            this.panel_registration.TabIndex = 19;
            // 
            // SignUp_Butt
            // 
            this.SignUp_Butt.BackColor = System.Drawing.Color.Transparent;
            this.SignUp_Butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUp_Butt.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignUp_Butt.ForeColor = System.Drawing.Color.White;
            this.SignUp_Butt.Location = new System.Drawing.Point(504, 379);
            this.SignUp_Butt.Name = "SignUp_Butt";
            this.SignUp_Butt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SignUp_Butt.Size = new System.Drawing.Size(197, 32);
            this.SignUp_Butt.TabIndex = 23;
            this.SignUp_Butt.Text = "Зарегистрироваться";
            this.SignUp_Butt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SignUp_Butt.Click += new System.EventHandler(this.SignUp_Butt_Click);
            // 
            // LogUserPass_label
            // 
            this.LogUserPass_label.BackColor = System.Drawing.Color.Transparent;
            this.LogUserPass_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogUserPass_label.ForeColor = System.Drawing.Color.LightCoral;
            this.LogUserPass_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogUserPass_label.Location = new System.Drawing.Point(386, 245);
            this.LogUserPass_label.Name = "LogUserPass_label";
            this.LogUserPass_label.Size = new System.Drawing.Size(408, 30);
            this.LogUserPass_label.TabIndex = 22;
            this.LogUserPass_label.Text = "Неверный никнейм или пароль";
            this.LogUserPass_label.Visible = false;
            // 
            // LogIn_Butt
            // 
            this.LogIn_Butt.BackColor = System.Drawing.Color.Transparent;
            this.LogIn_Butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogIn_Butt.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogIn_Butt.ForeColor = System.Drawing.Color.White;
            this.LogIn_Butt.Location = new System.Drawing.Point(301, 379);
            this.LogIn_Butt.Name = "LogIn_Butt";
            this.LogIn_Butt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LogIn_Butt.Size = new System.Drawing.Size(197, 32);
            this.LogIn_Butt.TabIndex = 21;
            this.LogIn_Butt.Text = "Войти";
            this.LogIn_Butt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LogIn_Butt.Click += new System.EventHandler(this.LogIn_Butt_Click);
            // 
            // ShowPassword_CB
            // 
            this.ShowPassword_CB.AutoSize = true;
            this.ShowPassword_CB.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowPassword_CB.ForeColor = System.Drawing.Color.White;
            this.ShowPassword_CB.Location = new System.Drawing.Point(390, 213);
            this.ShowPassword_CB.Name = "ShowPassword_CB";
            this.ShowPassword_CB.Size = new System.Drawing.Size(182, 29);
            this.ShowPassword_CB.TabIndex = 20;
            this.ShowPassword_CB.Text = "Показать пароль";
            this.ShowPassword_CB.UseVisualStyleBackColor = true;
            this.ShowPassword_CB.CheckedChanged += new System.EventHandler(this.ShowPassword_CB_CheckedChanged);
            // 
            // LogUserName_label
            // 
            this.LogUserName_label.BackColor = System.Drawing.Color.Transparent;
            this.LogUserName_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogUserName_label.ForeColor = System.Drawing.Color.LightCoral;
            this.LogUserName_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogUserName_label.Location = new System.Drawing.Point(386, 139);
            this.LogUserName_label.Name = "LogUserName_label";
            this.LogUserName_label.Size = new System.Drawing.Size(408, 30);
            this.LogUserName_label.TabIndex = 19;
            this.LogUserName_label.Text = "Это имя пользователя уже занято";
            this.LogUserName_label.Visible = false;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(107, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(277, 28);
            this.label12.TabIndex = 18;
            this.label12.Text = "Пароль";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LogPass_TB
            // 
            this.LogPass_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.LogPass_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogPass_TB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogPass_TB.ForeColor = System.Drawing.Color.White;
            this.LogPass_TB.Location = new System.Drawing.Point(390, 171);
            this.LogPass_TB.Name = "LogPass_TB";
            this.LogPass_TB.PasswordChar = '*';
            this.LogPass_TB.Size = new System.Drawing.Size(367, 36);
            this.LogPass_TB.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(107, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(277, 28);
            this.label14.TabIndex = 15;
            this.label14.Text = "Никнейм ёжика";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LogInNick_TB
            // 
            this.LogInNick_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.LogInNick_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogInNick_TB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogInNick_TB.ForeColor = System.Drawing.Color.White;
            this.LogInNick_TB.Location = new System.Drawing.Point(390, 100);
            this.LogInNick_TB.Name = "LogInNick_TB";
            this.LogInNick_TB.Size = new System.Drawing.Size(367, 36);
            this.LogInNick_TB.TabIndex = 4;
            this.LogInNick_TB.Text = "@";
            this.LogInNick_TB.TextChanged += new System.EventHandler(this.LogInNick_TB_TextChanged);
            // 
            // PanelChatMembers
            // 
            this.PanelChatMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.PanelChatMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelChatMembers.Controls.Add(this.CloseMembersButt);
            this.PanelChatMembers.Controls.Add(this.Members_LB);
            this.PanelChatMembers.Location = new System.Drawing.Point(241, 62);
            this.PanelChatMembers.Name = "PanelChatMembers";
            this.PanelChatMembers.Size = new System.Drawing.Size(177, 197);
            this.PanelChatMembers.TabIndex = 20;
            this.PanelChatMembers.Visible = false;
            // 
            // CloseMembersButt
            // 
            this.CloseMembersButt.BackColor = System.Drawing.Color.Transparent;
            this.CloseMembersButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseMembersButt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseMembersButt.ForeColor = System.Drawing.Color.White;
            this.CloseMembersButt.Location = new System.Drawing.Point(47, 4);
            this.CloseMembersButt.Name = "CloseMembersButt";
            this.CloseMembersButt.Size = new System.Drawing.Size(125, 19);
            this.CloseMembersButt.TabIndex = 17;
            this.CloseMembersButt.Text = "Закрыть";
            this.CloseMembersButt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.CloseMembersButt.Click += new System.EventHandler(this.CloseMembersButt_Click);
            // 
            // Members_LB
            // 
            this.Members_LB.BackColor = System.Drawing.Color.Black;
            this.Members_LB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Members_LB.ContextMenuStrip = this.MembList_CM;
            this.Members_LB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Members_LB.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Members_LB.ForeColor = System.Drawing.Color.White;
            this.Members_LB.FormattingEnabled = true;
            this.Members_LB.ItemHeight = 21;
            this.Members_LB.Items.AddRange(new object[] {
            "Dmitry",
            "Alexey",
            "Ivan",
            "Mary",
            "Kate",
            "Olga",
            "Rusakov",
            "eronoff",
            "Anton",
            "Slava"});
            this.Members_LB.Location = new System.Drawing.Point(3, 26);
            this.Members_LB.Name = "Members_LB";
            this.Members_LB.Size = new System.Drawing.Size(171, 168);
            this.Members_LB.TabIndex = 6;
            // 
            // MembList_CM
            // 
            this.MembList_CM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MemberName_CMP,
            this.MemberStatus_CMP,
            this.toolStripMenuItem3,
            this.notify_CMP,
            this.BlockUser_CMP,
            this.AwayUser_CMP,
            this.toolStripMenuItem4,
            this.MakeAdmin_CMP,
            this.разжаловатьАдминистратораToolStripMenuItem,
            this.назначитьМодераторомToolStripMenuItem,
            this.разжаловатьМодератораToolStripMenuItem,
            this.статьМодераторомToolStripMenuItem,
            this.статьАдминистраторомToolStripMenuItem,
            this.статьМодераторомToolStripMenuItem1,
            this.статьУчастникомToolStripMenuItem});
            this.MembList_CM.Name = "MembList_CM";
            this.MembList_CM.Size = new System.Drawing.Size(239, 286);
            this.MembList_CM.Opening += new System.ComponentModel.CancelEventHandler(this.MembList_CM_Opening);
            // 
            // MemberName_CMP
            // 
            this.MemberName_CMP.Enabled = false;
            this.MemberName_CMP.Name = "MemberName_CMP";
            this.MemberName_CMP.Size = new System.Drawing.Size(238, 22);
            this.MemberName_CMP.Text = "Имя участника";
            // 
            // MemberStatus_CMP
            // 
            this.MemberStatus_CMP.Enabled = false;
            this.MemberStatus_CMP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.MemberStatus_CMP.Name = "MemberStatus_CMP";
            this.MemberStatus_CMP.Size = new System.Drawing.Size(238, 22);
            this.MemberStatus_CMP.Text = "в сети";
            this.MemberStatus_CMP.Visible = false;
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(235, 6);
            // 
            // notify_CMP
            // 
            this.notify_CMP.Name = "notify_CMP";
            this.notify_CMP.Size = new System.Drawing.Size(238, 22);
            this.notify_CMP.Text = "Упомянуть";
            this.notify_CMP.Click += new System.EventHandler(this.notify_CMP_Click);
            // 
            // BlockUser_CMP
            // 
            this.BlockUser_CMP.Name = "BlockUser_CMP";
            this.BlockUser_CMP.Size = new System.Drawing.Size(238, 22);
            this.BlockUser_CMP.Text = "Заблокировать";
            // 
            // AwayUser_CMP
            // 
            this.AwayUser_CMP.Name = "AwayUser_CMP";
            this.AwayUser_CMP.Size = new System.Drawing.Size(238, 22);
            this.AwayUser_CMP.Text = "Изгнать";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(235, 6);
            // 
            // MakeAdmin_CMP
            // 
            this.MakeAdmin_CMP.Name = "MakeAdmin_CMP";
            this.MakeAdmin_CMP.Size = new System.Drawing.Size(238, 22);
            this.MakeAdmin_CMP.Text = "Назначить администратором";
            // 
            // разжаловатьАдминистратораToolStripMenuItem
            // 
            this.разжаловатьАдминистратораToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DemoteModer_CMP,
            this.DemoteMemb_CMP});
            this.разжаловатьАдминистратораToolStripMenuItem.Name = "разжаловатьАдминистратораToolStripMenuItem";
            this.разжаловатьАдминистратораToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.разжаловатьАдминистратораToolStripMenuItem.Text = "Разжаловать администратора";
            // 
            // DemoteModer_CMP
            // 
            this.DemoteModer_CMP.Name = "DemoteModer_CMP";
            this.DemoteModer_CMP.Size = new System.Drawing.Size(156, 22);
            this.DemoteModer_CMP.Text = "до модератора";
            // 
            // DemoteMemb_CMP
            // 
            this.DemoteMemb_CMP.Name = "DemoteMemb_CMP";
            this.DemoteMemb_CMP.Size = new System.Drawing.Size(156, 22);
            this.DemoteMemb_CMP.Text = "до участника";
            // 
            // назначитьМодераторомToolStripMenuItem
            // 
            this.назначитьМодераторомToolStripMenuItem.Name = "назначитьМодераторомToolStripMenuItem";
            this.назначитьМодераторомToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.назначитьМодераторомToolStripMenuItem.Text = "Назначить модератором";
            // 
            // разжаловатьМодератораToolStripMenuItem
            // 
            this.разжаловатьМодератораToolStripMenuItem.Name = "разжаловатьМодератораToolStripMenuItem";
            this.разжаловатьМодератораToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.разжаловатьМодератораToolStripMenuItem.Text = "Разжаловать модератора";
            // 
            // статьМодераторомToolStripMenuItem
            // 
            this.статьМодераторомToolStripMenuItem.Name = "статьМодераторомToolStripMenuItem";
            this.статьМодераторомToolStripMenuItem.Size = new System.Drawing.Size(235, 6);
            // 
            // статьАдминистраторомToolStripMenuItem
            // 
            this.статьАдминистраторомToolStripMenuItem.Name = "статьАдминистраторомToolStripMenuItem";
            this.статьАдминистраторомToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.статьАдминистраторомToolStripMenuItem.Text = "Стать администратором";
            // 
            // статьМодераторомToolStripMenuItem1
            // 
            this.статьМодераторомToolStripMenuItem1.Name = "статьМодераторомToolStripMenuItem1";
            this.статьМодераторомToolStripMenuItem1.Size = new System.Drawing.Size(238, 22);
            this.статьМодераторомToolStripMenuItem1.Text = "Стать модератором";
            // 
            // статьУчастникомToolStripMenuItem
            // 
            this.статьУчастникомToolStripMenuItem.Name = "статьУчастникомToolStripMenuItem";
            this.статьУчастникомToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.статьУчастникомToolStripMenuItem.Text = "Стать участником";
            // 
            // timerChats
            // 
            this.timerChats.Interval = 2500;
            this.timerChats.Tick += new System.EventHandler(this.timerChats_Tick);
            // 
            // timerFastUpdate
            // 
            this.timerFastUpdate.Interval = 5000;
            this.timerFastUpdate.Tick += new System.EventHandler(this.timerFastUpdate_Tick);
            // 
            // LogOut_Butt
            // 
            this.LogOut_Butt.BackColor = System.Drawing.Color.Transparent;
            this.LogOut_Butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOut_Butt.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogOut_Butt.ForeColor = System.Drawing.Color.White;
            this.LogOut_Butt.Location = new System.Drawing.Point(810, 9);
            this.LogOut_Butt.Name = "LogOut_Butt";
            this.LogOut_Butt.Size = new System.Drawing.Size(197, 32);
            this.LogOut_Butt.TabIndex = 21;
            this.LogOut_Butt.Text = "Выйти";
            this.LogOut_Butt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.LogOut_Butt.Click += new System.EventHandler(this.LogOut_Butt_Click);
            // 
            // FormMessanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1019, 545);
            this.Controls.Add(this.LogOut_Butt);
            this.Controls.Add(this.PanelChatMembers);
            this.Controls.Add(this.CreateChat_butt);
            this.Controls.Add(this.label_notifymore);
            this.Controls.Add(this.label_notify4);
            this.Controls.Add(this.label_notify3);
            this.Controls.Add(this.label_notify2);
            this.Controls.Add(this.SendButt);
            this.Controls.Add(this.label_notify1);
            this.Controls.Add(this.chatsLB);
            this.Controls.Add(this.head_lbl);
            this.Controls.Add(this.MessageTB);
            this.Controls.Add(this.panel_emptyChat);
            this.Controls.Add(this.panel_messages);
            this.Controls.Add(this.panel_registration);
            this.Controls.Add(this.panelCreateChat);
            this.Name = "FormMessanger";
            this.Text = "ЁжМессенджер";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ChatListCM.ResumeLayout(false);
            this.panel_messages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FixScrollBar)).EndInit();
            this.panelMsg_4.ResumeLayout(false);
            this.panelMsg_4.PerformLayout();
            this.panelMsg_3.ResumeLayout(false);
            this.panelMsg_3.PerformLayout();
            this.panelMsg_2.ResumeLayout(false);
            this.panelMsg_2.PerformLayout();
            this.panelMsg_1.ResumeLayout(false);
            this.panelMsg_1.PerformLayout();
            this.panel_emptyChat.ResumeLayout(false);
            this.panelCreateChat.ResumeLayout(false);
            this.panelCreateChat.PerformLayout();
            this.panel_registration.ResumeLayout(false);
            this.panel_registration.PerformLayout();
            this.PanelChatMembers.ResumeLayout(false);
            this.MembList_CM.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void timerChangeColor_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.TextBox MessageTB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label head_lbl;
        private System.Windows.Forms.ListBox chatsLB;
        private System.Windows.Forms.Label SendButt;
        private System.Windows.Forms.Timer timer_wighter;
        private System.Windows.Forms.Label label_notify1;
        private System.Windows.Forms.Label label_notify2;
        private System.Windows.Forms.Label label_notify3;
        private System.Windows.Forms.Label label_notify4;
        private System.Windows.Forms.Label label_notifymore;
        private System.Windows.Forms.Panel panel_messages;
        private System.Windows.Forms.Panel panelMsg_1;
        private System.Windows.Forms.Label textMsg_1;
        private System.Windows.Forms.Label nameMsg_1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label notifyMsg_1;
        private System.Windows.Forms.Label timeMsg_1;
        private System.Windows.Forms.Panel panelMsg_2;
        private System.Windows.Forms.Label timeMsg_2;
        private System.Windows.Forms.Label notifyMsg_2;
        private System.Windows.Forms.Label textMsg_2;
        private System.Windows.Forms.Label nameMsg_2;
        private System.Windows.Forms.Panel panelMsg_3;
        private System.Windows.Forms.Label timeMsg_3;
        private System.Windows.Forms.Label notifyMsg_3;
        private System.Windows.Forms.Label textMsg_3;
        private System.Windows.Forms.Label nameMsg_3;
        private System.Windows.Forms.Panel panelMsg_4;
        private System.Windows.Forms.Label timeMsg_4;
        private System.Windows.Forms.Label notifyMsg_4;
        private System.Windows.Forms.Label textMsg_4;
        private System.Windows.Forms.Label nameMsg_4;
        private System.Windows.Forms.Panel panel_emptyChat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CreateChat_butt;
        private System.Windows.Forms.ContextMenuStrip ChatListCM;
        private System.Windows.Forms.ToolStripMenuItem ChatNameCMP;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem InviteChat_CMP;
        private System.Windows.Forms.ToolStripMenuItem ChatMembers_CMP;
        private System.Windows.Forms.ToolStripMenuItem переименоватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LeaveChat_CMP;
        private System.Windows.Forms.ToolStripMenuItem deleteChat_context;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem CreateChat_CMP;
        private System.Windows.Forms.ToolStripMenuItem CreateSecret_CMP;
        private System.Windows.Forms.Panel panelCreateChat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ChatNameTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ChatMembersTB;
        private System.Windows.Forms.CheckBox SecretChat_CB;
        private System.Windows.Forms.Label ConfirmCreateChat_Butt;
        private System.Windows.Forms.Panel panel_registration;
        private System.Windows.Forms.Label SignUp_Butt;
        private System.Windows.Forms.Label LogUserPass_label;
        private System.Windows.Forms.Label LogIn_Butt;
        private System.Windows.Forms.CheckBox ShowPassword_CB;
        private System.Windows.Forms.Label LogUserName_label;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox LogPass_TB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox LogInNick_TB;
        private System.Windows.Forms.Label Error_label;
        private System.Windows.Forms.PictureBox FixScrollBar;
        private System.Windows.Forms.Panel PanelChatMembers;
        private System.Windows.Forms.ListBox Members_LB;
        private System.Windows.Forms.ContextMenuStrip MembList_CM;
        private System.Windows.Forms.ToolStripMenuItem MemberName_CMP;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem notify_CMP;
        private System.Windows.Forms.ToolStripMenuItem BlockUser_CMP;
        private System.Windows.Forms.ToolStripMenuItem AwayUser_CMP;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem MakeAdmin_CMP;
        private System.Windows.Forms.ToolStripMenuItem разжаловатьАдминистратораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DemoteModer_CMP;
        private System.Windows.Forms.ToolStripMenuItem DemoteMemb_CMP;
        private System.Windows.Forms.ToolStripMenuItem назначитьМодераторомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разжаловатьМодератораToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator статьМодераторомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статьАдминистраторомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статьМодераторомToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem статьУчастникомToolStripMenuItem;
        private System.Windows.Forms.Timer timerChats;
        private System.Windows.Forms.Label CloseMembersButt;
        private System.Windows.Forms.Timer timerFastUpdate;
        private System.Windows.Forms.ToolStripMenuItem MemberStatus_CMP;
        private System.Windows.Forms.Label LogOut_Butt;
    }
}

