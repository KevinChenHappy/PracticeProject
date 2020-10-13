using System;

namespace 靜態與非靜態區別
{
    class Program
    {
        static void Main(string[] args)
        {
            //調用非靜態
            //使用對象名.實例成員
            Person p = new Person();
            p.M1();

            //調用靜態
            //使用類名.靜態成員
            Person.M2();
        }
    }
}
