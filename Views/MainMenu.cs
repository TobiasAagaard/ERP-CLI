using TECHCOOL.UI;
namespace ErpCli.Views
{
    public class MainMenu : Screen
    {
        public override string Title { get; set; } = "LNE Security ";
        protected override void Draw()
        {
            Menu menu = new Menu();

            menu.Add(new ProductListPage());

            Display(menu);
        }
    }
}