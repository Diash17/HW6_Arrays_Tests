using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_Arrays
{

    public static class TwoDimensionalMock
    {
    
        public static int[,] GetMock(TwoDimensionalMockType type)
        {
            switch (type)
            {
                case TwoDimensionalMockType.First:
                    return new int[,] {
                    {1,5,3 },
                    {12,2,30 },
                    {23,53,32 },
                    };


                case TwoDimensionalMockType.Second:
                    return new int[,] {
                    {1,4,3 },
                    {7,9,2 },
                    {3,5,6 },
                    };
                case TwoDimensionalMockType.Third:
                    return new int[,] {
                    {9,4,3 },
                    {7,9,2 },
                    {3,5,6 },
                    };
                case TwoDimensionalMockType.NotSquare:
                    return new int[,] {
                    {9,4,3,4 },
                    {7,9,2,3 },
                    {3,5,6,1 },
                    };
                case TwoDimensionalMockType.Empty:
                    return new int[,] { };

                case TwoDimensionalMockType.FirstMirrored:
                    return new int[,] {
                    { 1,12,23 },
                    { 5,2,53 },
                    { 3,30,32 },
                    };
                    
                case TwoDimensionalMockType.SecondMirrored:
                    return new int[,] {
                    {1,7,3 },
                    {4,9,5 },
                    {3,2,6 },
                    };
                    
                case TwoDimensionalMockType.ThirdMirrored:
                    return new int[,] {
                    {9,7,3 },
                    {4,9,5 },
                    {3,2,6 },
                    };
                    
            default:
                    throw new Exception();
            }
        }
    }
}
