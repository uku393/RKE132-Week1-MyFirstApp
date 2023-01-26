//This is a comment to my code

//rakendus küsib kasutajal sisestada tema nime
//rakendus tervitab kasutajat nimepidi

Console.WriteLine("Sisesta oma nimi:");               //Output
//string - sõne
string userName = Console.ReadLine();                 //Input

Console.WriteLine("Tere" + ", " + userName + "!");    //Output

//string interpolation
Console.WriteLine($"Tere, {userName}!");              //Output