using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Undervisning1_06._11
{
    class Ingredienser
    {
        public string IngredientName;

        public double ToppingPrice;

        public override string ToString()
        {
            return IngredientName + ", price: " + ToppingPrice;
        }
    }
}
