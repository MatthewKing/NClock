using System;

namespace NClock
{
    /// <summary>
    /// Provides functionality to return the current date and time.
    /// </summary>
    public static class Clock
    {
        /// <summary>
        /// Gets or sets the <see cref="IClock"/> instance used to provide the current date and time.
        /// </summary>
        public static IClock Provider { get; set; } = new SystemClock();

        /// <summary>
        /// Gets a <see cref="DateTimeOffset"/> object whose date and time are set to the current 
        /// Coordinated Universal Time (UTC) date and time and whose offset is <see cref="TimeSpan.Zero"/>.
        /// </summary>
        public static DateTimeOffset UtcNow => Provider.UtcNow;
    }
}
