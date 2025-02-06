using System;
//abstract
    class Baker
    {
        static void Main(string[] args)
        {
            Banana banana = new Banana();
            Regular regular = new Regular();
        }
    }
abstract class Bread 
{
    public void Line()
    {
    Console.WriteLine("good stuff!");
    }

}
class Banana:Bread
{
    public int rating = 10000;
}
class Regular:Bread
{
    public int rating = 5;
}