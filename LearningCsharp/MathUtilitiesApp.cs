using IJDEVLibrary;
namespace LearningCsharp;

public class MathUtilitiesApp
{
     public static void MainMU(string[] args)
     {
        #region bloco ---------------- INICIO DE APP ----------------

        AppInputOutputManager ijlibs = new AppInputOutputManager();

        ijlibs.ShowAppInfo(title: "MATH UTILITIES APP",
            summary: "This application demonstrates basic and trigonometric operations using the MathUtilities library."
        );
        #endregion

        // Using Calculator
        Console.WriteLine("\n\n==================== BASIC OPERATIONS ====================\n");
        Calculator calc = new Calculator();

        Console.WriteLine($"RESULT OF 15 + 10 = {calc.Add(15, 10)}");                  // Two arguments → Output: 25
        Console.WriteLine($"RESULT OF 1 + 2 + 3 + 4 + 5 = {calc.Add(1, 2, 3, 4, 5)}"); // Multiple arguments → Output: 15
        Console.WriteLine($"RESULT OF 7 + 3 + 8 = {calc.Add(7, 3, 8)}");       // Multiple arguments → Output: 18
        Console.WriteLine($"RESULT OF 0 = {calc.Add()}");                      // No arguments → Output: 0 
        Console.WriteLine($"RESULT OF 20 - 5 = {calc.Subtract(20, 5)}");       // Output: 15
        Console.WriteLine($"RESULT OF 4 * 5 * 2 = {calc.Multiply(4, 5, 2)}");  // Multiple arguments → Output: 40
        Console.WriteLine($"RESULT OF 20 / 4 = {calc.Divide(20, 4)}");         // Output: 5

        // Using ManageTrigonometryOperations
        Console.WriteLine("\n\n==================== TRIGONOMETRY OPERATIONS ====================\n");
        ManageTrigonometryOperations trig = new ManageTrigonometryOperations();
        Console.WriteLine($"RESULT OF Sine(π/2) = {trig.CalculateSine(Math.PI / 2)}");
        Console.WriteLine($"RESULT OF Cosine(0) = {trig.CalculateCosine(0)}");
        Console.WriteLine($"RESULT OF Tangent(π/4) = {trig.CalculateTangent(Math.PI / 4)}");


        #region bloco ---------------- FIM DE APP --------------------

        ijlibs.ShowAppEndInfo();

        #endregion
     }
}
