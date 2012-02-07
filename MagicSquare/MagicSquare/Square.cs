using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagicSquare
{
    public class Square
    {
        public string IsMagic(int[,] arrInput)
        {
            //this is not a square
            if (arrInput.GetUpperBound(0) != arrInput.GetUpperBound(1))
            { return "No";}

            //be more than 1 row or column
            if (arrInput.GetUpperBound(0) < 1  || arrInput.GetUpperBound(1) < 1)
            { return "No";}

            int bound = arrInput.GetUpperBound(0);
            int[] rowSum = new int[bound+1];
            int[] colSum = new int[bound+1];

            //find summary of each row
            for (int i = 0; i <= bound; i++)
            {
                for (int j = 0; j <= bound; j++)
                { 
                     rowSum[i] += arrInput[i,j];
                }
            }

            //find summary of each column
            for (int j = 0; j <= bound; j++)
            {
                for (int i = 0; i <= bound; i++)
                {
                    colSum[j] += arrInput[i, j];
                }
            }

            //Compare all Summaries
            for (int j = 0; j <= bound; j++)
            {
                for (int i = 0; i <= bound; i++)
                {
                    if (rowSum[i] != colSum[j])
                    { return "No";}
                }
            }
            return "Yes";
        }

    }
}
