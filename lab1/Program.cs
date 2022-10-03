using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab1

{
    internal class Program
    {
        struct Human
        {
            int age;
            string name;
            string lastname;
            string sex;
            int height;
            public void Input() //инициализация полей структуры
            {
                name = "Иван";
                lastname = "Тимофеев";
                age = 19;
                sex = "male";
                height = 190;
            }
            public void Show() //отображение полей структуры
            {
                Console.Clear();
                Console.WriteLine("Текущие поля структуры: ");
                Console.WriteLine($"Имя: {name}");
                Console.WriteLine($"Фамилия: {lastname}");
                Console.WriteLine($"Возраст: {age} ");
                Console.WriteLine($"Пол: {sex} ");
                Console.WriteLine($"Рост: {height} ");
            }
        }
        static void Main(string[] args)
        {
            int choice = -1;

            while (choice != 0)
            {
                Console.Clear();
                Console.WriteLine("Выберите номер задания(1-5) и 0, чтобы выйти: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        {
                            break;
                        }
                    case 1:
                        {
                            Console.Clear();
                            Z1();
                            Console.ReadKey();
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            Z2();
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Z3();
                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Z4();
                            Console.ReadKey();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            Z5();
                            Console.ReadKey();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Такого задания не существует");
                            break;
                        }
                }
            }
        }
        public static void Z1()
        {
            double x = 0, y = 0, z = 0, a = 0, b = 0;
            Console.Write("Введите значение x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение z: ");
            z = Convert.ToDouble(Console.ReadLine());
            a = (Math.Sqrt(Math.Abs(x - 1)) - Math.Sqrt(Math.Abs(y))) / (1 + (Math.Pow(x, 2) / 2) + (Math.Pow(y, 2) / 4));
            b = x * (Math.Atan(z) + Math.E);
            Console.Write("Значение a равно "); Console.WriteLine(a);
            Console.Write("Значение b равно "); Console.WriteLine(b);
        }
        public static void Z2()
        {
            double a = 0, h = 0, V = 0, Sh = 0, L = 0, angle = 45, radians = 0, res = 0, S = 0;
            Console.WriteLine("Правильная пирамида");
            Console.Write("Введите значение стороны квадрата: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение высоты пирамиды: ");
            h = Convert.ToDouble(Console.ReadLine());
            Console.Write("При  a = ");
            Console.Write(a); Console.Write(" и h = "); Console.WriteLine(h);
            Sh = Math.Pow(a, 2);

            V = (1.0 / 3) * Sh * h;

            Console.Write("Объем правильной пирамиды равен "); Console.WriteLine(V);
            radians = angle * (Math.PI / 180);
            res = a / (2 * Math.Tan(radians));
            L = Math.Sqrt(Math.Pow(h, 2) + Math.Pow(res, 2));
            Console.Write("Апофема пирамиды равна "); Console.WriteLine(L);
            S = (4 * a) / 2 * (res + L);
            Console.Write("Площадь полной поверхности равна "); Console.WriteLine(S);
        }
        public static void Z3()
        {
            double x = 0, y = 0, z = 0;
            int n = 3;
            double[] arr = new double[3];
            Console.WriteLine("Введите 3 числа: ");
            for (int i = 0; i < 3; i++)
            {
                arr[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine(MinF(arr));
            Array.Sort(arr);

            Console.WriteLine("Числа в убывающем порядке: ");
            for (int i = n - 1; i >= 0; --i)
            {
                Console.Write(arr[i]);
                Console.Write(", ");
            }

        }
        public static double MinF(double[] arr)
        {
            double min = 0;
            for (int i = 0; i < 3; i++)
            {

                if (i == 0 || arr[i] < min)
                {

                    min = arr[i];
                }
            }
            Console.Write("Минимальное число равно ");
            return min;
        }
        public static void Z4()
        {
            int n = 0;

            string[] mas = new string[6];
            mas[0] = "Никита";
            mas[1] = "Максим";
            mas[2] = "Ваня";
            mas[3] = "Данил";
            mas[4] = "Саша";
            mas[5] = "Ольга";

            int[] array = new int[6];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;
            array[5] = 6;
            Console.WriteLine("Выберите номер машины(6): ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine($"За машиной номер {array[0]} сидит {mas[0]}");

            }
            else if (n == 2)
            {

                Console.WriteLine($"За машиной номер {array[1]} сидит {mas[1]}");

            }
            else if (n == 3)
            {
                Console.WriteLine($"За машиной номер {array[2]} сидит {mas[2]}");
            }
            else if (n == 4)
            {

                Console.WriteLine($"За машиной номер {array[3]} сидит {mas[3]}");
            }
            else if (n == 5)
            {
                Console.WriteLine($"За машиной номер {array[4]} сидит {mas[4]}");
            }
            else if (n == 6)
            {
                Console.WriteLine($"За машиной номер {array[5]} сидит {mas[5]}");
            }
            else
            {
                Console.WriteLine("Такой машины не существует");
            }
        } //**********************
        public static void Z5()
        {
            Human h = new Human();
            h.Input();
            h.Show();

        }
    }
}
