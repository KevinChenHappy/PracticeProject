using System;

namespace PracticeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //這作法不好 不應該直接對類別的字段作存取 應該對屬性
            Person kevin = new Person();
            kevin._age = 30;
            kevin._name="陳韋傑";
            kevin._gender = '男';
            kevin.CHLSS();

        }
    }
}
