using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiForm {
    class Witch :Person {

        private Broom _Broom;

        public Witch(string fname, string lName) : base(fname, lName) {

        }

        public Broom Broom {
            get { return _Broom; }
            set { _Broom = value; }
        }

        public override string ToString() {
            return FirstName + " " + LastName;
        }


    }
}
