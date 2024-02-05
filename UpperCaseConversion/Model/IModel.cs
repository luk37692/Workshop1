using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperCaseConversion.Model
{
    public interface IModel
    {
        string Text { get; set; }
        event EventHandler TextChanged;
    }
}
