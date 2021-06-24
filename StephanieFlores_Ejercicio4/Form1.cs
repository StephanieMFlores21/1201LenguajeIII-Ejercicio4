using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StephanieFlores_Ejercicio4
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NomEdadcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ARREGLO DE NOMBRES
            string[] nombres = new string[5];

            foreach (var items in nombres)
            {
                //NomEdadcomboBox.Items.Add(items);
                
                NomEdadcomboBox.Items.Add(NombretextBox.ToString());
            }
            
              //NomEdadcomboBox.Items.Add(nombres[index].ToString());
              //nombres[] = Convert.ToString(NombretextBox.Text);
            

            //ARREGLO DE EDADES
            int[] edades = new int[6];

            for (int i = 1; i < edades.Length; i++)
            {
                NomEdadcomboBox.Items.Add(edades[i]);
                //edades[i] = Convert.ToInt32(EdadtextBox.Text);
            }

           NomEdadcomboBox.Items.Add("Nombre: " + nombres + " / Edad: " + edades);
           
        }

        private void NombretextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EdadtextBox_TextChanged(object sender, EventArgs e)
        {
        
        }  
    }
}
