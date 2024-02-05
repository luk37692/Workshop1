using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperCaseConversion.ViewModel
{
    public interface IViewModel : INotifyPropertyChanged
    {
        string UpperCaseText { get; set; }
        void ProcessText(string input);
    }
}
