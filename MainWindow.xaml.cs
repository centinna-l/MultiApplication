using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MultiApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void clearTextBoxes()
        {
            speedTextBox.Text = string.Empty;
            travelTimeTextBox.Text = string.Empty;
            numOrganismsTextBox.Text = string.Empty;
            DaysTextBox.Text = string.Empty;
            averageIncreaseTextBox.Text= string.Empty;
        } 

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            string selectedApplication = ((ComboBoxItem)applicationComboBox.SelectedItem)?.Content.ToString();

            switch (selectedApplication)
            {
                case "Test Scores":
                    double score1, score2, score3;
                    if (double.TryParse(speedTextBox.Text, out score1) &&
                        double.TryParse(travelTimeTextBox.Text, out score2) &&
                        double.TryParse(numOrganismsTextBox.Text, out score3))
                    {
                        TestScores testScores = new TestScores(score1, score2, score3);
                        resultLabel.Content = $"Average: {testScores.getAverage()}, Letter Grade: {testScores.getLetterGrade()}";
                    }
                    else
                    {
                        MessageBox.Show("Invalid input for Test Scores. Please enter numeric values for the scores.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    break;

                case "Shipping Charges":
                    double weight, miles;
                    if (double.TryParse(speedTextBox.Text, out weight) && double.TryParse(travelTimeTextBox.Text, out miles))
                    {
                        ShippingCharges shippingCharges = new ShippingCharges(weight);
                        resultLabel.Content = $"Shipping Charge: {shippingCharges.calculateShippingCharge(miles)}";
                    }
                    else
                    {
                        MessageBox.Show("Invalid input for Shipping Charges. Please enter a numeric value for the weight.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    break;

                case "Population":
                    double numOrganisms, averageIncrease;
                    int numDays;
                    if (double.TryParse(numOrganismsTextBox.Text, out numOrganisms) &&
                        double.TryParse(averageIncreaseTextBox.Text, out averageIncrease) &&
                        int.TryParse(DaysTextBox.Text, out numDays))
                    {
                        Population population = new Population(numOrganisms, averageIncrease, numDays);
                        resultLabel.Content = population.displayPopulation();
                    }
                    else
                    {
                        MessageBox.Show("Invalid input for Population. Please enter numeric values for the number of organisms, average increase, and number of days.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    break;

                case "Distance Traveled":
                    double speed, travelTime;
                    if (double.TryParse(speedTextBox.Text, out speed) &&
                        double.TryParse(travelTimeTextBox.Text, out travelTime))
                    {
                        DistanceTraveled distanceTraveled = new DistanceTraveled(speed, travelTime);
                        resultLabel.Content = $"Distance Traveled: {distanceTraveled.getDistance()}";
                    }
                    else
                    {
                        MessageBox.Show("Invalid input for Distance Traveled. Please enter numeric values for the speed and travel time.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    break;

                default:
                    MessageBox.Show("Please select an application from the dropdown list.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    break;
            }
        }
    }
}
