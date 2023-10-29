using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp.Pages
{
    public class CategoriesModel : PageModel
    {
        public List<Category> Categories { get; set; } = new();

        public void OnGet(int skip=0, int take=25)
        {
            // n�o temos acesso � vari�veis de dentro do m�todo Get
            //await Task.Delay(1000);

            var temp = new List<Category>();
            for (int i = 0; i <= 100; i++)
            {
                temp.Add(
                    new Category(
                    id: i,
                    Title: $"Categoria {i}",
                    Price: i * 18.95m));
            }
            Categories = temp.Skip(skip).Take(take).ToList();
        }

        public record Category(
            int id,
            string Title,
            decimal Price
        );
    }
}
