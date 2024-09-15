﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SaigafarovBI.Sprint4.Task2.V17.Lib
{
    public class DataService : ISprint4Task2V17
    {
        public int Calculate(int[] array)
        {
            int pArray = 1;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 !=0)
                {
                    pArray *= array[i];
                }
            }
            return pArray;
        }
    }
}
