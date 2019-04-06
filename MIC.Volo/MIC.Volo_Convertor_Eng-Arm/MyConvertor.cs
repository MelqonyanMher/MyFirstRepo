using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIC.Volo_Convertor_Eng_Arm
{
    public delegate string MyDel(string c);
    class MyConvertor
    {
        private class Letter
        {
            public Letter(string let, byte id)
            {
                this.lett = let;
                this.id = id;
            }

            public string lett { get; set; }
            public byte id { get; set; }


        }

        private static IEnumerable<Letter> engLett = new Letter[]
        {
            new Letter("a",1),
            new Letter("b",2),
            new Letter("g",3),
            new Letter("d",4),
            new Letter("e",5),
            new Letter("z",6),
            new Letter("e",7),
            new Letter("@",8),
            new Letter("t",9),
            new Letter("i",10),
            new Letter("l",11),
            new Letter("x",12),
            new Letter("k",13),
            new Letter("h",14),
            new Letter("&",15),
            new Letter("m",16),
            new Letter("y",17),
            new Letter("n",18),
            new Letter("$",19),
            new Letter("p",20),
            new Letter("j",21),
            new Letter("r",22),
            new Letter("s",23),
            new Letter("v",24),
            new Letter("t",25),
            new Letter("o",26),
            new Letter("c",27),
            new Letter("u",28),
            new Letter("q",29),
            new Letter("f",30)

        };
        private static IEnumerable<Letter> armLett = new Letter[]
        {
            new Letter("ա",1),
            new Letter("բ",2),
            new Letter("գ",3),
            new Letter("դ",4),
            new Letter("ե",5),
            new Letter("զ",6),
            new Letter("է",7),
            new Letter("ը",8),
            new Letter("ի",10),
            new Letter("լ",11),
            new Letter("խ",12),
            new Letter("կ",13),
            new Letter("հ",14),
            new Letter("ճ",15),
            new Letter("մ",16),
            new Letter("յ",17),
            new Letter("ն",18),
            new Letter("շ",19),
            new Letter("պ",20),
            new Letter("ջ",21),
            new Letter("ռ",22),
            new Letter("ս",23),
            new Letter("վ",24),
            new Letter("տ",25),
            new Letter("օ",26),
            new Letter("ց",27),
            new Letter("ու",28),
            new Letter("ք",29),
            new Letter("ֆ",30)

        };

        public static string Convert(string s)
        {
            MyDel md = (string c) =>
            {
                if (engLett.Where(x => x.lett == c) == null)
                {
                    return c;
                }
                var str = (from x in engLett
                              where x.lett == c
                              select x into x1
                              from y in armLett
                              where x1.id == y.id
                              select y);






                return str.ElementAt(0).lett;
            };
            string myst = " ";
            for (int i = 0; i < s.Length; i++)
            {
                myst += md("" + s[i]);
            }
            return myst.ToString();
        }


    }
}
