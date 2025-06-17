namespace Project
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Lets Play The Game ;) \nHow much points is the line for winning : ");
            int points = Convert.ToInt32(Console.ReadLine());

            int user_point = 0, computer_point = 0, i = 1;

            Random random = new Random();

            while (user_point < points || computer_point < points)
            {
                Console.WriteLine($"\nRound: {i}\n1. Rock  2. Paper  3. Scissor");
                int choice = Convert.ToInt32(Console.ReadLine());
                int comp = random.Next(1, 4);
                String Computer_Choice;

                switch (comp)
                {
                    case 1:
                        Computer_Choice = "Rock";
                        break;
                    case 2:
                        Computer_Choice = "Paper";
                        break;
                    case 3:
                        Computer_Choice = "Scissor";
                        break;
                    default:
                        Computer_Choice = "Wrong Input";
                        break;
                }

                Console.WriteLine("Computer choose: " + Computer_Choice);

                switch (choice)
                {
                    case 1:
                        if (comp == 2)
                        {
                            Console.WriteLine("You lost!");
                            computer_point += 1;
                        }
                        else if (comp == 3)
                        {
                            Console.WriteLine("You win!");
                            user_point += 1;
                        }
                        else
                        {
                            Console.WriteLine("Its a draw!");
                        }
                        break;
                    case 2:
                        if (comp == 3)
                        {
                            Console.WriteLine("You lost!");
                            computer_point += 1;
                        }
                        else if (comp == 1)
                        {
                            Console.WriteLine("You win!");
                            user_point += 1;
                        }
                        else
                        {
                            Console.WriteLine("Its a draw!");
                        }
                        break;
                    case 3:
                        if (comp == 1)
                        {
                            Console.WriteLine("You lost!");
                            computer_point += 1;
                        }
                        else if (comp == 2)
                        {
                            Console.WriteLine("You win!");
                            user_point += 1;
                        }
                        else
                        {
                            Console.WriteLine("Its a draw!");
                        }
                        break;

                }
            }
            Console.WriteLine($"\nCOomputer Scored: {computer_point}\nUser Scored: {user_point}");
            if (user_point > computer_point)
            {
                Console.WriteLine("User Won\nCongrats");
            }
            else
            {
                Console.WriteLine("Computer Won\nTry Next Time!");
            }
        }
    }
}