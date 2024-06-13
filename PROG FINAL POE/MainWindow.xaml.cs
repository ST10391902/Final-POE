using System;
using System.Windows;
using System.Windows.Controls;

namespace PROG_FINAL_POE
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string tag = button?.Tag as string;

            if (!string.IsNullOrEmpty(tag))
            {
                Window window = null;

                switch (tag)
                {
                    case "Add_Recipe":
                        window = new Add_Recipe();
                        break;
                    case "View_Recipe":
                        window = new View_Recipe();
                        break;
                    case "Edit_Recipe":
                        // Create a new instance of Recipe or get the existing recipe to edit
                        Recipe recipeToEdit = GetRecipeToEdit();
                        window = new Edit_Recipe(recipeToEdit);
                        break;
                    case "Delete_Recipe":
                        window = new Delete_Recipe();
                        break;
                }

                if (window != null)
                {
                    window.Show();
                    this.Close();
                }
            }
        }

        private Recipe GetRecipeToEdit()
        {
            // Retrieve the recipe to be edited. For demonstration purposes, we'll create a dummy recipe.
            // Replace this with your actual logic to get the recipe.
            return new Recipe
            {
                RecipeName = "Sample Recipe",
                Ingredients = "Sample Ingredients",
                Instructions = "Sample Instructions"
            };
        }
    }

    // Define the Recipe class
    public class Recipe
    {
        public string RecipeName { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
    }
}
