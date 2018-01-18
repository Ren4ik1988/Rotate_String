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

        public void HowManyTests() => CountOfTests = int.Parse(Console.ReadLine());
        public void InputTestLine() => input = Console.ReadLine().Split(' ');

        public void Rotate()
        {
            int rotateIndex = int.Parse(input[0]);
            formCharArray();
            
        }

        private void formCharArray()
        {
            for (int i = 0; i < input[1].Length; i++)
                ToRotate[i] = input[1][i];
        }
    }
}
