using System.Windows;
using WPFUI.Classes;

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PersonManager personManager = new PersonManager();
            myComboBox.ItemsSource = personManager.GetPeople();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello there {firtNameText.Text}");
        }
    }
}
