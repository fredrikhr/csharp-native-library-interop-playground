// dllmain.cpp : Defines the entry point for the DLL application.
#include "pch.h"

_declspec(dllexport) int myNativeNumbers[42];

__declspec(dllexport) int WriteToStdOut(void)
{
    return printf("This is a string written from a native library.");
}
