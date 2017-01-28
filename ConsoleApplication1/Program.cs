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
        public static string String()
        {
            return null;
        }

        public static async Task<string> StringAsync()
        {
            await Task.Yield();
            return null;
        }

        public static MyObject CustomType()
        {
            return null;
        }

        public static async Task<MyObject> CustomTypeAsync()
        {
            await Task.Yield();
            return null;
        }
    }
}
