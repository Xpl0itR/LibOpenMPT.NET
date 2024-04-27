namespace LibOpenMPT.NET.Enums;

public enum ErrorFuncResult : int
{
    None    = 0,
    Log     = 1 << 0,
    Store   = 1 << 1,
    Default = Log | Store
}