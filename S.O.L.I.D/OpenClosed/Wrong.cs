using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D.OpenClosed
{
    public class PrettyFormatter
    {
        public enum FormatTypes
        {
            Json,
            Html
        }

        private JsonFormatter _jsonFormatter = new JsonFormatter();
        private HtmlFormatter _htmlFormatter = new HtmlFormatter();

        public string Format(FormatTypes inputType, string input)
        {
            switch (inputType)
            {
                case FormatTypes.Json:
                    return _jsonFormatter.Format(input);
                case FormatTypes.Html:
                    return _htmlFormatter.Format(input);
                default:
                    throw new Exception("unsupported format type!");
            }
        }
    }
}
