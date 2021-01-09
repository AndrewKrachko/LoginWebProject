using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoginWebProject.Pages
{
    public class PrivatePageModel : PageModel
    {
        public IEnumerable<int> Array { get; set; }
        public int MinInt { get; set; }
        public int MaxInt { get; set; }

        public void OnGet()
        {
            Array = from dbNumber in UserDb.GetNumbers()
                    select dbNumber;
            MinInt = Array.Min();
            MaxInt = Array.Max();
        }
    }
}
