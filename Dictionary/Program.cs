
Dictionary<int, string> rookieOfTheYear  = new Dictionary<int, string>();

rookieOfTheYear.Add(1, "Mike Miller");
rookieOfTheYear.Add(2, "Jane Doe");
rookieOfTheYear.Add(3, "Jane Doe");
rookieOfTheYear.Add(4, "John Smith");


if(rookieOfTheYear.ContainsKey(1))
{
    Console.WriteLine(rookieOfTheYear[1]);
}
Console.WriteLine(rookieOfTheYear.FirstOrDefault(O=>O.Key == 1)) ;

//var a = rookieOfTheYear.FirstOrDefault(O => O.Key == 1);
//Console.WriteLine(rookieOfTheYear[a.Value]);


Dictionary<string, List<string>> wishList = new();

wishList.Add("Server Tombak", new List<string> { "Xbox", "Tesla","Kebappp" });
wishList.Add("Someone Who", new List<string> { "PS5", "bmw", "Pizza" });



foreach (var (Key,value) in wishList)
{
    Console.WriteLine($"{Key}'s wishlist:");
    foreach (var item in value)
    {
        Console.WriteLine($"\t{item}");
    }
}


Console.WriteLine(wishList["Server Tombak"][0]);

Console.WriteLine(wishList["Server Tombak"].Count);
wishList.Remove("Server Tombak");