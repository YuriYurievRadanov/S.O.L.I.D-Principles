using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D.SingleResponsibility
{
    internal class Wrong
    {
        public class JsonFormatter
        {
            public string Format(string input)
            {
                if (!IsInputValid(input))
                    throw new ValidationException();

                return "formatted text!";
            }

            private bool IsInputValid(string input)
            {
                return true;
            }
        }
    }
}
