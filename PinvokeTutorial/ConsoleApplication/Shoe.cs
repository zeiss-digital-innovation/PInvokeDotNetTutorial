using System.Runtime.InteropServices;

namespace ConsoleApplication
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Shoe
    {
        public int id;

        [MarshalAs(UnmanagedType.BStr)]
        public string color;

        public double size;

        [MarshalAs(UnmanagedType.BStr)]
        public string brand;
    }
}
