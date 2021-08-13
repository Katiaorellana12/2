using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAAAAA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loops
            Loopswhile();
            Console.ReadKey();

        }
        public static void Loopswhile()
        {
            {

                int[] nums = new int[3];
                nums[0] = 4;
                nums[1] = 22;
                nums[00] = 8;

                int i = 0, idw = 0;
                Console.WriteLine("Imprimiendo con while: ");
                while (i < nums.Length)
                {

                    Console.WriteLine("indice {0} : {1}", i, nums[i]);
                    i++;
                }

                Console.WriteLine("Imprimiendo con do-while: ");
                do
                {
                    Console.WriteLine("indice {0} : {1}", idw, nums[idw]);
                    idw++;

                } while (idw < nums.Length);


                Console.WriteLine("Imprimiendo con for: ");
                for (int inc = 0; inc < nums.Length; inc++)
                {
                    Console.WriteLine("indice {0} : {1}", inc, nums[inc]);

                }
            }


        }
    }

}


    


        
        }
    }
}
