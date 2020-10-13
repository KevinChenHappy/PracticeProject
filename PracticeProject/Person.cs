using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject
{
    public class Person
    {
        public string _name;
        public int _age;
        public char _gender;

        public void CHLSS()
        {
            Console.WriteLine("我叫{0},今年{1}歲,{2}生, 我會吃喝拉撒",this._name,this._age,this._gender);
        }

    }
}
