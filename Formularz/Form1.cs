using System.Text.RegularExpressions;
using System.Windows.Forms.VisualStyles;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.CompilerServices;
using Pracownicy;
namespace Formularz
{
    public partial class Form1 : Form
    {
        List<Pracownik> listaPracownikow;

        public Form1()
        {
            InitializeComponent();
            listaPracownikow = new List<Pracownik>();
        }



        // if sender text == "" ,
        // if sender text contains number,
        // if sender text has multi words
        // if text other than letters
        // if text too long
        // default box values?
        // array of objects created
        // fix class
        // packing and unpacking to do
        // default class values maybe
        // lock some box choices and add some 
        // load and save buttons
        // add button functionality
        // make the box on the right show loaded objects
        protected void textBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox? currentTextBox = (sender as TextBox);
            if (currentTextBox != null)
            {
                if (currentTextBox.Text == "")
                {
                    ErrorProvider.SetError(currentTextBox, "This field can't be empty");
                }
                else
                {
                    if (!Regex.IsMatch(currentTextBox.Text, @"^[a-zA-Z]+$"))
                    {
                        ErrorProvider.SetError(currentTextBox, "Field can't contain special characters, whitespaces or numbers");
                    }
                    else
                    {
                        ErrorProvider.SetError(currentTextBox, null);
                    }
                }
            }

        }



        private bool ValidateAllButtons()
        {
            if (ErrorProvider.GetError(ImieBox) == "" &&
                ErrorProvider.GetError(NazwiskoBox) == "" &&
                ErrorProvider.GetError(DataBox) == "" &&
                ErrorProvider.GetError(PensjaBox) == "" &&
                ErrorProvider.GetError(StanowiskoBox) == "" &&
                ErrorProvider.GetError(opcja1) == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // "Add" Button
        private void button1_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            string radioButtonSelected = RadioButtons_Validator();

            if (ValidateAllButtons() == true)
            {
                Pracownik temp = new Pracownik(ImieBox.Text, NazwiskoBox.Text, ((double)PensjaBox.Value), DataBox.Value.Date, StanowiskoBox.Text, radioButtonSelected);
                this.listaPracownikow.Add(temp);
                this.dataGridView.Rows.Add(temp.name, temp.surname, temp.dateOfBirth.ToShortTimeString(), temp.salary, temp.position, temp.contractType);
            }

        }

        private void PensjaBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            NumericUpDown? NumericBox = sender as NumericUpDown;
            if (NumericBox.Value == 0)
            {
                ErrorProvider.SetError(NumericBox, "Provide a proper value (value>0)");
            }
            else
            {
                ErrorProvider.SetError(NumericBox, null);
            }
        }

        private void StanowiskoBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ComboBox? comboBox = sender as ComboBox;
            if (comboBox.SelectedItem == null)
            {
                ErrorProvider.SetError(comboBox, "You have to select your position");
            }
            else
            {
                ErrorProvider.SetError(comboBox, null);
            }

        }

        private void DataBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DateTimePicker? datePicker = sender as DateTimePicker;
            DateTime todayDate = DateTime.Today.Date;
            if (datePicker.Value.Date.Equals(todayDate))
            {
                ErrorProvider.SetError(datePicker, "You can't have been born just now");
            }
            else if (datePicker.Value.Date > todayDate)
            {
                ErrorProvider.SetError(datePicker, "Are you from the future?");
            }
            else
            {
                ErrorProvider.SetError(datePicker, null);
            }
        }
        private string RadioButtons_Validator()
        {
            string checkedOption = "";
            if (opcja1.Checked)
            {
                checkedOption = opcja1.Text;
            }
            else if (opcja2.Checked)
            {
                checkedOption = opcja2.Text;
            }
            else if (opcja3.Checked)
            {
                checkedOption = opcja3.Text;
            }
            else
            {
                ErrorProvider.SetError(opcja1, "You have to select one of the options");
                return "";
            }
            ErrorProvider.SetError(opcja1, null);
            return checkedOption;
        }

        //deserialize
        private void button3_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Pracownik>));
            using (TextReader reader = new StreamReader("pracownicy.xml"))
            {
                listaPracownikow = (List<Pracownik>)serializer.Deserialize(reader);
            }
            this.dataGridView.Rows.Clear();
            foreach (Pracownik pracownik in listaPracownikow)
            {
                this.dataGridView.Rows.Add(pracownik.name, pracownik.surname, pracownik.dateOfBirth.ToShortTimeString(), pracownik.salary, pracownik.position, pracownik.contractType);
            }
        }

        // serialize
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = "txt";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;

                MessageBox.Show("File saved at: " + filePath);

            }

            SaveState state = new SaveState();
            state.SaveEmployeesToTxtFile(this.listaPracownikow, "pracownicytxt.txt");
        }
    }
}
