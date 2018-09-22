using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kuasoft
{
    public partial class Form1 : Form
    {
        Sections mySec = new Sections();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mySec.iniReader();
        }

        private void button2_Click(object sender, EventArgs e)// get sections
        {
            List<Sections> secList = mySec.GetSections();
            listboxSectionsList.Items.Clear();
            listboxSectionsList.Items.Add("Sections");
            listboxSectionsList.Items.Add(" ");
            for (int i = 0; i < secList.Count; i++)
            {
                listboxSectionsList.Items.Add(secList[i].name);
            }

        }

        private void retrieveInput_Click(object sender, EventArgs e)// get Subsections
        {
            string sectionName = this.textBoxSectionNameForGetSubSections.Text;
            listboxSubSectionList.Items.Clear();
            listboxSubSectionList.Items.Add("Subsections of " + sectionName + "\n");
            listboxSubSectionList.Items.Add(" ");
            List<string> subSecList = mySec.GetSubSections(sectionName);
            for (int i = 0; i < subSecList.Count; i++)
            {
                listboxSubSectionList.Items.Add(subSecList[i]);
            }
        }

        private void retriavalValue_Click(object sender, EventArgs e)// get subsections value
        {
            string sectionName = this.textboxSectionNameForGetValue.Text;
            string subSectionName = this.textboxSubSectionNameForGetValue.Text;
            char type = Convert.ToChar(this.textboxReturnTypeForGetValue.Text);
            textboxResultSubSectionValue.Text = mySec.GetValue(sectionName, subSectionName, type);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonForSetSubsectionValueMethod_Click(object sender, EventArgs e)
        {
            string sectionName = this.textBoxtextBoxUserInputSectionNameForSetValue.Text;
            string subsectionName = this.textBoxtextBoxUserInputSubsectionNameForSetValue.Text;
            string value = this.textBoxtextBoxUserInputNewValueForSetValue.Text;
            mySec.setSubSectionValue(sectionName, subsectionName, value);
        }

    }
}
