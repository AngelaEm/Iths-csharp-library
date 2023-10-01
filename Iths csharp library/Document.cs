using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iths_csharp_library
{
    internal abstract class Document
    {
        //Fields
        private string _title;
        private string _author;

        public string Title { get { return _title; } set { _title = value; } }
        public string Author { get { return _author; } set { _author = value; } }

    }
}
