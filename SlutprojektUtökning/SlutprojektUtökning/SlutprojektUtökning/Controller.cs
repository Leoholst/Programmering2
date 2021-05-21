using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace SlutprojektUtökning
{
    public class Controller
    {
        Model model = new Model();
        public MainWindow view = new MainWindow();

        public Controller InitMainController()
        {
            

            return new Controller();
        }

        public void CheckAnswerController(Button button)
        {
            

            if (button.Tag.ToString() == "1")
            {
                model.score++;
            }

            if (model.qNum < 0)
            {
                model.qNum = 0;
            }
            else
            {
                model.qNum++;
            }

            view.ScoreTextOutput();

            NextQuestion();
        }

        public void RestartGame()
        {
            model.score = 0;
            model.qNum = -1;
            model.constant = 0;
            StartGame();
        }

        public void StartGame()
        {
            var randomList = model.questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();

            model.questionNumbers = randomList;

            view.ResetQOrder();

            for (int i = 0; i < model.questionNumbers.Count; i++)
            {
                view.QOrderView();
            }
        }

        public void NextQuestion()
        {
            if (model.qNum < model.questionNumbers.Count)
            {
                model.constant = model.questionNumbers[model.qNum];
            }
            else
            {
                RestartGame();
            }

            view.UpdateButton();

            switch (model.constant)
            {
                case 1:
                    view.txtQuestion.Text = "Question 1";

                    view.ans1.Content = "Answer 1";
                    view.ans2.Content = "Answer 2 Correct";
                    view.ans3.Content = "Answer 3";
                    view.ans4.Content = "Answer 4";

                    view.ans2.Tag = "1";

                    view.qImage.Source = new BitmapImage(new Uri("./images/1.jpg", UriKind.Relative));

                    break;

                case 2:
                    view.txtQuestion.Text = "Question 2";

                    view.ans1.Content = "Answer 1 Correct";
                    view.ans2.Content = "Answer 2";
                    view.ans3.Content = "Answer 3";
                    view.ans4.Content = "Answer 4";

                    view.ans1.Tag = "1";

                    view.qImage.Source = new BitmapImage(new Uri("./images/2.jpg", UriKind.Relative));

                    break;

                case 3:
                    view.txtQuestion.Text = "Question 3";

                    view.ans1.Content = "Answer 1";
                    view.ans2.Content = "Answer 2";
                    view.ans3.Content = "Answer 3 Correct";
                    view.ans4.Content = "Answer 4";

                    view.ans3.Tag = "1";

                    view.qImage.Source = new BitmapImage(new Uri("./images/3.jpg", UriKind.Relative));

                    break;

                case 4:
                    view.txtQuestion.Text = "Question 4";

                    view.ans1.Content = "Answer 1";
                    view.ans2.Content = "Answer 2";
                    view.ans3.Content = "Answer 3";
                    view.ans4.Content = "Answer 4 Correct";

                    view.ans4.Tag = "1";

                    view.qImage.Source = new BitmapImage(new Uri("./images/4.jpg", UriKind.Relative));

                    break;

                case 5:
                    view.txtQuestion.Text = "Question 5";

                    view.ans1.Content = "Answer 1 Correct";
                    view.ans2.Content = "Answer 2";
                    view.ans3.Content = "Answer 3";
                    view.ans4.Content = "Answer 4";

                    view.ans1.Tag = "1";

                    view.qImage.Source = new BitmapImage(new Uri("./images/5.jpg", UriKind.Relative));

                    break;

                case 6:
                    view.txtQuestion.Text = "Question 6";

                    view.ans1.Content = "Answer 1";
                    view.ans2.Content = "Answer 2 Correct";
                    view.ans3.Content = "Answer 3";
                    view.ans4.Content = "Answer 4";

                    view.ans2.Tag = "1";

                    view.qImage.Source = new BitmapImage(new Uri("./images/6.jpg", UriKind.Relative));

                    break;

                case 7:
                    view.txtQuestion.Text = "Question 7";

                    view.ans1.Content = "Answer 1";
                    view.ans2.Content = "Answer 2";
                    view.ans3.Content = "Answer 3 Correct";
                    view.ans4.Content = "Answer 4";

                    view.ans3.Tag = "1";

                    view.qImage.Source = new BitmapImage(new Uri("./images/7.jpg", UriKind.Relative));

                    break;

                case 8:
                    view.txtQuestion.Text = "Question 8";

                    view.ans1.Content = "Answer 1";
                    view.ans2.Content = "Answer 2";
                    view.ans3.Content = "Answer 3";
                    view.ans4.Content = "Answer 4 Correct";

                    view.ans4.Tag = "1";

                    view.qImage.Source = new BitmapImage(new Uri("./images/8.jpg", UriKind.Relative));

                    break;

                case 9:
                    view.txtQuestion.Text = "Question 9";

                    view.ans1.Content = "Answer 1 Correct";
                    view.ans2.Content = "Answer 2";
                    view.ans3.Content = "Answer 3";
                    view.ans4.Content = "Answer 4";

                    view.ans1.Tag = "1";

                    view.qImage.Source = new BitmapImage(new Uri("./images/9.jpg", UriKind.Relative));

                    break;

                case 10:
                    view.txtQuestion.Text = "Question 10";

                    view.ans1.Content = "Answer 1";
                    view.ans2.Content = "Answer 2";
                    view.ans3.Content = "Answer 3";
                    view.ans4.Content = "Answer 4 Correct";

                    view.ans4.Tag = "1";

                    view.qImage.Source = new BitmapImage(new Uri("./images/10.jpg", UriKind.Relative));

                    break;
            }
        }
    }
}
