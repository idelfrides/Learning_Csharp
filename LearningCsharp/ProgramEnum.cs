using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;

namespace LearningCsharp
{   
    public class ProgramEnum
    {   
        /*
        EnumStatusRelacioModerno - Enumeração que representa diferentes status de relacionamento em um contexto moderno.
        Cada valor na enumeração é associado a um número inteiro específico, que pode ser usado para representar o status de forma mais eficiente.
        1 - Visualizante: Indica que a pessoa apenas visualiza o perfil ou informações de outra pessoa.
        2 - Conversante: Indica que a pessoa está em um estágio inicial de conversa com outra pessoa.
        e assim por diante, até o valor 12 - Viuvo, que indica que a pessoa perdeu seu parceiro em um relacionamento anterior.
        
        Caracteristicas técnicas de enums em C#.

        1. Definição de Enumerações: Em C#, uma enumeração (enum) é um tipo de valor que consiste em um conjunto nomeado de constantes inteiras. Elas são definidas usando a palavra-chave 'enum'.
        2. Tipo Subjacente: Por padrão, o tipo subjacente de um enum é 'int', mas você pode especificar outro tipo integral (como byte, sbyte, short, ushort, uint, long ou ulong) se necessário.
        3. Atribuição de Valores: Você pode atribuir valores específicos aos membros do enum. Se você não atribuir valores, o compilador atribuirá automaticamente valores inteiros começando de 0.
        4. Uso de Enums: Enums são usados para representar um conjunto fixo de constantes relacionadas, tornando o código mais legível e fácil de manter.
        5. Conversão: Você pode converter entre enums e seus tipos subjacentes usando casting explícito.
        6. Métodos Úteis: A classe 'Enum' em C# fornece vários métodos úteis para trabalhar com enums, como 'GetNames', 'GetValues' e 'Parse'.
        7. Flags: Você pode usar o atributo '[Flags]' para criar enums que representam combinações de valores, permitindo operações bit a bit.
        8. Escopo: Enums são tipos de valor e, portanto, são armazenados na pilha. Eles também têm escopo limitado ao namespace ou classe em que são definidos.
        9. Comparação: Você pode comparar valores de enumeração diretamente usando operadores de comparação.
        10. Boas Práticas: É uma boa prática nomear enums e seus membros de forma clara e significativa para melhorar a legibilidade do código.
        11. Limitações: Enums não suportam herança e não podem conter métodos ou propriedades, embora você possa usar métodos de extensão para adicionar funcionalidade.
        12. Compatibilidade: Enums são compatíveis com outras estruturas de dados e podem ser usados em coleções, como listas e dicionários.
        13. Serialização: Enums podem ser facilmente serializados e desserializados, o que é útil para armazenamento e comunicação de dados.
        14. Performance: Como enums são tipos de valor, eles geralmente oferecem melhor desempenho em comparação com strings ou outros tipos de referência para representar conjuntos fixos de valores.
        15. Limitações de Valores: Embora você possa atribuir qualquer valor inteiro a um membro de enum, é importante garantir que os valores sejam únicos dentro do mesmo enum para evitar ambiguidades.
        16. Documentação: É recomendável documentar cada membro do enum para esclarecer seu propósito e uso dentro do contexto da aplicação.
        17. Integração com Switch: Enums são frequentemente usados em instruções switch para controlar o fluxo do programa com base no valor do enum.
        18. Compatibilidade com LINQ: Enums podem ser usados em consultas LINQ, facilitando a filtragem e manipulação de dados baseados em valores de enumeração.
        19. Atributos Personalizados: Você pode associar atributos personalizados aos membros do enum para fornecer metadados adicionais, como descrições ou valores de exibição.
        20. Evolução do Código: Ao adicionar novos membros a um enum, é importante considerar o impacto nas partes existentes do código que dependem do enum para evitar quebras inesperadas.
        21. Convenções de Nomenclatura: Siga as convenções de nomenclatura do C# ao nomear enums e seus membros, usando PascalCase para melhorar a consistência e legibilidade do código.
        22. Enum vs Constantes: Use enums quando tiver um conjunto fixo de valores relacionados, em vez de usar constantes individuais, para melhorar a organização e clareza do código.
        23. Limitações de Tamanho: Embora enums possam ter muitos membros, é importante considerar o tamanho e a complexidade do enum para evitar dificultar a manutenção do código.
        24. Compatibilidade com Outras Linguagens: Ao trabalhar em projetos que envolvem múltiplas linguagens de programação, considere como os enums serão representados e utilizados em cada linguagem para garantir compatibilidade.
        25. Testabilidade: Enums podem facilitar a testabilidade do código, permitindo que você crie testes unitários claros e concisos baseados em valores de enumeração.
        26. Ferramentas de Desenvolvimento: Muitas ferramentas de desenvolvimento e IDEs oferecem suporte aprimorado para trabalhar com enums, incluindo autocompletar e refatoração.
        27. Performance em Comparações: Comparar valores de enumeração é geralmente mais eficiente do que comparar strings, o que pode ser benéfico em cenários de desempenho crítico.
        28. Uso em APIs: Enums são frequentemente usados em APIs para representar estados, tipos ou categorias, facilitando a comunicação entre diferentes partes do sistema.
        29. Limitações de Serialização: Ao serializar enums, especialmente em formatos como JSON ou XML, é importante considerar como os valores serão representados e garantir que a serialização e desserialização sejam tratadas corretamente.
        30. Evolução do Enum: Ao modificar um enum existente, como adicionar ou remover membros, é importante considerar a compatibilidade retroativa e o impacto nas partes do código que dependem do enum.       
        31. Enum Genéricos: Embora C# não suporte enums genéricos diretamente,  você pode usar técnicas como classes genéricas com propriedades de enumeração para alcançar funcionalidade semelhante.
        32. Enum Aninhados: Você pode definir enums dentro de classes ou estruturas para limitar seu escopo e melhorar a organização do código.
        33. Enum e Reflection: Você pode usar reflexão para inspecionar enums em tempo de execução, permitindo operações dinâmicas baseadas em seus membros e valores.
        34. Enum e Internacionalização: Ao usar enums em aplicações multilíngues, considere como os valores serão apresentados ao usuário final e implemente mecanismos para suportar a internacionalização.
        35. Enum e Documentação Automática: Ferramentas de documentação automática podem extrair informações sobre enums e seus membros, facilitando a criação de documentação técnica para desenvolvedores.        
        36. Enum e Performance de Memória: Embora enums sejam tipos de valor e geralmente eficientes em termos de memória, é importante considerar o impacto do uso extensivo de enums em grandes coleções ou estruturas de dados.
        37. Enum e Design de Software: Use enums como parte de um design de software mais amplo, ajudando a definir estados, comportamentos e interações dentro do sistema de forma clara e estruturada.
        38. Enum e Padrões de Projeto: Enums podem ser usados em conjunto   com padrões de projeto, como State ou Strategy, para representar diferentes estados ou comportamentos de objetos.
        39. Enum e Testes Automatizados: Ao criar testes automatizados, use enums para representar diferentes cenários e condições, facilitando a criação de casos de teste claros e compreensíveis.
        40. Enum e Boas Práticas de Codificação: Siga boas práticas de codificação ao trabalhar com enums, incluindo nomeação clara, documentação adequada e consideração cuidadosa do design e uso dentro do sistema.
        41. Enum e Evolução do Software: Considere como os enums podem evoluir ao longo do tempo à medida que o software cresce e muda, garantindo que eles permaneçam relevantes e úteis para o design do sistema.
        */
        enum EStatusRelModerno
        {
            Viuvo=13,
            Divorciado=12,
            Casado=11,
            Noivo=10,
            UniaoEstavel=9,
            RelacionamentoAberto=8,
            Solteiro=7,
            FicantePremium=6,
            Ficante=5,
            AmigoColorido=4,
            Contatinho=3,
            Conversante=2,
            Visualizante=1
        }

