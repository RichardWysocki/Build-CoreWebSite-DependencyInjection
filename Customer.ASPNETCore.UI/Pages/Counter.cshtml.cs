using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Customer.ASPNETCore.UI.Pages
{
    public class CounterModel : PageModel
    {
        public int Counter { get; set; }
        public void OnPost()
        {
            Counter++;
        }
    }
}
