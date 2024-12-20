﻿using System.Data;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KhudoiberdievDB.Sprint4.Task5.V3.Lib;
    public class DataService : ISprint4Task5V3
{
    
public int[,] Calculate(int[,] matrix)
    {
        int rows = matrix.GetUpperBound(0)+1;
        int cols = matrix.Length/rows;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i,j] < 0)
                {
                    matrix[i,j] = 0;
                }
            }
        }
        return matrix;
    }
}

