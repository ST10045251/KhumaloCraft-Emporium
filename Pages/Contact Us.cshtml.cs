using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ST10045251_POE_PART1.Pages
{
    public class Contact_UsModel : PageModel
    {
        public bool hasData = false;
        public string firstName = "";
        public string lastName = "";
        public string message = "";
        public void OnGet()
        {
        }
        public void OnPost()
        {
            hasData = true;
            firstName = Request.Form["firstname"];
            lastName = Request.Form["lastname"];
            message = Request.Form["message"];
        }
    }
}