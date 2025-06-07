using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestMyApp.WebApp.Pages
{
    public class CheckPrimeModel : PageModel
    {
        [BindProperty]
        public int Number { get; set; }

        public string ResultMessage { get; set; }

        public void OnPost()
        {
            if (Number < 2)
            {
                ResultMessage = $"{Number} is not a prime number.";
                return;
            }

            for (int i = 2; i <= Math.Sqrt(Number); i++)
            {
                if (Number % i == 0)
                {
                    ResultMessage = $"{Number} is not a prime number.";
                    return;
                }
            }

            ResultMessage = $"{Number} is a prime number.";
        }
    }
}
