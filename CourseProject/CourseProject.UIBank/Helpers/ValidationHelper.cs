using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CourseProject.UIBank.Helpers
{
    public class ValidationHelper
    {
        private readonly ErrorProvider _errorProvider;

        public ValidationHelper(ErrorProvider errorProvider)
        {
            _errorProvider = errorProvider;
        }

        public bool CheckForEmpty(TextBox textBox)
        {
            if (String.IsNullOrEmpty(textBox.Text))
            {
                _errorProvider.SetError(textBox, "Can not be empty");
                return false;
            }

            return true;
        }

        public bool CheckForRegex(TextBox textBox, string pattern, string errorMessage)
        {
            if (Regex.IsMatch(textBox.Text, pattern))
            {
                _errorProvider.SetError(textBox, errorMessage);
                return false;
            }

            return true;
        }

        public bool CheckForLength(TextBox textBox, int length)
        {
            if (textBox.Text.Length > length)
            {
                _errorProvider.SetError(textBox, String.Format("Length can't be more than {0}", length));
                return false;
            }

            return true;
        }

        public void SetEmptyMessageForErrorProvider(TextBox textBox)
        {
            _errorProvider.SetError(textBox, String.Empty);
        }
    }
}
