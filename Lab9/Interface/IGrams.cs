using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9.Interface
{
    public interface IGrams
    {
        public int Grams { get; set; }

        void CalculateGramsPerCalories();
    }
}
