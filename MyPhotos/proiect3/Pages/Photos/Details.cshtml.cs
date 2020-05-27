using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReference1;

namespace proiect3.Photos
{
    public class DetailsModel : PageModel
    {
        public IItemsService serviceDetail;
        public MyItems curentItem;


        public DetailsModel(IItemsService service)
        {
            this.serviceDetail = service;
        }
        public async Task<IActionResult> OnGet(int ?Id)
        {
            if (Id == null)
                return NotFound();
            else
            {   
                this.curentItem = await serviceDetail.GetItemByIdAsync(Id.Value);
            }
            if (this.curentItem == null)
            {
                return NotFound();

            }
            else
                return Page();

        }
    }
}
