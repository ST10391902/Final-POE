using System.Windows;
using System.Windows.Controls;

namespace PROG_FINAL_POE
{
    public partial class Add_Recipe : Window
    {
        public Add_Recipe()
        {
            InitializeComponent();
        }

        private void SaveRecipe_Click(object sender, RoutedEventArgs e)
        {
            string recipeName = txtRecipeName.Text;
            string ingredients = txtIngredients.Text;
            string steps = txtSteps.Text;
            string instructions = txtInstructions.Text;
            string foodGroup = ((ComboBoxItem)cmbFoodGroup.SelectedItem).Content.ToString();
            string calories = txtCalories.Text;

            // Save the recipe data to your data source (database, file, etc.)
            // For now, just show a message box for demonstration purposes
            MessageBox.Show($"Recipe '{recipeName}' saved successfully!", "Save", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
