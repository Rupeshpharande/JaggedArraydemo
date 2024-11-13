using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraydemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[][] jarray = new int[4][];

           jarray[0] = new int[3] {10,20,30};
          jarray[1]=new int[4] { 40,50,60,70};
           jarray[2]=new int[5] { 80,90,100,110,120};
           jarray[3]=new int[2] {130,140};

            //    for (int i = 0; i < jarray.Length; i++)
            //    {
            //        for(int j = 0;j< jarray[i].Length;j++)
            //        {
            //            Console.Write($"jarray[{i}],[{j}]= {jarray[i][j]} ");
            //        }
            //        Console.WriteLine();
            //    }

            foreach (int[] p in jarray) 
                {
                   foreach(int i in p)
                   {

                    Console.Write(i+" ");
                   }
                   Console.WriteLine();
             }
        }
    }
}
