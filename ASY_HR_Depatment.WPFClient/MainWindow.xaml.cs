using ASY_HR_Depatment.DB;
using System.Windows;

namespace ASY_HR_Depatment.WPFClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tb_login.Text = "Frakiec89"; // todo это  для разработки  - потом  убрать 
            tb_password.Text = "123"; 
        }

        private void btn_in_Click(object sender, RoutedEventArgs e)
        {
            MS_Context _context = new MS_Context();

            try
            {
                var us = _context.Users.SingleOrDefault(x => x.Password == tb_password.Text &&
                x.Login == tb_login.Text);

                if (us != null) 
                {
                    MessageBox.Show("Привет " + us.UserName);
                    Forms.MenuWindow menu = new Forms.MenuWindow(us); 
                    menu.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Пользователь не найден");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error DB +\n" + ex.Message);

            }
        }

        private void btn_reg_Click(object sender, RoutedEventArgs e)
        {
            Forms.RegistrationWindows windows = new Forms.RegistrationWindows();
            windows.ShowDialog();
        }
    }
}