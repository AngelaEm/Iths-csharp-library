using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iths_csharp_library
{
    internal abstract class LibraryUser
    {
        // Fields
        private int _id;
        private string _name;

        public LibraryUser(int id, string name)
        {
            _id = id;
            _name = name;
        }


        // Properties

        public int Id
        {
            get { return _id; }
            private set { _id = value; }

        }

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        public virtual void IssueBook()
        {

        }

    }
}
