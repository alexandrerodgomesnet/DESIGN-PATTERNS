using System.Diagnostics;

namespace PROXY.MODO_COMUM;

public class ModoComum
{
    public static void Run()
    {

        Stopwatch stopWatch = new();
        stopWatch.Start();

        var usuario = new Usuario("João da Silva", "12345678900", 25);
        var nome = usuario.GetNome();

        stopWatch.Stop();
        TimeSpan ts = stopWatch.Elapsed;

        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime);
    }
}