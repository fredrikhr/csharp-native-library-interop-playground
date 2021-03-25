using System;
using System.Runtime.InteropServices;

namespace FredrikHr.CSharpWithNativeInterop
{
    public static class NativeMethods
    {
        private const string NativeLibraryName = "FredrikHr.CppNativeLibrary.dll";
        private static readonly IntPtr pMyNativeNumbers;

        public static unsafe Span<int> MyNativeNumbers => new Span<int>(pMyNativeNumbers.ToPointer(), 42);

        static NativeMethods()
        {
            var hLib = NativeLibrary.Load(NativeLibraryName);
            pMyNativeNumbers = NativeLibrary.GetExport(hLib, "myNativeNumbers");
        }

        [DllImport(NativeLibraryName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int WriteToStdOut();
    }
}
