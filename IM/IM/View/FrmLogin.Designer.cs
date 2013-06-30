namespace IM
{
    partial class FrmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlBase = new System.Windows.Forms.Panel();
            this.pnlWhite = new System.Windows.Forms.Panel();
            this.btnLogin = new dyForm.CControl.SkinButtom();
            this.btnTwoDimension = new dyForm.CControl.SkinButtom();
            this.btnMultiID = new dyForm.CControl.SkinButtom();
            this.picLoadding = new System.Windows.Forms.PictureBox();
            this.btnHead = new dyForm.CControl.SkinButtom();
            this.pnlPwd = new System.Windows.Forms.Panel();
            this.txtPwd = new dyForm.CControl.WaterTextBox();
            this.btnKeyBoard = new dyForm.CControl.SkinButtom();
            this.chkAutoLogin = new System.Windows.Forms.CheckBox();
            this.btnRegister = new dyForm.CControl.SkinButtom();
            this.chkRememberPwd = new System.Windows.Forms.CheckBox();
            this.btnFindPwd = new dyForm.CControl.SkinButtom();
            this.pnlID = new System.Windows.Forms.Panel();
            this.txtID = new dyForm.CControl.WaterTextBox();
            this.btnSelectID = new dyForm.CControl.SkinButtom();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.btnBack = new dyForm.CControl.SkinButtom();
            this.btnQuickRegister = new dyForm.CControl.SkinButtom();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.txtRegRePwd = new dyForm.CControl.WaterTextBox();
            this.lblRePwd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new dyForm.CControl.WaterTextBox();
            this.txtSex = new dyForm.CControl.WaterTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtRegPwd = new dyForm.CControl.WaterTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new dyForm.CControl.WaterTextBox();
            this.lable5 = new System.Windows.Forms.Label();
            this.pnlBase.SuspendLayout();
            this.pnlWhite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoadding)).BeginInit();
            this.pnlPwd.SuspendLayout();
            this.pnlID.SuspendLayout();
            this.pnlRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // pnlBase
            // 
            this.pnlBase.BackColor = System.Drawing.Color.Transparent;
            this.pnlBase.Controls.Add(this.pnlWhite);
            this.pnlBase.Controls.Add(this.picLoadding);
            this.pnlBase.Controls.Add(this.btnHead);
            this.pnlBase.Controls.Add(this.pnlPwd);
            this.pnlBase.Controls.Add(this.chkAutoLogin);
            this.pnlBase.Controls.Add(this.btnRegister);
            this.pnlBase.Controls.Add(this.chkRememberPwd);
            this.pnlBase.Controls.Add(this.btnFindPwd);
            this.pnlBase.Controls.Add(this.pnlID);
            this.pnlBase.Controls.Add(this.btnSelectID);
            this.pnlBase.Location = new System.Drawing.Point(-1, 130);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(382, 159);
            this.pnlBase.TabIndex = 18;
            // 
            // pnlWhite
            // 
            this.pnlWhite.BackColor = System.Drawing.Color.Transparent;
            this.pnlWhite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlWhite.BackgroundImage")));
            this.pnlWhite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlWhite.Controls.Add(this.btnLogin);
            this.pnlWhite.Controls.Add(this.btnTwoDimension);
            this.pnlWhite.Controls.Add(this.btnMultiID);
            this.pnlWhite.Location = new System.Drawing.Point(0, 110);
            this.pnlWhite.Name = "pnlWhite";
            this.pnlWhite.Size = new System.Drawing.Size(384, 50);
            this.pnlWhite.TabIndex = 16;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.ControlState = dyForm.SkinClass.ControlState.Normal;
            this.btnLogin.DownBack = ((System.Drawing.Image)(resources.GetObject("btnLogin.DownBack")));
            this.btnLogin.DrawType = dyForm.CControl.DrawStyle.Img;
            this.btnLogin.Location = new System.Drawing.Point(103, 0);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnLogin.MouseBack")));
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnLogin.NormlBack")));
            this.btnLogin.Size = new System.Drawing.Size(185, 49);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "登     录";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnTwoDimension
            // 
            this.btnTwoDimension.BackColor = System.Drawing.Color.Transparent;
            this.btnTwoDimension.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTwoDimension.ControlState = dyForm.SkinClass.ControlState.Normal;
            this.btnTwoDimension.DownBack = ((System.Drawing.Image)(resources.GetObject("btnTwoDimension.DownBack")));
            this.btnTwoDimension.DrawType = dyForm.CControl.DrawStyle.Img;
            this.btnTwoDimension.Location = new System.Drawing.Point(339, 15);
            this.btnTwoDimension.Margin = new System.Windows.Forms.Padding(0);
            this.btnTwoDimension.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnTwoDimension.MouseBack")));
            this.btnTwoDimension.Name = "btnTwoDimension";
            this.btnTwoDimension.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnTwoDimension.NormlBack")));
            this.btnTwoDimension.Size = new System.Drawing.Size(27, 27);
            this.btnTwoDimension.TabIndex = 18;
            this.btnTwoDimension.UseVisualStyleBackColor = false;
            // 
            // btnMultiID
            // 
            this.btnMultiID.BackColor = System.Drawing.Color.Transparent;
            this.btnMultiID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMultiID.ControlState = dyForm.SkinClass.ControlState.Normal;
            this.btnMultiID.DownBack = ((System.Drawing.Image)(resources.GetObject("btnMultiID.DownBack")));
            this.btnMultiID.DrawType = dyForm.CControl.DrawStyle.Img;
            this.btnMultiID.Location = new System.Drawing.Point(0, 10);
            this.btnMultiID.Margin = new System.Windows.Forms.Padding(0);
            this.btnMultiID.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnMultiID.MouseBack")));
            this.btnMultiID.Name = "btnMultiID";
            this.btnMultiID.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnMultiID.NormlBack")));
            this.btnMultiID.Size = new System.Drawing.Size(40, 40);
            this.btnMultiID.TabIndex = 17;
            this.btnMultiID.UseVisualStyleBackColor = false;
            this.btnMultiID.Click += new System.EventHandler(this.btnMultiID_Click);
            // 
            // picLoadding
            // 
            this.picLoadding.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLoadding.BackgroundImage")));
            this.picLoadding.Location = new System.Drawing.Point(1, 110);
            this.picLoadding.Name = "picLoadding";
            this.picLoadding.Size = new System.Drawing.Size(378, 2);
            this.picLoadding.TabIndex = 17;
            this.picLoadding.TabStop = false;
            this.picLoadding.Visible = false;
            // 
            // btnHead
            // 
            this.btnHead.BackColor = System.Drawing.Color.Transparent;
            this.btnHead.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHead.BackgroundImage")));
            this.btnHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHead.ControlState = dyForm.SkinClass.ControlState.Normal;
            this.btnHead.DownBack = null;
            this.btnHead.DrawType = dyForm.CControl.DrawStyle.Img;
            this.btnHead.Location = new System.Drawing.Point(19, 9);
            this.btnHead.Margin = new System.Windows.Forms.Padding(0);
            this.btnHead.MouseBack = null;
            this.btnHead.Name = "btnHead";
            this.btnHead.NormlBack = null;
            this.btnHead.Size = new System.Drawing.Size(85, 85);
            this.btnHead.TabIndex = 13;
            this.btnHead.UseVisualStyleBackColor = false;
            // 
            // pnlPwd
            // 
            this.pnlPwd.BackColor = System.Drawing.Color.White;
            this.pnlPwd.Controls.Add(this.txtPwd);
            this.pnlPwd.Controls.Add(this.btnKeyBoard);
            this.pnlPwd.Location = new System.Drawing.Point(116, 45);
            this.pnlPwd.Name = "pnlPwd";
            this.pnlPwd.Size = new System.Drawing.Size(172, 25);
            this.pnlPwd.TabIndex = 20;
            // 
            // txtPwd
            // 
            this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPwd.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPwd.Location = new System.Drawing.Point(7, 4);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(135, 16);
            this.txtPwd.TabIndex = 5;
            this.txtPwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPwd.WaterText = "密码";
            // 
            // btnKeyBoard
            // 
            this.btnKeyBoard.BackColor = System.Drawing.Color.Transparent;
            this.btnKeyBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKeyBoard.BaseColor = System.Drawing.Color.White;
            this.btnKeyBoard.ControlState = dyForm.SkinClass.ControlState.Normal;
            this.btnKeyBoard.DownBack = ((System.Drawing.Image)(resources.GetObject("btnKeyBoard.DownBack")));
            this.btnKeyBoard.DrawType = dyForm.CControl.DrawStyle.Img;
            this.btnKeyBoard.Location = new System.Drawing.Point(151, 3);
            this.btnKeyBoard.Margin = new System.Windows.Forms.Padding(0);
            this.btnKeyBoard.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnKeyBoard.MouseBack")));
            this.btnKeyBoard.Name = "btnKeyBoard";
            this.btnKeyBoard.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnKeyBoard.NormlBack")));
            this.btnKeyBoard.Size = new System.Drawing.Size(20, 20);
            this.btnKeyBoard.TabIndex = 15;
            this.btnKeyBoard.UseVisualStyleBackColor = false;
            this.btnKeyBoard.Click += new System.EventHandler(this.btnKeyBoard_Click);
            // 
            // chkAutoLogin
            // 
            this.chkAutoLogin.AutoSize = true;
            this.chkAutoLogin.BackColor = System.Drawing.Color.Transparent;
            this.chkAutoLogin.Location = new System.Drawing.Point(194, 78);
            this.chkAutoLogin.Name = "chkAutoLogin";
            this.chkAutoLogin.Size = new System.Drawing.Size(72, 16);
            this.chkAutoLogin.TabIndex = 3;
            this.chkAutoLogin.Text = "自动登录";
            this.chkAutoLogin.UseVisualStyleBackColor = false;
            this.chkAutoLogin.CheckedChanged += new System.EventHandler(this.chkAutoLogin_CheckedChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegister.ControlState = dyForm.SkinClass.ControlState.Normal;
            this.btnRegister.DownBack = ((System.Drawing.Image)(resources.GetObject("btnRegister.DownBack")));
            this.btnRegister.DrawType = dyForm.CControl.DrawStyle.Img;
            this.btnRegister.Location = new System.Drawing.Point(303, 14);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegister.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnRegister.MouseBack")));
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnRegister.NormlBack")));
            this.btnRegister.Size = new System.Drawing.Size(51, 16);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // chkRememberPwd
            // 
            this.chkRememberPwd.AutoSize = true;
            this.chkRememberPwd.BackColor = System.Drawing.Color.Transparent;
            this.chkRememberPwd.Location = new System.Drawing.Point(116, 78);
            this.chkRememberPwd.Name = "chkRememberPwd";
            this.chkRememberPwd.Size = new System.Drawing.Size(72, 16);
            this.chkRememberPwd.TabIndex = 2;
            this.chkRememberPwd.Text = "记住密码";
            this.chkRememberPwd.UseVisualStyleBackColor = false;
            // 
            // btnFindPwd
            // 
            this.btnFindPwd.BackColor = System.Drawing.Color.Transparent;
            this.btnFindPwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFindPwd.ControlState = dyForm.SkinClass.ControlState.Normal;
            this.btnFindPwd.DownBack = ((System.Drawing.Image)(resources.GetObject("btnFindPwd.DownBack")));
            this.btnFindPwd.DrawType = dyForm.CControl.DrawStyle.Img;
            this.btnFindPwd.Location = new System.Drawing.Point(303, 49);
            this.btnFindPwd.Margin = new System.Windows.Forms.Padding(0);
            this.btnFindPwd.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnFindPwd.MouseBack")));
            this.btnFindPwd.Name = "btnFindPwd";
            this.btnFindPwd.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnFindPwd.NormlBack")));
            this.btnFindPwd.Size = new System.Drawing.Size(51, 16);
            this.btnFindPwd.TabIndex = 5;
            this.btnFindPwd.UseVisualStyleBackColor = false;
            this.btnFindPwd.Click += new System.EventHandler(this.btnFindPwd_Click);
            // 
            // pnlID
            // 
            this.pnlID.BackColor = System.Drawing.Color.White;
            this.pnlID.Controls.Add(this.txtID);
            this.pnlID.Location = new System.Drawing.Point(116, 9);
            this.pnlID.Name = "pnlID";
            this.pnlID.Size = new System.Drawing.Size(150, 25);
            this.pnlID.TabIndex = 19;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("宋体", 10F);
            this.txtID.Location = new System.Drawing.Point(7, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(130, 16);
            this.txtID.TabIndex = 5;
            this.txtID.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtID.WaterText = "QQ号码/手机/邮箱";
            // 
            // btnSelectID
            // 
            this.btnSelectID.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectID.ControlState = dyForm.SkinClass.ControlState.Normal;
            this.btnSelectID.DownBack = ((System.Drawing.Image)(resources.GetObject("btnSelectID.DownBack")));
            this.btnSelectID.DrawType = dyForm.CControl.DrawStyle.Img;
            this.btnSelectID.Location = new System.Drawing.Point(266, 9);
            this.btnSelectID.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelectID.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnSelectID.MouseBack")));
            this.btnSelectID.Name = "btnSelectID";
            this.btnSelectID.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnSelectID.NormlBack")));
            this.btnSelectID.Size = new System.Drawing.Size(22, 25);
            this.btnSelectID.TabIndex = 13;
            this.btnSelectID.UseVisualStyleBackColor = false;
            // 
            // pnlRegister
            // 
            this.pnlRegister.BackColor = System.Drawing.Color.Transparent;
            this.pnlRegister.Controls.Add(this.btnBack);
            this.pnlRegister.Controls.Add(this.btnQuickRegister);
            this.pnlRegister.Controls.Add(this.dtpBirth);
            this.pnlRegister.Controls.Add(this.txtRegRePwd);
            this.pnlRegister.Controls.Add(this.lblRePwd);
            this.pnlRegister.Controls.Add(this.label2);
            this.pnlRegister.Controls.Add(this.txtEmail);
            this.pnlRegister.Controls.Add(this.txtSex);
            this.pnlRegister.Controls.Add(this.lblEmail);
            this.pnlRegister.Controls.Add(this.lblBirth);
            this.pnlRegister.Controls.Add(this.label5);
            this.pnlRegister.Controls.Add(this.lblSex);
            this.pnlRegister.Controls.Add(this.label4);
            this.pnlRegister.Controls.Add(this.label3);
            this.pnlRegister.Controls.Add(this.lblPwd);
            this.pnlRegister.Controls.Add(this.txtRegPwd);
            this.pnlRegister.Controls.Add(this.label1);
            this.pnlRegister.Controls.Add(this.lblName);
            this.pnlRegister.Controls.Add(this.txtName);
            this.pnlRegister.Controls.Add(this.lable5);
            this.pnlRegister.Location = new System.Drawing.Point(381, 51);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(381, 239);
            this.pnlRegister.TabIndex = 19;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.ControlState = dyForm.SkinClass.ControlState.Normal;
            this.btnBack.DownBack = null;
            this.btnBack.Location = new System.Drawing.Point(112, 202);
            this.btnBack.MouseBack = null;
            this.btnBack.Name = "btnBack";
            this.btnBack.NormlBack = null;
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "返回登录";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnQuickRegister
            // 
            this.btnQuickRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnQuickRegister.ControlState = dyForm.SkinClass.ControlState.Normal;
            this.btnQuickRegister.DownBack = null;
            this.btnQuickRegister.Location = new System.Drawing.Point(193, 202);
            this.btnQuickRegister.MouseBack = null;
            this.btnQuickRegister.Name = "btnQuickRegister";
            this.btnQuickRegister.NormlBack = null;
            this.btnQuickRegister.Size = new System.Drawing.Size(75, 23);
            this.btnQuickRegister.TabIndex = 8;
            this.btnQuickRegister.Text = "立即注册";
            this.btnQuickRegister.UseVisualStyleBackColor = true;
            // 
            // dtpBirth
            // 
            this.dtpBirth.Location = new System.Drawing.Point(96, 133);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(130, 21);
            this.dtpBirth.TabIndex = 7;
            // 
            // txtRegRePwd
            // 
            this.txtRegRePwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegRePwd.Font = new System.Drawing.Font("宋体", 10F);
            this.txtRegRePwd.Location = new System.Drawing.Point(96, 72);
            this.txtRegRePwd.Name = "txtRegRePwd";
            this.txtRegRePwd.Size = new System.Drawing.Size(130, 16);
            this.txtRegRePwd.TabIndex = 6;
            this.txtRegRePwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtRegRePwd.WaterText = "确认密码";
            // 
            // lblRePwd
            // 
            this.lblRePwd.AutoSize = true;
            this.lblRePwd.Location = new System.Drawing.Point(232, 73);
            this.lblRePwd.Name = "lblRePwd";
            this.lblRePwd.Size = new System.Drawing.Size(89, 12);
            this.lblRePwd.TabIndex = 0;
            this.lblRePwd.Text = "请再次输入密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "确认密码：";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("宋体", 10F);
            this.txtEmail.Location = new System.Drawing.Point(96, 169);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(130, 16);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtEmail.WaterText = "邮箱";
            // 
            // txtSex
            // 
            this.txtSex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSex.Font = new System.Drawing.Font("宋体", 10F);
            this.txtSex.Location = new System.Drawing.Point(96, 103);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(130, 16);
            this.txtSex.TabIndex = 6;
            this.txtSex.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtSex.WaterText = "性别";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(232, 170);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(101, 12);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "请填入正确邮箱号";
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Location = new System.Drawing.Point(232, 139);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(65, 12);
            this.lblBirth.TabIndex = 0;
            this.lblBirth.Text = "请选择生日";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "邮箱：";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(232, 104);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(113, 12);
            this.lblSex.TabIndex = 0;
            this.lblSex.Text = "性别不限，自由发挥";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "生日：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "性别：";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(232, 42);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(113, 24);
            this.lblPwd.TabIndex = 0;
            this.lblPwd.Text = "长度为6-16个字符，\r\n不能输入空格";
            // 
            // txtRegPwd
            // 
            this.txtRegPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegPwd.Font = new System.Drawing.Font("宋体", 10F);
            this.txtRegPwd.Location = new System.Drawing.Point(96, 41);
            this.txtRegPwd.Name = "txtRegPwd";
            this.txtRegPwd.Size = new System.Drawing.Size(130, 16);
            this.txtRegPwd.TabIndex = 6;
            this.txtRegPwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtRegPwd.WaterText = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "密码：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(232, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "长度小于14字节";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("宋体", 10F);
            this.txtName.Location = new System.Drawing.Point(96, 11);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(130, 16);
            this.txtName.TabIndex = 6;
            this.txtName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtName.WaterText = "昵称";
            // 
            // lable5
            // 
            this.lable5.AutoSize = true;
            this.lable5.Location = new System.Drawing.Point(49, 12);
            this.lable5.Name = "lable5";
            this.lable5.Size = new System.Drawing.Size(41, 12);
            this.lable5.TabIndex = 0;
            this.lable5.Text = "昵称：";
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(380, 290);
            this.CloseDownBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseDownBack")));
            this.CloseMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseMouseBack")));
            this.CloseNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseNormlBack")));
            this.Controls.Add(this.pnlRegister);
            this.Controls.Add(this.pnlBase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaxDownBack = ((System.Drawing.Image)(resources.GetObject("$this.MaxDownBack")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(380, 290);
            this.MaxMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.MaxMouseBack")));
            this.MaxNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.MaxNormlBack")));
            this.MiniDownBack = global::IM.Properties.Resources.btn_mini_down;
            this.MiniMouseBack = global::IM.Properties.Resources.btn_mini_highlight;
            this.MinimumSize = new System.Drawing.Size(380, 290);
            this.MiniNormlBack = global::IM.Properties.Resources.btn_mini_normal;
            this.Name = "FrmLogin";
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.SysBottomDown = global::IM.Properties.Resources.btn_set_press;
            this.SysBottomMouse = global::IM.Properties.Resources.btn_set_hover;
            this.SysBottomNorml = global::IM.Properties.Resources.btn_set_normal;
            this.SysBottomSize = new System.Drawing.Size(32, 18);
            this.SysBottomVisibale = true;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.pnlBase.ResumeLayout(false);
            this.pnlBase.PerformLayout();
            this.pnlWhite.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLoadding)).EndInit();
            this.pnlPwd.ResumeLayout(false);
            this.pnlPwd.PerformLayout();
            this.pnlID.ResumeLayout(false);
            this.pnlID.PerformLayout();
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Panel pnlBase;
        private dyForm.CControl.SkinButtom btnHead;
        private System.Windows.Forms.Panel pnlPwd;
        private dyForm.CControl.WaterTextBox txtPwd;
        private System.Windows.Forms.Panel pnlID;
        private dyForm.CControl.WaterTextBox txtID;
        private dyForm.CControl.SkinButtom btnKeyBoard;
        private dyForm.CControl.SkinButtom btnTwoDimension;
        private System.Windows.Forms.Panel pnlWhite;
        private dyForm.CControl.SkinButtom btnLogin;
        private dyForm.CControl.SkinButtom btnMultiID;
        private dyForm.CControl.SkinButtom btnSelectID;
        private System.Windows.Forms.CheckBox chkRememberPwd;
        private dyForm.CControl.SkinButtom btnFindPwd;
        private System.Windows.Forms.CheckBox chkAutoLogin;
        private dyForm.CControl.SkinButtom btnRegister;
        private System.Windows.Forms.PictureBox picLoadding;
        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private dyForm.CControl.WaterTextBox txtRegRePwd;
        private System.Windows.Forms.Label label2;
        private dyForm.CControl.WaterTextBox txtSex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private dyForm.CControl.WaterTextBox txtRegPwd;
        private System.Windows.Forms.Label label1;
        private dyForm.CControl.WaterTextBox txtName;
        private System.Windows.Forms.Label lable5;
        private dyForm.CControl.SkinButtom btnQuickRegister;
        private dyForm.CControl.WaterTextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRePwd;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblName;
        private dyForm.CControl.SkinButtom btnBack;

    }
}

