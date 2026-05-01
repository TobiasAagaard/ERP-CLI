namespace ErpCli.Utils
{
    public class Search
    {
        public void SearchByParameter<T>(List<T> list, string SearchPropety)
        {
            Console.Write($"Søge efter {SearchPropety}");
            string SearchTerm = Console.ReadLine() ?? string.Empty;
            List<T> SearchResults = list.Where(x => x.GetType().GetProperty(SearchPropety)?.GetValue(x)?.ToString() == SearchTerm).ToList();
            if (SearchResults.Count > 0)
            {
                Console.WriteLine($"Fandt {SearchResults.Count} resultater:");
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