

using ASY_HR_Depatment.DB;
using System.Windows;

namespace ASY_HR_Depatment.WPFClient.Forms
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindows.xaml
    /// </summary>
    public partial class RegistrationWindows : Window
    {
        public RegistrationWindows()
        {
            InitializeComponent();
        }

        private void btn_reg_Click(object sender, RoutedEventArgs e)
        {
            if(tb_password.Text != tb_double_password.Text) 
            {
                MessageBox.Show("Пароли не  равны");
                return;
            }
            
            MS_Context _context = new MS_Context();

            User user = new User();
            user.UserName = tb_name_user.Text;
            user.Password = tb_password.Text;
            user.Login = tb_login.Text;
            user.Login = tb_login.Text;

            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                MessageBox.Show("Пользователь  добавлен в  БД");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error DB +\n" +ex.Message);

            }
        }
    }
}
