using apbd_cw2.inheritance;

{
    int number = 10;
    string text = "Text: " + number + ".";
    string textWithDollar = $"TEst: {number}.";

    var k = "test";

    //Nullable
    int? nullableInt = null;
    nullableInt = 10;
    Object? o = null;
}

//Kolekcje
{
    var list = new List<int>();
    list.Add(10);
    
    var dict = new Dictionary<string, int>();
    dict.Add("text", 10);
}

{

    try
    {
        throw new Exception();
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
    }


    A a = new A(1);
    A b = new B(1, 2);
    
    a.DoSomething();
    b.DoSomething();

}