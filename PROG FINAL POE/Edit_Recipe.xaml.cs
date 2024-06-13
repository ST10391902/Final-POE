using System.Windows;

namespace PROG_FINAL_POE
{
    public partial class Edit_Recipe : Window
    {
        private Recipe recipe;

        public Edit_Recipe(Recipe recipe)
        {
            InitializeComponent();

            // Set the data context for data binding
            this.recipe = recipe;
            this.DataContext = this.recipe;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Save changes to the recipe
            // For demonstration, let's assume updating the recipe object directly
            this.recipe.RecipeName = txtRecipeName.Text;
            this.recipe.Ingredients = txtIngredients.Text;
            this.recipe.Instructions = txtInstructions.Text;

            // Example: Save logic (replace with actual saving mechanism)
            MessageBox.Show("Recipe saved successfully!", "Save Confirmation", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            // Prompt user to confirm exit
            MessageBoxResult result = MessageBox.Show("Are you sure you want to exit without saving?", "Confirm Exit", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                // Close the Edit_Recipe window
                this.Close();
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate back to MainWindow
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
