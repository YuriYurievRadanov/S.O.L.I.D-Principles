using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D.OpenClosed
{
    public abstract class PrettyFormatProvider
    {
        public abstract string Format(string input);
    }

    public class JsonFormatter : PrettyFormatProvider
    {
        private JsonValidator _validator = new JsonValidator();

        public override string Format(string input)
        {

            if (!_validator.IsValid(input))
                throw new ValidationException();

            return "formatted text!";
        }
    }

    public class HtmlFormatter : PrettyFormatProvider
    {
        private HtmlValidator _validator = new HtmlValidator();

        public override string Format(string input)
        {

            if (!_validator.IsValid(input))
                throw new ValidationException();

            return "formatted text!";
        }
    }
}
