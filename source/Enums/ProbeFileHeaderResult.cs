namespace LibOpenMPT.NET.Enums;

public enum ProbeFileHeaderResult : int
{
    Failure      = 0,
    Success      = 1,
    WantMoreData = -1,
    Error        = -255
}