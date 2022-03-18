using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiForm {
    abstract class Person {
        #region Private Variables
        private string _FirstName;
        private string _LastName;
        private string _FavoriteFood;
        private DateTime _DateOfBirth;
        #endregion

        //public Person():this("steve","perry") { }

        public Person(string fstName, string lstName) {
            _FirstName = fstName;
            _LastName = lstName;
        }



        #region Properties

        public string FirstName {
            get {
                return _FirstName;
            }
            set {
                _FirstName = value.ToUpper();
            }
        }

        public string LastName {
            get {
                return _LastName;
            }
            set {
                _LastName = value;
            }
        }

        public string FavoriteFood {
            get {
                return _FavoriteFood;
            }
            set {
                _FavoriteFood = value;
            }
        }

        public DateTime DateOfBirth {
            get {
                return _DateOfBirth;
            }
            set {
                _DateOfBirth = value;
            }
        }

        #endregion

        #region Public Methods

        public virtual string Shout() {
            return "Hey!";
        }

        public override string ToString() {
            return this.FirstName + " " + this.LastName;
        }

        #endregion


        // Shape  --- Abstract Concept
        //    ---> Triangle
        //    ---> Pentagon
        //    ---> Square


    }
}
