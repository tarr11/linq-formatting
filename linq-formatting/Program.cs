using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            var foo = new Foo();
            var result = foo.Bars
        .OrderBy(s => s.Baz)
            .Select(s => s.Baz);

        }
    }

    public class Foo
    {
        public ICollection<Bar> Bars { get; set; }

    }

    public class Bar
    {
        public string Baz { get; set; }

    }


}
