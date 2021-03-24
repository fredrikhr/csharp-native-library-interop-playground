// dllmain.cpp : Defines the entry point for the DLL application.
#include "pch.h"

__declspec(dllexport) int WriteToStdOut(void)
{
    return printf("This is a string written from a native library.");
}
