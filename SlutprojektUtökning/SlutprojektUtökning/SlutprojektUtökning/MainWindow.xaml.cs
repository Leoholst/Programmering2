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
        public Controller controller = new Controller();
        

        public MainWindow()
        {
            InitializeComponent();
            
            // controller = Controller.InitMainController();
            
            StartGame();
            NextQuestion();
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

            NextQuestion();
        }

        public void StartGame()
        {
            controller.StartGameController();

            ResetQOrder();

            for (int i = 0; i < model.questionNumbers.Count; i++)
            {
                QOrderView();
            }
        }

        public void NextQuestion()
        {
            controller.NextQuestionController();

            UpdateButton();

            switch (model.constant)
            {
                case 1:
                    txtQuestion.Text = "Question 1";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2 Correct";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4";

                    ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("./images/1.jpg", UriKind.Relative));

                    break;

                case 2:
                    txtQuestion.Text = "Question 2";

                    ans1.Content = "Answer 1 Correct";
                    ans2.Content = "Answer 2";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4";

                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("./images/2.jpg", UriKind.Relative));

                    break;

                case 3:
                    txtQuestion.Text = "Question 3";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2";
                    ans3.Content = "Answer 3 Correct";
                    ans4.Content = "Answer 4";

                    ans3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("./images/3.jpg", UriKind.Relative));

                    break;

                case 4:
                    txtQuestion.Text = "Question 4";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4 Correct";

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("./images/4.jpg", UriKind.Relative));

                    break;

                case 5:
                    txtQuestion.Text = "Question 5";

                    ans1.Content = "Answer 1 Correct";
                    ans2.Content = "Answer 2";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4";

                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("./images/5.jpg", UriKind.Relative));

                    break;

                case 6:
                    txtQuestion.Text = "Question 6";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2 Correct";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4";

                    ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("./images/6.jpg", UriKind.Relative));

                    break;

                case 7:
                    txtQuestion.Text = "Question 7";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2";
                    ans3.Content = "Answer 3 Correct";
                    ans4.Content = "Answer 4";

                    ans3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("./images/7.jpg", UriKind.Relative));

                    break;

                case 8:
                    txtQuestion.Text = "Question 8";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4 Correct";

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("./images/8.jpg", UriKind.Relative));

                    break;

                case 9:
                    txtQuestion.Text = "Question 9";

                    ans1.Content = "Answer 1 Correct";
                    ans2.Content = "Answer 2";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4";

                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("./images/9.jpg", UriKind.Relative));

                    break;

                case 10:
                    txtQuestion.Text = "Question 10";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4 Correct";

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("./images/10.jpg", UriKind.Relative));

                    break;
            }
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
