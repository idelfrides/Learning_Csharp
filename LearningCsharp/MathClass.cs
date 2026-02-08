/*
---------------------
C# Math
---------------------
The C# Math class has many methods that allows you to perform mathematical tasks on numbers.

Math.Max(x,y)
The Math.Max(x,y) method can be used to find the highest value of x and y:


*/


using IJDEVLibrary;
namespace LearningCsharp;

class MathClass
{
    class Program
    {
        static void Main009(string[] args)
        {
            #region bloco introdução: ------------- INICIO APP ----------------
            var infos = "STUDING MATH CLASS AND IT METHODS EM C#!\n\tMAIN CLASS:  Program\n\tAUXILIAR CLASS: MathClass";

            AppInputOutputManager ijlibs = new AppInputOutputManager();

            char lineShape = '=';
            ijlibs.ShowPrettyInfo(infos, lineShape, 60);
            #endregion

            #region bloco da app propriamente dita
            Random rand = new Random();

            int randV1 = rand.Next(100); 
            int randV2 = rand.Next(100);
            int randV = rand.Next(10, 1000);
            
            double randDV = rand.NextDouble();

            double randDVx = rand.NextDouble();
            double randDVy = rand.NextDouble();
            double randDVz = rand.NextDouble();

            Console.WriteLine($"\n\tRANDOM VALUES: \n\tV = {randV}\n\tV1 = {randV1}\n\tV2 = {randV2}\n\tDV = {randDV}\n\tDVx = {randDVx}\n\tDVy = {randDVy}\n\tDVz = {randDVz}");

            ijlibs.BuildLines('-', 60, 1);

            Console.WriteLine($"\n\tMAX ({randV1}, {randV2}) IS => {Math.Max(randV1, randV2)}");
            Console.WriteLine($"\n\tMIN ({randV1}, {randV2}) IS => {Math.Min(randV1, randV2)}");
                     
            /*
             ->  converter seguntos para milissegundos
             
            Fórmula: multiplique o valor de tempo por 1000

            */
            int tempoSleepSegundos = 30;
            Thread.Sleep(tempoSleepSegundos * 1000);
            //Thread.Sleep(30000);

            Console.WriteLine($"\n\t SQUARE ROOT OF V1 IS => {Math.Sqrt(randV1)}");
            Console.WriteLine($"\n\t SQUARE ROOT OF V2 IS => {Math.Sqrt(randV2)}");
            Console.WriteLine($"\n\t ABSOLUTE VALUE => {Math.Abs(randV)}");
            Console.WriteLine($"\n\t ABS VALUE : V1 - V2 => {Math.Abs(randV1 - randV2)}");
            Console.WriteLine($"\n\t OPERATION: V2 - V => {randV2 - randV}");
            Console.WriteLine($"\n\t FusedMultiplyAdd OF VDx, VDy, VDz IS => {Math.FusedMultiplyAdd(randDVx, randDVy, randDVz)}");
            Console.WriteLine($"\n\t SINE OF VALUE IS => {Math.Sin(randV)}");
            Console.WriteLine($"\n\t COSINE OF VALUE IS => {Math.Cos(randV)}");
            Console.WriteLine($"\n\t TANGENT OF VALUE IS => {Math.Tan(randV)}");
            Console.WriteLine($"\n\t TRUNCATE VALUE => {Math.Truncate((decimal)randV)}");
            Console.WriteLine($"\n\t PI VALUE IS => {Math.PI}");
            Console.WriteLine($"\n\t POWER 2 OF VALUE IS => {Math.Pow(randV, 2)}");
            Console.WriteLine($"\n\t EXP IS => {Math.ILogB(randDV)}");
            Console.WriteLine($"\n\t ROUND OF VALUE IS => {Math.Round((decimal)randV)}");
            Console.WriteLine($"\n\t FLOOR OF VALUE IS => {Math.Floor((decimal)randV)}");
            Console.WriteLine($"\n\t CEILING OF VALUE IS => {Math.Ceiling((decimal)randV)}");
            Console.WriteLine($"\n\t LOG OF DOUBLE VALUE IS => {Math.Log(randDV)}");
            Console.WriteLine($"\n\t LOG10 OF DOUBLE VALUE IS => {Math.Log10(randDV)}");
            Console.WriteLine($"\n\t LOG2 OF DOUBLE VALUE IS => {Math.Log2(randDV)}");
                                     
            #endregion

            #region bloco ---------------- FIM DE APP --------------------

            ijlibs.ShowAppEndInfo();

            #endregion

        }

    }
}
