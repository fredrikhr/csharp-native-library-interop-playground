using System.Runtime.InteropServices;

namespace FredrikHr.CSharpWithNativeInterop
{
    public static class Program
    {
        [DllImport("FredrikHr.CppNativeLibrary.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int WriteToStdOut();

        public static void Main()
        {
            int charsWritten = WriteToStdOut();
            _ = charsWritten;
        }
    }
}
