using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServiceReference1;

namespace proiect3.Photos
{
    public class IndexModel : PageModel
    {
        public IItemsService serviceItems;
        public List<MyItems> ItemsPhoto;
        [BindProperty(SupportsGet = true)]
        public string Word { get; set; }
        
        public SelectList CuvantCheie { get; set; }
        public string[] CuvinteCheie =
        {
            "Nume","extensie"
        };
        [BindProperty(SupportsGet = true)]
        public string CuvantFilter { get; set; }

        public IndexModel(IItemsService service)
        {
            this.serviceItems = service;
            this.CuvantCheie = new SelectList(CuvinteCheie);
        }
        public async Task OnGetAsync()
        {
            if (string.IsNullOrEmpty(Word))
                this.ItemsPhoto = await serviceItems.GetItemsAsync();
            else if (CuvantFilter =="Nume")
                
            {
                this.ItemsPhoto = SearchItems(Word, await serviceItems.GetItemsAsync());
                    }
            else
            {
                this.ItemsPhoto = SearchItemsExtension(Word, await serviceItems.GetItemsAsync());
            }
        }
        public List<MyItems> SearchItems(string Cautare, List<MyItems> list)
        {
            
            return list.Where(i => i.IName.Contains(Cautare)).ToList();

        }


        public List<MyItems> SearchItemsExtension(string Cautare, List<MyItems> list)
        {

            return list.Where(i => i.IType.Contains(Cautare)).ToList();

        }
    }
}
