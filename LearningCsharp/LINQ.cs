

using System;
using System.Collections.Generic;
using System.Linq;
using LearningCsharp;      //include the System.IO namespace


namespace LearningCsharp
{
    public class LINQProgram
    {
        static void Main(string[] args)
        {

            #region bloco --------------- Introdução: INICIO APP -------------------
            var infos = "ESTUDANDO LINQ EM C#: \n\tMAIN CLASS: LINQProgram\n\tAUXILIAR CLASS: LINQExamples";

            IJDEVLibs ijlibs = new IJDEVLibs();
            LINQMethodSintaxe linqObj = new LINQMethodSintaxe();

            char lineShape = '=';
            ijlibs.ShowPrettyInfo(infos, lineShape, 60);
            #endregion


            #region bloco -------------- App propriamente dita: LINQ ------------------------

            int studentCount = 15;

            // Generate random scores and ages
            var StudentGradesArray = ijlibs.GenerateIntValuesArray(qtd: studentCount, maxValue: 10);
            var agesList = ijlibs.GenerateStudentAgesList(numberOfStudents: studentCount, minAge: 1, maxAge: 25);

            Console.WriteLine("\n\tGenerated Students Grades: " + string.Join(", ", StudentGradesArray));
            Console.WriteLine("\n\tGenerated Students Ages: " + string.Join(", ", agesList));

            // Demonstrate LINQ operations by using the LINQExamples class
            ijlibs.ShowPrettyInfo("LINQ OPERATIONS USING LINQExamples CLASS METHOS for SCORES", lineShape, 60);
            linqObj.FilterExampleArr(StudentGradesArray, 7);
            linqObj.SelectExampleArr(StudentGradesArray, 8);
            linqObj.OrderByExampleArr(StudentGradesArray);

            ijlibs.ShowPrettyInfo("LINQ OPERATIONS USING LINQExamples CLASS for AGES", lineShape, 60);
            linqObj.FilterExample(agesList, 15);
            linqObj.SelectExample(agesList, 15);
            linqObj.OrderByExample(agesList);

            
            // Demonstrate LINQ operations by directly using LINQ query syntax

            /*
                As Faixas do Serasa Score:

                -> Baixo (0 a 300): Indica grande probabilidade de inadimplência; chance muito baixa de conseguir crédito.
                -> Regular (301 a 500): Sinaliza uma probabilidade considerável de risco; baixa chance de obter crédito.
                -> Bom (501 a 700): Aponta baixo risco de inadimplência; boa chance de conseguir crédito.
                -> Excelente (701 a 1000): Indica risco muito baixo de inadimplência; maior probabilidade de aprovação de crédito.  
            */

            var SerasaScores =  ijlibs.GenerateIntValuesArray(qtd: 25, maxValue: 1000);

            var scoreBaixo = from v in SerasaScores
                             where v >= 0 && v <= 300
                             select v;

            var scoreRegular = from v in SerasaScores
                               where v >= 301 && v <= 500
                               select v;

            var scoreBom = from v in SerasaScores
                           where v >= 501 && v <= 700
                           select v;

            var scoreExcelente = from v in SerasaScores
                                 where v >= 701 && v <= 1000
                                 select v;


            ijlibs.ShowPrettyInfo("Serasa Scores Analysis:", lineShape, 60);
            
            Console.WriteLine("\n\tScores - Baixo (0 a 300): " + string.Join(", ", scoreBaixo));
            Console.WriteLine("\n\tScores - Regular (301 a 500): " + string.Join(", ", scoreRegular));
            Console.WriteLine("\n\tScores - Bom (501 a 700): " + string.Join(", ", scoreBom));
            Console.WriteLine("\n\tScores - Excelente (701 a 1000): " + string.Join(", ", scoreExcelente));
                        
            #endregion


            #region bloco ---------------- FIM DE APP --------------------
            Console.Write($"{Environment.NewLine}\nPressione qualquer tecla para sair  . . . ");

            Console.ReadKey(true);

            Console.Write("\n\n\n==================== FIM DE APP ====================\n\n\n\n");
            #endregion
        }
    }

    public class LINQMethodSintaxe
    {

        #region  block ------------ for int array ---------------------------
        public void FilterExampleArr(int[] arrayContent, int minToAccept)
        {
            var approved = arrayContent.Where(n => n >= minToAccept);
            Console.WriteLine("\n\tAccepted Values: " + string.Join(", ", approved));

            var rejected = arrayContent.Where(n => n < minToAccept);
            Console.WriteLine("\n\tRejected Values: " + string.Join(", ", rejected));
        }

        public void SelectExampleArr(int[] arrayContent, int minToAccept)
        {
            var approved = arrayContent.Where(n => n >= minToAccept);
            Console.WriteLine("\n\tAccepted Values: " + string.Join(", ", approved));
        }

        public void OrderByExampleArr(int[] ArrayContent)
        {
            var sortedList = ArrayContent.OrderBy(n => n);
            Console.WriteLine("\n\tSorted List: " + string.Join(", ", sortedList));
        }

        #endregion


        #region block -------------- for int list ---------------------------
        public void FilterExample(List<int> ListContent, int minToAccept)
        {
            var approved = ListContent.Where(n => n >= minToAccept);
            Console.WriteLine("\n\tAccepted Values: " + string.Join(", ", approved));

            var rejected = ListContent.Where(n => n < minToAccept);
            Console.WriteLine("\n\tRejected Values: " + string.Join(", ", rejected));
        }

        public void SelectExample(List<int> ListContent, int minToAccept)
        {
            var squaredNumbers = ListContent.Where(n => n >= minToAccept).Select(n => n);
            Console.WriteLine("\n\tAccepted Values: ---> " + string.Join(", ", squaredNumbers));
        }

        public void OrderByExample(List<int> ListContent)
        {
            var sortedList = ListContent.OrderBy(n => n);
            Console.WriteLine("\n\tSorted List: " + string.Join(", ", sortedList));
        }

        #endregion
    }

}