using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Undervisning1_06._11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Pizza p1 = new Pizza() { PizzaName = "Margharita", PizzaPrice = 45};
            Pizza p2 = new Pizza() { PizzaName = "Hawaii", PizzaPrice = 50 };
            Pizza p3 = new Pizza() { PizzaName = "Pepperoni", PizzaPrice = 43 };

            List<Pizza> listPizza = new List<Pizza>() { p1, p2, p3 };

            Ingredienser item1 = new Ingredienser() { IngredientName = "Pepperoni", ToppingPrice = 8 };
            Ingredienser item2 = new Ingredienser() { IngredientName = "Ananas", ToppingPrice = 5 };
            Ingredienser item3 = new Ingredienser() { IngredientName = "Skinke", ToppingPrice = 7 };
            Ingredienser item4 = new Ingredienser() { IngredientName = "Ost", ToppingPrice = 5 };
            ListBoxPizza.ItemsSource = listPizza;

            p1.allIngredients.Add(item1);
            p1.allIngredients.Add(item4);

            p2.allIngredients.Add(item2);
            p2.allIngredients.Add(item3);
            p2.allIngredients.Add(item4);

            p3.allIngredients.Add(item1);
            p3.allIngredients.Add(item4);

            int i = 0;
            double TotalPrice = 0;
            double totalToppingPrice = 0;
            while (i < listPizza.Count)
            {
                
                //calculate total topping price per pizza
                int j = 0;
                totalToppingPrice = 0;
                while(j < listPizza[i].allIngredients.Count)
                {
                    totalToppingPrice = totalToppingPrice + listPizza[i].allIngredients[j].ToppingPrice;
                    j++;
                }

                //calculate total pizza price (basis price + all toppings)
                TotalPrice = listPizza[i].PizzaPrice + totalToppingPrice;
                listPizza[i].TotalPrice = TotalPrice;

                i++;
            }
        }

        private void ListBoxPizza_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Pizza valgt = (Pizza)ListBoxPizza.SelectedItem;
            ListBoxToppings.ItemsSource = valgt.allIngredients;

        }

    }
}