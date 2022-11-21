using System;
using System.Collections.Generic;
using System.Linq;

namespace MoreTypes_Lib
{
    public class ArraysExercises
    {
        // returns a 1D array containing the contents of a given List
        public static string[] Make1DArray(List<string> contents)
        {
            return contents.ToArray();
        }

        // returns a 3D array containing the contents of a given List
        public static string[,,] Make3DArray(int length1, int length2, int length3, List<string> contents)
        {
            if (length1*length2*length3 != contents.Count) 
            {
                throw new ArgumentException("Number of elements in list must match array size");
            }

            var threeDArray = new string[length1, length2, length3];
            
            int counter = 0;
            for (int x = 0; x < length1; x++)
            {
                for (int y = 0; y < length2; y++)
                {
                    for (int z = 0; z < length3; z++)
                    {
                        threeDArray[x, y, z] = contents[counter++];
                    }
                }
            }
            return threeDArray;
        }

        // returns a jagged array containing the contents of a given List
        public static string[][] MakeJagged2DArray(int countRow1, int countRow2, List<string> contents)
        {
            string[][] jagged =
            {
                new string [countRow1],
                new string [countRow2],
            };
            if (countRow1 + countRow2 > contents.Count)
            {
                throw new NotImplementedException();
            }
                
            int counter = 0;
            for (int i = 0; i < countRow1; i++)
            {
                jagged[0][i] = contents[counter++];
            }
            for (int j = 0; j < countRow2; j++)
            {
                jagged[1][j] = contents[counter++];
            }

            return jagged;
        }
    }
}
