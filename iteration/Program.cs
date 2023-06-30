
namespace iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    System.Console.WriteLine(i);
            }


            for (int i = 10; i > 0; i--)
            {
                if (i % 2 == 0)
                    System.Console.WriteLine(i);
            }

            System.Console.WriteLine();


            foreach (int j in Enumerable.Range(0, 10))
                System.Console.Write(" j = {0}    ", j);




            System.Console.WriteLine(" FOREACH ");


            var name = "John Smith";

            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine(name[i]);
            }

            foreach (var i in name)
            {
                System.Console.WriteLine(i);
            }



            var arrayNumbers = new int[] { 1, 2, 3, 4 };

            foreach (var item in arrayNumbers)
            {
                System.Console.WriteLine(item);

            }


            System.Console.WriteLine("While");

            var m = 0;
            while (m <= 10)
            {
                if (m % 2 == 0)
                    System.Console.WriteLine(m);
                m++;
            }

            System.Console.WriteLine();


            while (true)
            {
                System.Console.Write("Type your name: ");

                var input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    System.Console.WriteLine("@Echo : " + input);
                    continue;
                }

                break;
            }





            System.Console.WriteLine("Random Numbers");

            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine(random.Next(1, 10));
            }


            System.Console.WriteLine("a ASCII = " + (int)'a');

            System.Console.WriteLine();

            const passwordLength= 10;

            var randomChar = new Random();

            var buffer = new char[passwordLength];

            for (int i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char)('a' + randomChar.Next(0, 26));
            }

            var password = new string(buffer);

            System.Console.WriteLine(password);



        }
    }
}