using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Quiz_Abdul_Hakimzadah
{
    class Quiz
    {

        public Quiz(string title)
        {
            title = Title;

            LoadQuestions();

        }

        private readonly List<Question> _questionList = new List<Question> { };
        private int CurrentQuestionIndex;
        private string Title { get; set; } = "Food Quiz";
        private int Score { get; }




        private void LoadQuestions()
        {
            CurrentQuestionIndex = 0;
            _questionList.Add(new Question
            {
                QuestionText = "What is a food that uses cheese and tomato sauce?",
                Answer1 = "Pizza",
                Answer2 = "Chicken",
                Answer3 = "Meat Loaf",
                Answer4 = "Hotdog",
                CorrectAnswer = "Pizza",
            });

            CurrentQuestionIndex = 1;
            _questionList.Add(new Question
            {
                QuestionText = "What is a food that consists of a circular patty and two pieces of bread all stacked?",
                Answer1 = "Pasta",
                Answer2 = "Hotdog",
                Answer3 = "Burger",
                Answer4 = "Dumplings",
                CorrectAnswer = "Burger",
            });

            CurrentQuestionIndex = 2;
            _questionList.Add(new Question
            {
                QuestionText = "What is a food that is deep fried and then can be served either dry or saucy?",
                Answer1 = "Hotdogs",
                Answer2 = "Chicken noodle soup",
                Answer3 = "Chicken Wings",
                Answer4 = "Pasta",
                CorrectAnswer = "Chicken Wings",
            });

            CurrentQuestionIndex = 3;
            _questionList.Add(new Question
            {
                QuestionText = "What fruit is stinky and covered in a spikey outer shell?",
                Answer1 = "Orange",
                Answer2 = "Banana",
                Answer3 = "Apple",
                Answer4 = "Durian",
                CorrectAnswer = "Durian",
            });


            CurrentQuestionIndex = 4;
            _questionList.Add(new Question
            {
                QuestionText = "What fruit has a green outside and black seeds inside?",
                Answer1 = "Watermelon",
                Answer2 = "Apple",
                Answer3 = "Cherry",
                Answer4 = "Mango",
                CorrectAnswer = "Watermelon",
            });

          
        }


        private string GetQuestionWithoutAnswer()
        {
            //var rand = new Random();

            
        }


        public void GetNextQuestion()
        {

        }

        public void CheckUserAnswer()
        {

        }

    }
}
