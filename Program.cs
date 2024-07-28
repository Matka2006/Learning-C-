//class Program
//{
//    static void Main(string[] args)
//    {

//        if (!int.TryParse(Console.ReadLine(), out int a))
//        {
//            Console.WriteLine("Not a number!");
//            Console.Read();
//            return;
//        }
//        if (!int.TryParse(Console.ReadLine(), out int b))
//        {
//            Console.WriteLine("Not a number!");
//            Console.Read();
//            return;
//        }

//        var s = Console.ReadLine();
//        var boolVar = true;
//        if (s.Length == 0 || s.Length > 1 && !boolVar)
//        {
//            Console.WriteLine("Wrong sign");
//            Console.Read();
//            return;
//        }

//        switch (s[0])
//        {
//            case '+':
//                Console.WriteLine("Result of {0} + {1} = {2}, 0b: {3}, 0x: {4} ", a, b, a + b, Convert.ToString(a + b, 2), Convert.ToString(a + b, 16));
//                break;
//            case '-':
//                Console.WriteLine("Result of {0} - {1} = {2}, 0b: {3}, 0x: {4} ", a, b, a - b, Convert.ToString(a - b, 2), Convert.ToString(a - b, 16));
//                break;
//            case '/':
//                Console.WriteLine("Result of {0} / {1} = {2}, 0b: {3}, 0x: {4} ", a, b, a / b, Convert.ToString(a / b, 2), Convert.ToString(a / b, 16));
//                break;
//            case '*':
//                Console.WriteLine("Result of {0} * {1} = {2}, 0b: {3}, 0x: {4} ", a, b, a * b, Convert.ToString(a * b, 2), Convert.ToString(a * b, 16));
//                break;
//            case '%':
//                Console.WriteLine("Result of {0} % {1} = {2}, 0b: {3}, 0x: {4} ", a, b, a % b, Convert.ToString(a % b, 2), Convert.ToString(a % b, 16));
//                break;

//        }

//        Console.WriteLine("Also suggest using the following functions: &, |, ^");
//        var c = Console.ReadLine();
//        //var boolC = true;
//        if (c[0] != '&' && c[0] != '|' && c[0] != '^' && c[0] != 'N')
//        {
//            Console.WriteLine("Wrong sign");
//            Console.Read();
//            return;
//        }

//        switch (c[0])
//        {
//            case '&':
//                Console.WriteLine("Result of {0} & {1} = {2}, 0b: {3}, 0x: {4} ", a, b, a & b, Convert.ToString(a & b, 2), Convert.ToString(a & b, 16));
//                break;
//            case '|':
//                Console.WriteLine("Result of {0} | {1} = {2}, 0b: {3}, 0x: {4} ", a, b, a | b, Convert.ToString(a | b, 2), Convert.ToString(a | b, 16));
//                break;
//            case '^':
//                Console.WriteLine("Result of {0} ^ {1} = {2}, 0b: {3}, 0x: {4} ", a, b, a ^ b, Convert.ToString(a ^ b, 2), Convert.ToString(a ^ b, 16));
//                break;
//            case 'N':
//                break;

//        }

//        Console.WriteLine("Thank you for using my calculator!!!");
//        Console.Read();

//    }
//}

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var FibArray = new[] { 0, 1, 1, 2, 3, 5, 8, 13 };

            //string[] Month = new[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "November", "December" };

            //int[][] Degrees = new[] { new[] { 2, 3, 4 }, new[] { 4, 9, 16 }, new[] { 8, 27, 64 } };

            //double[][] JuggedArray = { new[] { 1d, 2, 3, 4, 5 }, new[] { Math.E, Math.PI } };

            //Console.WriteLine(JuggedArray[1][0]);
            //Console.Read();

            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };

            //Array.Copy(array, 0, array2, -1, 3);
            //Console.WriteLine(array2[-1]);
            //Console.Read();

            Array.Resize(ref array, 10);
            foreach (int i in array)
            {
                Console.WriteLine(array[8]);
                Console.Read();
            }
            
        }
    }
}

//namespace Homework
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var last = 1;
//            for (int i = 0; i == 34; i += last)
//            {
//                Console.WriteLine(i);
//                last = i;
//                Console.Read();
//            }

//            for (int i = 0; i == 20; i += 2)
//            {
//                Console.WriteLine(i);
//                Console.Read();
//            }

//            int[] num = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//            for (int i = 0; i == 5; i += 1)
//            {
//                foreach (int g in num)
//                {
//                    Console.WriteLine(g * i);
//                    Console.Read();
//                }
//            }

//            string password;
//            do
//            {
//                password = Console.ReadLine();
//            } while (password != "qwerty");



//        }
//    }
//}

