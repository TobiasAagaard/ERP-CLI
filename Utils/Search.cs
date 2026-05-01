namespace ErpCli.Utils
{
    public class Search
    {
        public void SearchByParameter<T>(List<T> list, string searchParameter)
        {
            Console.Write($"Søge efter {searchParameter}");
        }
    }
}