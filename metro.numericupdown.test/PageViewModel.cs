using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace metro.numericupdown.test
{
    public class PageViewModel : BindableBase
    {
        public string Name { get; set; }

        public byte Address { get; set; }
    }
}
