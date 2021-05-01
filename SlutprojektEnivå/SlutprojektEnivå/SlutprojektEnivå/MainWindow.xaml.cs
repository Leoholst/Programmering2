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

namespace SlutprojektEnivå
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*
         * Först skapas fyra universala variabler, tre ints och en List. 
         * List questionNumbers är av typen int och går från 1 till 10, där varje nummer motsvarar en fråga.
         * int qNum är den aktuella frågan.
         * int i är en standard-variabel som är universal därför att den används i flera klasser.
         * int score är till för att hålla koll på spelarens poäng dvs. hur många rätt spelaren har fått.
        */
        List<int> questionNumbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int qNum = 0;

        int i;

        int score;

        /* 
         * Detta är Main-klassen för frågespelet som sköter ordningen för hur spelet ska köras.
         * Först anropas standard InitializeComponent().
         * Sedan anropas StartGame().
         * Slutligen anropas NextQuestion().
        */
        public MainWindow()
        {
            InitializeComponent();
            StartGame();
            NextQuestion();
        }
        
        /*
         * Denna klass heter checkAnswer och är en produkt av knapparna i .xaml filen.
         * Klassen består av en knapp variabel, två if-statements och en scoreText.
         * Första if-statementet kollar om knappen som trycks på har rätt värde och om så är fallet, lägger på ett poäng på score alltså poängen.
         * Det andra if-statementet kollar vilken fråga som spelaren är på. Om det är innan första frågan kommer det bli första frågan, annars kommer det bli nästa fråga i ordningen.
         * Sedan skriver den ut hur många poäng spelaren ligger på efter att ha svarat på frågan.
         * Slutligen anropas NextQuestion().
        */
        private void checkAnswer(object sender, RoutedEventArgs e)
        {
            Button senderButton = sender as Button;

            if (senderButton.Tag.ToString() == "1")
            {
                score++;
            }

            if (qNum < 0)
            {
                qNum = 0;
            }
            else
            {
                qNum++;
            }

            scoreText.Content = "Answered Correctly " + score + "/" + questionNumbers.Count;

            NextQuestion();
        }

        /* 
         * Denna klass heter RestartGame och har i uppgift att starta om spelet vid anropning.
         * Klassen sätter score dvs. spelarens poäng till 0.
         * qNum sätter den under 0 vilket betyder att den i CheckAnswer() kan sättas till 0 och på så sätt starta spelet.
         * Slutligen sätts i till 0 och StartGame() anropas.
        */
        private void RestartGame()
        {
            score = 0;
            qNum = -1;
            i = 0;
            StartGame();
        }

        /*
         * Denna klass heter NextQuestion och är den största klassen i programmet. Klassen bryter mot S i SOLID därför att den inte bara har ett ansvarsområde.
         * Klassen består av ett if-statement, en foreach-loop och ett switch-statement.
         * Först kommer if-statementet och kollar om qNum är mindre än det aktuella nummret i List questionNumbers, och isåfall sätter i till det specifika index nummret. Om inte så startar spelet om.
         * Med andra ord, if-statementet kollar om frågan spelaren är på är mindre än antalet frågor tillgängliga i spelet så sätts i till just det nummret. Detta är för att frågorna i spelet är slumpmässiga.
         * Sedan kommer foreach-loopen som säger att för varje knapp i vår Canvas, kommer deras värde sättas till 0. Detta för att kunna räkna poäng på rätt sätt.
         * Sist men inte minst kommer swtich-statementet. Denna består av 10 cases, en för varje fråga som skriver ut frågan med en bild samt de fyra alternativen, där ett är rätt. 
         * Den sätter sedan värdet på den rätta frågan till 1. Detta betyder att resterande frågor kommer ha värde 0 och om man klickar på den rätta frågan, så kommer score gå upp.
         * Det enda som jag inte har kopierat exakt av guiden är bild-länken. Detta för att hans sätt inte fungerade för mig, men problemet var nog ändå att Build Action inte var satt till Resource.
        */
        private void NextQuestion()
        {
            if (qNum < questionNumbers.Count)
            {
                i = questionNumbers[qNum];
            }
            else
            {
                RestartGame();
            }

            foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.DarkGoldenrod;
            }

            switch (i)
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

        /*
         * Denna klass heter StartGame, det är här frågorna slumpas innan spelaren får börja spela.
         * Först skapas en variabel randomList som skapar en ny ordning av List questionNumbers med hjälp av Guid.
         * Sedan sätts att questionNumbers är lika med randomList.
         * Efter det skapas questionOrder, vilket är den synliga slumpmässiga ordningen av frågorna. 
         * Sist kommer en for-loop som kommer loopa så länge i är mindre än antalet tillgängliga frågor.
         * Och det loopen gör, är att den adderar siffrorna från den slumpade listan till questionOrder.
        */
        private void StartGame()
        {
            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();

            questionNumbers = randomList;

            questionOrder.Content = null;

            for (int i = 0; i < questionNumbers.Count; i++)
            {
                questionOrder.Content += " " + questionNumbers[i].ToString();
            }
        }
    }
}
