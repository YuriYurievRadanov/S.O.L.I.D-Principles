using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D
{
    public class ValidationException : ApplicationException { }

    public class JsonValidator
    {
        public bool IsValid(string input)
        {
            return true;
        }
    }

    public class JsonFormatter
    {
        private JsonValidator _validator = new JsonValidator();

        public string Format(string input)
        {
            if (!_validator.IsValid(input))
                throw new ValidationException();

            return "formatted text!";
        }
    }
}
