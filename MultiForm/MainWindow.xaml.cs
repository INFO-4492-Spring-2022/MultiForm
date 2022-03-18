using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MultiForm {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
            FillPeople();
            GetOther();

            // int[] nums = { 42, 16, 71, 38, 7, 25, 37, 16, 99 };

            //tbNames.Text = nums.Count().ToString() + "\n";
            //tbNames.Text += nums.Max().ToString() + "\n";
            //tbNames.Text += nums.Average().ToString() + "\n";

            //var evens = nums.Where(n => n % 2 == 0);
            //var odds = nums.Where(n => n % 2 == 1);
            //tbNames.Text += "evens: ";
            //foreach (int n in evens) {
            //    tbNames.Text += n.ToString() + ",";
            //}
            //tbNames.Text += "\n";

            //tbNames.Text += "odds: ";
            //for (int ndx = 0; ndx < odds.Count(); ndx++) {
            //    tbNames.Text += odds.ElementAt(ndx).ToString() + ",";
            //}
            //tbNames.Text += "\n";

            //tbNames.Text = Universe.placeOfParty.Members.Max(chr => chr.FirstName).ToString();

            //var aPeople = Universe.placeOfParty.Members.Where(per => per.FirstName.ToLower().Contains("a"))
            //    .OrderByDescending(per => per.LastName);

            ////    tbNames.Text += "A names: ";
            ////foreach (Person p in aPeople) {
            ////    tbNames.Text += p.FirstName + ", ";

            ////}

            //var bPeople = from person in Universe.placeOfParty.Members
            //              where person.FirstName.ToLower().Contains("b")
            //              orderby person.LastName descending
            //              select person.LastName;


            //tbNames.Text += "A names: ";
            //foreach (string ln in bPeople) {
            //    tbNames.Text += ln + ", ";

            //}


        }

        private void GetOther() {
            //Person batman = Universe.placeOfParty.Members.First(
            //    per => per.FirstName == "Bruce" && per.LastName == "Wayne"
            //    );

            Person batman = Universe.placeOfParty.Members.FirstOrDefault(
                per => per.FirstName == "Brucey" && per.LastName == "Wayne"
                );

            if (batman != null) {
                tbNames.Text = "" + batman;
            } else {
                tbNames.Text = "no batman found";
            }


        }

        private void FillPeople() {
            Universe.placeOfParty.Add(new Superhero("Bruce", "Wayne", "Black"));
            Universe.placeOfParty.Add(new Citizen("Alfred", "Pennyworth"));
            Universe.placeOfParty.Add(new Villian("Lex", "Luther"));
            Universe.placeOfParty.Add(new Citizen("Harry", "Houdini"));
            Universe.placeOfParty.Add(new Citizen("Jane", "Waterwood"));
            Universe.placeOfParty.Add(new Citizen("Celina", "Kyle"));
            Universe.placeOfParty.Add(new Superhero("Wonder", "Woman", "Red"));
            Universe.placeOfParty.Add(new Superhero("Robin", "Wonder", "Green"));
        }

        private void btnShowOther_Click(object sender, RoutedEventArgs e) {
            // show a different form
            // MessageBox.Show("I will open a form.");
            OtherForm frm = new OtherForm("Sub form here.");
            //frm.ShowDialog();
            frm.Show();
            this.Close();
            string formText = frm.txtName.Text;
            //MessageBox.Show("I opened the form with " + formText);
        }

        private void btnShowPeople_Click(object sender, RoutedEventArgs e) {
            tbNames.Text = "";
            foreach (Person per in Universe.placeOfParty.Members) {
                tbNames.Text += per.FirstName + "\n";
            }
        }
    }
}
