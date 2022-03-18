using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiForm {
    class Lair {

        private List<Person> _Members;

        public Lair() {
            Members = new List<Person>();
        }

        public List<Person> Members {
            get {
                if(_Members == null) {
                    _Members = new List<Person>();
                }
                return _Members;
            }
            private set {
                _Members = value;
            }
        }

        public void Add(Person per) {
            Members.Add(per);
        }

    }
}
