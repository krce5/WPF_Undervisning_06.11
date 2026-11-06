using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Undervisning1_06._11
{
    class Pizza
    {
        public string PizzaName;
        public List<Ingredienser> allIngredients = new List<Ingredienser>();
        public double TotalPrice;

        public double PizzaPrice;
        public override string ToString()
        {
            return "Total Price: " + TotalPrice + ", " + PizzaName + ", (pizza price: " + PizzaPrice + ")";
        }

    }
}
