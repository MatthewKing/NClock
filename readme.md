NClock
======

Introduction
------------

Provides testable and mockable clock implementations.

Quickstart
----------

First, set the clock provider in your application:

```csharp
static void Main(string[] args)
{
    Clock.Provider = new SystemClock();

    ...
}
```

Next, use `Clock.UtcNow` to get the time in the same way as you'd use `DateTimeOffset.UtcNow` or `DateTime.UtcNow`:

```csharp
string GetTimestampString()
{
    return Clock.UtcNow.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss")
}
```

Now, you can change the clock provider in your test methods:

```csharp
[Test]
void GetTimestampString_ReturnsCorrectFormattedTimestamp()
{
    // Arrange
    Clock.Provider = new ConstantClock(new DateTimeOffset(2017, 10, 29, 08, 39, 00, TimeSpan.Zero));

    // Act
    var timestamp = GetTimestampString();

    // Assert
    timestamp.Should().Be("2017-10-29T08:39:00");
}
```

### 

Installation
------------

`PM> Install-Package NClock`

Copyright
---------
Copyright Matthew King 2016-2017.

License
-------
NClock is licensed under the [MIT License](https://opensource.org/licenses/MIT). Refer to license.txt for more information.
