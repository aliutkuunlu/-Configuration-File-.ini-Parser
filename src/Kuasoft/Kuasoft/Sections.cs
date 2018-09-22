using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kuasoft
{
    public class Sections
    {
        public String name;
        public Dictionary<string, string> subsections = new Dictionary<string, string>();
        public List<Sections> sections = new List<Sections>();
        OpenFileDialog ofd = new OpenFileDialog();
        StreamReader sr;

        public void iniReader()
        {
            
            int secCounter = 0;
            string line = "";
            bool endOfFile = false;

            ofd.Filter = "INI|*.ini";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                sr = new StreamReader(ofd.FileName);
                while (!endOfFile)
                {
                    line = sr.ReadLine();
                    if (line == "")
                    {
                        continue;
                    }
                    else if (line == null)
                    {
                        endOfFile = true;
                        continue;

                    }
                    else
                    {
                        string[] tokens = line.Split('=');
                        char c = tokens[0].FirstOrDefault();
                        if (c == '[')
                        {
                            sections.Add(new Sections());
                            sections[secCounter].name = tokens[0].Substring(1, tokens[0].Length - 2);
                            secCounter++;
                        }
                        else
                        {
                            sections[secCounter - 1].subsections.Add(tokens[0].Trim(), tokens[1].Trim());
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("File not found!!");
            }
        }
        public List<Sections> GetSections()
        {
            return sections;
        }

        public List<string> GetSubSections(string sectionName)
        {
            List<string> keyList = new List<string>();
            int controlList = 0;
            for (int i = 0; i < sections.Count; i++)
            {
                if (sections[i].name.Equals(sectionName))
                {
                    controlList = 1;
                    keyList = sections[i].subsections.Keys.ToList();
                    break;
                }
                else
                {
                    continue;
                }
            }

            if (controlList == 0)
            {
                MessageBox.Show("No Sections Found!!");
            }

            return keyList;
        }

        public string GetValue(string sectionName, string subSectionName, char c)
        {
            int controlList = 0;
            string result = null;

            for (int i = 0; i < sections.Count; i++)
            {
                if (sections[i].name.Equals(sectionName))
                {
                    controlList = 1;
                    Sections myObject = sections[i];

                    int dictControl = ControlDict(myObject.subsections, subSectionName);

                    if (dictControl == 1)
                    {
                        result = Executer(subSectionName, c, myObject.subsections);
                    }
                    else
                    {
                        MessageBox.Show("No subsections Found!!");
                    }

                    break;
                }
                else
                {
                    continue;
                }
            }

            if (controlList == 0)
            {
                MessageBox.Show("No Sections Found!!");
            }
            return result;
        }

        public void setSubSectionValue(string sectionName, string subSectionName, string value)
        {
            int controlList = 0;
            string result = null;

            for (int i = 0; i < sections.Count; i++)
            {
                if (sections[i].name.Equals(sectionName))
                {
                    controlList = 1;
                    Sections myObject = sections[i];

                    int dictControl = ControlDict(myObject.subsections, subSectionName);

                    if (dictControl == 1)
                    {
                        string oldValue = myObject.subsections[subSectionName];
                        string newValue = value;
                        
                        myObject.subsections[subSectionName] = newValue;
                        //replaceItem(ofd.FileName, oldValue, newValue);
                    }
                    else
                    {
                        MessageBox.Show("No subsections Found!!");
                    }

                    break;
                }
                else
                {
                    continue;
                }
            }

            if (controlList == 0)
            {
                MessageBox.Show("No Sections Found!!");
            }
            
        }     
        

        private string Executer(string subSectionName, char c, Dictionary<string, string> myDict)
        {
            string result;
            if (c == 'i' || c == 'I')
            {
                result = Convert.ToString(IntGetValue(myDict, subSectionName));
            }
            else if (c == 'd' || c == 'D')
            {
                result = Convert.ToString(DoubleGetValue(myDict, subSectionName));
            }
            else if (c == 's' || c == 'S')
            {
                result = StringGetValue(myDict, subSectionName);
            }
            else if (c == 'b' || c == 'B')
            {
                result = Convert.ToString(BooleanGetValue(myDict, subSectionName));
            }
            else
            {
                result = "Wrong return type...";
            }
            return result;

        }

        private int ControlDict(Dictionary<string, string> myDict, string subSectionName)
        {
            int dictControl = 0;
            foreach (string key in myDict.Keys)
            {
                if (key.Contains(subSectionName))
                {
                    dictControl = 1;
                    break;
                }
                else
                {
                    continue;
                }
            }

            return dictControl;
        }

        private int IntGetValue(Dictionary<string, string> myDict, string subSectionName)
        {
            try
            {
                int result = Convert.ToInt32(myDict[subSectionName]);
                return result;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Type can not convert to int..");
                return 0;
            }

        }

        private double DoubleGetValue(Dictionary<string, string> myDict, string subSectionName)
        {
            try
            {
                double result = Convert.ToDouble(myDict[subSectionName]);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Type can not convert to double..");
                return 0;
            }
        }

        private string StringGetValue(Dictionary<string, string> myDict, string subSectionName)
        {
            try
            {
                string result = myDict[subSectionName];
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Type can not convert to string..");
                return null;
            }

        }

        private Boolean BooleanGetValue(Dictionary<string, string> myDict, string subSectionName)
        {
            try
            {
                Boolean result = Convert.ToBoolean(myDict[subSectionName]);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Type can not convert to boolean..");
                return false;
            }

        }
    }
}
