using System;

namespace NClock
{
    /// <summary>
    /// An implementation of <see cref="IClock"/> that always returns the same value.
    /// </summary>
    public class ConstantClock : IClock
    {
        /// <summary>
        /// The <see cref="DateTimeOffset"/> object to return.
        /// </summary>
        private DateTimeOffset _value;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConstantClock"/> class.
        /// </summary>
        /// <param name="value">The <see cref="DateTimeOffset"/> object to return.</param>
        public ConstantClock(DateTimeOffset value)
        {
            _value = value;
        }

        /// <summary>
        /// Gets a <see cref="DateTimeOffset"/> object whose date and time are set to the current 
        /// Coordinated Universal Time (UTC) date and time and whose offset is <see cref="TimeSpan.Zero"/>.
        /// </summary>
        public DateTimeOffset UtcNow => _value.ToUniversalTime();
    }
}
