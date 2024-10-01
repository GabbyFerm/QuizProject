
namespace QuizProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0;

            Console.WriteLine("Welcome to the quiz!");
            Console.WriteLine("Answer by typing the corresponding letter.(A, B, C or D)");
            Console.WriteLine();
            Console.WriteLine("1. What is the capitol of Sweden?");
            Console.WriteLine("A - Berlin");
            Console.WriteLine("B - Madrid");
            Console.WriteLine("C - Stockholm");
            Console.WriteLine("D - Budapest");

            string answerQuestion1 = Console.ReadLine()!;


            switch (answerQuestion1) 
            {
                case "A":
                    Console.WriteLine($"Your answer: {answerQuestion1}");
                    Console.WriteLine("Your answer is incorrect. The correct answer is C - Stockholm.");
                    break;

                case "B":
                    Console.WriteLine($"Your answer: {answerQuestion1}");
                    Console.WriteLine("Your answer is incorrect. The correct answer is C - Stockholm.");
                    break;

                case "C":
                    Console.WriteLine($"Your answer: {answerQuestion1}");
                    Console.WriteLine("Correct");
                    score++;
                    break;

                case "D":
                    Console.WriteLine($"Your answer: {answerQuestion1}");
                    Console.WriteLine("Your answer is incorrect. The correct answer is C - Stockholm.");
                    break;

                default:
                    Console.WriteLine("Invalid answer.");
                    break;
            }
            Console.WriteLine();

            Console.WriteLine("2. Which is the largest animal on land?");
            Console.WriteLine("A - Elephant");
            Console.WriteLine("B - Giraff");
            Console.WriteLine("C - Rhinoceros");
            Console.WriteLine("D - Lion");

            string answerQuestion2 = Console.ReadLine()!;


            switch (answerQuestion2)
            {

                case "A":
                    Console.WriteLine($"Your answer is: {answerQuestion2}");
                    Console.WriteLine("Correct");
                    score++;
                    break;

                case "B":
                    Console.WriteLine($"Your answer is: {answerQuestion2}");
                    Console.WriteLine("Your answer is incorrect. The correct answer is A - Elephant.");
                    break;

                case "C":
                    Console.WriteLine($"Your answer is: {answerQuestion2}");
                    Console.WriteLine("Your answer is incorrect. The correct answer is A - Elephant.");
                    break;

                case "D":
                    Console.WriteLine($"Your answer is: {answerQuestion2}");
                    Console.WriteLine("Your answer is incorrect. The correct answer is A - Elephant.");
                    break;

                default:
                    Console.WriteLine("Invalid answer.");
                    break;
            }

            Console.WriteLine();

            Console.WriteLine("3. What color does the Sunflower have?");
            Console.WriteLine("A - Blue");
            Console.WriteLine("B - Yellow");
            Console.WriteLine("C - Green");
            Console.WriteLine("D - Purple");

            string answerQuestion3 = Console.ReadLine()!;


            switch (answerQuestion3)
            {

                case "A":
                    Console.WriteLine($"Your answer is: {answerQuestion3}");
                    Console.WriteLine("Your answer is incorrect. The correct answer is B - Yellow.");
                    break;

                case "B":
                    Console.WriteLine($"Your answer is: {answerQuestion3}");
                    Console.WriteLine("Correct");
                    score++;
                    break;

                case "C":
                    Console.WriteLine($"Your answer is: {answerQuestion3}");
                    Console.WriteLine("Your answer is incorrect. The correct answer is B - Yellow.");
                    break;

                case "D":
                    Console.WriteLine($"Your answer is: {answerQuestion3}");
                    Console.WriteLine("Your answer is incorrect. The correct answer is B - Yellow.");
                    break;

                default:
                    Console.WriteLine("Invalid answer.");
                    break;
            }

            Console.WriteLine();

            Console.WriteLine($"Number of right answers: { score} / 3");

            //if (score == 3)
            //{
            //    Console.WriteLine("Your score is 3!");
            //}
            //else if (score == 2)
            //{
            //    Console.WriteLine("Your score is 2");
            //}
            //else if (score == 1)
            //{
            //    Console.WriteLine("Your score is 1");
            //}
            //else 
            //{
            //    Console.WriteLine("Your score is 0, better luck next time!");
            //}
        }
    }
}
