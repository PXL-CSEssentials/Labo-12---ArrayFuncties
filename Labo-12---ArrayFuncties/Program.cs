string[] namen = { "Peter", "Tom", "Piet", "Ahmed", "Benny", "Anna", "Jane", "Ali", "John", "Tom" };

//Deel 1
//Console.Write("Geef een naam: ");
//string searchName = Console.ReadLine();
//Console.WriteLine($"De naam \"{searchName}\" staat op plaats {Array.IndexOf(namen, searchName) + 1}.");
//Console.ReadLine();

//Deel 2
//Console.Write("Geef een letter: ");
//char searchLetter = Console.ReadLine()[0];
//string[] searchResult = Array.FindAll(namen, naam => naam.StartsWith(searchLetter));
//Console.Write($"Namen die beginnen met de letter \"{searchLetter}\": ");
//int counter = 0;
//foreach (string result in searchResult)
//{
//    counter++;
//    Console.Write(result);
//    if (counter < searchResult.Length)
//        Console.Write(", ");
//}
//Console.ReadLine();

//Deel 3
//bool isInputCorrect = false;
//int numberOne;
//int numberTwo;

//do
//{
//    Console.Write("Geef eerste getal: ");
//    isInputCorrect = int.TryParse(Console.ReadLine(), out numberOne);
//    if (isInputCorrect)
//        isInputCorrect = (numberOne > 0 && numberOne < namen.Length);
//} while (!isInputCorrect);

//do
//{
//    Console.Write("Geef tweede getal: ");
//    isInputCorrect = int.TryParse(Console.ReadLine(), out numberTwo);
//    if (isInputCorrect)
//        isInputCorrect = (numberTwo > 0 && numberTwo < namen.Length);
//} while (!isInputCorrect);

//Console.Write("Ongesorteerde array: ");
//ShowArray();
//Array.Sort(namen, numberOne, numberTwo);
//Console.WriteLine();
//Console.Write("Gesorteerde array: ");
//ShowArray();
//Console.ReadLine();


//void ShowArray()
//{
//    for (int i = 0; i < namen.Length; i++)
//    {
//        Console.Write(namen[i]);
//        if (i < namen.Length - 1)
//            Console.Write(", ");
//    }
//}