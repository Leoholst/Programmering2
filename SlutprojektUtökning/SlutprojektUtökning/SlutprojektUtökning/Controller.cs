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

            ResetQOrder();

            for (int i = 0; i < model.questionNumbers.Count; i++)
            {
                QOrderView();
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
    }
}
