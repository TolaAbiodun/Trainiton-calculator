using System.Windows;
using System.Windows.Controls;

namespace TrainitonCalculator {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private Calculator _calculator;

        public MainWindow() {
            InitializeComponent();
            _calculator = new Calculator(screen.Text);
        }

        private void NumberClicked(object sender, RoutedEventArgs e) {
            var button = (Button)sender;
            var content = (string)button.Content;
            screen.Text = _calculator.NumberPressed(content);
        }

        private void Clear_Click(object sender, RoutedEventArgs e) {
            screen.Text = _calculator.ClearScreen();
        }

        private void BackSpace_Click(object sender, RoutedEventArgs e) {
            screen.Text = _calculator.BackSpace();
        }

        private void Nagate_Click(object sender, RoutedEventArgs e) {
            screen.Text = _calculator.Negate();
        }

        private void Dot_Click(object sender, RoutedEventArgs e) {
            screen.Text = _calculator.Dot();
        }

        private void Add_Click(object sender, RoutedEventArgs e) {
            _calculator.Add();
        }

        private void Equals_Click(object sender, RoutedEventArgs e) {
            screen.Text = _calculator.EqualsTo(screen.Text);
        }

        private void SinButton_Click(object sender, RoutedEventArgs e) {
            screen.Text = _calculator.Sine();
        }
    }
}
