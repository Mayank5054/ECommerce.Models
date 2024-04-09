using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Mvc.Rendering
{
    public class SelectionListItem
    {
        public SelectionListItem() { }
        public SelectionListItem(string text,int value) { }
    public string text {  get; set; }
        public int value { get; set; }
    }
}
