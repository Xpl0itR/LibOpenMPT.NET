using System.Runtime.InteropServices;

namespace LibOpenMPT.NET;

/// <summary>
///     Opaque type representing a libopenmpt extension module.
/// </summary>
[StructLayout(LayoutKind.Sequential, Size = 1)]
public readonly struct ModuleExt;