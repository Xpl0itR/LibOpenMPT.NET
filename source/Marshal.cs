namespace LibOpenMPT.NET;

public static unsafe class Marshal
{
    public static string String(sbyte* str)
    {
        try
        {
            return new string(str);
        }
        finally
        {
            NativeMethods.free_string(str);
        }
    }
}