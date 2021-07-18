using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using Microsoft.Data.Sqlite;
using System.Security.Cryptography;
namespace MemeGenerator
{
    public partial class Form1 : Form
    {
        Control ctrlToDraw;
        System.Drawing.Bitmap bmp;
        string[] BasePath = Directory.GetFiles("Base", "*.jpeg")
                                     .Select(Path.GetFileNameWithoutExtension)
                                     .ToArray();
        string CurrentUser = "";
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < BasePath.Length; i++)
            {
                comboImage.Items.Add(BasePath[i]);
            }


            txtSize.Text = "16";
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.Size = new Size(640, 480);
            gbpic.Controls.Add(picture);
            gbpic.Controls.Add(lblTop);
            gbpic.Controls.Add(lblBottom);
            gbpic.Size = new Size(640,475);
            lblTop.BringToFront();
            lblTop.Parent = picture;
            lblBottom.Parent = picture;
            lblBottom.BringToFront();
            btnBrowse.Enabled = false;
            lstPrev.Items.Add("Login to Use");


            tbTop.TextChanged += new System.EventHandler(this.tbTop_TextChanged);
            tbBottom.TextChanged += new System.EventHandler(this.tbBottom_TextChanged);
            comboImage.TextChanged += new System.EventHandler(this.Combo_TextChanged);
            tbFileName.TextChanged += new System.EventHandler(this.FN_Changed);
            cbColor.TextChanged += new System.EventHandler(this.Color_Change);
            txtSize.TextChanged += new System.EventHandler(this.Fontsize);
            cbFam.TextChanged += new System.EventHandler(this.FontFamily);
            lstPrev.SelectedIndexChanged += new System.EventHandler(this.PreviouslySaved);
            cbFormat.SelectedIndexChanged += new System.EventHandler(this.cbFormatChange);


        }

        private void cbFormatChange(object sender, EventArgs e)
        {
            if(cbFormat.Text=="Text Above Image")
            {
                lblTop.ForeColor = Color.Black;
                lblTop.Parent = gbpic;
                gbpic.Size = new Size(640, 600);
                lblBottom.Visible = false;
                lblTop.Location = new Point(69, 14);
                lblBottom.Location = new Point(69, 356);
                lblTop.MaximumSize = new Size(400, 0);
                lblBottom.MaximumSize = new Size(400, 0);
            }
            else if(cbFormat.Text=="Text on Image")
            {
                lblTop.Parent = picture;
                gbpic.Size = new Size(640, 480);
                lblBottom.Visible = true;
                lblTop.Location = new Point(69, 14);
                lblBottom.Location = new Point(69, 356);
                lblTop.MaximumSize = new Size(400, 0);
                lblBottom.MaximumSize = new Size(400, 0);
            }
            else if(cbFormat.Text=="Text on the Right")
            {
                lblTop.Location = new Point(344, 32);
                lblBottom.Location = new Point(344, 254);
                lblTop.Parent = picture;
                gbpic.Size = new Size(640, 480);
                lblTop.MaximumSize = new Size(250, 0);
                lblBottom.MaximumSize = new Size(250, 0);
                lblTop.ForeColor = Color.Black;
                lblBottom.ForeColor = Color.Black;
            }
           
        }

        private void PreviouslySaved (object sender, EventArgs e)
        {
            picture.ImageLocation = "Saved/"+CurrentUser+"/"+ lstPrev.SelectedItem + ".jpeg";
            lblBottom.Visible = false;
            lblTop.Visible = false;
        }
        private void Color_Change(object sender, EventArgs e)
        {
            if(cbColor.Text=="Black")
            {
                lblTop.ForeColor = Color.Black;
                lblBottom.ForeColor = Color.Black;
            }
            else if(cbColor.Text=="White")
            {
                lblTop.ForeColor = Color.White;
                lblBottom.ForeColor = Color.White;
            }
            else if(cbColor.Text=="Red")
            {
                lblTop.ForeColor = Color.Red;
                lblBottom.ForeColor = Color.Red;
            }
            else if (cbColor.Text == "Blue")
            {
                lblTop.ForeColor = Color.Blue;
                lblBottom.ForeColor = Color.Blue;
            }
            else if (cbColor.Text == "Green")
            {
                lblTop.ForeColor = Color.Green;
                lblBottom.ForeColor = Color.Green;
            }
            else if(cbColor.Text=="Gray")
            {
                lblTop.ForeColor = Color.Gray;
                lblBottom.ForeColor = Color.Gray;
            }
        }
        private void tbTop_TextChanged(object sender, EventArgs e)
        {
            lblTop.Text = tbTop.Text;
        }
        private void Fontsize(object sender, EventArgs e)
        {
            try
            {
                if(cbFam.Text!="")
                {
                    lblTop.Font = new Font(cbFam.Text, Int32.Parse(txtSize.Text), FontStyle.Regular);
                    lblBottom.Font = new Font(cbFam.Text, Int32.Parse(txtSize.Text), FontStyle.Regular);
                }
                else
                {
                    lblTop.Font = new Font("Microsoft Sans Serif", Int32.Parse(txtSize.Text), FontStyle.Regular);
                    lblBottom.Font = new Font("Microsoft Sans Serif", Int32.Parse(txtSize.Text), FontStyle.Regular);
                }
                lblTop.Font = new Font("Microsoft Sans Serif", Int32.Parse(txtSize.Text), FontStyle.Regular);
            }
            catch
            {
                
                txtSize.Text = "16";
            }
        }
        private void FontFamily(object sender, EventArgs e)
        {
            try
            {

                lblTop.Font = new Font(cbFam.Text, Int32.Parse(txtSize.Text), FontStyle.Regular);
                lblBottom.Font = new Font(cbFam.Text, Int32.Parse(txtSize.Text), FontStyle.Regular);
            }
            catch
            {
                txtSize.Text = "16";
            }
        }
        private void tbBottom_TextChanged(object sender, EventArgs e)
        {
            lblBottom.Text = tbBottom.Text;
        }
        private void Combo_TextChanged(object sender, EventArgs e)
        {
            picture.ImageLocation = "Base/"+ comboImage.Text + ".jpeg";
            lblBottom.Visible = true;
            lblTop.Visible = true;
        }
        private void FN_Changed(object sender, EventArgs e)
        {
            if(tbFileName.Text!="")
            {
                btnBrowse.Enabled = true;
            }
            else
            {
                btnBrowse.Enabled = false;
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            //Block For making of image bmp
            lblTop.SendToBack();
            lblBottom.SendToBack();
            
            
            ctrlToDraw = gbpic;
            bmp = new System.Drawing.Bitmap(ctrlToDraw.Width, ctrlToDraw.Height);
            ctrlToDraw.DrawToBitmap(bmp, ctrlToDraw.ClientRectangle);
            lblTop.BringToFront();
            lblBottom.BringToFront();

            if(!Directory.Exists("Saved/"+CurrentUser))
            {
                Directory.CreateDirectory("Saved/" + CurrentUser);
            }
            
            if (tbFileName.Text != "")
            {
                bmp.Save("Saved/" +CurrentUser+"/"+ tbFileName.Text + ".jpeg", ImageFormat.Jpeg);
            }
            
            //Block for the saving of said image
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.DefaultExt = "jpeg";
            dialog.AddExtension = true;
            dialog.FileName = tbFileName.Text + ".jpeg";
            dialog.Filter= "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" +
        "All files (*.*)|*.*";
            
            dialog.RestoreDirectory = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(dialog.FileName, ImageFormat.Jpeg);
            }
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            OpenFileDialog getImg = new OpenFileDialog();
            getImg.InitialDirectory = "c:\\";
            getImg.Filter = "Images (*.BMP;*.JPG;*.PNG;*.GIF)|*.BMP;*.JPG;*.PNG;*.GIF";
            getImg.FilterIndex = 2;
            getImg.RestoreDirectory = true;
            if (getImg.ShowDialog() == DialogResult.OK)
            {
                picture.ImageLocation = getImg.FileName;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "" && txtPass.Text != "")
            {
                string UserTest = "";
                
                var con = new SqliteConnection(@"Data Source = Users.db;");
                con.Open();
                string stm = "SELECT * FROM Users WHERE UserName=$User_Name";
                var UserReadTest = new SqliteCommand(stm, con);
                UserReadTest.Parameters.AddWithValue("$User_Name", txtUser.Text);
                SqliteDataReader Read = UserReadTest.ExecuteReader();
                
                while (Read.Read())
                {
                    UserTest = Read.GetString(1);
                }
                con.Close();
                if (UserTest == "")
                {
                    var cmd = new SqliteCommand("INSERT INTO Users(UserName, Password) VALUES($User_Name,$Pass_Word)", con);
                    cmd.Parameters.AddWithValue("$User_Name", txtUser.Text);
                    cmd.Parameters.AddWithValue("$Pass_Word", txtPass.Text.GetHashCode());


                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Operation was successful. Please Login.");
                }
                else
                {
                    MessageBox.Show("User already exists.");
                }
            }
            else
            {
                MessageBox.Show("Please Enter A Username and Password!!");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string UserTest = "";
            string PassTest = "";
            var con = new SqliteConnection(@"Data Source = Users.db;");
            con.Open();
            string stm = "SELECT * FROM Users WHERE UserName=$User_Name";
            var UserReadTest = new SqliteCommand(stm, con);
            UserReadTest.Parameters.AddWithValue("$User_Name", txtUser.Text);
            UserReadTest.Parameters.AddWithValue("$Password", txtPass.Text.GetHashCode());
            SqliteDataReader Read = UserReadTest.ExecuteReader();
            while (Read.Read())
            {
                UserTest = Read.GetString(0);
            }
            Read.Close();
            
            UserReadTest.CommandText = "SELECT* FROM Users WHERE Password=$Password";
            Read = UserReadTest.ExecuteReader();
            while(Read.Read())
            {
                PassTest = Read.GetString(1);
            }

            if (UserTest != ""&&PassTest!="")
            {
                lblWelcome.Visible = true;              
                btnOut.Visible = true;

                lblUser.Visible = false;
                lblPass.Visible = false;
                txtUser.Visible = false;
                txtPass.Visible = false;
                btnLogin.Visible = false;
                btnRegister.Visible = false;


                CurrentUser = UserTest;
                lblWelcome.Text = "Welcome: " + CurrentUser;


                refresh();
            }
            else
            {
                MessageBox.Show("No Such User Exists");
            }
            
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            lblWelcome.Visible = false;
            btnOut.Visible = false;

            lblUser.Visible = true;
            lblPass.Visible = true;
            txtUser.Visible = true;
            txtPass.Visible = true;
            btnLogin.Visible = true;
            btnRegister.Visible = true;
            txtUser.Text = "";
            txtPass.Text = "";

            CurrentUser = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string[] PreviousImages = Directory.GetFiles("Saved/" + CurrentUser, "*.jpeg")
                                     .Select(Path.GetFileNameWithoutExtension)
                                     .ToArray();
            lstPrev.Items.Clear();
            for (int i = 0; i < PreviousImages.Length; i++)
            {
                lstPrev.Items.Add(PreviousImages[i]);
            }
        }
        public void refresh()
        {
            if (!Directory.Exists("Saved/" + CurrentUser))
            {
                Directory.CreateDirectory("Saved/" + CurrentUser);
            }

            string[] PreviousImages = Directory.GetFiles("Saved/" + CurrentUser, "*.jpeg")
                                 .Select(Path.GetFileNameWithoutExtension)
                                 .ToArray();
            lstPrev.Items.Clear();
            for (int i = 0; i < PreviousImages.Length; i++)
            {
                lstPrev.Items.Add(PreviousImages[i]);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            File.Delete("Saved/" + CurrentUser + "/" + lstPrev.SelectedItem + ".jpeg");
            refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(gbpic.Height==600)
            {
                lblTop.Parent = picture;
                gbpic.Size = new Size(640, 480);
                lblBottom.Visible = true;
            }
            else
            {
                lblTop.ForeColor = Color.Black;
                lblTop.Parent = gbpic;
                gbpic.Size = new Size(640, 600);
                lblBottom.Visible = false;
            }
            
        }
    }
}
