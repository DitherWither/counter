// ReSharper disable file InconsistentNaming
// The "inconsistent naming" is intentional, because they are global constants.
namespace io.github.DitherWither.counter;

/// <summary>
/// Contains constants used throughout the application.
/// </summary>
///
/// <remarks>
/// This class contains constants that are used throughout the application.
/// This class is `global using`d in Program.cs, so we don't have to specify which class the constant is in.
///
/// This is done because C# doesn't have global constants.
/// </remarks>
public static class Constants
{
    public const string APP_ID = "io.github.ditherwither.counter";
}