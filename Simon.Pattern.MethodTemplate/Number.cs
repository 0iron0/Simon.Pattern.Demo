using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simon.Pattern.MethodTemplate
{
    /// <summary>
    /// 可以通过委托实现模板方法
    /// 将具体的方法实现抽象成一个委托，对于委托可以有不同的实现
    /// </summary>
    public class Number
    {
        public delegate float Compare(float x, float b);
        public Compare DoCompare;
        public float CompareTo(float[] list)
        {
            float nf = float.NaN;
            foreach (float df in list)
            { 
                if(float.IsNaN(nf))
                {
                    nf = df;
                }
                else
                {
                    nf = this.DoCompare(nf, df);
                }
            }

            return nf;
        }
    }

    public class CompareMehod
    {
        public float C1(float x, float y)
        {
            return x + y;
        }

        public float C2(float x, float y)
        {
            return x * y;
        }
    }
}
