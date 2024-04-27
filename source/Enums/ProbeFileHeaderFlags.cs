namespace LibOpenMPT.NET.Enums;

public enum ProbeFileHeaderFlags : ulong
{
    None       = 0x0UL,
    Modules    = 0x1UL,
    Containers = 0x2UL,
    Default    = Modules | Containers
}