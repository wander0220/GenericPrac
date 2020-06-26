﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GenericPrac
{
    class Program
    {
        class Wanted<T>
        {
            public T value;

            public Wanted(T value)
            {
                this.value = value;
            }
        }

        static void Main(string[] args)
        {
            //실행시점에 타입이 바뀐다.  컴파일 시점은 타입이 굳어져버린다.
            Wanted<string> wantedString = new Wanted<string>("String");
            Wanted<int> wantedInt = new Wanted<int>(920116);
            Wanted<double> wantedDouble = new Wanted<double>(52.273);


            Console.WriteLine(wantedString.value);
            Console.WriteLine(wantedInt.value);
            Console.WriteLine(wantedDouble.value);


        }


    }
}
