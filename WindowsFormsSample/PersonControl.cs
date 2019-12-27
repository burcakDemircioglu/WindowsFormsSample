using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSample
{
    public partial class PersonControl : UserControl
    {
        private Person _person;

        public PersonControl()
        {
            InitializeComponent();

            _person = new Person();
        }

        internal Person Person { 
            get {
                _person.FirstName = FirstNameTextBox.Text;
                _person.LastName = LastNameTextBox.Text;
                Int32.TryParse(AgeTextBox.Text, out _person.Age);
                return _person;
            }
            set {
                FirstNameTextBox.Text = _person.FirstName;
                LastNameTextBox.Text = _person.LastName;
                AgeTextBox.Text = _person.Age.ToString();
                _person = value; 
            } 
        }
    }
}
