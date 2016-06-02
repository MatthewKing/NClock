using System;

namespace NClock
{
    /// <summary>
    /// An implementation of <see cref="IClock"/> that uses the system clock.
    /// </summary>
    public class SystemClock : IClock
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemClock"/> class.
        /// </summary>
        public SystemClock() { }

        /// <summary>
        /// Gets a <see cref="DateTimeOffset"/> object whose date and time are set to the current 
        /// Coordinated Universal Time (UTC) date and time and whose offset is <see cref="TimeSpan.Zero"/>.
        /// </summary>
        public DateTimeOffset UtcNow => DateTimeOffset.UtcNow;
    }
}
