using System.Collections.Generic;
using System.Threading.Tasks;
using Facade;
using Pages;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;

namespace Abc.Soft.Areas.Quantity.Pages.Measures
{
    public class IndexModel : MeasuresPage
    {
        public IndexModel(IMeasuresRepository r) : base(r) { }

        public async Task OnGetAsync()
        {
            var l = await data.Get();
            Items = new List<MeasureView>();

            foreach (var e in l) { Items.Add(MeasureViewFactory.Create(e)); }
        }
    }
}
