using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp.Pages
{
    public class IndexModel : PageModel
    {
        public List<Category> Categories { get; set; } = new();

        public async Task<IActionResult> OnGet()
        {
            // n�o temos acesso � vari�veis de dentro do m�todo Get

            //await Task.Delay(1000);
            for (int i = 0; i <= 100; i++)
            {
                Categories.Add(
                    new Category(
                    id: i,
                    Title: $"Categoria {i}",
                    Price: i*18.95m));
            }
            return Page();
        }

        public record Category (
            int id,
            string Title,
            decimal Price
        );

        public void OnPost()
        {
        }
    }
}
