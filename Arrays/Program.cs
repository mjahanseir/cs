
namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                        var matrix = new int[3, 5]{
                                                    {1,2,3,4,5,6},
                                                    {7,8,9,10,11,12},
                                                    {1,2,3,4,5,6}
                                                };


                        var jaggedArray = new int[3][];

                        jaggedArray[0] = new int[4];
                        jaggedArray[1] = new int[5];
                        jaggedArray[2] = new int[3];

                        System.Console.WriteLine(jaggedArray[0][2]);

            */
            var numbers = new[] { 3, 7, 9, 2, 14, 16 };
            System.Console.WriteLine(numbers.Length);

            System.Console.WriteLine(Array.IndexOf(numbers, 9));


            Array.Clear(numbers, 0, 2);

            foreach (var number in numbers)
                System.Console.WriteLine(number);

            var another = new int[3];
            Array.Copy(numbers, another, 3);

            foreach (var number in another)
                System.Console.WriteLine(number);


            Array.Sort(numbers);
            foreach (var number in numbers)
                System.Console.WriteLine(number);


            Array.Reverse(numbers);
            foreach (var number in numbers)
                System.Console.WriteLine(number);

            System.Console.WriteLine("LISTS");

            var nums = new List<int>() { 1, 2, 3, 4 };
            nums.Add(1);
            nums.AddRange(new int[3] { 5, 6, 7 });

            foreach (var item in nums)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine(nums.IndexOf(1));
            System.Console.WriteLine(nums.LastIndexOf(1));
            System.Console.WriteLine(nums.Count);

            for (int i = 0; i < 10; i++)
            {
                if (nums[i] == 1)
                    nums.Remove(nums[i]);
            }
            foreach (var item in nums)
            {
                System.Console.WriteLine(item);
            }

            nums.Clear();
            System.Console.WriteLine(nums.Count);

        }
    }
}