using System;

namespace _4128_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of Elements You want to Enter ");
            int leng = Convert.ToInt32(Console.ReadLine());


            int[] arr = new int[leng];

            for (int i = 0; i < arr.Length; i++)   // Taking Inputs 
            {
                Console.WriteLine("Enter Value at Index " + i);
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("\n");

            for (int j = 0; j < arr.Length; j++)   // Displaying Output 
            {
                Console.WriteLine(" Value at Index " + j + " is =  " + arr[j]);


            }



           // int count = 0;
            //int del;
            //int n;


            

            
            int newl = 1;
            int[] newarr = new int[newl];

            for (int x=0;x<arr.Length-1;x++)
            {
                n = arr[x];

                for (int y = 2;( y < n/2-1); y++)
                {


                    if (n%y==0 && n>1)                            // Checking Its prime or not 
                    {
                        

                       for (int e=0;e<newarr.Length;e++)
                        {
                            newarr[e] = n;
                            
                        }

                        newl++;
                    }

                }

              

            }



            if (count==0)
            {
                Console.WriteLine(" No Prime Number Was Found !");

            }

            Console.WriteLine(" \nUpdated Array ");
            for (int u = 0; u < arr.Length; u++)   // Displaying Output After Deleting  
            {
                Console.WriteLine(" New Value at Index " + u + " is =  " + arr[u]);


            }
        }
    }
}