        /*
        explcação técnica de structs em C#.
        Structs em C# são tipos de valor que permitem agrupar dados relacionados em uma única unidade. Eles são definidos usando a palavra-chave 'struct' e são úteis para representar pequenos conjuntos de dados que não requerem a complexidade de uma classe. Structs são armazenados na pilha, o que pode oferecer vantagens de desempenho em comparação com classes, que são tipos de referência armazenados no heap. Eles podem conter campos, propriedades, métodos e construtores, mas não suportam herança. Structs são ideais para representar dados imutáveis ou pequenos objetos que serão frequentemente criados e destruídos.
        1. Definição de Structs: Em C#, uma struct é definida usando a palavra-chave 'struct' seguida pelo nome da struct e um bloco de código que contém seus membros.
        2. Tipo de Valor: Structs são tipos de valor, o que significa que eles são armazenados na pilha e copiados por valor quando atribuídos a uma nova variável ou passados como parâmetros para métodos.
        3. Membros: Structs podem conter campos, propriedades, métodos, construtores e eventos, permitindo encapsular dados e comportamentos relacionados.
        4. Construtores: Structs podem ter construtores personalizados, mas não podem ter um construtor padrão (sem parâmetros) definido pelo usuário, pois o compilador fornece um automaticamente.
        5. Imutabilidade: Embora structs possam ser mutáveis, é uma prática comum torná-los imutáveis para evitar problemas relacionados à cópia de valores.
        6. Sem Herança: Structs não suportam herança, o que significa que não podem derivar de outras structs ou classes, mas podem implementar interfaces.
        7. Uso de Structs: Structs são ideais para representar pequenos conjuntos de dados que não requerem a complexidade de uma classe, como pontos em um espaço 2D, cores ou coordenadas.
        8. Performance: Devido ao armazenamento na pilha, structs podem oferecer melhor desempenho em cenários onde muitos objetos pequenos são criados e destruídos rapidamente.
        9. Comparação: Structs são comparados por valor, o que significa que duas instâncias de uma struct são consideradas iguais se todos os seus campos tiverem os mesmos valores.
        10. Boxeamento e Desboxeamento: Quando uma struct é convertida para um tipo de referência (como 'object'), ocorre o boxeamento, o que pode impactar a performance. O desboxeamento é o processo inverso.
        11. Limitações: Structs têm algumas limitações, como não poderem ter um construtor padrão definido pelo usuário e não poderem ser nulos.
        12. Boas Práticas: É recomendável usar structs para tipos pequenos e simples, geralmente com menos de 16 bytes, para evitar problemas de desempenho relacionados ao boxeamento.
        */

