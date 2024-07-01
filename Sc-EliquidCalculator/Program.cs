namespace Sc_EliquidCalculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                double totalMl = ReadDouble("Enter the total desired quantity of liquid (ml): ");
                double desiredPgPercentage;
                double desiredVgPercentage;
                double baseNicotineStrength;
                double basePgPercentage;
                double baseVgPercentage;
                while (true)
                {
                     desiredPgPercentage = ReadDouble("Enter the desired percentage of Propylene Glycol (PG): ");
                     desiredVgPercentage = ReadDouble("Enter the desired percentage of Vegetable Glycerin (VG): ");
                    if(desiredPgPercentage + desiredVgPercentage <= 100)
                    {
                        break;
                    }
                    Console.WriteLine("The sum of PG and VG should not exceed 100. Please Enter Valid values.");
                }
                double desiredNicotineStrenght = ReadDouble("Enter the desired nicotine Strength (mg/ml): ");
                while (true)
                {
                    baseNicotineStrength = ReadDouble("Enter the nicotine strength in base (mg/ml): ");
                    if (baseNicotineStrength <= 20)
                    {
                        break;
                    }
                    Console.WriteLine("The maximum nicotine strenght is 20. Please Enter Valid values.");
                }
                while (true)
                {
                    basePgPercentage = ReadDouble("Enter the percentage of Propylene Glycol (PG) in nicotine base: ");
                    baseVgPercentage = ReadDouble("Enter the percentage of Vegetable Glycerin (VG) in nicotine base: ");
                    if (basePgPercentage + baseVgPercentage <= 100)
                    {
                        break;
                    }
                    Console.WriteLine("The sum of nicotine PG and VG should not exceed 100. Please Enter Valid values.");
                }
                double flavorPercentage = ReadDouble("Enter the desired flavor percentage: ");
                
                //Aroma can only be in pg.
                double flavorPgPercentage = 100;

                // Calculate flavor amount in ml
                double flavorMl = (flavorPercentage / 100) * totalMl;

                // Calculate nicotine amount in ml
                double nicotineMl = (desiredNicotineStrenght * totalMl) / baseNicotineStrength;

                // Calculate PG amount from flavor
                double flavorPgMl = flavorMl * (flavorPgPercentage / 100);
                double flavorVgMl = 0;

                // Calculate PG and VG amount from nicotine base
                double nicotinePgMl = nicotineMl * (basePgPercentage / 100);
                double nicotineVgMl = nicotineMl * (baseVgPercentage / 100);

                // Calculate total desired PG and VG
                double desiredTotalPgMl = (desiredPgPercentage / 100) * totalMl;
                double desiredTotalVgMl = (desiredVgPercentage / 100) * totalMl;

                // Calculate PG and VG from neutral base considering what is already present in flavor and nicotine
                double basePgMl = desiredTotalPgMl - flavorPgMl - nicotinePgMl;
                double baseVgMl = desiredTotalVgMl - flavorVgMl - nicotineVgMl;

                // Output results
                Console.WriteLine($"\nAmount of Propylene Glycol (PG) to add: {basePgMl} ml");
                Console.WriteLine($"Amount of Vegetable Glycerin (VG) to add: {baseVgMl} ml");
                Console.WriteLine($"Amount of nicotine to add: {nicotineMl} ml");
                Console.WriteLine($"Amount of flavor to add: {flavorMl} ml");

                Console.Write("\nDo you want to calculate another composition? (y/n): ");
                string response = Console.ReadLine().ToLower();

                if (response != "y")
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
                if (double.TryParse(Console.ReadLine(), out result) && result >=0)
                {
                    break;
                }
                Console.WriteLine("Please enter a valid number.");
            }
            return result;
        }
    }
}
