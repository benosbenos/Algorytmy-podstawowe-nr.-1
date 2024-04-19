class Program
{
    static Sort sort = new Sort();
    public static void Main()
    {
        List<int> tablica = new List<int>();

        for (int i = 0; i < 11; i++ )  {
            Console.WriteLine("podaj liczbe do tablicy która potem będzie uporządkowana");
            tablica.Add(int.Parse(Console.ReadLine()));
        
        }
        sort.sort(tablica);
        Console.WriteLine("posortowana tablica");
        sort.wypiszTablice(tablica);
    }

}