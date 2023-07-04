using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Controler
    {

        readonly int MemoriAccess;

        public Controler(int MemoriAccess)
        {
            this.MemoriAccess = MemoriAccess;
        }

        public void MemoryLimitExceeded(string errorMessage)
        {
            if (MemoriAccess < GC.GetTotalMemory(false))
            {
                Console.WriteLine("{0}", errorMessage);
                throw new Exception(errorMessage);
            }
        }
    }



    internal class Program
    {
        static void Main()
        {
            Controler controler = new Controler(1000);

            int[] ints = new int[10000];
            
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = i;
                controler.MemoryLimitExceeded("Перевовнено лимит вычерпано");
            }

            Console.ReadKey();
        }
    }
}
