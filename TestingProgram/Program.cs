//TestRunner.Run();

Test test1 = new();
Test.AddQuestion("Which of the following methods is an entry point in the C# console program?");

test1.AddOption(1, "public static void Program()");
test1.AddOption(2, "public static void Main()");
test1.AddOption(3, "public static void main()");
test1.AddOption(4, "None of the above");

test1.AddCorrectOption(2, "public static void Main()");

Test.RunTest();

Console.ReadKey();