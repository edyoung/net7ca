using System.Runtime.InteropServices;
using WixToolset.Dtf.WindowsInstaller;

namespace CustomAction;
public class Class1
{
    [UnmanagedCallersOnly(EntryPoint = "CustomAction2")]
    public static uint CustomAction2(IntPtr handle)
    {
        using Session session = Session.FromHandle(handle, false);

        session.Log("Custom Action 2 Called");
        return 0;
    }
}
