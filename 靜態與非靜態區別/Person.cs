using System;
using System.Collections.Generic;
using System.Text;

namespace 靜態與非靜態區別
{
    //非靜態的類當中可以有靜態成員與非靜態成員
    //總結 
    //靜態函數中 只能訪用靜態成員 不允許訪問實例成員
    //實例函數中 可以使用靜態成員與實例成員
    //靜態類別 不可以創建實例
    public class Person
    {
        public void M1()
        {
            Console.WriteLine("非靜態");
        }
        public static void M2()
        {
            Console.WriteLine("靜態");
        }

        
    }
}
//靜態類使用
//如果想要當工具類使用 可以寫成靜態類
//靜態類在整個項目中資源共享