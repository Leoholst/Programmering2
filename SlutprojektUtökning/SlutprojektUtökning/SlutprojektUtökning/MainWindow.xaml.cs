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

namespace SlutprojektUtökning
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Model model = new Model();
        private Controller controller;

        public MainWindow()
        {
            InitializeComponent();
            controller = Controller.InitMainController();
            controller.StartGame();
            NextQuestion();
        }

        private void checkAnswer2(object sender, RoutedEventArgs e)
        {
            scoreText.Content = "Answered Correctly " + model.score + "/" + model.questionNumbers.Count;
        }

        private void UpdateButton()
        {
            foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.DarkGoldenrod;
            }
        }

        /// Metod med värdena, anropa denna metod i controller.

    }
}
