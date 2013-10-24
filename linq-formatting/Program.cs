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
            // this sample app uses the default auto-formatting option
            var foo = new Foo();
            var result = foo.Bars
                // why is OrderBy outdented here?  
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
