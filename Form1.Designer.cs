using System.Windows.Forms;

namespace MemeGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPick = new System.Windows.Forms.Label();
            this.comboImage = new System.Windows.Forms.ComboBox();
            this.picture = new System.Windows.Forms.PictureBox();
            this.tbTop = new System.Windows.Forms.TextBox();
            this.gbpic = new System.Windows.Forms.GroupBox();
            this.lblBottom = new System.Windows.Forms.Label();
            this.lblTop = new System.Windows.Forms.Label();
            this.tbBottom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.cbFam = new System.Windows.Forms.ComboBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnOut = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lstPrev = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.gbpic.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPick
            // 
            this.lblPick.AutoSize = true;
            this.lblPick.BackColor = System.Drawing.Color.Transparent;
            this.lblPick.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPick.ForeColor = System.Drawing.Color.Black;
            this.lblPick.Location = new System.Drawing.Point(8, 9);
            this.lblPick.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPick.Name = "lblPick";
            this.lblPick.Size = new System.Drawing.Size(77, 15);
            this.lblPick.TabIndex = 0;
            this.lblPick.Text = "Select Image:";
            // 
            // comboImage
            // 
            this.comboImage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboImage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboImage.BackColor = System.Drawing.Color.LightSteelBlue;
            this.comboImage.FormattingEnabled = true;
            this.comboImage.Location = new System.Drawing.Point(140, 6);
            this.comboImage.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboImage.Name = "comboImage";
            this.comboImage.Size = new System.Drawing.Size(196, 21);
            this.comboImage.TabIndex = 1;
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.MidnightBlue;
            this.picture.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picture.Location = new System.Drawing.Point(2, -1);
            this.picture.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(636, 480);
            this.picture.TabIndex = 2;
            this.picture.TabStop = false;
            // 
            // tbTop
            // 
            this.tbTop.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbTop.Location = new System.Drawing.Point(140, 58);
            this.tbTop.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbTop.Name = "tbTop";
            this.tbTop.Size = new System.Drawing.Size(196, 20);
            this.tbTop.TabIndex = 5;
            // 
            // gbpic
            // 
            this.gbpic.BackColor = System.Drawing.SystemColors.Control;
            this.gbpic.Controls.Add(this.lblBottom);
            this.gbpic.Controls.Add(this.lblTop);
            this.gbpic.Controls.Add(this.picture);
            this.gbpic.Location = new System.Drawing.Point(11, 116);
            this.gbpic.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbpic.Name = "gbpic";
            this.gbpic.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gbpic.Size = new System.Drawing.Size(640, 480);
            this.gbpic.TabIndex = 8;
            this.gbpic.TabStop = false;
            // 
            // lblBottom
            // 
            this.lblBottom.AutoSize = true;
            this.lblBottom.BackColor = System.Drawing.Color.Transparent;
            this.lblBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBottom.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBottom.Location = new System.Drawing.Point(69, 356);
            this.lblBottom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBottom.MaximumSize = new System.Drawing.Size(400, 0);
            this.lblBottom.Name = "lblBottom";
            this.lblBottom.Size = new System.Drawing.Size(0, 24);
            this.lblBottom.TabIndex = 4;
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.BackColor = System.Drawing.Color.Transparent;
            this.lblTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTop.Location = new System.Drawing.Point(69, 14);
            this.lblTop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTop.MaximumSize = new System.Drawing.Size(400, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(0, 24);
            this.lblTop.TabIndex = 3;
            // 
            // tbBottom
            // 
            this.tbBottom.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbBottom.Location = new System.Drawing.Point(140, 82);
            this.tbBottom.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbBottom.Name = "tbBottom";
            this.tbBottom.Size = new System.Drawing.Size(196, 20);
            this.tbBottom.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Top Line Text Here:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bottom Line Text Here:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBrowse.Location = new System.Drawing.Point(356, 80);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(126, 22);
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.Text = "Save Your Meme!";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSelectImage.Location = new System.Drawing.Point(355, 2);
            this.btnSelectImage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(126, 27);
            this.btnSelectImage.TabIndex = 14;
            this.btnSelectImage.Text = "Browse Local Images...";
            this.btnSelectImage.UseVisualStyleBackColor = false;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // tbFileName
            // 
            this.tbFileName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbFileName.Location = new System.Drawing.Point(355, 58);
            this.tbFileName.Margin = new System.Windows.Forms.Padding(2);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(127, 20);
            this.tbFileName.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(352, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 14);
            this.label3.TabIndex = 16;
            this.label3.Text = "File Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(652, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Text Controls";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(652, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 14);
            this.label5.TabIndex = 18;
            this.label5.Text = "Color:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(652, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 14);
            this.label6.TabIndex = 19;
            this.label6.Text = "Font Size:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(652, 233);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 14);
            this.label7.TabIndex = 20;
            this.label7.Text = "Font:";
            // 
            // cbColor
            // 
            this.cbColor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Black",
            "White",
            "Red",
            "Blue",
            "Green",
            "Gray"});
            this.cbColor.Location = new System.Drawing.Point(655, 153);
            this.cbColor.Margin = new System.Windows.Forms.Padding(2);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(131, 21);
            this.cbColor.TabIndex = 21;
            // 
            // txtSize
            // 
            this.txtSize.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtSize.Location = new System.Drawing.Point(655, 202);
            this.txtSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(131, 20);
            this.txtSize.TabIndex = 22;
            this.txtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbFam
            // 
            this.cbFam.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cbFam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFam.FormattingEnabled = true;
            this.cbFam.Items.AddRange(new object[] {
            "Microsoft Sans Serif",
            "Times New Roman",
            "Modern No. 20",
            "Papyrus",
            "Ravie"});
            this.cbFam.Location = new System.Drawing.Point(655, 248);
            this.cbFam.Margin = new System.Windows.Forms.Padding(2);
            this.cbFam.Name = "cbFam";
            this.cbFam.Size = new System.Drawing.Size(131, 21);
            this.cbFam.TabIndex = 23;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(551, 18);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 24;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(657, 18);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 25;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(548, 2);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(58, 14);
            this.lblUser.TabIndex = 26;
            this.lblUser.Text = "UserName:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(654, 2);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(49, 14);
            this.lblPass.TabIndex = 27;
            this.lblPass.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(551, 44);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 23);
            this.btnLogin.TabIndex = 28;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(657, 44);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(97, 23);
            this.btnRegister.TabIndex = 29;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(486, 2);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(53, 14);
            this.lblWelcome.TabIndex = 30;
            this.lblWelcome.Text = "Welcome:";
            this.lblWelcome.Visible = false;
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(489, 18);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 23);
            this.btnOut.TabIndex = 31;
            this.btnOut.Text = "Log Out";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Visible = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(652, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "View Your Memes";
            // 
            // lstPrev
            // 
            this.lstPrev.FormattingEnabled = true;
            this.lstPrev.Location = new System.Drawing.Point(655, 300);
            this.lstPrev.Name = "lstPrev";
            this.lstPrev.Size = new System.Drawing.Size(128, 264);
            this.lstPrev.TabIndex = 33;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(655, 570);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(29, 23);
            this.btnRefresh.TabIndex = 34;
            this.btnRefresh.Text = "⟳";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(690, 570);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbFormat
            // 
            this.cbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Items.AddRange(new object[] {
            "Text Above Image",
            "Text on Image",
            "Text on the Right"});
            this.cbFormat.Location = new System.Drawing.Point(570, 81);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(121, 21);
            this.cbFormat.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(483, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Format Options:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::MemeGenerator.Properties.Resources.GradBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 750);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbFormat);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lstPrev);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.cbFam);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBottom);
            this.Controls.Add(this.tbTop);
            this.Controls.Add(this.comboImage);
            this.Controls.Add(this.lblPick);
            this.Controls.Add(this.gbpic);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Form1";
            this.Text = "Meme Generator";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.gbpic.ResumeLayout(false);
            this.gbpic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPick;
        private System.Windows.Forms.ComboBox comboImage;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.TextBox tbTop;
        private System.Windows.Forms.GroupBox gbpic;
        private TextBox tbBottom;
        private Label label1;
        private Label label2;
        private Label lblBottom;
        private Label lblTop;
        private Button btnBrowse;
        private Button btnSelectImage;
        private TextBox tbFileName;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cbColor;
        private TextBox txtSize;
        private ComboBox cbFam;
        private TextBox txtUser;
        private TextBox txtPass;
        private Label lblUser;
        private Label lblPass;
        private Button btnLogin;
        private Button btnRegister;
        private Label lblWelcome;
        private Button btnOut;
        private Label label8;
        private ListBox lstPrev;
        private Button btnRefresh;
        private Button btnDelete;
        private ComboBox cbFormat;
        private Label label9;
    }
}

