// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

using FredrikHr.CSharpWithNativeInterop;

[assembly: SuppressMessage("Performance",
    "CA1810: Initialize reference type static fields inline",
    Justification = nameof(NativeMethods))]
