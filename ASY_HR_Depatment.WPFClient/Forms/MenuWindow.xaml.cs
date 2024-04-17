using ASY_HR_Depatment.DB;
using System.Windows;

// track

namespace ASY_HR_Depatment.WPFClient.Forms
{
    /// <summary>
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
            Title = $"Не  авторизованный пользователь";
        }

        public MenuWindow(User us):this ()
        {
            Title = $"Вы авторизованы в  системе  под  ником " +  us.Login;
        }

        private void btnAddGroup_Click(object sender, RoutedEventArgs e)
        {
            Forms.AddGroupWindows windows = new Forms.AddGroupWindows();
            windows.ShowDialog();
        }

        private void btnAddStudetn_Click(object sender, RoutedEventArgs e)
        {
            Forms.AddStudnetWindow window = new AddStudnetWindow();
            window.ShowDialog();

        }

        private void btnSelectGroup_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("В разработке");
        }

        private void btnSelecStudent_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("В разработке");

        }
    }
}
