using System;
using System.Collections.Generic;
using System.Text;
using GenericsSolo02.Entities;

namespace GenericsSolo02.Service
{
    class CalculationService
    {
        //Função retorna um tipo T, desde que esse ele seja IComparable
        public T Max<T>(List<T> list) where T : IComparable
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("This list can not be empty");
            }

            T max = list[0];

            for (int i = 0; i < list.Count - 1; i++)
            {
                //Aqui usa o IComparable -1, 0, 1
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}