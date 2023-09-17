// Carl Fransson .NET23

// The variables i use for the project
int number;
string firstLetter;
string secondLetter;
int row;
int column;

Console.WriteLine("Hur många nummer vill du ha i ditt schackbräde?");
number = Convert.ToInt32(Console.ReadLine()); // Because we want to store a number insted of a text we have to convert from string to int and then save users input in variable number
Console.WriteLine("Vilken bokstav ska den första rutan ha?");
firstLetter = Console.ReadLine();
Console.WriteLine("Vilken bokstav ska den andra rutan ha?");
secondLetter = Console.ReadLine();
Console.WriteLine("Vilken bokstav vill du att din pjäs ska ha?");
char chessSymbol = Console.ReadLine()[0]; // I use char here because we want to implement a single letter and we use [0] to access the first character of the input string. 
Console.WriteLine("I vilken rad vill du placera din pjäs? (i siffror)");
row= Convert.ToInt32(Console.ReadLine()); // Same here we convert from string to int and store it in variable row
Console.WriteLine("I vilken column vill du placera din pjäs? (i siffror)");
column = Convert.ToInt32(Console.ReadLine()); // We convert from string to int and store it in variable column

char[,] array = new char[number, number]; // We create a two dimensional array of characters. So we can get acsess to row and column.

for (int i = 1;i < number; i++) // We create a for loop. Where index starts at 1 and keeps looping until we reach the number specified in the variable "number"
{
    for(int j = 1; j < number; j++) // We create an inner loop so we can alternate the first letter and second letter. It keeps looping until it reaches the amount of numbers the user choosed in the beginning
    {
        array[i, j] = (i + j) % 2 == 0 ? firstLetter[0] : secondLetter[0]; // To get the the letters to alternate we use this calculation.

        if (row >= 0 && row < number && column >= 0 && column < number) // If row is greater then or equal to 0 and row is less then the amount of numbers user declared and same for column 
        {
            array[row, column] = chessSymbol; // We replace that letter in the chessboard to the letter the user wanted as chessSymbol
        }
        else // If user picks a greater number then the amount of numbers he choosed in the beginning the text inside "" will show
        {
            Console.WriteLine("Ogiltig kolumn eller rad");
        }
        Console.Write(array[i,j]); // Prints out the new chessSymbol
    }
    Console.WriteLine(); // So we get as many lines as the number in variable number
}

Console.WriteLine("Din pjäs ligger på rad {0} och på kolumn {1}", row,column);
Console.WriteLine("Klicka på valfri knapp för att stänga programmet.");
Console.ReadKey();




