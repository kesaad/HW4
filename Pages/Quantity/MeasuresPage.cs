using System;
using System.Collections.Generic;
using Abc.Domain.Quantity;
using Facade;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pages
{
    public class MeasuresPage : PageModel
    {
        protected internal readonly IMeasuresRepository data;

        protected internal MeasuresPage(IMeasuresRepository r) => data = r;

        [BindProperty]
        public MeasureView Item { get; set; }

        public IList<MeasureView> Items { get; set; }
    }
}
