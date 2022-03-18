using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiForm {
    class Superhero : Person, IFlyable {

        private Citizen _Identity;
        private string _Color;

        public Superhero():this("Bob") {
            //FirstName = "Bob";
            //LastName = "Awesome";
            //Color = "Black";
            FavoriteFood = "Bland";
        }

        public Superhero(string fName):this(fName, "Awesome", "Black") {
            //FillData(fName,"Smith","Gray");
            FavoriteFood = "Pizza";
        }

        public Superhero(string fName, string lName, string custColor)
            :base(fName,lName){
            //FirstName = fName;
            //LastName = lName;
            Colors = custColor;
            FavoriteFood = "Tacos";
        }

        //private void FillData(string fNamer, string lNamer, string cColor) {

        //}


        public Citizen Identity {
            get { return _Identity; }
            set { _Identity = value; }
        }

        public string Colors {
            get { return _Color; }
            set { _Color = value; }
        }


        public override string Shout() {
            return "Yay";
        }

        public override string ToString() {
            return "Super " + base.ToString();
        }

        public string Fly() {
            return "Up up and Away";
        }

        public string Land() {
            return "I hits the ground";
        }

        public void AddPassengers (int number) {

        }


        public static Superhero operator +(Superhero h, Citizen c) {
            // shallow copy
            h.Identity = c;
            return h;
        }

        public static Superhero operator +( Citizen c , Superhero h) {
            // deep copy -- cloning
            Superhero newSup = new Superhero();
            newSup.FirstName = h.FirstName;
            newSup.LastName = h.LastName;
            newSup.DateOfBirth = h.DateOfBirth;
            newSup.FavoriteFood = h.FavoriteFood;
            newSup.Identity = c;

            return newSup;
        }
    }
}
