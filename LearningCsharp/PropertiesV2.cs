/*

C# Properties (Get and Set)
-----------------------------
1 - Properties and Encapsulation
Before we start to explain properties, you should have a basic understanding of "Encapsulation".

The meaning of Encapsulation, is to make sure that "sensitive" data is hidden from users. To achieve this, you must:
    - declare fields/variables as private
    - provide public get and set methods, through properties, to access and update the value of a private field

2 - Properties
You learned from the previous chapter that private variables can only be accessed within the same class (an outside class has no access to it). However, sometimes we need to access them - and it can be done with properties.

A property is like a combination of a variable and a method, and it has two methods: a get and a set method:

Example explained : class Person
The Name property is associated with the name field. It is a good practice to use the same name for both the property and the private field, but with an uppercase first letter.

The get method returns the value of the variable name.

The set method assigns a value to the name variable. The value keyword represents the value we assign to the property.

If you don't fully understand it, take a look at the example below.

Now we can use the Name property to access and update the private field of the Person class:

Now we can use the Name property to access and update the private field of the Person class: see class PersonWithProperties

3- Why Encapsulation?
    - Better control of class members (reduce the possibility of yourself (or others) to mess up the code)
    - Fields can be made read-only (if you only use the get method), or write-only (if you only use the set method)
    - Flexible: the programmer can change one part of the code without affecting other parts
    - Increased security of data

*/

namespace LearningCsharp
{

    class Personv2
    {
        private string name;         // private field

        public string Name           // property
        {
            get { return name; }     // get method
            set { name = value; }    // set method
        }
    }


    class PersonWithPropertiesv2
    {
        private string name;         // private field
        // private int age;          // private field

        public string Name           // property
        {
            get { return name; }     // get method
            set { name = value; }    // set method
        }

        // automatic property
        public int Age { get; set; }
        
        public char Gender { get; set; }  
    }

    public class Propertiesv2
    {
        public static void Main05(string[] args)
        {

            #region bloco introdução: ------------- INICIO APP ----------------
            Console.Write("\n===================================================\n\n");
            Console.WriteLine($"ESTUDANDO PROPORTIES EM C#!\nMAIN CLASSE:  Properties\nAUXILIAR CLASS 01: PersonV2\nAUXILIAR CLASS 02 : PersonWithPropertiesV2");
            Console.Write("\n===================================================\n\n");
            #endregion

            #region bloco de código da app

            PersonWithPropertiesv2 myObj3 = new PersonWithPropertiesv2();

            myObj3.Name = "Mr. presi Obama";
            myObj3.Age = 62;
            myObj3.Gender='M';
            Console.WriteLine($"\n\nPERSON NAME IS :  {myObj3.Name}");
            Console.WriteLine($"\nPERSON AGE IS : {myObj3.Age}");
            Console.WriteLine($"\nPERSON GENDER IS : {myObj3.Gender}");
            #endregion

            #region bloco ---------------- FIM DE APP --------------------
            Console.Write($"{Environment.NewLine}\nPressione qualquer tecla para sair ...  ");

            Console.ReadKey(true);

            Console.Write("\n\n\n==================== FIM DE APP ====================\n\n\n\n");
            #endregion
        }
    }

}