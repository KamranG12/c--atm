using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm
{
    class Program
    {
        static void Main(string[] args)
        {   int mebleg=466;
            int[] a = new int[5] { 100, 50, 20, 10, 5 };
            if(mebleg%5!=0){
                    Console.WriteLine("atm.de"+" "+"yalniz"+" "+"5,10,20,50,100"+" "+"Azn"+" "+"eskinaslar"+" "+"movcuddur");
                }else{
            foreach (int i in a)
            { 
                if(mebleg>=i){
                    Console.WriteLine(i+" "+"eskinasindan"+"-"+mebleg/i+" "+"dene");
                }
                mebleg=mebleg%i;
            }
            Console.ReadLine();
            }
            Console.ReadLine();
        }
        
            
        
    }
}
