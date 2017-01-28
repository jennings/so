using System.Threading.Tasks;

namespace ConsoleApplication1
{
    static class Program
    {
        public static void Main()
        {
        }
    }

    public class MyObject
    {
    }

    public static class Service
    {
        public static async Task<string> String()
        {
            await Task.Yield();
            return null;
        }

        public static async Task<MyObject> CustomType()
        {
            await Task.Yield();
            return null;
        }
    }
}
