using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRental
{
    public static class TextWriterFactory
    {
        static TextWriter textWriter;

        internal static TextWriter GetTextWriter(string path)
        {
            if (textWriter != null)
                return textWriter;

            return new StreamWriter(path, true);
        }

        public static void SetTextWriter(TextWriter mockWriter)
        {
            textWriter = mockWriter;
        }
    }
}
