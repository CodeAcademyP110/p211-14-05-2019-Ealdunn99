using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {

        #region work1
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Cumle yaz");
        //    string input = Console.ReadLine();

        //    Console.WriteLine("Bosduglarin sayi : {0}", num(input));
        //}

        //static int num(string w)
        //{
        //    int count = 0;
        //    for (int i = 0; i < w.Length; i++)
        //    {
        //        if (w[i] == ' ')
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}
        #endregion

        #region work2
        //static void Main(string[] args)
        //{


        //    int[] myarr = { 5, 5, 1, 8, 3, 9 };

        //    Console.WriteLine("reqemlerin ortalaması {0}", tparr(myarr));

        //}
        //static int tparr(int[] myarr2)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < myarr2.Length; i++)
        //    {
        //        sum += myarr2[i];

        //    }
        //    int tp = sum / myarr2.Length;

        //    return tp;
        //}
        #endregion

        #region work3
        //static void Main(string[] args)
        //{


        //    int[] myarr = { 5, 4, 1, 8, 3, 6 };
        //    //Console.WriteLine("Arr {0}", myarr);
        //    Console.WriteLine("cut reqemler {0}", tparr(myarr));

        //}
        //static string tparr(int[] myarr2)
        //{
        //    string tp = "";
        //    for (int i = 0; i < myarr2.Length; i++)
        //    {
        //        if (myarr2[i] %2==0)
        //        {
        //            tp += myarr2[i];
        //            tp += " ";
        //        }

        //    }


        //    return tp;
        //}
        #endregion

        #region work4
        //static void Main(string[] args)
        //{


        //    int[] myarr = {10,5,3,2,20,9,6,3,7,2};
        //    //Console.WriteLine("Arr {0}", myarr);
        //    Console.WriteLine("reqemlerin ortalamasından boyuk olan  array {0}", tparr(myarr));

        //}
        //static string tparr(int[] myarr2)
        //{
        //    string tp = "";


        //        int sum = 0;
        //        for (int i = 0; i < myarr2.Length; i++)
        //         {
        //            sum += myarr2[i];

        //        }
        //        int max = sum / myarr2.Length;


        //    for (int i = 0; i < myarr2.Length; i++)
        //    {
        //        if (myarr2[i] >max)
        //        {
        //            tp += myarr2[i];
        //            tp += " ";
        //        }

        //    }


        //    return tp;
        //}
        #endregion

        #region work5
        //static void Main(string[] args)
        //{




        //    Console.Write("Eded yaz:");
        //    string nonum = Console.ReadLine();
        //    int num;
        //    bool ifyes = int.TryParse(nonum, out num);
        //    while (!ifyes)
        //    {
        //        Console.Write("Duzgun reqem daxil edin:");
        //        nonum = Console.ReadLine();
        //        ifyes = int.TryParse(nonum, out num);
        //    }

        //    Console.Write("ustluk yaz:");
        //    string nonum2 = Console.ReadLine();
        //    int num2;
        //    bool ifyes2 = int.TryParse(nonum2, out num2);
        //    while (!ifyes2)
        //    {
        //        Console.Write("Duzgun reqem daxil edin:");
        //        nonum2 = Console.ReadLine();
        //        ifyes2 = int.TryParse(nonum2, out num2);
        //    }

        //    Console.WriteLine("Cavab:{0}", ans(num,num2));


        //}
        //static int ans(int num, int num2)
        //{     int newnum = 1;
        //    for (int i = 0; i < num2; i++)
        //    {
        //        newnum = newnum * num;
        //    }
        //    return newnum;
        //}
        #endregion



    }
}
