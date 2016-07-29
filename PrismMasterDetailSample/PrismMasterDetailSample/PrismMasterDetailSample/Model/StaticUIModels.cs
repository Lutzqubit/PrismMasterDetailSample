using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PrismMasterDetailSample.Model
{
    public class MasterPageItem
    {
        public string Title { get; set; }

        public string IconSource { get; set; }

        public string TargetType { get; set; }

        public Color Color { get; set; }

        public DelegateCommand<string> Command { get; set; }

        public string CommandParameter { get; set; }
    }
}
