using System.Windows;
// track
namespace ASY_HR_Depatment.WPFClient.Forms
{
    /// <summary>
    /// Логика взаимодействия для AddStudnetWindow.xaml
    /// </summary>
    public partial class AddStudnetWindow : Window
    {
        public AddStudnetWindow()
        {
            InitializeComponent();
            this.Loaded += AddStudnetWindow_Loaded;

        }

        private void AddStudnetWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                DB.MS_Context context = new DB.MS_Context();
                List<DB.Group> groups = context.Groups.ToList();

                cb_group.ItemsSource = groups;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error db");
            }

        }

        private void btn_add_student_Click(object sender, RoutedEventArgs e)
        {
            DB.Group group = cb_group.SelectedItem as DB.Group;

            if(group == null) 
            {
                MessageBox.Show("Выберите группу");
                return;
            }

            DB.Student student = new DB.Student();
            student.Name = tb_name_student.Text;
            student.SurName = tb_surName_student.Text;
            student.Patronumic = tb_Patronumic_Student.Text;

            student.GroupID = group.GroupID;
            try
            {
                DB.MS_Context context = new DB.MS_Context();
                context.Students.Add(student);
                context.SaveChanges();
                MessageBox.Show($"Студент {student.Name} добавлен  в  базу  данных");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error db");
            }


        }
    }
}
