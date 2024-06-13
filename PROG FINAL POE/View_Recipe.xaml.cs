using System.Collections.Generic;
using System.Windows;

namespace PROG_FINAL_POE
{
    public partial class View_Recipe : Window
    {
        public View_Recipe()
        {
            InitializeComponent();
            LoadDefaultRecipe();
        }

        private void LoadDefaultRecipe()
        {
            var defaultRecipe = new Recipe
            {
                Name = "Caffe Mocha",
                Ingredients = "Espresso, Steamed Milk, Chocolate Syrup, Whipped Cream",
                Instructions = "1. Brew the espresso.\n2. Add chocolate syrup.\n3. Pour steamed milk.\n4. Top with whipped cream."
            };

            List<Recipe> recipes = new List<Recipe> { defaultRecipe };
            RecipeListView.ItemsSource = recipes;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
    // Example: Define a class or structure for Recipe
    public class Recipe
    {
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
    }
}
