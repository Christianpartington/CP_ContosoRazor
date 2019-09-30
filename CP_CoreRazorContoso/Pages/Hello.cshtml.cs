using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CP_CoreRazorContoso.Pages
{
    public class HelloModel : PageModel
    {
        public string Name { get; set; }
        public void OnGet()
        {
            Name = null;
        }

        public void OnPost()
        {
            this.Name = Request.Form ["Name"];
        }
    }
}