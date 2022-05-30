
class Task1
{
    /* Задание 1

Имеется 3 переменные типа int x = 10, y = 12, и z = 3;
Выполните и рассчитайте результат следующих операций для этих переменных: 
 x += y - x++ * z;
 z = --x - y * 5;
 y /= x + 5 % z;
 z = x++ + y * 5;
 x = y - x++ * z; */

    static void Main()
    {
        {
            int x = 10;
            int y = 12;
            int z = 3;
            int a = x += y - x++ * z;
            Console.WriteLine("Task1");
            Console.WriteLine("equation 1: " + a);
        }
        {
            int x = 10;
            int y = 12;
            int z = 3;
            int b = z = --x - y * 5;
            Console.WriteLine("equation 2: " + b);
        }
        {
            int x = 10;
            int y = 12;
            int z = 3;
            int c = y /= x + 5 % z;
            Console.WriteLine("equation 3: " + c);
        }
        {
            int x = 10;
            int y = 12;
            int z = 3;
            int d = z = x++ + y * 5;
            Console.WriteLine("equation 4: " + d);
        }
        {
            int x = 10;
            int y = 12;
            int z = 3;
            int e = x = y - x++ * z;
            Console.WriteLine("equation 5: " + e);
            Console.WriteLine("_____________________");
        }
        {
            /* Задание 2

Используя Visual Studio, создайте проект по шаблону Console Application.
Вычислите среднее арифметическое трех целочисленных значений и выведите его на экран.
С какой проблемой вы столкнулись? Какой тип переменных лучше использовать
для корректного отображения результата? */

            double a = 2;
            double b = 4;
            double c = 8;
            double result = (a + b + c) / 3;
            Console.WriteLine("Task2");
            Console.WriteLine("{0:#.#}", result);
            Console.WriteLine("_____________________");
        }
        {
            /*Задание 3

 Используя Visual Studio, создайте проект по шаблону Console Application.
 Создайте константу с именем -pi (число π «пи»), создайте переменную радиус с именем – r.
 Используя формулу πR 2 , вычислите площадь круга и выведите результат на экран. */

            const double pi = 3.14;
            double r = 4;
            double area = pi * Math.Pow(r, 2);
            Console.WriteLine("Task3");
            Console.WriteLine("Circle area - " + area + " sm^2");
            Console.WriteLine("_____________________");
        }
        {
            /* Задание 4
 Используя Visual Studio, создайте проект по шаблону Console Application.
 Напишите программу расчета объема – V и площади поверхности – S цилиндра.
 Объем V цилиндра радиусом – R и высотой – h, вычисляется по формуле: V = πR 2 h
 Площадь S поверхности цилиндра вычисляется по формуле: S = 2πR 2 + 2πR 2 = 2πR(R+h)
 Результаты расчетов выведите на экран. */

            const double pi = 3.14;
            double r = 4;
            double h = 20;
            double v = pi * Math.Pow(r, 2) * h;
            double s = 2 * pi * r * (r + h); 
            Console.WriteLine("Task4");
            Console.WriteLine("Cylinder volume - " + "{0:#.## sm^3}", v);
            Console.WriteLine("Total cylinder area - " + s + " sm^2");
            Console.WriteLine("_____________________");
        }
        {
            /* Задание 7
 Используя VisualStudio, создайте проект по шаблону ConsoleApplication.
 Создайте две целочисленные переменные и выведите на экран результаты всех арифметических операций
 над этими двумя переменными. */

            int a = 5;
            int b = 10;
            int d = 6;
            int e = 7;
            int sum = a + b;
            int difference = b - a;
            int product = a * b;
            int quotient = b / a;
            int remainder = e % a;
            int postincrement = a++;
            int preincrement = ++a;
            int postdecrement = b--;
            int predecrement = --b;
            double result = Math.Pow (a, b);
            d += 3;
            Console.WriteLine("Task7");
            Console.WriteLine("Addition: " + sum);
            Console.WriteLine("Subtraction: " + difference);
            Console.WriteLine("Multiplication: " + product);
            Console.WriteLine("Division: " + quotient);
            Console.WriteLine("Remainder: " + remainder);
            Console.WriteLine("Postincrement: " + postincrement);
            Console.WriteLine("Preincrement: " + preincrement);
            Console.WriteLine("Postdecrement: " + postdecrement);
            Console.WriteLine("Predecrement: " + predecrement);
            Console.WriteLine("Power: " + result);
            Console.WriteLine("Compound assignment: " + d);
        }
    }
}