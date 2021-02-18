using System;

namespace MyDictionary2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary2<int, string> myDictionary2 = new MyDictionary2<int, string>();

            myDictionary2.Add(1, "bardak");
            myDictionary2.Add(2, "kalem");
            myDictionary2.Add(3, "kitap");
            myDictionary2.List();
           

           
        }
    }
}
