using bottlenoselabs.C2CS.Runtime;
using Optick;
using static Optick.PInvoke;

internal sealed class Program
{
    static unsafe double delay()
    {
        int i, end;
        double j = 0;

        var funcName = "delay";
        var fileName = "Program.cs";

        var desc = OptickAPICreateEventDescription((CString)funcName, (ushort)funcName.Length, (CString)fileName, (ushort)fileName.Length, 25);
        OptickAPIPushEvent(desc);

        Random random = new Random();

        for (i = 0, end = (int)random.NextInt64() / 100; i < end; ++i)
        {
            j += Math.Sin(i);
        }

        return j;
    }

    internal unsafe static void Main(string[] args)
    {
        OptickAPIStartCapture();

        while (true)
        {
            OptickAPINextFrame();
            delay();
        }

        Console.WriteLine("Cleaned up and quit \n");
        return;
    }
}