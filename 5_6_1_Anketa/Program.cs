using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace _5_6_1_Anketa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Заполните данные пользователя:");
            var userData = userdata();
            var userpets = pets();
            var usercolors = colors();
            Console.WriteLine("ваше имя: {0}", userData.name);
            Console.WriteLine("Ваша фамилия: {0}", userData.secname);
            Console.WriteLine("Ваш возраст: {0}", userData.age);
            Console.WriteLine("Имена ваших питомцев:");
            foreach (var name in userpets)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("ваши любимые цвета: ");
            foreach (var color in usercolors)
            { 
                Console.WriteLine(color);
            };

        }
        public static  (string name, string secname, int age) userdata()
        {
            Console.WriteLine("введите ваше имя: ");
            var name = Console.ReadLine();

            Console.WriteLine("введите вашу фамилию");
            var secname = Console.ReadLine();

            int age = 0;
            while (true)
            {
                Console.WriteLine("Введите ваш возраст цифрами: ");
                var input = int.Parse(Console.ReadLine());

                if (input >= 0)
                { age = input; break; }
                else
                { Console.WriteLine("неверное значение"); }

            }
            return (name, secname, age);

        }
        public static string[] pets()
        {
            
            while (true)
            {
                Console.WriteLine("Есть ли у вас домашние питомцы (да или нет)?");
                var input = Console.ReadLine();

                if (input == "да")
                {
                    Console.WriteLine("Сколько домашних у вас есть? (введите число цифрами)");
                    var pets = int.Parse(Console.ReadLine());

                    string[] petnames = new string[pets];

                    Console.WriteLine("Как зовут ваших петомцев");
                    for (int i = 0; i < pets; i++)
                    {
                        Console.WriteLine($"введите имя {i +1} питомца");
                       petnames[i] = Console.ReadLine();
                    }
                    return petnames;
                }
                else if (input == "нет")
                {
                    return Array.Empty<string>();
                }
                else
                {
                    Console.WriteLine("пожалуйста выберете ответ да или нет");
                }
                return pets();
            }
        }
        public static string[] colors()
        {

            while (true)
            {
                Console.WriteLine("сколько у вас любимых цветов(введите число цифрами)");
                var x = int.Parse(Console.ReadLine());

                if (x < 0)
                { Console.WriteLine("неверное значение"); }
                if (x == 0)
                { Console.WriteLine("у вас нет любимых цветов"); return Array.Empty<string>(); ; }
                else
                {
                    Console.WriteLine("перечислите любимые цвета");

                    string[] color = new string[x];

                    for (int i = 0; i < x; i++)
                    { 
                        Console.WriteLine($"введите {i+1} цвет");
                        color[i] = Console.ReadLine();

                    }
                    
                    return color;
                }
            }
        }

    }
}

