using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_String
{
    class Program
    {
        static void Main(string[] args)
        {
            DoWork doWork = new DoWork();
            doWork.HowManyTests();

            for (int i = 0; i< doWork.CountOfTests; i++)
            {
                doWork.InputTestLine();
                doWork.Rotate();
                for(int j = 0; j < doWork.ToRotate.Length; j++)
                {
                    Console.Write(doWork.ToRotate[j]);
                }
                Console.Write(" ");
            }
        }
    }

    class DoWork
    {
        public int CountOfTests { get; private set; }
        public char[] ToRotate { get; private set; }

        private string[] input { get; set; }

        public void HowManyTests()
        {
            CountOfTests = int.Parse(Console.ReadLine());
        }

        public void InputTestLine()
        {
            input = Console.ReadLine().Split(' ');
        }

        public void Rotate()
        {
            int rotateIndex = int.Parse(input[0]);
            ToRotate = new char[input[1].Length];
            formCharArray();
            doRotate(rotateIndex);

        }

        private void formCharArray()
        {
            for (int i = 0; i < input[1].Length; i++)
                ToRotate[i] = input[1][i];
        }

        private void doRotate(int rotateIndex)
        {
            bool needRevers = false;
            if (rotateIndex < 0)
            {
                rotateIndex = Math.Abs(rotateIndex);
                ToRotate.Reverse();
                needRevers = true;
            }

            for (int k = 0; k < rotateIndex; k++)
            {
                char temp = ToRotate[0];
                ToRotate[0] = ToRotate[ToRotate.Length - 1];
                
                for (int i = ToRotate.Length -1 ; i > 1; i--)
                {
                    ToRotate[i] = ToRotate[i - 1];
                }

                ToRotate[1] = temp;
            }

            if (needRevers)
            {
                ToRotate.Reverse();
            }
        }
    }
}
