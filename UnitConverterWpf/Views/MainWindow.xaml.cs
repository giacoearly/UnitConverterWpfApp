using System.Windows;

namespace UnitConverterWpf
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var inch_tb = TBInch.Text;
            var foot_tb = TBFoot.Text;

            if ((double.TryParse(inch_tb, out double inch)) &&
                 (double.TryParse(foot_tb, out double foot)))
            {
                double meter = foot * 0.3048;
                meter += inch * 0.0254;
                TBMeter.Text = meter.ToString("N3");
            }
        }
    }
}
