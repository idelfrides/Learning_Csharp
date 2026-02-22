
/*
 * 
 * 🔹 O que esse exemplo mostra
- Construtor primário → Person(string Name, int Age) define propriedades automaticamente.
- Igualdade por valor → p1 == p2 retorna true porque os valores são iguais.
- ToString automático → imprime propriedades sem precisar sobrescrever.
- Deconstruction → (name, age) = p1; extrai valores facilmente.
- Imutabilidade → propriedades só podem ser definidas na inicialização (init).
- with expression → cria cópias modificadas sem alterar o original.
- Herança entre records → Employee herda de Person.
- Métodos customizados → você pode adicionar lógica dentro do record.

📌 Em resumo:  record é perfeito para modelos de dados imutáveis, comparações por valor e código mais conciso.

*/


using System;
using System.Collections.Generic;
using System.Text;
using IJDEVLibrary;
namespace LearningCsharp
{    
  
    public record Person(string Name, int Age)
    {

        // Propriedade adicional com init-only
        public string Country { get; init; } = "Brazil";

        public string City { get; init; } = "São Paulo";

        // Método customizado
        public string Greet() => $"Hello, my name is {Name}, I'm {Age} years old and I am from {City}/{Country}";

        // Sobrescrevendo ToString V1 (opcional, já vem automático)
        //public override string ToString()
        //{
        //    return ToString($"override of ToString() V1: {Name}, ({Age})");
        //}

        // Sobrescrevendo ToString V2 (opcional, já vem automático)
        public override string ToString() => $"override of ToString() V2: {Name}, ({Age}) ";
            
    }

    // Record herdando de outro record
    public record Employee(string Name, int Age, string Position) : Person(Name, Age)
    {
        public decimal Salary { get; init; }

        public string GreetEmp()
        {
            return $"{base.Greet()}. My profession is {Position} with salary U$ {Salary}";
        }
    }

    public record SocialMedia(string IG, string FB, string YTB, string TKTK);

    public class RecordTypeUsageDemoProgram
    {
        public RecordTypeUsageDemoProgram() { }

        public static void MainRTD(string[] args)
        {

            #region block 1 --------------- START OF APP ------------------------
            AppInputOutputManager iom = new();

            var infos = "Record Type Usage Demo";
            char lineShape = '*';
            int lineLen = 0;
            int vspace = 0;
            int hspace = 2;
            bool useTab = false;

            iom.ShowAppInfo(
                title: infos,
                summary: "This App attempts to show how we can use Special type - record in C#."
            );
            #endregion


            #region block 2 --------------- USAGE OF SPECIAL TYPE: record -------

            // Criando instâncias
            var p1 = new Person("Maria", 20);
            var p2 = new Person("Maria", 20);
            var p4 = new Person("IRINA", 17);

            //MÉTODOS GERADOS AUTOMATICAMENTE: ToString()
            infos = "MÉTODOS GERADOS AUTOMATICAMENTE: ToString()";
            iom.ShowPrettyInfo(infos, lineShape, lineLen, vspace, hspace, useTab);
            Console.WriteLine($"P1 ::> {p1}");
            Console.WriteLine($"P2 ::> {p2}");
            Console.WriteLine($"P4 ::> {p4}");

            // Igualdade por valor            
            infos = "Igualdade por valor px == py";
            iom.ShowPrettyInfo(infos, lineShape, lineLen, vspace, hspace, useTab);
            Console.WriteLine($"Resultado de p1 == p2: {p1 == p2}");
            Console.WriteLine($"Resultado de p1 == p4: {p1 == p4}");
            Console.WriteLine($"Resultado de p2 == p4: {p2 == p4}");

            /*
            Não é possivel editar propriedades Name e Age porque são
            'init-only' ( podem ser editados somente na inicialização )
            código de erro: CS8852

            p1.Name = "JESSICA";
            p1.Age = 23;
            */
           
            // Deconstruction
            var (name, age) = p1;
            Console.WriteLine($"\n\n Deconstructed 'var (name, age) = p1': {name}, {age} ");

            // Usando método customizado
            infos = "RESULT OF CUSTOM METHODS: Greet() ";
            iom.ShowPrettyInfo(infos, lineShape, lineLen, vspace, hspace, useTab);
            Console.WriteLine($"{p1.Greet()}");
            Console.WriteLine($"{p2.Greet()}");
            Console.WriteLine($"{p4.Greet()}");

            // Criando cópia com with expression
            // -  with expression → cria cópias modificadas sem alterar o original
            infos = "Criando cópia com 'with expression' \n with expression -→ cria cópias modificadas sem alterar o original";
            iom.ShowPrettyInfo(infos, lineShape, lineLen, vspace, hspace, useTab);

            var p3 = p2 with
            {
                Name = "Joseph",
                Age = 31,
                Country = "USA",
                City = "California"
            };
            Console.WriteLine(p3);
            Console.WriteLine($"Greet(): {p3.Greet()}");

            // Record herdado
            infos = "Record herdado: Employee";
            iom.ShowPrettyInfo(infos, lineShape, lineLen, vspace, hspace, useTab);
            var emp = new Employee(Name: "Eng. SDL",
                                   Age: 30,
                                   Position: "Software Developer") { Salary = 20000m };
            Console.WriteLine(emp);
            // Console.WriteLine($"Position: {emp.Position}, Salary: {emp.Salary}");
            Console.WriteLine($"{emp.GreetEmp()}");

            // Comparing objects
            infos = "Comparing objects with px.Equals(py)";
            iom.ShowPrettyInfo(infos, lineShape, lineLen, vspace, hspace, useTab);
            Console.WriteLine($"p1.Equals(p3): { p1.Equals(p3) }");
            Console.WriteLine($"p2.Equals(p3): { p2.Equals(p3) }");
            Console.WriteLine($"p4.Equals(p3): { p4.Equals(p3) }");

            // GetHashCode of each object
            infos = "Showing GetHashCode of each object";
            iom.ShowPrettyInfo(infos, lineShape, lineLen, vspace, hspace, useTab);
            Console.WriteLine($"p1.GetHashCode(): { p1.GetHashCode() }");
            Console.WriteLine($"p2.GetHashCode(): { p2.GetHashCode() }");
            Console.WriteLine($"p3.GetHashCode(): { p3.GetHashCode() }");
            Console.WriteLine($"p4.GetHashCode(): { p4.GetHashCode() }");
            
            var sm1 = new SocialMedia(IG: "mariapaulaig01",
                                      FB: "mariapaulafb01",
                                      YTB: "mariapaulaytb01",
                                      TKTK: "mariapaulatk01");

            Console.WriteLine($"\n\n{p1.Name}, your social media accounts are ::>> {sm1.IG}, {sm1.FB}, {sm1.YTB}, {sm1.TKTK}");

            //sm1.TKTK = "tiktokaccount_test"; // código de erro: CS8852

            #endregion


            #region block 3 --------------- ENDING OF APP -----------------------

            iom.ShowAppEndInfo();

            #endregion

        }
    }
}
