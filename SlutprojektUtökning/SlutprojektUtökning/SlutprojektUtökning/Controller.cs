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
            StartGameController();
        }

        public void StartGameController()
        {
            var randomList = model.questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();

            model.questionNumbers = randomList;
        }

        public void NextQuestionController()
        {
            if (model.qNum < model.questionNumbers.Count)
            {
                model.constant = model.questionNumbers[model.qNum];
            }
            else
            {
                RestartGame();
            }

        }
    }
}
