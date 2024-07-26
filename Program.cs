using System.Diagnostics;
using System.Threading.Tasks;

namespace TRF
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            Controller controller = new Controller();
            await controller.Run();

            sw.Stop();
            Console.WriteLine("---------------");
            Console.WriteLine($"Threading: {sw.Elapsed.TotalMilliseconds}");

        }
    }
}
