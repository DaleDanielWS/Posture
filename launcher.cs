using System;
using System.Diagnostics;
using System.IO;

// Opens index.html (next to this exe) in the default browser.
class PostureLauncher
{
    static void Main()
    {
        string dir = AppDomain.CurrentDomain.BaseDirectory;
        string page = Path.Combine(dir, "index.html");
        Process.Start(new ProcessStartInfo(page) { UseShellExecute = true });
    }
}
