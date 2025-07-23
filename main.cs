
// to change set a user passward.
int continueOrNot=0;
do
{
    // taking user info.
    Console.Write("Enter your username : ");
    string userName = Console.ReadLine();

    Console.Write("\nEnter your passward : ");
    string userPassward = Console.ReadLine();

    // printing operation message.
    Console.Write($"\nHello {userName}, you Passward saved succesfully.");

} while (continueOrNot != 0);
