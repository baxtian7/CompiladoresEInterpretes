using System.Text.RegularExpressions;

namespace CompiladoresEInterpretes.Domain
{
    public class Validator
    {
        public bool IsStringValid(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }

            if (!Regex.IsMatch(name, @"^[a-zA-Z0-9]+$"))
            {
                return false;
            }

            return true;
        }
    }
}
