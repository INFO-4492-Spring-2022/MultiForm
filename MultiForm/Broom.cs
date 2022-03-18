using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiForm {
    class Broom : IFlyable {

        private Witch _Owner;
        private String _Color;

        public Broom(Witch own, string color) {
            _Owner = own;
            _Owner.Broom = this;
            this._Color = color;
        }


        public Witch Owner {
            get { return _Owner; }
            set { _Owner = value; }
        }


        public string Fly() {
            return "Swoosh";
        }

        public string Land() {
            return "Screeeeech";
        }

        public void AddPassengers(int witches) {

        }

        public override string ToString() {
            return _Color + " Broom";
        }


    }
}
