using System.Runtime.InteropServices;

namespace CustomAction;
public class Class1
{
    [UnmanagedCallersOnly(EntryPoint = "CustomAction2")]
    public static uint CustomAction2(IntPtr handle)
    {
        return 0;
    }
}
