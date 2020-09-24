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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CosButton_Click(object sender, RoutedEventArgs e) {
            screen.Text = _calculator.Cosine();
        }

        private void TanButton_Click(object sender, RoutedEventArgs e) {
            screen.Text = _calculator.Tangent();
        }

        private void SqrtButton_Click(object sender, RoutedEventArgs e) {
            screen.Text = _calculator.sqrt();
        }

        private void PowButton_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = _calculator.power();
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            _calculator.Subtract();
        }

        private void ProductButton_Click(object sender, RoutedEventArgs e)
        {
            _calculator.Multiply();
        }

        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            _calculator.Divide();
        }
    }
}
