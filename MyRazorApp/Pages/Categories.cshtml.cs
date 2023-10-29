using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp.Pages
{
    public class CategoriesModel : PageModel
    {
        public List<Category> Categories { get; set; } = new();

        public void OnGet()
        {
            // não temos acesso à variáveis de dentro do método Get
            //await Task.Delay(1000);
            
            for (int i = 0; i <= 100; i++)
            {
                Categories.Add(
                    new Category(
                    id: i,
                    Title: $"Categoria {i}",
                    Price: i * 18.95m));
            }
            
        }

        public record Category(
            int id,
            string Title,
            decimal Price
        );
    }
}
