using System;

namespace 上午複習
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Age = 10;
            p.Gender = '男';
            p.Name = "大帥";

            Person p1 = new Person();
            p1.Age = 12;
            p1.Gender = '女';
            p1.Name = "大美";

            p.CHLSS();
            p1.CHLSS();
            
        }
    }
}
