<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
</head>
<body>
    <h1>E-Liquid Composition Calculator</h1>
    <p>This program calculates the composition of e-liquid based on user-specified parameters including desired nicotine strength, PG/VG ratios, flavor percentages, and base nicotine characteristics.</p>
    <h2>How to Use</h2>
    <ol>
        <li><strong>Input Parameters:</strong>
            <ul>
                <li><strong>Total Desired Quantity (ml):</strong> Total amount of e-liquid you wish to produce.</li>
                <li><strong>Desired PG Percentage:</strong> Percentage of Propylene Glycol (PG) in the final e-liquid.</li>
                <li><strong>Desired VG Percentage:</strong> Percentage of Vegetable Glycerin (VG) in the final e-liquid.</li>
                <li><strong>Desired Nicotine Percentage:</strong> Desired nicotine concentration in the final e-liquid.</li>
                <li><strong>Base Nicotine Strength (mg/ml):</strong> Nicotine concentration in the base liquid used.</li>
                <li><strong>Base PG Percentage:</strong> Percentage of PG in the nicotine base.</li>
                <li><strong>Base VG Percentage:</strong> Percentage of VG in the nicotine base.</li>
                <li><strong>Flavor Percentage:</strong> Percentage of flavor concentrate to add.</li>
            </ul>
        </li>
        <li><strong>Calculation Process:</strong>
            <ul>
                <li>The program calculates the amount of flavor, nicotine, PG, and VG needed based on the provided percentages and quantities.</li>
                <li>It subtracts the amounts of PG and VG contributed by the flavor and nicotine base from the desired total, ensuring the final PG/VG ratio matches the user's specifications.</li>
            </ul>
        </li>
        <li><strong>Output:</strong>
            <ul>
                <li>The program outputs the exact amounts (in ml) of PG, VG, nicotine, and flavor to add to achieve the desired e-liquid composition.</li>
                <li>It then prompts whether to calculate another composition or exit.</li>
            </ul>
        </li>
        <li><strong>Continuous Usage:</strong>
            <ul>
                <li>The program runs continuously until the user chooses to exit, allowing for easy adjustment and calculation of different e-liquid compositions.</li>
            </ul>
        </li>
    </ol>
    <h2>How to Run</h2>
    <ul>
        <li>Ensure you have a C# compiler installed (such as Visual Studio or .NET Core SDK).</li>
        <li>Compile and execute the program, following the prompts to enter the required parameters.</li>
    </ul>
    <h2>Example Usage</h2>
    <pre>
Enter the total desired quantity of liquid (ml): 30
Enter the desired percentage of Propylene Glycol (PG): 40
Enter the desired percentage of Vegetable Glycerin (VG): 60
Enter the desired nicotine percentage: 3
Enter the nicotine strength in base (mg/ml): 18
Enter the percentage of Propylene Glycol (PG) in nicotine base: 50
Enter the percentage of Vegetable Glycerin (VG) in nicotine base: 50
Enter the desired flavor percentage: 10
Enter the percentage of Propylene Glycol (PG) in flavor (check on the flavor label): 20
Enter the percentage of Vegetable Glycerin (VG) in flavor (check on the flavor label): 80

Amount of Propylene Glycol (PG) to add: 9 ml
Amount of Vegetable Glycerin (VG) to add: 12 ml
Amount of nicotine to add: 5 ml
Amount of flavor to add: 3 ml

Do you want to calculate another composition? (y/n):
    </pre>

</body>
</html>
