using System;
using System.Collections.Generic;
using System.Text;

namespace SlutprojektUtökning
{
    interface IQuestionFactory
    {
        public string ICreateQuestion()
        {

            return " ";
        }
    }

    class QuestionFactory
    {
        public string CreateQuestion()
        {
            
            
            return " ";
        }
    }

    class Questions
    {
        public void IQuestion(Questions question)
        {
            
            
        }
    }

    class Category : Questions
    {
        public void ICategory()
        {

        }
    }

    class AnimalCategory : Category
    {
        public void NewAnimalCategory()
        {

        }
    }

    class SportsCategory : Category
    {
        public void NewSportsCategory()
        {

        }
    }

    class ActionCategory : Category
    {
        public void NewActionCategory()
        {

        }
    }
}
