using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D.InterfaceSegregation
{
    public interface IPrettyFormatValidator1
    {
        bool IsValid(string input);
    }
    public interface IPrettyFormatSchemaValidator : IPrettyFormatValidator1
    {
        string Schema { get; set; }
    }

    public class XmlValidator1 : IPrettyFormatValidator1
    {
        public bool IsValid(string input)
        {
            return true;
        }
    }

    public class XmlSchemaValidator1 : IPrettyFormatSchemaValidator
    {
        public string Schema { get; set; }

        public bool IsValid(string input)
        {
            return true;
        }
    }
}
