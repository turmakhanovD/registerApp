using SecurityApp.DataAccess;
using SecurityApp.Models;
using System.Linq;
using System.Windows;

namespace SecurityApp
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void RegistrationClick(object sender, RoutedEventArgs e)
        {
            using (var context = new SecurityContext())
            {
                User userFind = context.Users.Where(user => user.Login == loginTextBox.Text).FirstOrDefault();
                if (userFind!=null)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует!", "Ошибка!");
                }
                else
                {
                    var newUser = new User
                    {
                        Login = loginTextBox.Text,
                        Password = passwordTextBox.Password
                    };
                    context.Users.Add(newUser);
                    context.SaveChanges();
                    MessageBox.Show("Регистрация прошла успешно!", "Успешно!");
                }
            }
        }
    }
}
