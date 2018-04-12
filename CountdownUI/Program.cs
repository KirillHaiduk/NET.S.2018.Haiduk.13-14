using System;
using Day13_14Tasks1_4;

namespace CountdownUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var reverseWatch = new ReverseWatch();
            var subscriber = new ReverseWatchSubscriber();
            subscriber.Register(reverseWatch);
            Console.WriteLine("Enter time in seconds for Coundown: ");
            int seconds = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your message for subscriber: ");
            string message = Console.ReadLine();
            Console.Clear();
            reverseWatch.StartCoundown(seconds, message);
            Console.ReadLine();
        }
    }
}
