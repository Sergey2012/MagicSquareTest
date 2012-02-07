using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using MagicSquare;

namespace TestMagicSquare
{
    [TestFixture]
    public class UnitTestMagicSquare
    {   
       
        [Test]
        public void IsMagicTest_CorrectInput()
        {
            int[,] arr = new int[2, 2];
            arr[0, 0] = 1;
            arr[0, 1] = 2;         
            arr[1, 0] = 2;
            arr[1, 1] = 1;
            
            Square mySquare = new Square();
            string actualResult = mySquare.IsMagic(arr);
            StringAssert.IsMatch("Yes",actualResult);
            
        }

        [Test]
        public void IsMagicTest_IncorrectInput()
        {
            int[,] arr = new int[2, 2];
            arr[0, 0] = 1;
            arr[0, 1] = 2;
            arr[1, 0] = 2;
            arr[1, 1] = 3;

            Square mySquare = new Square();
            string actualResult = mySquare.IsMagic(arr);
            StringAssert.IsMatch("No", actualResult.ToString());

        }


    }
}
