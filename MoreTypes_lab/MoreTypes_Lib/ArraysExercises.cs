using System;
using System.Collections.Generic;

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
            string[,,] threeDList = new string[length1, length2, length3];

            for (int x = 0; x < length1; x++)
            {
                for (int y = 0; y < length2; y++)
                {
                    for (int z = 0; z < length3; z++)
                    {
                        string threeDList[x][y][z] = contents.ToArray();
                    }
                }
            }
        }

        // returns a jagged array containing the contents of a given List
        public static string[][] MakeJagged2DArray(int countRow1, int countRow2, List<string> contents)
        {
            throw new NotImplementedException();
        }
    }
}
