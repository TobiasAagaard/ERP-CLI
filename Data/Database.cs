using System.ComponentModel;

namespace ErpCli.Data
{
    public partial class Database
    {
        public static Database Instance { get;} = new Database();
    }
}