using System;

namespace NClock
{
    /// <summary>
    /// Provides functionality to return the current date and time.
    /// </summary>
    public interface IClock
    {
        /// <summary>
        /// Gets a <see cref="DateTimeOffset"/> object whose date and time are set to the current 
        /// Coordinated Universal Time (UTC) date and time and whose offset is <see cref="TimeSpan.Zero"/>.
        /// </summary>
        DateTimeOffset UtcNow { get; }
    }
}
