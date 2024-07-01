namespace Sc_EliquidCalculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                double totalMl = ReadDouble("Inserisci la quantità totale di liquido desiderato (ml): ");
                double desiredNicotinePercentage = ReadDouble("Inserisci la percentuale di nicotina desiderata: ");
                double desiredPgPercentage = ReadDouble("Inserisci la percentuale di glicole propilenico (PG) desiderata: ");
                double desiredVgPercentage = ReadDouble("Inserisci la percentuale di glicerolo vegetale (VG) desiderata: ");
                double baseNicotineStrength = ReadDouble("Inserisci la percentuale di nicotina nella base (mg/ml): ");
                double basePgPercentage = ReadDouble("Inserisci la percentuale di glicole propilenico (PG) nella base di nicotina: ");
                double baseVgPercentage = ReadDouble("Inserisci la percentuale di glicerolo vegetale (VG) nella base di nicotina: ");
                double flavorPercentage = ReadDouble("Inserisci la percentuale di aroma desiderata: ");
                double flavorPgPercentage = ReadDouble("Inserisci la percentuale di glicole propilenico (PG) nell'aroma (leggi sul retro dell'aroma): ");
                double flavorVgPercentage = ReadDouble("Inserisci la percentuale di glicerolo vegetale (VG) nell'aroma (leggi sul retro dell'aroma): ");

                // Calcolare i ml di aroma
                double flavorMl = (flavorPercentage / 100) * totalMl;

                // Calcolare i ml di nicotina necessari
                double nicotineMl = (desiredNicotinePercentage * totalMl) / baseNicotineStrength;

                // Calcolare i ml di glicole e glicerolo dall'aroma
                double flavorPgMl = flavorMl * (flavorPgPercentage / 100);
                double flavorVgMl = flavorMl * (flavorVgPercentage / 100);

                // Calcolare i ml di glicole e glicerolo dalla base di nicotina
                double nicotinePgMl = nicotineMl * (basePgPercentage / 100);
                double nicotineVgMl = nicotineMl * (baseVgPercentage / 100);

                // Calcolare il totale desiderato di PG e VG
                double desiredTotalPgMl = (desiredPgPercentage / 100) * totalMl;
                double desiredTotalVgMl = (desiredVgPercentage / 100) * totalMl;

                // Calcolare il PG e VG della base neutra tenendo conto di quanto già presente in aroma e nicotina
                double basePgMl = desiredTotalPgMl - flavorPgMl - nicotinePgMl;
                double baseVgMl = desiredTotalVgMl - flavorVgMl - nicotineVgMl;

                // Output dei risultati
                Console.WriteLine($"\nQuantità di glicole propilenico (PG) da aggiungere: {basePgMl} ml");
                Console.WriteLine($"Quantità di glicerolo vegetale (VG) da aggiungere: {baseVgMl} ml");
                Console.WriteLine($"Quantità di nicotina da aggiungere: {nicotineMl} ml");
                Console.WriteLine($"Quantità di aroma da aggiungere: {flavorMl} ml");

                Console.Write("\nVuoi calcolare un'altra composizione? (s/n): ");
                string response = Console.ReadLine().ToLower();

                if (response != "s")
                {
                    break;
                }
            }
        }
        static double ReadDouble(string message)
        {
            double result;
            while (true)
            {
                Console.Write(message);
                if (double.TryParse(Console.ReadLine(), out result))
                {
                    break;
                }
                Console.WriteLine("Per favore, inserisci un numero valido.");
            }
            return result;
        }
    }
}
