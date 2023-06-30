// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace controlflow
{

    public enum Season
    {
        Spring, Summer, Fall, Winter
    }
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Fall;
            Console.WriteLine("hi {0}", season);


            switch (season)
            {
                case Season.Fall:
                    System.Console.WriteLine("Fall");
                    break;
                case Season.Summer:
                    System.Console.WriteLine("Summer");
                    break;
                default:
                    System.Console.WriteLine("other");
                    break;
            }



            switch (season)
            {
                case Season.Summer:
                case Season.Winter:
                    System.Console.WriteLine("Not Promotion");
                    break;
                default:
                    System.Console.WriteLine("other");
                    break;
            }



        }
    }
}