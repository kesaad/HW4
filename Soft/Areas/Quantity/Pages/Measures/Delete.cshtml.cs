using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pages;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;

namespace Abc.Soft.Areas.Quantity.Pages.Measures
{
    public class DeleteModel : MeasuresPage
    {
        public DeleteModel(IMeasuresRepository r) : base(r) { }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null) return NotFound();

            Item = MeasureViewFactory.Create(await data.Get(id));

            if (Item == null) { return NotFound(); }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null) return NotFound();

            await data.Delete(id);

            return RedirectToPage("./Index");
        }
    }
}
