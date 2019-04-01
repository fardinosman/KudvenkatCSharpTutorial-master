using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _54_Reflection_Example_Windows_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_TypeInfo_Click(object sender, EventArgs e)
        {
            try
            {

        
            listBox_Methods.Items.Clear();
            listBox_properties.Items.Clear();
            listBox_Constructors.Items.Clear();
            string typeName = textBox_TypeName.Text;

            Type T = Type.GetType(typeName);

            MethodInfo[] methodInfos = T.GetMethods();

            foreach (var methods in methodInfos)
            {
                listBox_Methods.Items.Add(methods.ReturnType.Name +" " + methods.Name);
            }

            PropertyInfo[] properties = T.GetProperties();

            foreach (var props in properties)
            {
                listBox_properties.Items.Add( props.PropertyType.Name+" "+props.Name);
            }
            ConstructorInfo[] conStrInfos = T.GetConstructors();

            foreach (var constructor in methodInfos)
            {
                listBox_Constructors.Items.Add( constructor.ToString());
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Wrong Namespace and class" + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox_Methods.Items.Clear();
            listBox_properties.Items.Clear();
            listBox_Constructors.Items.Clear();

        }
    }
}
