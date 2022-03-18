using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiForm {
    class Node {
        private string _Text;

        public Node Next;


        public string Text {
            get { return _Text; }
            set { _Text = value; }
        }

    }
}
