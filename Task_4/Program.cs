using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{

    public class User : IDisposable
    {
        public int[] code;

        public User()
        {
            code = new int[10000 * 10000];
        }

        public void Dispose()
        {
            code = new int[0];
        }

    }

    internal class Program
    {
        static void Main()
        {

            User user = new User();

            Console.WriteLine(user.code.Length);
            user.Dispose();
            Console.WriteLine(user.code.Length);
            Console.ReadKey();

        }
    }
}
