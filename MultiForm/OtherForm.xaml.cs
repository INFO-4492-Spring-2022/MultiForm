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
using System.Windows.Shapes;

namespace MultiForm {
    /// <summary>
    /// Interaction logic for OtherForm.xaml
    /// </summary>
    public partial class OtherForm : Window {
        private string magic = "Hocus Pocus";
        
        public OtherForm() {
            InitializeComponent(); // builds all of the form objects
        }

        public OtherForm(string startingText) {
            InitializeComponent(); // builds all of the form objects
            tbOne.Text = startingText;
        }

        private void btnClickMe_Click(object sender, RoutedEventArgs e) {
            tbOne.Text = "Found me.";

        }

        private void btnMakeMore_Click(object sender, RoutedEventArgs e) {
            OtherForm frm = new OtherForm();
            frm.Show();
        }

        private void btnCloseMe_Click(object sender, RoutedEventArgs e) {
            MainWindow mW = new MainWindow();
            mW.Show();
            this.Close();
        }

        private void btnAddPerson_Click(object sender, RoutedEventArgs e) {
            Citizen cit = new Citizen(txtName.Text,"Added");
            Universe.placeOfParty.Add(cit);
        }

        private void btnGetOut_Click(object sender, RoutedEventArgs e) {
            Application.Current.Shutdown();
        }
    }
}
