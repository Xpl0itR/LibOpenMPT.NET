namespace LibOpenMPT.NET.Enums;

public enum Error : int
{
    Ok                   = 0,
    Base                 = 256,
    Unknown              = Base + 1,
    Exception            = Base + 11,
    OutOfMemory          = Base + 21,
    Runtime              = Base + 30,
    Range                = Base + 31,
    Overflow             = Base + 32,
    Underflow            = Base + 33,
    Logic                = Base + 40,
    Domain               = Base + 41,
    Length               = Base + 42,
    OutOfRange           = Base + 43,
    InvalidArgument      = Base + 44,
    General              = Base + 101,
    InvalidModulePointer = Base + 102,
    ArgumentNullPointer  = Base + 103
}