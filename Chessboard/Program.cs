// Carl Fransson .NET23

using System.Data.Common;

internal class Program
{
    private static void Main(string[] args)
    {
        int number;
        int row;
        int column;
        Console.WriteLine("Hur många nummer vill du ha i ditt schackbräde?");
        while (true) // Loopen fortsätter köras så länge användaren inte skriver in ett heltal
        {
            string convertNumber = Console.ReadLine(); // Lagrar användarens input i variabeln convertNumber
            if (int.TryParse(convertNumber, out number)) //Skapar en if sats och använder oss utav TryParse för att se om användaren skriver in ett heltal och lagrar de i variabeln number
            {
                break; // Loopen avslutas när användaren skriver ett heltal
            }
            else // Om användaren skriver något annat än ett heltal
            {
                Console.WriteLine("Vänligen skriv in ett heltal");
            }
        }
            Console.WriteLine("Vilken bokstav ska den första rutan ha?");
            string firstLetter = Console.ReadLine(); // Lagrar användarens input i variabeln firstLetter
            Console.WriteLine("Vilken bokstav ska den andra rutan ha?");
           string secondLetter = Console.ReadLine(); // Lagrar användarens input i variabeln secondLetter
        Console.WriteLine("Vilken bokstav vill du att din pjäs ska ha?");
            char chessSymbol = Console.ReadLine()[0]; //Använder char eftersom vi vill implementera en bokstav och vi använder [0] för att komma åt det första tecknet i inmatningssträngen. 
        Console.WriteLine("I vilken rad vill du placera din pjäs? (i siffror)");

        while (true)
        {
            string chooseRow = Console.ReadLine();
            if (int.TryParse(chooseRow, out row) && row > 0 && row < number) // Kollar så användaren skriver in ett heltal och om den är inanför schackbrädets storlek
            {
                break;
            }
            else
            {
                Console.WriteLine("Vänligen skriv in ett heltal inom intervallet 1 till {0}.",number -1); // Om användaren skriver ett för stort tal skrivs denna text ut
            }
        }
            Console.WriteLine("I vilken column vill du placera din pjäs? (i siffror)");
        while (true)
        {
            string chooseColumn = Console.ReadLine();
            if(int.TryParse(chooseColumn, out column) && column > 0 && column < number)
            {
                break;
            }
            else
            {
                Console.WriteLine("Vänligen skriv in ett heltal inom intervallet 1 till {0}.", number -1);
            }
        }         
            char[,] array = new char[number, number]; //Skapar en tvådimensionell array av tecken char. Så vi kan få tillgång till rad och kolumn.
            for (int i = 1; i < number; i++) // Skapar en for-loop. Där index börjar på 1 och fortsätter att loopa tills vi når det nummer som anges i variabeln "number"
            {
                for (int j = 1; j < number; j++) // Vi skapar en inre loop så att vi kan varva första bokstaven och andra bokstaven. Den fortsätter att loopa tills den når det antal nummer som användaren valde i början
                {
                    array[i, j] = (i + j) % 2 == 0 ? firstLetter[0] : secondLetter[0]; // För att få bokstäverna att alternera
                }
            }
           array[row, column] = chessSymbol; // Vi ersätter den bokstaven i schackbrädet till den bokstav som användaren ville ha som schacksymbol
            for (int i = 0; i < number; i++) // Loopar igenom för att kunna skriva ut och placera ut den nya schacksymbolen
            {
                for (int j = 0; j < number; j++)
                {
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Din pjäs ligger på rad {0} och på kolumn {1}", row, column); // Skriver ut vart i schackspelet sin pjäs står på
            Console.WriteLine("Klicka på valfri knapp för att stänga programmet.");
            Console.ReadKey();
    }
}