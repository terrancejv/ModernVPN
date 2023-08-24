using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernVPN.MVVM.ViewModel
{
    internal class ProtectionViewModel
    {
        public ObservableCollection<ServerModel> MyProperty { get; set; }
        public ProtectionViewModel()
        {
            
        }
    }
}
