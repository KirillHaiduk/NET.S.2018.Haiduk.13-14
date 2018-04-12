using System;
using System.Threading;

namespace Day13_14Tasks1_4
{
    /// <summary>
    /// Class-broadcaster for countdown when it's over
    /// </summary>
    public class ReverseWatch
    {
        /// <summary>
        /// Delegate for handling event
        /// </summary>
        /// <param name="sender">Name of event broadcaster</param>
        /// <param name="e">Information about event</param>
        public delegate void ReverseWatchEventHandler(object sender, ReverseWatchEventArgs e);

        /// <summary>
        /// Event member
        /// </summary>
        public event ReverseWatchEventHandler Countdown = delegate { };        
        
        /// <summary>
        /// Method that initiates event and sends information in it
        /// </summary>
        /// <param name="seconds">Time in seconds</param>
        /// <param name="message">Message for passing</param>
        public void StartCoundown(int seconds, string message)
        {
            if (seconds < 0)
            {
                throw new ArgumentException(nameof(seconds), "Number of seconds must be greater than 0");
            }

            Thread.Sleep(seconds * 1000);
            OnCountdown(this, new ReverseWatchEventArgs(seconds, message));
        }

        protected virtual void OnCountdown(object sender, ReverseWatchEventArgs e) => Countdown?.Invoke(sender, e);
    }    
}
