using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listview_task
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            string surname = surnameInput.Text;
            string age = ageInput.Text;

            if(name == "" || surname == "" || age == "") {
                MessageBox.Show("Fill all inputs");
            }
            else if (int.TryParse(age, out int ageInt))
            {

                Person person = new Person(nameInput.Text, surnameInput.Text, ageInt);

                ListViewItem item = new ListViewItem(person.Name);
                item.SubItems.Add(person.Surname);
                item.SubItems.Add(person.Age.ToString());

                listView.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Age must be a number");
            }
        }

        private void editPersonButton_Click(object sender, EventArgs e)
        {

            if(listView.CheckedItems.Count == 0)
            {
                MessageBox.Show("Didn't select any row");
            }
            else if(listView.CheckedItems.Count > 1)
            {
                MessageBox.Show("Selected more than one row");
            }
            else
            {
                ListViewItem item = listView.CheckedItems[0];

                string name = nameEditInput.Text;
                string surname = surnameEditInput.Text;
                string age = ageEditInput.Text;

                if (name == "" || surname == "" || age == "")
                {
                    MessageBox.Show("Fill all inputs");
                }
                else if (int.TryParse(age, out int ageInt)) { 
                    item.SubItems[0].Text = name;
                    item.SubItems[1].Text = surname;
                    item.SubItems[2].Text = age;
                }
                else
                {
                    MessageBox.Show("Age must be a number");
                }
            }

        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person(string firstName, string lastName, int age)
        {
            Name = firstName;
            Surname = lastName;
            Age = age;
        }
    }
}
