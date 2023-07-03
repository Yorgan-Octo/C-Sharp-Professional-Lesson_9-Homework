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
            if (code != null)
            {
                code = null;
            }
        }

    }

    internal class Program
    {
        static void Main()
        {

            User user = new User();

            try
            {
                Console.WriteLine(user.code.Length);

            }
            finally
            {
                if (user is IDisposable && user != null)
                {
                    user.Dispose();
                }

            }

            Console.ReadKey();

        }
    }
}
