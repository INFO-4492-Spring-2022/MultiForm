using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiForm {
    class SpaceShip : IFlyable {
        private string _Title;
        //private Engine _Motor;
        private List<Person> _Passengers = new List<Person>();

        public string Title {
            get { return _Title; }
            set { _Title = value; }
        }


        public string Fly() {
            return "Zoom Zoom";
        }

        public string Land() {
            return "Landing gear down";
        }

        void IFlyable.AddPassengers(int people) {
            // Added people to ship.
            for (int i = 0; i < people; i++) {
                _Passengers.Add(new Citizen("Person",i.ToString()));
            }
        }
    }
}
