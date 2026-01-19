using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
// For binary serialization
using System.Runtime.Serialization.Formatters.Binary;
// XML
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;


namespace WinSerializeDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ClearAllTextBoxes()
        {
            foreach (Control item in this.Controls)
            { // "this" means form

                if (item.GetType() == typeof(TextBox))
                {
                    TextBox txtBox = (TextBox)item; // typecast
                    txtBox.Clear(); // smart coding
                    /// all the text boxes in the form will be cleared out
                    /// just by this code
                    /// Multiple lines of code won't to be written to 
                    /// clear out every text box one by one
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        


        private void btnSerialize_Click_1(object sender, EventArgs e)
        // we are fetching the data from text box to object
        {
            Employee emp1 = new Employee();

            emp1.ID = Convert.ToInt32(txtEmployeeID.Text);
            emp1.Name = (txtName.Text);
            emp1.Salary = Convert.ToInt32(txtSalary.Text);

            // Binary serialization
            FileStream fs = new FileStream(@"C:\Users\hp\Training\Day8\FileIoDemo\FileIoDemo\bin\Debug\net10.0\LPU\BinSerialize.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, emp1);

            ClearAllTextBoxes();
            fs.Close();
            MessageBox.Show("Record Added...");
            
        }


        private void btnDserialize_Click(object sender, EventArgs e)
        {
            // we are assigning the data from object to textbox


            FileStream fs = new FileStream(@"C:\Users\hp\Training\Day8\FileIoDemo\FileIoDemo\bin\Debug\net10.0\LPU\BinSerialize.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();

            Employee emp1 = (Employee) bf.Deserialize(fs);
            txtEmployeeID.Text = emp1.ID.ToString();
            txtName.Text = emp1.Name;
            txtSalary.Text = emp1.Salary.ToString();
            fs.Close();
        }


        /// <summary>
        /// For XML serialization
        /// </summary>
        
        private void button3_Click(object sender, EventArgs e)
        {
            Employee emp1 = new Employee();

            emp1.ID = Convert.ToInt32(txtEmployeeID.Text);
            emp1.Name = (txtName.Text);
            emp1.Salary = Convert.ToInt32(txtSalary.Text);

            // XML serialization
            FileStream fs = new FileStream(@"C:\Users\hp\Training\Day8\FileIoDemo\FileIoDemo\bin\Debug\net10.0\LPU\XMLSerialize.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            xs.Serialize(fs, emp1);
            fs.Close();
            ClearAllTextBoxes();
            MessageBox.Show("Record Added!!!");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            FileStream fs = new FileStream(@"C:\Users\hp\Training\Day8\FileIoDemo\FileIoDemo\bin\Debug\net10.0\LPU\XMLSerialize.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Employee));

            Employee emp1 = (Employee)xs.Deserialize(fs);
            txtEmployeeID.Text = emp1.ID.ToString();
            txtName.Text = emp1.Name;
            txtSalary.Text = emp1.Salary.ToString();
            fs.Close();
        }

        ///SOAP serialization
        /// just like Binary serialization in terms of sensitive information

        private void btnSOAPSerialization_Click(object sender, EventArgs e)
        {
            Employee emp1 = new Employee();

            emp1.ID = Convert.ToInt32(txtEmployeeID.Text);
            emp1.Name = (txtName.Text);
            emp1.Salary = Convert.ToInt32(txtSalary.Text);

            // SOAP serialization
            FileStream fs = new FileStream(@"C:\Users\hp\Training\Day8\FileIoDemo\FileIoDemo\bin\Debug\net10.0\LPU\SoapSerialize.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            SoapFormatter sf = new SoapFormatter();
            sf.Serialize(fs, emp1);

            ClearAllTextBoxes();
            fs.Close();
            MessageBox.Show("Record Added...");
        }

        private void btnSOAPDeserialization_Click(object sender, EventArgs e)
        {

            FileStream fs = new FileStream(@"C:\Users\hp\Training\Day8\FileIoDemo\FileIoDemo\bin\Debug\net10.0\LPU\SoapSerialize.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            SoapFormatter sf = new SoapFormatter();

            Employee emp1 = (Employee)sf.Deserialize(fs);
            txtEmployeeID.Text = emp1.ID.ToString();
            txtName.Text = emp1.Name;
            txtSalary.Text = emp1.Salary.ToString();
            fs.Close();
        }
    }
}
