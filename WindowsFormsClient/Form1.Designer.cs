
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
            this.LeaveChat_CMP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.CreateChat_CMP = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateSecret_CMP = new System.Windows.Forms.ToolStripMenuItem();
            this.SendButt = new System.Windows.Forms.Label();
            this.label_notify1 = new System.Windows.Forms.Label();
            this.label_notify2 = new System.Windows.Forms.Label();
            this.label_notify3 = new System.Windows.Forms.Label();
            this.label_notify4 = new System.Windows.Forms.Label();
            this.label_notifymore = new System.Windows.Forms.Label();
            this.panel_messages = new System.Windows.Forms.Panel();
            this.panel_emptyChat = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.FixScrollBar = new System.Windows.Forms.PictureBox();
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
            this.textMsg_2 = new System.Windows.Forms.Label();
            this.timeMsg_2 = new System.Windows.Forms.Label();
            this.notifyMsg_2 = new System.Windows.Forms.Label();
            this.nameMsg_2 = new System.Windows.Forms.Label();
            this.panelMsg_1 = new System.Windows.Forms.Panel();
            this.textMsg_1 = new System.Windows.Forms.Label();
            this.timeMsg_1 = new System.Windows.Forms.Label();
            this.notifyMsg_1 = new System.Windows.Forms.Label();
            this.nameMsg_1 = new System.Windows.Forms.Label();
            this.Error_label = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CreateChat_butt = new System.Windows.Forms.Label();
            this.panelCreateChat = new System.Windows.Forms.Panel();
            this.CloseCreateChat = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ChatMembersTB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChatNameTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ConfirmCreateChat_Butt = new System.Windows.Forms.Label();
            this.SecretChat_CB = new System.Windows.Forms.CheckBox();
            this.panel_registration = new System.Windows.Forms.Panel();
            this.PanelRegName = new System.Windows.Forms.Panel();
            this.LogInNick_TB = new System.Windows.Forms.TextBox();
            this.LogUserName_label = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SignUp_Butt = new System.Windows.Forms.Label();
            this.PanelRegPass = new System.Windows.Forms.Panel();
            this.LogUserPass_label = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LogPass_TB = new System.Windows.Forms.TextBox();
            this.ShowPassword_CB = new System.Windows.Forms.CheckBox();
            this.LogIn_Butt = new System.Windows.Forms.Label();
            this.PanelChatMembers = new System.Windows.Forms.Panel();
            this.Label_Updating = new System.Windows.Forms.Label();
            this.CloseMembersButt = new System.Windows.Forms.Label();
            this.Members_LB = new System.Windows.Forms.ListBox();
            this.MembList_CM = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MemberName_CMP = new System.Windows.Forms.ToolStripMenuItem();
            this.MemberStatus_CMP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.notify_CMP = new System.Windows.Forms.ToolStripMenuItem();
            this.BlockUser_CMP = new System.Windows.Forms.ToolStripMenuItem();
            this.AwayUser_CMP = new System.Windows.Forms.ToolStripMenuItem();
            this.MembSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.MakeAdmin_CMP = new System.Windows.Forms.ToolStripMenuItem();
            this.DemoteAdmin_CMP = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminToModer_CMP = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminToMemb_CMP = new System.Windows.Forms.ToolStripMenuItem();
            this.MakeModer_CMP = new System.Windows.Forms.ToolStripMenuItem();
            this.DemoteModer_CMP = new System.Windows.Forms.ToolStripMenuItem();
            this.MembSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.BecomeAdmin_CMP = new System.Windows.Forms.ToolStripMenuItem();
            this.BecomeModer_CMP = new System.Windows.Forms.ToolStripMenuItem();
            this.BecomeMemb_CMP = new System.Windows.Forms.ToolStripMenuItem();
            this.timerChats = new System.Windows.Forms.Timer(this.components);
            this.timerFastUpdate = new System.Windows.Forms.Timer(this.components);
            this.panel_invite = new System.Windows.Forms.Panel();
            this.Invite_Butt = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.InviteRename_TB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CloseInviteWindow = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TimerOnline = new System.Windows.Forms.Timer(this.components);
            this.NavigationBar = new System.Windows.Forms.PictureBox();
            this.CloseWindowButton = new System.Windows.Forms.Label();
            this.Minimize_Butt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PictureTriangle = new System.Windows.Forms.PictureBox();
            this.PanelLeavingChat = new System.Windows.Forms.Panel();
            this.LeaveChat_Butt = new System.Windows.Forms.Label();
            this.StayChat_Butt = new System.Windows.Forms.Label();
            this.TextAttentionLeaving = new System.Windows.Forms.Label();
            this.Panel_NoConnection = new System.Windows.Forms.Panel();
            this.Button_repeatConnection = new System.Windows.Forms.Label();
            this.Label_Invitations = new System.Windows.Forms.Label();
            this.Invites_LB = new System.Windows.Forms.ListBox();
            this.ChatListCM.SuspendLayout();
            this.panel_messages.SuspendLayout();
            this.panel_emptyChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FixScrollBar)).BeginInit();
            this.panelMsg_4.SuspendLayout();
            this.panelMsg_3.SuspendLayout();
            this.panelMsg_2.SuspendLayout();
            this.panelMsg_1.SuspendLayout();
            this.panelCreateChat.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_registration.SuspendLayout();
            this.PanelRegName.SuspendLayout();
            this.PanelRegPass.SuspendLayout();
            this.PanelChatMembers.SuspendLayout();
            this.MembList_CM.SuspendLayout();
            this.panel_invite.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavigationBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureTriangle)).BeginInit();
            this.PanelLeavingChat.SuspendLayout();
            this.Panel_NoConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageTB
            // 
            this.MessageTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.MessageTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageTB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageTB.ForeColor = System.Drawing.Color.Gray;
            this.MessageTB.Location = new System.Drawing.Point(249, 439);
            this.MessageTB.Name = "MessageTB";
            this.MessageTB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.MessageTB.Size = new System.Drawing.Size(511, 25);
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
            this.head_lbl.Location = new System.Drawing.Point(7, 46);
            this.head_lbl.Name = "head_lbl";
            this.head_lbl.Size = new System.Drawing.Size(213, 40);
            this.head_lbl.TabIndex = 4;
            this.head_lbl.Text = "Ёжечаты";
            // 
            // chatsLB
            // 
            this.chatsLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.chatsLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chatsLB.ContextMenuStrip = this.ChatListCM;
            this.chatsLB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chatsLB.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chatsLB.ForeColor = System.Drawing.Color.White;
            this.chatsLB.FormattingEnabled = true;
            this.chatsLB.ItemHeight = 23;
            this.chatsLB.Items.AddRange(new object[] {
            "Общий чат"});
            this.chatsLB.Location = new System.Drawing.Point(14, 91);
            this.chatsLB.Name = "chatsLB";
            this.chatsLB.Size = new System.Drawing.Size(208, 370);
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
            this.LeaveChat_CMP,
            this.toolStripMenuItem2,
            this.CreateChat_CMP,
            this.CreateSecret_CMP});
            this.ChatListCM.Name = "contextMenuStrip1";
            this.ChatListCM.Size = new System.Drawing.Size(243, 148);
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
            this.InviteChat_CMP.Click += new System.EventHandler(this.InviteChat_CMP_Click);
            // 
            // ChatMembers_CMP
            // 
            this.ChatMembers_CMP.Name = "ChatMembers_CMP";
            this.ChatMembers_CMP.Size = new System.Drawing.Size(242, 22);
            this.ChatMembers_CMP.Text = "Участники";
            this.ChatMembers_CMP.Click += new System.EventHandler(this.ChatMembers_CMP_Click);
            // 
            // LeaveChat_CMP
            // 
            this.LeaveChat_CMP.Name = "LeaveChat_CMP";
            this.LeaveChat_CMP.Size = new System.Drawing.Size(242, 22);
            this.LeaveChat_CMP.Text = "Покинуть ёжечат";
            this.LeaveChat_CMP.Click += new System.EventHandler(this.LeaveChat_CMP_Click);
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
            this.SendButt.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendButt.ForeColor = System.Drawing.Color.White;
            this.SendButt.Location = new System.Drawing.Point(743, 439);
            this.SendButt.Name = "SendButt";
            this.SendButt.Size = new System.Drawing.Size(129, 32);
            this.SendButt.TabIndex = 6;
            this.SendButt.Text = "Отправить";
            this.SendButt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.SendButt.Click += new System.EventHandler(this.SendButt_Click);
            // 
            // label_notify1
            // 
            this.label_notify1.AutoSize = true;
            this.label_notify1.BackColor = System.Drawing.Color.Transparent;
            this.label_notify1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_notify1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(199)))), ((int)(((byte)(254)))));
            this.label_notify1.Location = new System.Drawing.Point(259, 414);
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
            this.label_notify2.Location = new System.Drawing.Point(354, 414);
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
            this.label_notify3.Location = new System.Drawing.Point(449, 414);
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
            this.label_notify4.Location = new System.Drawing.Point(544, 414);
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
            this.label_notifymore.Location = new System.Drawing.Point(641, 414);
            this.label_notifymore.Name = "label_notifymore";
            this.label_notifymore.Size = new System.Drawing.Size(79, 21);
            this.label_notifymore.TabIndex = 13;
            this.label_notifymore.Text = "everyone";
            this.label_notifymore.Visible = false;
            // 
            // panel_messages
            // 
            this.panel_messages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_messages.Controls.Add(this.panel_emptyChat);
            this.panel_messages.Controls.Add(this.FixScrollBar);
            this.panel_messages.Controls.Add(this.panelMsg_4);
            this.panel_messages.Controls.Add(this.panelMsg_3);
            this.panel_messages.Controls.Add(this.panelMsg_2);
            this.panel_messages.Controls.Add(this.panelMsg_1);
            this.panel_messages.Location = new System.Drawing.Point(249, 91);
            this.panel_messages.Name = "panel_messages";
            this.panel_messages.Size = new System.Drawing.Size(623, 334);
            this.panel_messages.TabIndex = 14;
            this.panel_messages.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panel_messages_Scroll);
            this.panel_messages.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel_messages.MouseEnter += new System.EventHandler(this.panel_messages_MouseEnter);
            this.panel_messages.MouseLeave += new System.EventHandler(this.panel_messages_MouseLeave);
            this.panel_messages.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.panel_messages_MouseWheel);
            // 
            // panel_emptyChat
            // 
            this.panel_emptyChat.Controls.Add(this.label5);
            this.panel_emptyChat.Location = new System.Drawing.Point(1, 1);
            this.panel_emptyChat.Name = "panel_emptyChat";
            this.panel_emptyChat.Size = new System.Drawing.Size(621, 331);
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
            this.label5.Size = new System.Drawing.Size(618, 196);
            this.label5.TabIndex = 16;
            this.label5.Text = "Этот чат ёжепуст";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FixScrollBar
            // 
            this.FixScrollBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FixScrollBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FixScrollBar.ErrorImage = null;
            this.FixScrollBar.InitialImage = null;
            this.FixScrollBar.Location = new System.Drawing.Point(610, -1);
            this.FixScrollBar.Name = "FixScrollBar";
            this.FixScrollBar.Size = new System.Drawing.Size(12, 86);
            this.FixScrollBar.TabIndex = 18;
            this.FixScrollBar.TabStop = false;
            this.FixScrollBar.Visible = false;
            // 
            // panelMsg_4
            // 
            this.panelMsg_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMsg_4.Controls.Add(this.timeMsg_4);
            this.panelMsg_4.Controls.Add(this.notifyMsg_4);
            this.panelMsg_4.Controls.Add(this.textMsg_4);
            this.panelMsg_4.Controls.Add(this.nameMsg_4);
            this.panelMsg_4.Location = new System.Drawing.Point(0, 0);
            this.panelMsg_4.Name = "panelMsg_4";
            this.panelMsg_4.Size = new System.Drawing.Size(608, 77);
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
            this.timeMsg_4.Size = new System.Drawing.Size(214, 21);
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
            this.textMsg_4.MaximumSize = new System.Drawing.Size(300, 0);
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
            this.panelMsg_3.Location = new System.Drawing.Point(0, 80);
            this.panelMsg_3.Name = "panelMsg_3";
            this.panelMsg_3.Size = new System.Drawing.Size(608, 77);
            this.panelMsg_3.TabIndex = 2;
            this.panelMsg_3.Visible = false;
            // 
            // timeMsg_3
            // 
            this.timeMsg_3.BackColor = System.Drawing.Color.Transparent;
            this.timeMsg_3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeMsg_3.ForeColor = System.Drawing.Color.DarkGray;
            this.timeMsg_3.Location = new System.Drawing.Point(414, 41);
            this.timeMsg_3.Name = "timeMsg_3";
            this.timeMsg_3.Size = new System.Drawing.Size(193, 21);
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
            this.textMsg_3.MaximumSize = new System.Drawing.Size(300, 0);
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
            this.panelMsg_2.Controls.Add(this.textMsg_2);
            this.panelMsg_2.Controls.Add(this.timeMsg_2);
            this.panelMsg_2.Controls.Add(this.notifyMsg_2);
            this.panelMsg_2.Controls.Add(this.nameMsg_2);
            this.panelMsg_2.Location = new System.Drawing.Point(0, 160);
            this.panelMsg_2.Name = "panelMsg_2";
            this.panelMsg_2.Size = new System.Drawing.Size(608, 77);
            this.panelMsg_2.TabIndex = 1;
            this.panelMsg_2.Visible = false;
            // 
            // textMsg_2
            // 
            this.textMsg_2.AutoSize = true;
            this.textMsg_2.BackColor = System.Drawing.Color.Transparent;
            this.textMsg_2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMsg_2.ForeColor = System.Drawing.Color.DarkGray;
            this.textMsg_2.Location = new System.Drawing.Point(18, 38);
            this.textMsg_2.MaximumSize = new System.Drawing.Size(300, 0);
            this.textMsg_2.Name = "textMsg_2";
            this.textMsg_2.Size = new System.Drawing.Size(290, 23);
            this.textMsg_2.TabIndex = 15;
            this.textMsg_2.Text = "Hello, hello again. I am writing you...";
            // 
            // timeMsg_2
            // 
            this.timeMsg_2.BackColor = System.Drawing.Color.Transparent;
            this.timeMsg_2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeMsg_2.ForeColor = System.Drawing.Color.DarkGray;
            this.timeMsg_2.Location = new System.Drawing.Point(410, 40);
            this.timeMsg_2.Name = "timeMsg_2";
            this.timeMsg_2.Size = new System.Drawing.Size(197, 21);
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
            this.panelMsg_1.Controls.Add(this.textMsg_1);
            this.panelMsg_1.Controls.Add(this.timeMsg_1);
            this.panelMsg_1.Controls.Add(this.notifyMsg_1);
            this.panelMsg_1.Controls.Add(this.nameMsg_1);
            this.panelMsg_1.Location = new System.Drawing.Point(0, 241);
            this.panelMsg_1.Name = "panelMsg_1";
            this.panelMsg_1.Size = new System.Drawing.Size(608, 77);
            this.panelMsg_1.TabIndex = 0;
            this.panelMsg_1.Visible = false;
            // 
            // textMsg_1
            // 
            this.textMsg_1.AutoSize = true;
            this.textMsg_1.BackColor = System.Drawing.Color.Transparent;
            this.textMsg_1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMsg_1.ForeColor = System.Drawing.Color.DarkGray;
            this.textMsg_1.Location = new System.Drawing.Point(18, 38);
            this.textMsg_1.MaximumSize = new System.Drawing.Size(300, 0);
            this.textMsg_1.Name = "textMsg_1";
            this.textMsg_1.Size = new System.Drawing.Size(290, 23);
            this.textMsg_1.TabIndex = 15;
            this.textMsg_1.Text = "Hello, hello again. I am writing you...";
            // 
            // timeMsg_1
            // 
            this.timeMsg_1.BackColor = System.Drawing.Color.Transparent;
            this.timeMsg_1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeMsg_1.ForeColor = System.Drawing.Color.DarkGray;
            this.timeMsg_1.Location = new System.Drawing.Point(370, 40);
            this.timeMsg_1.Name = "timeMsg_1";
            this.timeMsg_1.Size = new System.Drawing.Size(237, 21);
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
            // Error_label
            // 
            this.Error_label.BackColor = System.Drawing.Color.Transparent;
            this.Error_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Error_label.ForeColor = System.Drawing.Color.LightCoral;
            this.Error_label.Location = new System.Drawing.Point(-1, 6);
            this.Error_label.Name = "Error_label";
            this.Error_label.Size = new System.Drawing.Size(198, 32);
            this.Error_label.TabIndex = 17;
            this.Error_label.Text = "Нет ёжесоединения";
            this.Error_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CreateChat_butt
            // 
            this.CreateChat_butt.BackColor = System.Drawing.Color.Transparent;
            this.CreateChat_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateChat_butt.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateChat_butt.ForeColor = System.Drawing.Color.White;
            this.CreateChat_butt.Location = new System.Drawing.Point(12, 464);
            this.CreateChat_butt.Name = "CreateChat_butt";
            this.CreateChat_butt.Size = new System.Drawing.Size(197, 32);
            this.CreateChat_butt.TabIndex = 16;
            this.CreateChat_butt.Text = "Создать ёжечат";
            this.CreateChat_butt.Click += new System.EventHandler(this.CreateChat_butt_Click);
            // 
            // panelCreateChat
            // 
            this.panelCreateChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panelCreateChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCreateChat.Controls.Add(this.CloseCreateChat);
            this.panelCreateChat.Controls.Add(this.panel2);
            this.panelCreateChat.Controls.Add(this.panel1);
            this.panelCreateChat.Controls.Add(this.label2);
            this.panelCreateChat.Controls.Add(this.ConfirmCreateChat_Butt);
            this.panelCreateChat.Controls.Add(this.SecretChat_CB);
            this.panelCreateChat.Location = new System.Drawing.Point(268, 249);
            this.panelCreateChat.Name = "panelCreateChat";
            this.panelCreateChat.Size = new System.Drawing.Size(349, 246);
            this.panelCreateChat.TabIndex = 18;
            this.panelCreateChat.Visible = false;
            // 
            // CloseCreateChat
            // 
            this.CloseCreateChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.CloseCreateChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CloseCreateChat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseCreateChat.Font = new System.Drawing.Font("Webdings", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CloseCreateChat.ForeColor = System.Drawing.Color.White;
            this.CloseCreateChat.Location = new System.Drawing.Point(225, 7);
            this.CloseCreateChat.Margin = new System.Windows.Forms.Padding(0);
            this.CloseCreateChat.Name = "CloseCreateChat";
            this.CloseCreateChat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CloseCreateChat.Size = new System.Drawing.Size(20, 20);
            this.CloseCreateChat.TabIndex = 32;
            this.CloseCreateChat.Text = "r";
            this.CloseCreateChat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseCreateChat.Click += new System.EventHandler(this.CloseCreateChat_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.ChatMembersTB);
            this.panel2.Location = new System.Drawing.Point(1, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 74);
            this.panel2.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(137, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "через пробел";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(137, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(294, 27);
            this.label9.TabIndex = 19;
            this.label9.Text = "Перечислите никнеймы";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 28);
            this.label8.TabIndex = 18;
            this.label8.Text = "Участники";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ChatMembersTB
            // 
            this.ChatMembersTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ChatMembersTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChatMembersTB.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChatMembersTB.ForeColor = System.Drawing.Color.White;
            this.ChatMembersTB.Location = new System.Drawing.Point(141, 4);
            this.ChatMembersTB.Name = "ChatMembersTB";
            this.ChatMembersTB.Size = new System.Drawing.Size(185, 27);
            this.ChatMembersTB.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ChatNameTB);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(1, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 40);
            this.panel1.TabIndex = 30;
            // 
            // ChatNameTB
            // 
            this.ChatNameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ChatNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChatNameTB.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChatNameTB.ForeColor = System.Drawing.Color.White;
            this.ChatNameTB.Location = new System.Drawing.Point(141, 3);
            this.ChatNameTB.Name = "ChatNameTB";
            this.ChatNameTB.Size = new System.Drawing.Size(185, 27);
            this.ChatNameTB.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Имя ёжечата";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 27);
            this.label2.TabIndex = 29;
            this.label2.Text = "Создать чат";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ConfirmCreateChat_Butt
            // 
            this.ConfirmCreateChat_Butt.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmCreateChat_Butt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConfirmCreateChat_Butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmCreateChat_Butt.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmCreateChat_Butt.ForeColor = System.Drawing.Color.White;
            this.ConfirmCreateChat_Butt.Location = new System.Drawing.Point(110, 207);
            this.ConfirmCreateChat_Butt.Name = "ConfirmCreateChat_Butt";
            this.ConfirmCreateChat_Butt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ConfirmCreateChat_Butt.Size = new System.Drawing.Size(130, 24);
            this.ConfirmCreateChat_Butt.TabIndex = 21;
            this.ConfirmCreateChat_Butt.Text = "Создать ёжечат";
            this.ConfirmCreateChat_Butt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ConfirmCreateChat_Butt.Click += new System.EventHandler(this.ConfirmCreateChat_Butt_Click);
            // 
            // SecretChat_CB
            // 
            this.SecretChat_CB.AutoSize = true;
            this.SecretChat_CB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecretChat_CB.ForeColor = System.Drawing.Color.White;
            this.SecretChat_CB.Location = new System.Drawing.Point(142, 169);
            this.SecretChat_CB.Name = "SecretChat_CB";
            this.SecretChat_CB.Size = new System.Drawing.Size(172, 23);
            this.SecretChat_CB.TabIndex = 20;
            this.SecretChat_CB.Text = "Ёжесекретный ёжечат";
            this.SecretChat_CB.UseVisualStyleBackColor = true;
            // 
            // panel_registration
            // 
            this.panel_registration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel_registration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_registration.Controls.Add(this.PanelRegName);
            this.panel_registration.Controls.Add(this.label1);
            this.panel_registration.Controls.Add(this.SignUp_Butt);
            this.panel_registration.Controls.Add(this.PanelRegPass);
            this.panel_registration.Controls.Add(this.LogIn_Butt);
            this.panel_registration.Location = new System.Drawing.Point(268, 36);
            this.panel_registration.Name = "panel_registration";
            this.panel_registration.Size = new System.Drawing.Size(349, 200);
            this.panel_registration.TabIndex = 19;
            // 
            // PanelRegName
            // 
            this.PanelRegName.Controls.Add(this.LogInNick_TB);
            this.PanelRegName.Controls.Add(this.LogUserName_label);
            this.PanelRegName.Controls.Add(this.label14);
            this.PanelRegName.Location = new System.Drawing.Point(-1, 49);
            this.PanelRegName.Name = "PanelRegName";
            this.PanelRegName.Size = new System.Drawing.Size(349, 38);
            this.PanelRegName.TabIndex = 26;
            // 
            // LogInNick_TB
            // 
            this.LogInNick_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.LogInNick_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogInNick_TB.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogInNick_TB.ForeColor = System.Drawing.Color.White;
            this.LogInNick_TB.Location = new System.Drawing.Point(142, 6);
            this.LogInNick_TB.Margin = new System.Windows.Forms.Padding(0);
            this.LogInNick_TB.Name = "LogInNick_TB";
            this.LogInNick_TB.Size = new System.Drawing.Size(185, 27);
            this.LogInNick_TB.TabIndex = 4;
            this.LogInNick_TB.Text = "@";
            this.LogInNick_TB.TextChanged += new System.EventHandler(this.LogInNick_TB_TextChanged);
            // 
            // LogUserName_label
            // 
            this.LogUserName_label.BackColor = System.Drawing.Color.Transparent;
            this.LogUserName_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogUserName_label.ForeColor = System.Drawing.Color.LightCoral;
            this.LogUserName_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogUserName_label.Location = new System.Drawing.Point(139, 34);
            this.LogUserName_label.Name = "LogUserName_label";
            this.LogUserName_label.Size = new System.Drawing.Size(191, 20);
            this.LogUserName_label.TabIndex = 19;
            this.LogUserName_label.Text = "Это имя уже занято";
            this.LogUserName_label.Visible = false;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(3, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 28);
            this.label14.TabIndex = 15;
            this.label14.Text = "Никнейм ёжика";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 27);
            this.label1.TabIndex = 28;
            this.label1.Text = "Войдите или зарегистрируйтесь";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SignUp_Butt
            // 
            this.SignUp_Butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.SignUp_Butt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SignUp_Butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUp_Butt.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignUp_Butt.ForeColor = System.Drawing.Color.White;
            this.SignUp_Butt.Location = new System.Drawing.Point(147, 161);
            this.SignUp_Butt.Margin = new System.Windows.Forms.Padding(0);
            this.SignUp_Butt.Name = "SignUp_Butt";
            this.SignUp_Butt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SignUp_Butt.Size = new System.Drawing.Size(150, 24);
            this.SignUp_Butt.TabIndex = 23;
            this.SignUp_Butt.Text = "Зарегистрироваться";
            this.SignUp_Butt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SignUp_Butt.Click += new System.EventHandler(this.SignUp_Butt_Click);
            this.SignUp_Butt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SignUp_Butt_MouseDown);
            this.SignUp_Butt.MouseHover += new System.EventHandler(this.SignUp_Butt_MouseHover);
            // 
            // PanelRegPass
            // 
            this.PanelRegPass.Controls.Add(this.LogUserPass_label);
            this.PanelRegPass.Controls.Add(this.label12);
            this.PanelRegPass.Controls.Add(this.LogPass_TB);
            this.PanelRegPass.Controls.Add(this.ShowPassword_CB);
            this.PanelRegPass.Location = new System.Drawing.Point(1, 89);
            this.PanelRegPass.Name = "PanelRegPass";
            this.PanelRegPass.Size = new System.Drawing.Size(347, 61);
            this.PanelRegPass.TabIndex = 27;
            // 
            // LogUserPass_label
            // 
            this.LogUserPass_label.BackColor = System.Drawing.Color.Transparent;
            this.LogUserPass_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogUserPass_label.ForeColor = System.Drawing.Color.LightCoral;
            this.LogUserPass_label.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.LogUserPass_label.Location = new System.Drawing.Point(7, 34);
            this.LogUserPass_label.Name = "LogUserPass_label";
            this.LogUserPass_label.Size = new System.Drawing.Size(235, 21);
            this.LogUserPass_label.TabIndex = 22;
            this.LogUserPass_label.Text = "Неверный пароль";
            this.LogUserPass_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.LogUserPass_label.Visible = false;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(3, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 28);
            this.label12.TabIndex = 18;
            this.label12.Text = "Пароль";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LogPass_TB
            // 
            this.LogPass_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.LogPass_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogPass_TB.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogPass_TB.ForeColor = System.Drawing.Color.White;
            this.LogPass_TB.Location = new System.Drawing.Point(140, 6);
            this.LogPass_TB.Name = "LogPass_TB";
            this.LogPass_TB.PasswordChar = '*';
            this.LogPass_TB.Size = new System.Drawing.Size(185, 27);
            this.LogPass_TB.TabIndex = 17;
            this.LogPass_TB.TextChanged += new System.EventHandler(this.LogPass_TB_TextChanged);
            // 
            // ShowPassword_CB
            // 
            this.ShowPassword_CB.AutoSize = true;
            this.ShowPassword_CB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowPassword_CB.ForeColor = System.Drawing.Color.White;
            this.ShowPassword_CB.Location = new System.Drawing.Point(248, 33);
            this.ShowPassword_CB.Name = "ShowPassword_CB";
            this.ShowPassword_CB.Size = new System.Drawing.Size(86, 23);
            this.ShowPassword_CB.TabIndex = 20;
            this.ShowPassword_CB.Text = "Показать";
            this.ShowPassword_CB.UseVisualStyleBackColor = true;
            this.ShowPassword_CB.CheckedChanged += new System.EventHandler(this.ShowPassword_CB_CheckedChanged);
            // 
            // LogIn_Butt
            // 
            this.LogIn_Butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.LogIn_Butt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogIn_Butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogIn_Butt.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogIn_Butt.ForeColor = System.Drawing.Color.White;
            this.LogIn_Butt.Location = new System.Drawing.Point(70, 161);
            this.LogIn_Butt.Name = "LogIn_Butt";
            this.LogIn_Butt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LogIn_Butt.Size = new System.Drawing.Size(70, 24);
            this.LogIn_Butt.TabIndex = 21;
            this.LogIn_Butt.Text = "Войти";
            this.LogIn_Butt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LogIn_Butt.Click += new System.EventHandler(this.LogIn_Butt_Click);
            // 
            // PanelChatMembers
            // 
            this.PanelChatMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.PanelChatMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelChatMembers.Controls.Add(this.Label_Updating);
            this.PanelChatMembers.Controls.Add(this.CloseMembersButt);
            this.PanelChatMembers.Controls.Add(this.Members_LB);
            this.PanelChatMembers.Location = new System.Drawing.Point(231, 182);
            this.PanelChatMembers.Name = "PanelChatMembers";
            this.PanelChatMembers.Size = new System.Drawing.Size(177, 197);
            this.PanelChatMembers.TabIndex = 20;
            this.PanelChatMembers.Visible = false;
            // 
            // Label_Updating
            // 
            this.Label_Updating.BackColor = System.Drawing.Color.Transparent;
            this.Label_Updating.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Updating.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Updating.ForeColor = System.Drawing.Color.White;
            this.Label_Updating.Location = new System.Drawing.Point(3, 172);
            this.Label_Updating.Name = "Label_Updating";
            this.Label_Updating.Size = new System.Drawing.Size(125, 19);
            this.Label_Updating.TabIndex = 18;
            this.Label_Updating.Text = "Обновление...";
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
            this.Members_LB.Location = new System.Drawing.Point(3, 26);
            this.Members_LB.Name = "Members_LB";
            this.Members_LB.Size = new System.Drawing.Size(171, 147);
            this.Members_LB.TabIndex = 6;
            this.Members_LB.SelectedIndexChanged += new System.EventHandler(this.Members_LB_SelectedIndexChanged);
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
            this.MembSep1,
            this.MakeAdmin_CMP,
            this.DemoteAdmin_CMP,
            this.MakeModer_CMP,
            this.DemoteModer_CMP,
            this.MembSep2,
            this.BecomeAdmin_CMP,
            this.BecomeModer_CMP,
            this.BecomeMemb_CMP});
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
            this.BlockUser_CMP.Click += new System.EventHandler(this.BlockUser_CMP_Click);
            // 
            // AwayUser_CMP
            // 
            this.AwayUser_CMP.Name = "AwayUser_CMP";
            this.AwayUser_CMP.Size = new System.Drawing.Size(238, 22);
            this.AwayUser_CMP.Text = "Изгнать";
            this.AwayUser_CMP.Click += new System.EventHandler(this.AwayUser_CMP_Click);
            // 
            // MembSep1
            // 
            this.MembSep1.Name = "MembSep1";
            this.MembSep1.Size = new System.Drawing.Size(235, 6);
            // 
            // MakeAdmin_CMP
            // 
            this.MakeAdmin_CMP.Name = "MakeAdmin_CMP";
            this.MakeAdmin_CMP.Size = new System.Drawing.Size(238, 22);
            this.MakeAdmin_CMP.Text = "Назначить администратором";
            this.MakeAdmin_CMP.Click += new System.EventHandler(this.MakeAdmin_CMP_Click);
            // 
            // DemoteAdmin_CMP
            // 
            this.DemoteAdmin_CMP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdminToModer_CMP,
            this.AdminToMemb_CMP});
            this.DemoteAdmin_CMP.Name = "DemoteAdmin_CMP";
            this.DemoteAdmin_CMP.Size = new System.Drawing.Size(238, 22);
            this.DemoteAdmin_CMP.Text = "Разжаловать администратора";
            // 
            // AdminToModer_CMP
            // 
            this.AdminToModer_CMP.Name = "AdminToModer_CMP";
            this.AdminToModer_CMP.Size = new System.Drawing.Size(156, 22);
            this.AdminToModer_CMP.Text = "до модератора";
            this.AdminToModer_CMP.Click += new System.EventHandler(this.AdminToModer_CMP_Click);
            // 
            // AdminToMemb_CMP
            // 
            this.AdminToMemb_CMP.Name = "AdminToMemb_CMP";
            this.AdminToMemb_CMP.Size = new System.Drawing.Size(156, 22);
            this.AdminToMemb_CMP.Text = "до участника";
            this.AdminToMemb_CMP.Click += new System.EventHandler(this.AdminToMemb_CMP_Click);
            // 
            // MakeModer_CMP
            // 
            this.MakeModer_CMP.Name = "MakeModer_CMP";
            this.MakeModer_CMP.Size = new System.Drawing.Size(238, 22);
            this.MakeModer_CMP.Text = "Назначить модератором";
            this.MakeModer_CMP.Click += new System.EventHandler(this.MakeModer_CMP_Click);
            // 
            // DemoteModer_CMP
            // 
            this.DemoteModer_CMP.Name = "DemoteModer_CMP";
            this.DemoteModer_CMP.Size = new System.Drawing.Size(238, 22);
            this.DemoteModer_CMP.Text = "Разжаловать модератора";
            this.DemoteModer_CMP.Click += new System.EventHandler(this.DemoteModer_CMP_Click);
            // 
            // MembSep2
            // 
            this.MembSep2.Name = "MembSep2";
            this.MembSep2.Size = new System.Drawing.Size(235, 6);
            // 
            // BecomeAdmin_CMP
            // 
            this.BecomeAdmin_CMP.Name = "BecomeAdmin_CMP";
            this.BecomeAdmin_CMP.Size = new System.Drawing.Size(238, 22);
            this.BecomeAdmin_CMP.Text = "Стать администратором";
            // 
            // BecomeModer_CMP
            // 
            this.BecomeModer_CMP.Name = "BecomeModer_CMP";
            this.BecomeModer_CMP.Size = new System.Drawing.Size(238, 22);
            this.BecomeModer_CMP.Text = "Стать модератором";
            // 
            // BecomeMemb_CMP
            // 
            this.BecomeMemb_CMP.Name = "BecomeMemb_CMP";
            this.BecomeMemb_CMP.Size = new System.Drawing.Size(238, 22);
            this.BecomeMemb_CMP.Text = "Стать участником";
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
            // panel_invite
            // 
            this.panel_invite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel_invite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_invite.Controls.Add(this.Invite_Butt);
            this.panel_invite.Controls.Add(this.panel3);
            this.panel_invite.Controls.Add(this.CloseInviteWindow);
            this.panel_invite.Controls.Add(this.label3);
            this.panel_invite.Location = new System.Drawing.Point(268, 397);
            this.panel_invite.Name = "panel_invite";
            this.panel_invite.Size = new System.Drawing.Size(349, 172);
            this.panel_invite.TabIndex = 22;
            this.panel_invite.Visible = false;
            // 
            // Invite_Butt
            // 
            this.Invite_Butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.Invite_Butt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Invite_Butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Invite_Butt.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Invite_Butt.ForeColor = System.Drawing.Color.White;
            this.Invite_Butt.Location = new System.Drawing.Point(122, 135);
            this.Invite_Butt.Margin = new System.Windows.Forms.Padding(0);
            this.Invite_Butt.Name = "Invite_Butt";
            this.Invite_Butt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Invite_Butt.Size = new System.Drawing.Size(105, 24);
            this.Invite_Butt.TabIndex = 35;
            this.Invite_Butt.Text = "Пригласить";
            this.Invite_Butt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Invite_Butt.Click += new System.EventHandler(this.Invite_Butt_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.InviteRename_TB);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(2, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 73);
            this.panel3.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(138, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(294, 25);
            this.label11.TabIndex = 22;
            this.label11.Text = "через пробел";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.Gray;
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label15.Location = new System.Drawing.Point(138, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(294, 27);
            this.label15.TabIndex = 21;
            this.label15.Text = "Перечислите никнеймы";
            // 
            // InviteRename_TB
            // 
            this.InviteRename_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.InviteRename_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InviteRename_TB.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InviteRename_TB.ForeColor = System.Drawing.Color.White;
            this.InviteRename_TB.Location = new System.Drawing.Point(141, 5);
            this.InviteRename_TB.Name = "InviteRename_TB";
            this.InviteRename_TB.Size = new System.Drawing.Size(193, 27);
            this.InviteRename_TB.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(41, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 28);
            this.label13.TabIndex = 15;
            this.label13.Text = "Ёжики";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CloseInviteWindow
            // 
            this.CloseInviteWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.CloseInviteWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CloseInviteWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseInviteWindow.Font = new System.Drawing.Font("Webdings", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CloseInviteWindow.ForeColor = System.Drawing.Color.White;
            this.CloseInviteWindow.Location = new System.Drawing.Point(226, 7);
            this.CloseInviteWindow.Margin = new System.Windows.Forms.Padding(0);
            this.CloseInviteWindow.Name = "CloseInviteWindow";
            this.CloseInviteWindow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CloseInviteWindow.Size = new System.Drawing.Size(20, 20);
            this.CloseInviteWindow.TabIndex = 33;
            this.CloseInviteWindow.Text = "r";
            this.CloseInviteWindow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseInviteWindow.Click += new System.EventHandler(this.CloseInviteWindow_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 27);
            this.label3.TabIndex = 29;
            this.label3.Text = "Пригласить";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TimerOnline
            // 
            this.TimerOnline.Interval = 45000;
            this.TimerOnline.Tick += new System.EventHandler(this.TimerOnline_Tick);
            // 
            // NavigationBar
            // 
            this.NavigationBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.NavigationBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NavigationBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.NavigationBar.Location = new System.Drawing.Point(0, 0);
            this.NavigationBar.Name = "NavigationBar";
            this.NavigationBar.Size = new System.Drawing.Size(885, 28);
            this.NavigationBar.TabIndex = 23;
            this.NavigationBar.TabStop = false;
            this.NavigationBar.Click += new System.EventHandler(this.NavigationBar_Click);
            this.NavigationBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NavigationBar_MouseDown);
            this.NavigationBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NavigationBar_MouseMove);
            this.NavigationBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NavigationBar_MouseUp);
            // 
            // CloseWindowButton
            // 
            this.CloseWindowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.CloseWindowButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CloseWindowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseWindowButton.Font = new System.Drawing.Font("Webdings", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CloseWindowButton.ForeColor = System.Drawing.Color.White;
            this.CloseWindowButton.Location = new System.Drawing.Point(839, 0);
            this.CloseWindowButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseWindowButton.Name = "CloseWindowButton";
            this.CloseWindowButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CloseWindowButton.Size = new System.Drawing.Size(47, 28);
            this.CloseWindowButton.TabIndex = 24;
            this.CloseWindowButton.Text = "r";
            this.CloseWindowButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseWindowButton.Click += new System.EventHandler(this.CloseWindowButton_Click);
            // 
            // Minimize_Butt
            // 
            this.Minimize_Butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.Minimize_Butt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Minimize_Butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize_Butt.Font = new System.Drawing.Font("Webdings", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Minimize_Butt.ForeColor = System.Drawing.Color.White;
            this.Minimize_Butt.Location = new System.Drawing.Point(793, 0);
            this.Minimize_Butt.Margin = new System.Windows.Forms.Padding(0);
            this.Minimize_Butt.Name = "Minimize_Butt";
            this.Minimize_Butt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Minimize_Butt.Size = new System.Drawing.Size(47, 28);
            this.Minimize_Butt.TabIndex = 25;
            this.Minimize_Butt.Text = "0";
            this.Minimize_Butt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Minimize_Butt.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "ЁжМессенджер";
            // 
            // PictureTriangle
            // 
            this.PictureTriangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureTriangle.Location = new System.Drawing.Point(231, 96);
            this.PictureTriangle.Name = "PictureTriangle";
            this.PictureTriangle.Size = new System.Drawing.Size(17, 26);
            this.PictureTriangle.TabIndex = 27;
            this.PictureTriangle.TabStop = false;
            this.PictureTriangle.Click += new System.EventHandler(this.PictureTriangle_Click);
            // 
            // PanelLeavingChat
            // 
            this.PanelLeavingChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.PanelLeavingChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelLeavingChat.Controls.Add(this.LeaveChat_Butt);
            this.PanelLeavingChat.Controls.Add(this.StayChat_Butt);
            this.PanelLeavingChat.Controls.Add(this.TextAttentionLeaving);
            this.PanelLeavingChat.Location = new System.Drawing.Point(246, 443);
            this.PanelLeavingChat.Name = "PanelLeavingChat";
            this.PanelLeavingChat.Size = new System.Drawing.Size(394, 172);
            this.PanelLeavingChat.TabIndex = 28;
            this.PanelLeavingChat.Visible = false;
            // 
            // LeaveChat_Butt
            // 
            this.LeaveChat_Butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.LeaveChat_Butt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeaveChat_Butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeaveChat_Butt.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeaveChat_Butt.ForeColor = System.Drawing.Color.LightCoral;
            this.LeaveChat_Butt.Location = new System.Drawing.Point(97, 125);
            this.LeaveChat_Butt.Margin = new System.Windows.Forms.Padding(0);
            this.LeaveChat_Butt.Name = "LeaveChat_Butt";
            this.LeaveChat_Butt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LeaveChat_Butt.Size = new System.Drawing.Size(93, 24);
            this.LeaveChat_Butt.TabIndex = 36;
            this.LeaveChat_Butt.Text = "Покинуть";
            this.LeaveChat_Butt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LeaveChat_Butt.Click += new System.EventHandler(this.LeaveChat_Butt_Click);
            // 
            // StayChat_Butt
            // 
            this.StayChat_Butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.StayChat_Butt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StayChat_Butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StayChat_Butt.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StayChat_Butt.ForeColor = System.Drawing.Color.White;
            this.StayChat_Butt.Location = new System.Drawing.Point(198, 125);
            this.StayChat_Butt.Margin = new System.Windows.Forms.Padding(0);
            this.StayChat_Butt.Name = "StayChat_Butt";
            this.StayChat_Butt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StayChat_Butt.Size = new System.Drawing.Size(93, 24);
            this.StayChat_Butt.TabIndex = 35;
            this.StayChat_Butt.Text = "Остаться";
            this.StayChat_Butt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StayChat_Butt.Click += new System.EventHandler(this.StayChat_Butt_Click);
            // 
            // TextAttentionLeaving
            // 
            this.TextAttentionLeaving.BackColor = System.Drawing.Color.Transparent;
            this.TextAttentionLeaving.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextAttentionLeaving.ForeColor = System.Drawing.Color.White;
            this.TextAttentionLeaving.Location = new System.Drawing.Point(42, 38);
            this.TextAttentionLeaving.Name = "TextAttentionLeaving";
            this.TextAttentionLeaving.Size = new System.Drawing.Size(347, 79);
            this.TextAttentionLeaving.TabIndex = 29;
            this.TextAttentionLeaving.Text = "Вы действительно хотите покинуть чат?\r\nВернуться в него вы сможете только по приг" +
    "лашению";
            // 
            // Panel_NoConnection
            // 
            this.Panel_NoConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Panel_NoConnection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_NoConnection.Controls.Add(this.Button_repeatConnection);
            this.Panel_NoConnection.Controls.Add(this.Error_label);
            this.Panel_NoConnection.Location = new System.Drawing.Point(682, 34);
            this.Panel_NoConnection.Name = "Panel_NoConnection";
            this.Panel_NoConnection.Size = new System.Drawing.Size(198, 64);
            this.Panel_NoConnection.TabIndex = 29;
            this.Panel_NoConnection.Visible = false;
            // 
            // Button_repeatConnection
            // 
            this.Button_repeatConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.Button_repeatConnection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Button_repeatConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_repeatConnection.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_repeatConnection.ForeColor = System.Drawing.Color.White;
            this.Button_repeatConnection.Location = new System.Drawing.Point(53, 34);
            this.Button_repeatConnection.Name = "Button_repeatConnection";
            this.Button_repeatConnection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button_repeatConnection.Size = new System.Drawing.Size(89, 24);
            this.Button_repeatConnection.TabIndex = 22;
            this.Button_repeatConnection.Text = "Повторить";
            this.Button_repeatConnection.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_repeatConnection.Click += new System.EventHandler(this.Button_repeatConnection_Click);
            // 
            // Label_Invitations
            // 
            this.Label_Invitations.BackColor = System.Drawing.Color.Transparent;
            this.Label_Invitations.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Invitations.ForeColor = System.Drawing.Color.White;
            this.Label_Invitations.Location = new System.Drawing.Point(7, 365);
            this.Label_Invitations.Name = "Label_Invitations";
            this.Label_Invitations.Size = new System.Drawing.Size(213, 40);
            this.Label_Invitations.TabIndex = 30;
            this.Label_Invitations.Text = "Приглашения";
            this.Label_Invitations.Visible = false;
            // 
            // Invites_LB
            // 
            this.Invites_LB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Invites_LB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Invites_LB.ContextMenuStrip = this.ChatListCM;
            this.Invites_LB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Invites_LB.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Invites_LB.ForeColor = System.Drawing.Color.White;
            this.Invites_LB.FormattingEnabled = true;
            this.Invites_LB.ItemHeight = 23;
            this.Invites_LB.Location = new System.Drawing.Point(14, 451);
            this.Invites_LB.Name = "Invites_LB";
            this.Invites_LB.Size = new System.Drawing.Size(208, 2);
            this.Invites_LB.TabIndex = 31;
            this.Invites_LB.Visible = false;
            // 
            // FormMessanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 506);
            this.Controls.Add(this.Invites_LB);
            this.Controls.Add(this.Label_Invitations);
            this.Controls.Add(this.panelCreateChat);
            this.Controls.Add(this.Panel_NoConnection);
            this.Controls.Add(this.panel_registration);
            this.Controls.Add(this.PanelLeavingChat);
            this.Controls.Add(this.panel_invite);
            this.Controls.Add(this.PanelChatMembers);
            this.Controls.Add(this.PictureTriangle);
            this.Controls.Add(this.chatsLB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Minimize_Butt);
            this.Controls.Add(this.CloseWindowButton);
            this.Controls.Add(this.NavigationBar);
            this.Controls.Add(this.CreateChat_butt);
            this.Controls.Add(this.label_notifymore);
            this.Controls.Add(this.label_notify4);
            this.Controls.Add(this.label_notify3);
            this.Controls.Add(this.label_notify2);
            this.Controls.Add(this.SendButt);
            this.Controls.Add(this.label_notify1);
            this.Controls.Add(this.head_lbl);
            this.Controls.Add(this.MessageTB);
            this.Controls.Add(this.panel_messages);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMessanger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЁжМессенджер";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.FormMessanger_Shown);
            this.ChatListCM.ResumeLayout(false);
            this.panel_messages.ResumeLayout(false);
            this.panel_emptyChat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FixScrollBar)).EndInit();
            this.panelMsg_4.ResumeLayout(false);
            this.panelMsg_4.PerformLayout();
            this.panelMsg_3.ResumeLayout(false);
            this.panelMsg_3.PerformLayout();
            this.panelMsg_2.ResumeLayout(false);
            this.panelMsg_2.PerformLayout();
            this.panelMsg_1.ResumeLayout(false);
            this.panelMsg_1.PerformLayout();
            this.panelCreateChat.ResumeLayout(false);
            this.panelCreateChat.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_registration.ResumeLayout(false);
            this.PanelRegName.ResumeLayout(false);
            this.PanelRegName.PerformLayout();
            this.PanelRegPass.ResumeLayout(false);
            this.PanelRegPass.PerformLayout();
            this.PanelChatMembers.ResumeLayout(false);
            this.MembList_CM.ResumeLayout(false);
            this.panel_invite.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavigationBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureTriangle)).EndInit();
            this.PanelLeavingChat.ResumeLayout(false);
            this.Panel_NoConnection.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem LeaveChat_CMP;
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
        private System.Windows.Forms.ToolStripSeparator MembSep1;
        private System.Windows.Forms.ToolStripMenuItem MakeAdmin_CMP;
        private System.Windows.Forms.ToolStripMenuItem DemoteAdmin_CMP;
        private System.Windows.Forms.ToolStripMenuItem AdminToModer_CMP;
        private System.Windows.Forms.ToolStripMenuItem AdminToMemb_CMP;
        private System.Windows.Forms.ToolStripMenuItem MakeModer_CMP;
        private System.Windows.Forms.ToolStripMenuItem DemoteModer_CMP;
        private System.Windows.Forms.ToolStripSeparator MembSep2;
        private System.Windows.Forms.ToolStripMenuItem BecomeAdmin_CMP;
        private System.Windows.Forms.ToolStripMenuItem BecomeModer_CMP;
        private System.Windows.Forms.ToolStripMenuItem BecomeMemb_CMP;
        private System.Windows.Forms.Timer timerChats;
        private System.Windows.Forms.Label CloseMembersButt;
        private System.Windows.Forms.Timer timerFastUpdate;
        private System.Windows.Forms.ToolStripMenuItem MemberStatus_CMP;
        private System.Windows.Forms.Panel panel_invite;
        private System.Windows.Forms.TextBox InviteRename_TB;
        private System.Windows.Forms.Timer TimerOnline;
        private System.Windows.Forms.Label Label_Updating;
        private System.Windows.Forms.Panel PanelRegName;
        private System.Windows.Forms.Panel PanelRegPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox NavigationBar;
        private System.Windows.Forms.Label CloseWindowButton;
        private System.Windows.Forms.Label Minimize_Butt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PictureTriangle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label CloseCreateChat;
        private System.Windows.Forms.Label CloseInviteWindow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Invite_Butt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel PanelLeavingChat;
        private System.Windows.Forms.Label StayChat_Butt;
        private System.Windows.Forms.Label TextAttentionLeaving;
        private System.Windows.Forms.Label LeaveChat_Butt;
        private System.Windows.Forms.Panel Panel_NoConnection;
        private System.Windows.Forms.Label Button_repeatConnection;
        private System.Windows.Forms.Label Label_Invitations;
        private System.Windows.Forms.ListBox Invites_LB;
    }
}

