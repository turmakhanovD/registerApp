using SecurityApp.DataAccess;
using SecurityApp.Services;
using System.Linq;
using System.Windows;

namespace SecurityApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SignInButtonClick(object sender, RoutedEventArgs e)
        {
            var login = loginTextBox.Text;
            var password = passswordBox.Password;

            if(string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Вы не заполнили поля!", "Ошибка!");
                return;
            }

            using (var context = new SecurityContext())
            {
                var user = context.Users.SingleOrDefault(searchingUser => searchingUser.Login == login);

                if (user == null || SecurityHasher.VerifyPassword(password, user.Password))
                    MessageBox.Show("Неверный логин или пароль!","Ошибка!");
                else
                    MessageBox.Show("Успешный вход!", "Успешно!");
            }

        }

        private void RegistrationClick(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
        }
    }
}
