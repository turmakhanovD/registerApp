using System;

namespace SecurityApp
{
    public class Menu
    {
        public void StartMainMenu(SecurityContext context)
        {
            Console.WriteLine("\t\tДобро пожаловать!\nВведите ФИО посетителя:");
            var name = Console.ReadLine();

            Console.WriteLine("Введите дату когда пришел посетитель:");

            DateTime whenArrived = new DateTime();
            while(!DateTime.TryParse(Console.ReadLine(),out whenArrived))
            {
                Console.WriteLine("Введите корректную дату когда пришел посетитель:");
            }

            Console.WriteLine("Введите дату когда ушел посетитель:");

            DateTime whenLeaved = new DateTime();
            while (!DateTime.TryParse(Console.ReadLine(), out whenLeaved))
            {
                Console.WriteLine("Введите корректную дату когда ушел посетитель:");
            }

            Console.WriteLine("Введите номер удостоверения личности посетителя: ");

            int num = 0;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Введите корректный номер удостоверения личности посетителя: ");
            }

            var Visitor = new Visitor()
            {
                Name = name,
                WhenArrived = whenArrived,
                WhenLeaved = whenLeaved,
                CertificateNumber = num
            };

            using (context)
            {
                context.Visitors.Add(Visitor);
                context.SaveChanges();
            }

            Console.WriteLine("Данные успешно записаны!");
        }
    }
}
