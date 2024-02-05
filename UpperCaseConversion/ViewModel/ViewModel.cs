using UpperCaseConversion.Model;

namespace UpperCaseConversion.ViewModel
{
    public class MainViewModel
    {
        private readonly UpperCaseModel _model;

        public MainViewModel()
        {
            _model = new UpperCaseModel();
        }

        public string GetUpperCaseString(string input)
        {
            return _model.ConvertToUpperCase(input);
        }
    }
}
