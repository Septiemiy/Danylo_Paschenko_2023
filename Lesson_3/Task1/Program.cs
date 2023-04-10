using Task1.Classes;

var computer = new Computer();

while (true)
{
    Console.Write("\n1 - Add RAM\n" +
               "2 - Add CPU\n" +
               "3 - Add GPU\n" +
               "4 - Add Motherboard\n" +
               "5 - Add Drives\n" +
               "6 - Build PC\n" +
               "7 - Quit\n" +
               "Enter the number of the function: ");

    string userChoice = Console.ReadLine();

    if (userChoice == "7") break;

    computer.addToPC(userChoice);
}