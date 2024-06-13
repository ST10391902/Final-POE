using System.Windows;

namespace PROG_FINAL_POE
{
    public partial class Delete_Recipe : Window
    {
        public Delete_Recipe()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            // Example: Implement delete logic here
            MessageBox.Show("Recipe deleted successfully!", "Delete Confirmation", MessageBoxButton.OK, MessageBoxImage.Information);

            // Close the Delete_Recipe window after deletion
            this.Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            // Close the Delete_Recipe window without deleting
            this.Close();
        }
    }
}
