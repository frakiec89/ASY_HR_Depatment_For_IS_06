using ASY_HR_Depatment.DB;
using System.Text;
using System.Windows;
using System.Windows.Media.Imaging;
// track
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