

Console.WriteLine("Welcome to Rock , Paper , Scissors");
Console.WriteLine("To Start The Game Please Press yes/y Or no/n to leave");

var random = new Random();

int PlayerPoints = 3;
int ComputerPoints = 3;
int GameLose = 0;




string Userinput;
Userinput = Console.ReadLine();


if (Userinput == "y")
{


    while (PlayerPoints > GameLose || ComputerPoints > GameLose )
    {
        Console.WriteLine("Please Pick an Option Rock ,Paper ,Scissors ");
        Console.WriteLine("----------------------------------------------");
        string Userinput2 = Console.ReadLine();
        var Computerinput = random.Next(0, 4);

        if (Userinput2 == "Rock")
        {
            Console.WriteLine("Ok you picked rock....");

            switch (Computerinput)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("The Computer Picked Rock");
                    Console.WriteLine("No one loses , No one loses points");
                    Console.WriteLine("");
                    Console.WriteLine("Press Enter To Continue");

                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("The Computer Picked Scissors");
                    Console.WriteLine("The Computer loses a point"+ComputerPoints+":Computer Points");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Your Points ----:" + PlayerPoints);
                    Console.WriteLine("");
                    Console.WriteLine("Press Enter To Continue");

                    ComputerPoints--;
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("The Computer Picked Paper");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("You Lost and will lose 1 point ---:" + PlayerPoints + ":Points left");
                    Console.WriteLine("");
                    Console.WriteLine("Press Enter To Continue");

                    PlayerPoints--;
                    break;
                    
            }
            
        }

        else if (Userinput2 == "Scissors")
        {
            

            Console.WriteLine("Ok you picked Scissors....");

            switch (Computerinput)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("The Computer Picked Scissors");
                    Console.WriteLine("No one loses , No one loses points");
                    Console.WriteLine("");
                    Console.WriteLine("Press Enter To Continue");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("The Computer Picked Paper");
                    Console.WriteLine("The Computer loses a point" + ComputerPoints + ":Computer Points");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Your Points----:" + PlayerPoints);
                    Console.WriteLine("");
                    Console.WriteLine("Press Enter To Continue");
                    ComputerPoints--;
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("The Computer Picked Rock");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("You Lost and will lose 1 point ---:" + PlayerPoints + ":Points left");
                    Console.WriteLine("");
                    Console.WriteLine("Press Enter To Continue");
                    PlayerPoints--;
                    break;
            }
            
        }
        
        else if (Userinput2 == "Paper")
        {
            Console.WriteLine("Ok you picked Paper....");
            switch (Computerinput)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("The Computer Picked Paper");
                    Console.WriteLine("No one loses , No one loses points");
                    Console.WriteLine("");
                    Console.WriteLine("Press Enter To Continue");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("The Computer Picked Rock");
                    Console.WriteLine("The Computer loses a point" + ComputerPoints + ":Computer Points");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Your Points----:" + PlayerPoints);
                    Console.WriteLine("");
                    Console.WriteLine("Press Enter To Continue");
                    ComputerPoints--;
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("The Computer Picked Scissors");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("You Lost and will lose 1 point ---:" + PlayerPoints + ":Points left");
                    Console.WriteLine("");
                    Console.WriteLine("Press Enter To Continue");
                    PlayerPoints--;
                    break;
                    
            }
        }
        Console.ReadLine(); 
    }   
}

else if (Userinput=="n")
{
    Environment.Exit(0);
}
Console.ReadLine();





