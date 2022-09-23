using System.Runtime.InteropServices;

Console.WriteLine("---");
Console.WriteLine("DllImport:");
Native.hello();
Console.WriteLine();
Console.WriteLine($"Sum of 3 + 4: {Native.sum(3, 4)}");
Native.printf("Hello from MSVC!");
Console.WriteLine("\n---");

Console.WriteLine("LibraryImport:");
NativeGenerated.hello();
Console.WriteLine();
Console.WriteLine($"Sum of 3 + 4: {NativeGenerated.sum(3, 4)}");
NativeGenerated.printf("Hello from MSVC!\n");
Console.WriteLine("---");

public static class Native
{
    [DllImport(@"rust_native_lib.dll")]
    public extern static void hello();
    [DllImport(@"rust_native_lib.dll")]
    public extern static int sum(int a, int b);
    [DllImport("msvcr120.dll")]
    public static extern int printf(string format);
}

public static partial class NativeGenerated
{
    [LibraryImport(@"rust_native_lib.dll")]
    public static partial void hello();
    [LibraryImport(@"rust_native_lib.dll")]
    public static partial int sum(int a, int b);
    [LibraryImport("msvcr120.dll")]
    public static partial int printf([MarshalAs(UnmanagedType.LPStr)] string format);
}
