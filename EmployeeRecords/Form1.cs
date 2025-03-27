using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace CharacterRecords
{
    public partial class mainForm : Form
    {
        List<Character> characterList = new List<Character>();

        public mainForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        { 
            ClearLabels();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
           
        }

        private void listButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearLabels()
        {
            nameInput.Text = "";
            classInput.Text = "";
            levelInput.Text = "";
            healthInput.Text = "";
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        public void loadDB()
        {
            
        }

        public void saveDB()
        {

        }
    }
}
