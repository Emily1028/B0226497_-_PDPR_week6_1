using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR_week6_1
{
    public class STU 
    {
        private int CHI, ENG, MATH;
        private double AVG;
        public int chi
        {
            get { return CHI; }
            set
            {
                if (value > 100)
                    value = 100;
                else if (value < 0)
                    value = 0;
                CHI = value;
            }
        }
        public int eng
        {
            get { return ENG; }
            set
            {
                if (value > 100)
                    value = 100;
                else if (value < 0)
                    value = 0;
                ENG = value;
            }
        }
        public int math
        {
            get { return MATH; }
            set
            {
                if (value > 100)
                    value = 100;
                else if (value < 0)
                    value = 0;
                MATH = value;
            }
        }
        public double avg
        {
            get { return (CHI + ENG + MATH) / 3; }
        }
        public string ID { set; get; }
        public string NAME { set; get; }
        public string PHONE { set; get; }
        public string PRINTME()
        {
            
            return $"學號:{ID}，姓名:{NAME}，電話:{PHONE}，國:{chi}，英:{eng}，數:{math}，平均:{avg.ToString("0.0")}";
        }
    }
}
