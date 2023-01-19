// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;

[DllImport("_library")]
static extern string pinvoke_get_platform_name();

Console.WriteLine("Hello, World! " + pinvoke_get_platform_name());