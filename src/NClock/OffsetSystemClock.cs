using System;

namespace NClock
{
    /// <summary>
    /// An implementation of <see cref="IClock"/> using the system clock offset by a specified value.
    /// </summary>
    public class OffsetSystemClock : IClock
    {
        /// <summary>
        /// The <see cref="TimeSpan"/> to offset the system clock value by.
        /// </summary>
        private readonly TimeSpan _offset;

        /// <summary>
        /// Initializes a new instance of the <see cref="OffsetSystemClock"/> class.
        /// </summary>
        /// <param name="offset">The <see cref="TimeSpan"/> to offset the system clock value by.</param>
        public OffsetSystemClock(TimeSpan offset)
        {
            _offset = offset;
        }

        /// <summary>
        /// Gets a <see cref="DateTimeOffset"/> object whose date and time are set to the current 
        /// Coordinated Universal Time (UTC) date and time and whose offset is <see cref="TimeSpan.Zero"/>.
        /// </summary>
        public DateTimeOffset UtcNow => DateTimeOffset.UtcNow.Add(_offset);
    }
}
