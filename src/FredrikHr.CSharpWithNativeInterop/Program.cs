
namespace FredrikHr.CSharpWithNativeInterop
{
    using static NativeMethods;

    public static class Program
    {
        public static void Main()
        {
            foreach (ref int pNum in MyNativeNumbers)
            {
                pNum = 42;
            }

            int charsWritten = WriteToStdOut();
            _ = charsWritten;
        }
    }
}
