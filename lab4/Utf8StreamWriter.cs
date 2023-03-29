
using System.Text;

namespace lab4
{
    public class Utf8StreamWriter : StreamWriter
    {
        public Utf8StreamWriter(Stream stream) : base(stream)
        {
        }

        public override Encoding Encoding => Encoding.UTF8;
    }
}