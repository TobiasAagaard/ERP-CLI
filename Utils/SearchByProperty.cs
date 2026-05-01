namespace ErpCli.Utils
{
    public class Search
    {
        public void SearchByProperty<T>(List<T> list, string SearchProperty)
        {
            Console.Write($"Søge efter {SearchProperty}");
            string SearchTerm = Console.ReadLine() ?? string.Empty;
            List<T> SearchResults = list.Where(x => x?.GetType().GetProperty(SearchProperty)?.GetValue(x)?.ToString() == SearchTerm).ToList();
            if (SearchResults.Count > 0)
            {
                foreach (T result in SearchResults)
                {
                    Console.WriteLine(result);
                }
            }
            else
            {
                Console.WriteLine($"Ingen resultater fundet gå ind i  menu for at oprette ny .");
            }
        }
    }
}