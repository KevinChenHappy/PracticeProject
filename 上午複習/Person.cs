using System;
using System.Collections.Generic;
using System.Text;

namespace 上午複習
{
    public class Person
    {
        private string _name;
        private int _age;
        private char _gender;
        public string Name //習慣上大寫的Name為Class的屬性
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set {//設定Age屬性時的判斷
                if (value < 0 || value > 100)
                    value = 0;
                _age = value; }
        }
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public void CHLSS()
        {
            //這裡呼叫時，若使用_name 不會進行get方法，所以該給屬性(大寫)
            Console.WriteLine("我叫{0},今年{1}歲,{2}生, 我會吃喝拉撒", this.Name, this.Age, this.Gender);
        }
    }
}
