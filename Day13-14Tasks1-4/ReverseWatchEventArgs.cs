using System;

namespace Day13_14Tasks1_4
{
    /// <summary>
    /// Identify the type of information that stores information, which is passed to the subscribers of the event notification.
    /// </summary>
    public sealed class ReverseWatchEventArgs : EventArgs
    {
        private readonly int seconds;

        private readonly string message;

        /// <summary>
        /// Consructor for event information handler
        /// </summary>
        /// <param name="sec">Time in seconds</param>
        /// <param name="msg">Message for passing</param>
        public ReverseWatchEventArgs(int sec, string msg)
        {
            seconds = sec;
            message = msg;
        }

        /// <summary>
        /// Property for getting time in seconds
        /// </summary>
        public int Seconds { get => seconds; }

        /// <summary>
        /// Property for getting message
        /// </summary>
        public string Message { get => message; }
    }
}
