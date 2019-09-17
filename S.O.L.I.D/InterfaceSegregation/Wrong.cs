using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D.InterfaceSegregation
{
    public interface IPrettyFormatValidator
    {
        string Schema { get; set; }
        bool IsValid(string input);
    }

    public class JsonValidator : IPrettyFormatValidator
    {
        public string Schema { get; set; }
        public bool IsValid(string input)
        {
            return true;
        }
    }

    public class HtmlValidator : IPrettyFormatValidator
    {
        public string Schema { get; set; }
        public bool IsValid(string input)
        {
            return true;
        }
    }

    public class XmlValidator : IPrettyFormatValidator
    {
        public string Schema { get; set; }
        public bool IsValid(string input)
        {
            return true;
        }
    }

    public class XmlSchemaValidator : IPrettyFormatValidator
    {
        public string Schema { get; set; }

        public bool IsValid(string input)
        {
            return true;
        }
    }
}
