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
        public Controller controller;
        

        public MainWindow()
        {
            InitializeComponent();
            
            // controller = Controller.InitMainController();
            
            controller.StartGame();
            controller.NextQuestion();
            Close();
        }

        public void ScoreTextOutput()
        {
            scoreText.Content = "Answered Correctly " + model.score + "/" + model.questionNumbers.Count;
        }

        public void UpdateButton()
        {
            foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.DarkGoldenrod;
            }
        }

        public void ResetQOrder()
        {
            questionOrder.Content = null;
        }

        public void QOrderView()
        {
            questionOrder.Content += " " + model.questionNumbers[model.constant].ToString();
        }

        private void checkAnswer(object sender, RoutedEventArgs e)
        {
            Button senderButton = sender as Button;

            controller.CheckAnswerController(senderButton);

            ScoreTextOutput();

            controller.NextQuestion();
        }

        public void SetQuestionData(Question2 question)
        {
            Question2 questionA = new Question2();
            ans1.Content = questionA.Content;
        }
    }

    public class Question2
    {
        public string Content { get; set; }
    }
}
