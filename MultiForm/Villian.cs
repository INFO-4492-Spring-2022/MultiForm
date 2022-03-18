using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiForm {
    class Villian : Person, IFlyable {
        private string _Minion;

        public Villian(string firName, string lasName)
            : base(firName, lasName) { 
        }


        public string Minion{
            get { return _Minion; }
            set { _Minion = value; }
        }


        public override string Shout() {
            return "You dirty rascal";
        }

        public override string ToString() {
            return "Bad guy";
        }
        public string Fly() {
            return "To the moon!";
        }

        public string Land() {
            return "Look out below";
        }

        public void AddPassengers(int lvl) {

        }


    }
}
