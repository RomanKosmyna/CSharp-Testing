public class TestsInitialization
{
    public List<Test> ListOfTests { get; set; }

    public TestsInitialization()
    {
        ListOfTests = [];

        // test #1
        Test test1 = new();
        test1.AddQuestion("Which of the following methods is an entry point in the C# console program?");

        test1.AddOption(1, "public static void Program()");
        test1.AddOption(2, "public static void Main()");
        test1.AddOption(3, "public static void main()");
        test1.AddOption(4, "None of the above");

        test1.AddCorrectOption(2, "public static void Main()");

        ListOfTests.Add(test1);

        // test #2
        Test test2 = new();
        test2.AddQuestion("Which of the followings are value types in C#?");

        test2.AddOption(1, "Int32");
        test2.AddOption(2, "Double");
        test2.AddOption(3, "Decimal");
        test2.AddOption(4, "All of the above");

        test2.AddCorrectOption(4, "All of the above");

        ListOfTests.Add(test2);
        // test #3
        Test test3 = new();
        test3.AddQuestion("What is the nullable type in C#?");

        test3.AddOption(1, "It allows assignment of null to reference type.");
        test3.AddOption(2, "It allows assignment of null to value type.");
        test3.AddOption(3, "It allows assignment of null to static class.");
        test3.AddOption(4, "None of the above");

        test3.AddCorrectOption(2, "It allows assignment of null to value type.");

        ListOfTests.Add(test3);
        // test #4
        Test test4 = new();
        test4.AddQuestion("Struct is a _____.");

        test4.AddOption(1, "Reference type");
        test4.AddOption(2, "Value type");
        test4.AddOption(3, "Class type");
        test4.AddOption(4, "String type");

        test4.AddCorrectOption(2, "Value type");

        ListOfTests.Add(test4);
        //test #5
        Test test5 = new();
        test5.AddQuestion("Which of the following datatype can be used with enum?");

        test5.AddOption(1, "int");
        test5.AddOption(2, "string");
        test5.AddOption(3, "boolean");
        test5.AddOption(4, "All of the above");

        test5.AddCorrectOption(1, "int");

        ListOfTests.Add(test5);
        // test #6
        Test test6 = new();
        test6.AddQuestion("Which of the following type escapes type checking at compile-time; instead, it resolves type at run time?");

        test6.AddOption(1, "dynamic");
        test6.AddOption(2, "var");
        test6.AddOption(3, "undefined");
        test6.AddOption(4, "null");

        test6.AddCorrectOption(1, "dynamic");

        ListOfTests.Add(test6);
        //test #7
        Test test7 = new();
        test7.AddQuestion("Which of the following generic constraints restricts the generic type parameter to an object of the class that implements IEnumerable interface?");

        test7.AddOption(1, "class Processor<T> where T: class: IEnumerable");
        test7.AddOption(2, "class Processor<T> T: interface IEnumerable");
        test7.AddOption(3, "class Processor<T> where T: IEnumerable");
        test7.AddOption(4, "class Processor<T> where T: new()");

        test7.AddCorrectOption(3, "class Processor<T> where T: IEnumerable");

        ListOfTests.Add(test7);
    }
}