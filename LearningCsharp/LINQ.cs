

using System;
using System.Collections.Generic;
using System.Linq;
using LearningCsharp;      //include the System.IO namespace


class LINQExamplesProgram
{
    public class LINQMainClass
    {
        static void Main(string[] args)
        {

            #region bloco --------------- Introduction: START OF APP -------------------
            var infos = "ESTUDANDO LINQ EM C#: \n\tMAIN CLASS: LINQMainClass\n\tAUXILIAR CLASS: LINQExamples";

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

            // Demonstrate LINQ operations by using the LINQMethodSintaxe class
            ijlibs.ShowPrettyInfo("LINQ OPERATIONS USING LINQMethodSintaxe CLASS METHOS for SCORES", lineShape, 60);
            linqObj.FilterExampleArr(StudentGradesArray, 7);
            linqObj.SelectExampleArr(StudentGradesArray, 8);
            linqObj.OrderByExampleArr(StudentGradesArray);

            ijlibs.ShowPrettyInfo("LINQ OPERATIONS USING LINQMethodSintaxe CLASS for AGES", lineShape, 60);
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

            var scoresBaixo = from v in SerasaScores
                             where v >= 0 && v <= 300
                             select v;

            var scoresRegular = from v in SerasaScores
                               where v >= 301 && v <= 500
                               select v;

            var scoresBom = from v in SerasaScores
                           where v >= 501 && v <= 700
                           select v;

            var scoresExcelente = from v in SerasaScores
                                 where v >= 701 && v <= 1000
                                 select v;


            ijlibs.ShowPrettyInfo("Serasa Scores Analysis:", lineShape, 60);

            Console.WriteLine("\n\tScores - Baixo (0 a 300): " + string.Join(", ", scoresBaixo));
            Console.WriteLine("\n\tScores - Regular (301 a 500): " + string.Join(", ", scoresRegular));
            Console.WriteLine("\n\tScores - Bom (501 a 700): " + string.Join(", ", scoresBom));
            Console.WriteLine("\n\tScores - Excelente (701 a 1000): " + string.Join(", ", scoresExcelente));


            #region block -------------- Testando outras cláusulas do LINQ ------------------------

            /*
            TESTANDO OUTRAS CLÁUSULAS E CONCEITOS DO LINQ
              Como seria, na sintaxe de query (consulta) o uso das clausulas no LINQ?

            - SELECT DISTINCT
            - HAVING
            - CASE ...WHEN
            - FUNÇÕES DE AGREGAÇÃO E GROUP BY
            - SUBCONSULTAS
            - LIMIT 
            - IN 
            - LIKE
            - BETWEEN
            - COUNT
            - JOIN
            */

            infos = """
                TESTANDO OUTRAS CLÁUSULAS E CONCEITOS DO LINQ
                Como seria, na sintaxe de query (consulta) o uso das clausulas no LINQ?

                - SELECT DISTINCT
                - HAVING
                - CASE ...WHEN
                - FUNÇÕES DE AGREGAÇÃO E GROUP BY
                - SUBCONSULTAS
                - LIMIT 
                - IN 
                - LIKE
                - BETWEEN
                - COUNT
                - JOIN
                - etc
            """;
            
            ijlibs.ShowPrettyInfo(infos, lineShape, 80);

            int qtd = ijlibs.GetRandomIntValue(minValue: 10, maxValue: 20);
            int magnitude = ijlibs.GetRandomIntValue(minValue: 50, maxValue: 100);

            var otherLINQExamplesValues = ijlibs.GenerateIntValuesArray(qtd: qtd, maxValue: magnitude);

            Console.WriteLine("\n\n\tGENERATED VALUES FOR SECTION Testando outras cláusulas do LINQ\n\n");
            foreach (var item in otherLINQExamplesValues)
            {
                Console.Write($"{item}; ");
            }

            // 🔹 SELECT DISTINCT
            var distinctValues = (from v in otherLINQExamplesValues
                                  select v).Distinct();

            Console.WriteLine("\n\n\tDistinct Values: \n" + string.Join(", ", distinctValues));

            // 🔹 HAVING (usado junto com GROUP BY)
            int countTimes = ijlibs.GetRandomIntValue(maxValue: 2);

            var groupedValues = from v in otherLINQExamplesValues
                                group v by v into g
                                where g.Count() > countTimes  // HAVING clause : HAVING COUNT(*) > 1
                                select new { Value = g.Key, Count = g.Count() };

            Console.WriteLine($"\n\tGrouped Values with HAVING COUNT > {countTimes}:\n");
            foreach (var item in groupedValues)
            {
                Console.WriteLine($"\tValue: {item.Value} | Count: {item.Count}");
            }


            // 🔹 CASE ... WHEN (simulado com operador ternário)

            var caseWhenResult = from v in otherLINQExamplesValues
                                 select new
                                 {
                                     Number = v,
                                     Category = (v % 2 == 0 ? "EVEN (PAR)" : "ODD (ÍMPAR)") // CASE ... WHEN
                                 };

            foreach(var r in caseWhenResult)
                Console.WriteLine($"\t THE NUMBER {r.Number} IS {r.Category}");


            // 🔹 FUNÇÕES DE AGREGAÇÃO + GROUP BY : MÉTRICAS SOBRE NÚMEROS PARES E ÍMPARES
            var aggregationResults = from v in otherLINQExamplesValues
                                     group v by v % 2 into g
                                     select new
                                     {
                                         Key = g.Key,
                                         Sum = g.Sum(),
                                         Average = g.Average(),
                                         Max = g.Max(),
                                         Min = g.Min(),
                                         Count = g.Count()
                                     };

            Console.WriteLine("\n\n MÉTRICAS SOBRE NÚMEROS PARES E ÍMPARES\n");
            foreach (var item in aggregationResults)
            {
                Console.WriteLine($"\n\tKey: {item.Key} | Sum: {item.Sum} | Average: {item.Average} | Max: {item.Max} | Min: {item.Min} | Count: {item.Count}");
            }

            // 🔹 SUBCONSULTAS

            Console.WriteLine($"\n\nSUBCONSULTAS:\n");

            var average = from v in otherLINQExamplesValues
                          let avg = otherLINQExamplesValues.Average()
                          select avg;

            // subconsulta 01 - maiores do que a média de todos os valores
            var subqueryResults = from v in otherLINQExamplesValues
                                  where v > (from x in otherLINQExamplesValues select x).Average() // subconsulta
                                  select v;

            // subconsulta 02 - menores do que a média de todos os valores
            var menoresQueMedia = from n in otherLINQExamplesValues
                                  let media = otherLINQExamplesValues.Average() // subconsulta
                                  where n < media
                                  select n;

            Console.WriteLine($"\nAVERAGE IS : {average.First()}");

            Console.WriteLine("\nSubconsulta 01 - maiores do que a média de todos os valores\n");
            foreach(var mm in subqueryResults)  Console.Write($"{mm}; ");

            Console.WriteLine("\n\nSubconsulta 02 - menores do que a média de todos os valores\n");
            foreach (var m in menoresQueMedia)  Console.Write($"{m}, ");

            
            // 🔹 LIMIT (em LINQ é Take)

            var first5Values = (from v in otherLINQExamplesValues
                                select v).Take(5);

            Console.WriteLine($"\n\nLIMIT (Take) - First 5 Values:\n");
            foreach (var item in first5Values) Console.Write($"{item}; ");


            // 🔹 IN (usando Contains)

            int[] filter = { 11 , 4, 9, 7, 10, 15, 17, 27 };

            var selectedByINOper = from v in otherLINQExamplesValues
                                   where filter.Contains(v)  // equivalente ao operador IN ( 11, 4, 9, 7, 10, 15, 17, 27 )
                                   select v;

            Console.WriteLine($"\n\n Equivalente ao operador IN ( 11, 4, 9, 7, 10, 15, 17, 27 ):\n");
            foreach (var item in selectedByINOper) Console.Write($"{item}; ");


            // 🔹 LIKE (usando StartsWith, EndsWith, Contains)

            string[] names = { "Ana", "André", "Bruno", "Beatriz", "João", "Pedro", "Marcos", "Paula", "Jéssica", "Letícia", "Sarah", "Agatha", "Perpétua"};

            var comecaComA = from nome in names
                       where nome.StartsWith("A")  // LIKE 'A%'
                       select nome;

            var terminaComA = from nome in names
                              where nome.EndsWith("a")  // LIKE '%a'
                              select nome;

            var contemE = from nome in names
                          where nome.Contains("e")  // LIKE '%e%'
                          select nome;

            Console.WriteLine($"\n\n LIKE (usando StartsWith 'A'):\n");
            foreach (var item in comecaComA) Console.Write($"{item}; ");

            Console.WriteLine($"\n\n LIKE (usando EndsWith 'a' ):\n");
            foreach (var item in terminaComA) Console.Write($"{item}; ");

            Console.WriteLine($"\n\n LIKE (usando Contains 'e'):\n");
            foreach (var item in contemE) Console.Write($"{item}; ");


            // 🔹 BETWEEN

            var betweenResult = from v in otherLINQExamplesValues
                                where v >= 5 && v <= 20  // BETWEEN 5 AND 20
                                select v;

            Console.WriteLine($"\n\n BETWEEN 5 AND 20 \n");
            foreach (var item in betweenResult) Console.Write($"{item}; ");

            // 🔹 COUNT

            var countResult = (from v in otherLINQExamplesValues
                               select v).Count();

            Console.WriteLine($"\n\nTotal de elementos: {countResult}");

            infos = """
                ✅ Resumo

                • 	SELECT DISTINCT -> .Distict()
                • 	HAVING -> where após group ... into
                • 	CASE WHEN -> operador ternário cond ? valorSeTrue:ValorSeFalse
                • 	GROUP BY + agregações -> group ... by ... into + Sum(), Average(), Count() 
                • 	SUBCONSULTAS -> let ou chamadas dentro da query
                • 	LIMIT -> .Take()
                • 	IN -> Contains()
                • 	LIKE -> .StartsWith(), .EndsWith(), .Contains()  
                • 	BETWEEN -> where x >= min && x <= max
                • 	COUNT -> .Count()
            """;

            ijlibs.ShowPrettyInfo(infos, lineShape, 80);


            #endregion

            #endregion  // bloco -------------- App propriamente dita: LINQ ------------------------


            #region bloco ---------------- Conclusion: END OF APP --------------------

            ijlibs.FinishProgram();

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