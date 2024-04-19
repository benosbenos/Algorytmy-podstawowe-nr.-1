
public class Sort
{

    /**************************************
     * nazwa funkcji:        <sort>*
     * parametry wejściowe: <nazwa parametru> -<co przechowuje>*
     * wartość zwracana:     <co zwraca funkcja–opis>*
     * autor:                <Mikołaj Wieczorek 3D>* 
     **************************************/
    public void sort(List<int> tablica)
    {
        int n = tablica.Count;

        // One by one move boundary of unsorted subarray
        for (int i = 0; i < n - 1; i++)
        {
            // Find the minimum element in unsorted array
            int min_idx = i;
            for (int j = i + 1; j < n; j++)
                if (tablica[j] < tablica[min_idx])
                    min_idx = j;

            // Swap the found minimum element with the first
            // element
            int temp = tablica[min_idx];
            tablica[min_idx] = tablica[i];
            tablica[i] = temp;
        }
    }

    // Prints the array

    /**************************************
     * nazwa funkcji:        <wypiszTablice>*
     * parametry wejściowe: <nazwa parametru> -<co przechowuje>*
     * wartość zwracana:     <co zwraca funkcja–opis>*
     * autor:                <Mikołaj Wieczorek 3D>* 
     **************************************/
    public void wypiszTablice(List<int> tablica)
    {
        int n = tablica.Count;
        for (int i = 0; i < n; ++i)
            Console.Write(tablica[i] + " ");
        Console.WriteLine();
    }

    // Driver code 

    /**************************************
     * nazwa funkcji:        <Main>*
     * parametry wejściowe: <nazwa parametru> -<co przechowuje>*
     * wartość zwracana:     <co zwraca funkcja–opis>*
     * autor:                <Mikołaj Wieczorek 3D>* 
     **************************************/

}

