using System;

namespace Day13_14Tasks1_4
{
    /// <summary>
    /// Class that subscribes for Coundown
    /// </summary>
    public class ReverseWatchSubscriber
    {    
        /// <summary>
        /// Method for subscribing for event
        /// </summary>
        /// <param name="reverseWatch">Instance of Countdown</param>
        public void Register(ReverseWatch reverseWatch) => reverseWatch.Countdown += CountdownOver;

        /// <summary>
        /// Method for unsubscribing from event
        /// </summary>
        /// <param name="reverseWatch">Instance of Countdown</param>
        public void Unregister(ReverseWatch reverseWatch) => reverseWatch.Countdown -= CountdownOver;

        private void CountdownOver(object sender, ReverseWatchEventArgs eventArgs)
        {
            Console.WriteLine("Countdown ended");
            Console.WriteLine("The message is: {0}", eventArgs.Message);
        }
    }
}
