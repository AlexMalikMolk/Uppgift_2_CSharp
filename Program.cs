namespace Uppgift_2_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapa en instans av Random-klassen så att man kan generera slumpmässiga tal
            Random rand = new Random();

            // Använd Random-instansen för att generera ett slumpmässigt tal mellan 1 och 100, detta är det hemliga numret
            int secretNumber = rand.Next(1, 101);

            // Informera användaren om vad de behöver göra
            Console.WriteLine("Du ska nu gissa ett tal mellan 1 och 100, så varsågod...");
            Console.WriteLine("Skriv in ett tal: ");

            // Läs in det tal användaren skriver in som en sträng
            string userInput = Console.ReadLine();

            // Försök konvertera strängen till ett heltal, om det lyckas får isNumber värdet true
            bool isNumber = int.TryParse(userInput, out int guessedNumber);

            // Skriv ut felmeddelande ifall talet inte är mellan 1 och 100, eller om det inte är ett tal
            if (!isNumber || guessedNumber > 100 || guessedNumber < 1)
            {
                Console.WriteLine("Du måste skriva in ett tall mellan 1 och 100!");
            }
            else
            {
                // Om användaren gissade rätt, meddela dem om det
                if (guessedNumber == secretNumber)
                {
                    Console.WriteLine("Grattis! Du gissade rätt tal!");
                }
                // Om användaren gissade inom 3 enheter av det hemliga talet, men för litet
                else if (guessedNumber >= secretNumber - 3 && guessedNumber < secretNumber)
                {
                    Console.WriteLine("Du gissade för lågt, men du är nära!");
                }
                // Om användaren gissade inom 3 enheter av det hemliga talet, men för stort
                else if (guessedNumber <= secretNumber + 3 && guessedNumber > secretNumber)
                {
                    Console.WriteLine("Du gissade för högt, men du är nära!");
                }
                // Om användaren gissade för lågt, och inte inom 3 enheter
                else if (guessedNumber < secretNumber)
                {
                    Console.WriteLine("Ditt tal är för litet. Gissa på ett större tal.");
                }
                // Om användaren gissade för högt, och inte inom 3 enheter
                else
                {
                    Console.WriteLine("Ditt tal är för stort. Gissa på ett mindre tal.");
                }
            }

                // Meddela användaren att programmet avslutas
                Console.WriteLine("Programmet är slut");
        }
    }
}
