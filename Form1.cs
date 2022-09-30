namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                ipUserName.Text = Properties.Settings.Default.UserName;
                ipPassword.Text = Properties.Settings.Default.PassWord;
                cbAccount.Checked = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string adminName = "admin";
            string adminPassword = "admin";
            string userName = ipUserName.Text;
            string userPassword = ipPassword.Text;

            if (userName == "" || userPassword == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin!");
                return;
            }

            if (userName == adminName && userPassword == adminPassword)
            {
                if (cbAccount.Checked)
                {
                    Properties.Settings.Default.UserName = ipUserName.Text;
                    Properties.Settings.Default.PassWord = ipPassword.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.UserName = null;
                    Properties.Settings.Default.PassWord = null;
                    Properties.Settings.Default.Save();
                }

                MessageBox.Show("Đăng nhập thành công!");

            } 
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
            }

        }
    }
}