        struct PessoaRelacioModerno
        {
            public PessoaRelacioModerno(EStatusRelModerno pStatusRelac)
            {
                this.pStatusRelac = pStatusRelac;
                Nome = string.Empty;   
                Idade = 0;
                genero = 'O';
            }
            public string Nome;
            public int Idade;
            public char genero; // M = Masculino, F = Feminino, O = Outro
            public EStatusRelModerno pStatusRelac;
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine($"\n\n\tHello!{Environment.NewLine} My name is IJDEV PRO.\n\tYou are welcome to this small app. Today we are going to experiment the usage of enum (enumerations) in C-Sharp programming language.");


            Console.Write("\n\n\t Digite seu NOME ::>>  ");
            var inputNome = Console.ReadLine() ?? string.Empty;

            Console.Write("\n\n\t Informe sua IDADE ::>>  ");
            var inputIdade = Console.ReadLine() ?? string.Empty;
            int idade = Convert.ToInt32(inputIdade);

            Console.Write("\n\n\t Informe seu GÊNERO (M/F/O) ::>>  ");
            var inputGenero = Console.ReadLine() ?? string.Empty;
            char genero = string.IsNullOrEmpty(inputGenero) ? 'O' : inputGenero[0];

            Console.Write("\n\n\t Informe UM NÚMERO DE 1 A 13 ::>>  ");
            var inputStatus = Console.ReadLine() ?? string.Empty;

            int statusNumero = Convert.ToInt32(inputStatus);
            EStatusRelModerno statusRelac = (EStatusRelModerno)statusNumero;
            var pessoa1 = new PessoaRelacioModerno(statusRelac);
            pessoa1.Nome = inputNome;
            pessoa1.Idade = idade;
            pessoa1.genero = genero;

            Console.WriteLine("\n\n\t Agora, vamos exibir as informações que você forneceu:\n");

            Console.WriteLine($"\n\n\t Olá, {pessoa1.Nome}! Como está hoje?");
            Console.WriteLine($"\n\t Você tem {pessoa1.Idade} anos de idade e seu gênero é '{pessoa1.genero}'.");
            Console.WriteLine($"\n\t Seu status de relacionamento é: {pessoa1.pStatusRelac}.");
            Console.WriteLine($"\n\t Seu código de status de relacionamento: {(int)pessoa1.pStatusRelac}");   
            

            // ------------------------ FIM DE APP ---------------------------

            Console.Write($"{Environment.NewLine}\nPressione qualquer tecla para sair...");

            Console.ReadKey(true);

            Console.Write("\n\n\n==================== FIM DE APP ====================\n\n\n\n");

        }
    }
}

