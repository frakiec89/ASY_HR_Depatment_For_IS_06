using System.Windows;
// track
namespace ASY_HR_Depatment.WPFClient.Forms
{
    /// <summary>
    /// Логика взаимодействия для AddGroupWindows.xaml
    /// </summary>
    public partial class AddGroupWindows : Window
    {
        public AddGroupWindows()
        {
            InitializeComponent();
        }

        private void btn_add_group_Click(object sender, RoutedEventArgs e)
        {
            DB.MS_Context context = new DB.MS_Context();    

            DB.Group group = new DB.Group();
            group.Name = tb_name_Group.Text;

            try
            {
                context.Groups.Add(group);
                context.SaveChanges();
                MessageBox.Show($"группа {group.Name} добавлена  в БД");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранение  в  БД\n" + ex.Message);
            }

        }
    }
}
