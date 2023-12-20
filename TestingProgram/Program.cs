List<Dictionary<int, string>> listOfOptions = [];

Dictionary<int, string> firstOption = new()
{
    {1, "33" }
};

Dictionary<int, string> secondOption = new()
{
    {2, "4" }
};

Dictionary<int, string> thirdOption = new()
{
    {3, "3" }
};

Dictionary<int, string> fourthOption = new()
{
    {4, "5" }
};

listOfOptions.Add(firstOption);
listOfOptions.Add(secondOption);
listOfOptions.Add(thirdOption);
listOfOptions.Add(fourthOption);

Dictionary<int, string> correctOption = new()
{
    { 2, "4" }
};

Console.WriteLine("Скільки дорівнює 2 + 2?");

// екземпляр класу
Test testInstance = new Test(listOfOptions, correctOption);

// відображаю варіанти відповідей
testInstance.LogAllOptions();

// приймаю варіант відповіді
string answer = Console.ReadLine();
// відображаю результат
testInstance.RunTest(answer);