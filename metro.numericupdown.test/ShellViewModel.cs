using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace metro.numericupdown.test
{
    public class ShellViewModel : BindableBase
    {
        public ShellViewModel()
        {
            Pages = new ObservableCollection<PageViewModel>
            {
                new PageViewModel
                {
                    Name = "Page 1",
                },
                new PageViewModel
                {
                    Name = "Page 2"
                },
            };
        }

        public ObservableCollection<PageViewModel> Pages { get; }
    }
}
