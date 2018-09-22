using System;

namespace Kuasoft
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonGetSectionsMethod = new System.Windows.Forms.Button();
            this.textBoxSectionNameForGetSubSections = new System.Windows.Forms.TextBox();
            this.buttonGetSubSectionsMethod = new System.Windows.Forms.Button();
            this.textboxSectionNameForGetValue = new System.Windows.Forms.TextBox();
            this.textboxSubSectionNameForGetValue = new System.Windows.Forms.TextBox();
            this.textboxReturnTypeForGetValue = new System.Windows.Forms.TextBox();
            this.buttonGetSubsectionValueMethod = new System.Windows.Forms.Button();
            this.textBoxUserInformationForInput = new System.Windows.Forms.TextBox();
            this.textBoxUserInformationForInputSectionName = new System.Windows.Forms.TextBox();
            this.textBoxUserInformationForInputSubSectionName = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buttonForExitApplication = new System.Windows.Forms.Button();
            this.listboxSectionsList = new System.Windows.Forms.ListBox();
            this.listboxSubSectionList = new System.Windows.Forms.ListBox();
            this.textboxResultSubSectionValue = new System.Windows.Forms.TextBox();
            this.textBoxUserInformationSectionNameForInputSetValue = new System.Windows.Forms.TextBox();
            this.textBoxtextBoxUserInputSectionNameForSetValue = new System.Windows.Forms.TextBox();
            this.buttonForSetSubsectionValueMethod = new System.Windows.Forms.Button();
            this.textBoxtextBoxUserInputSubsectionNameForSetValue = new System.Windows.Forms.TextBox();
            this.textBoxtextBoxUserInputNewValueForSetValue = new System.Windows.Forms.TextBox();
            this.textBoxUserInformationSubsectionNameForInputSetValue = new System.Windows.Forms.TextBox();
            this.textBoxUserInformationvalueForInputSetValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonOpenFile.Location = new System.Drawing.Point(-2, 1);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(292, 47);
            this.buttonOpenFile.TabIndex = 1;
            this.buttonOpenFile.Text = "Open File";
            this.buttonOpenFile.UseVisualStyleBackColor = false;
            this.buttonOpenFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonGetSectionsMethod
            // 
            this.buttonGetSectionsMethod.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonGetSectionsMethod.Location = new System.Drawing.Point(126, 54);
            this.buttonGetSectionsMethod.Name = "buttonGetSectionsMethod";
            this.buttonGetSectionsMethod.Size = new System.Drawing.Size(164, 23);
            this.buttonGetSectionsMethod.TabIndex = 2;
            this.buttonGetSectionsMethod.Text = "Get Sections";
            this.buttonGetSectionsMethod.UseVisualStyleBackColor = false;
            this.buttonGetSectionsMethod.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxSectionNameForGetSubSections
            // 
            this.textBoxSectionNameForGetSubSections.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxSectionNameForGetSubSections.Location = new System.Drawing.Point(126, 83);
            this.textBoxSectionNameForGetSubSections.Name = "textBoxSectionNameForGetSubSections";
            this.textBoxSectionNameForGetSubSections.Size = new System.Drawing.Size(164, 20);
            this.textBoxSectionNameForGetSubSections.TabIndex = 3;
            // 
            // buttonGetSubSectionsMethod
            // 
            this.buttonGetSubSectionsMethod.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonGetSubSectionsMethod.Location = new System.Drawing.Point(126, 109);
            this.buttonGetSubSectionsMethod.Name = "buttonGetSubSectionsMethod";
            this.buttonGetSubSectionsMethod.Size = new System.Drawing.Size(164, 23);
            this.buttonGetSubSectionsMethod.TabIndex = 4;
            this.buttonGetSubSectionsMethod.Text = "Get SubSections";
            this.buttonGetSubSectionsMethod.UseVisualStyleBackColor = false;
            this.buttonGetSubSectionsMethod.Click += new System.EventHandler(this.retrieveInput_Click);
            // 
            // textboxSectionNameForGetValue
            // 
            this.textboxSectionNameForGetValue.BackColor = System.Drawing.SystemColors.Info;
            this.textboxSectionNameForGetValue.Location = new System.Drawing.Point(126, 138);
            this.textboxSectionNameForGetValue.Name = "textboxSectionNameForGetValue";
            this.textboxSectionNameForGetValue.Size = new System.Drawing.Size(164, 20);
            this.textboxSectionNameForGetValue.TabIndex = 5;
            // 
            // textboxSubSectionNameForGetValue
            // 
            this.textboxSubSectionNameForGetValue.BackColor = System.Drawing.SystemColors.Info;
            this.textboxSubSectionNameForGetValue.Location = new System.Drawing.Point(126, 164);
            this.textboxSubSectionNameForGetValue.Name = "textboxSubSectionNameForGetValue";
            this.textboxSubSectionNameForGetValue.Size = new System.Drawing.Size(164, 20);
            this.textboxSubSectionNameForGetValue.TabIndex = 6;
            // 
            // textboxReturnTypeForGetValue
            // 
            this.textboxReturnTypeForGetValue.BackColor = System.Drawing.SystemColors.Info;
            this.textboxReturnTypeForGetValue.Location = new System.Drawing.Point(126, 190);
            this.textboxReturnTypeForGetValue.MaxLength = 1;
            this.textboxReturnTypeForGetValue.Name = "textboxReturnTypeForGetValue";
            this.textboxReturnTypeForGetValue.Size = new System.Drawing.Size(164, 20);
            this.textboxReturnTypeForGetValue.TabIndex = 7;
            // 
            // buttonGetSubsectionValueMethod
            // 
            this.buttonGetSubsectionValueMethod.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonGetSubsectionValueMethod.Location = new System.Drawing.Point(126, 216);
            this.buttonGetSubsectionValueMethod.Name = "buttonGetSubsectionValueMethod";
            this.buttonGetSubsectionValueMethod.Size = new System.Drawing.Size(164, 23);
            this.buttonGetSubsectionValueMethod.TabIndex = 8;
            this.buttonGetSubsectionValueMethod.Text = "Get SubSection Value";
            this.buttonGetSubsectionValueMethod.UseVisualStyleBackColor = false;
            this.buttonGetSubsectionValueMethod.Click += new System.EventHandler(this.retriavalValue_Click);
            // 
            // textBoxUserInformationForInput
            // 
            this.textBoxUserInformationForInput.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxUserInformationForInput.Location = new System.Drawing.Point(-2, 83);
            this.textBoxUserInformationForInput.Name = "textBoxUserInformationForInput";
            this.textBoxUserInformationForInput.Size = new System.Drawing.Size(122, 20);
            this.textBoxUserInformationForInput.TabIndex = 9;
            this.textBoxUserInformationForInput.Text = "Enter Section Name";
            // 
            // textBoxUserInformationForInputSectionName
            // 
            this.textBoxUserInformationForInputSectionName.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxUserInformationForInputSectionName.Location = new System.Drawing.Point(-2, 138);
            this.textBoxUserInformationForInputSectionName.Name = "textBoxUserInformationForInputSectionName";
            this.textBoxUserInformationForInputSectionName.Size = new System.Drawing.Size(122, 20);
            this.textBoxUserInformationForInputSectionName.TabIndex = 10;
            this.textBoxUserInformationForInputSectionName.Text = "Enter Section Name";
            this.textBoxUserInformationForInputSectionName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxUserInformationForInputSubSectionName
            // 
            this.textBoxUserInformationForInputSubSectionName.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxUserInformationForInputSubSectionName.Location = new System.Drawing.Point(-2, 164);
            this.textBoxUserInformationForInputSubSectionName.Name = "textBoxUserInformationForInputSubSectionName";
            this.textBoxUserInformationForInputSubSectionName.Size = new System.Drawing.Size(122, 20);
            this.textBoxUserInformationForInputSubSectionName.TabIndex = 11;
            this.textBoxUserInformationForInputSubSectionName.Text = "Enter Subsection Name";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox4.Location = new System.Drawing.Point(-2, 190);
            this.textBox4.MaxLength = 1;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(122, 20);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "Enter Return Type";
            // 
            // buttonForExitApplication
            // 
            this.buttonForExitApplication.BackColor = System.Drawing.SystemColors.WindowText;
            this.buttonForExitApplication.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonForExitApplication.Location = new System.Drawing.Point(319, 256);
            this.buttonForExitApplication.Name = "buttonForExitApplication";
            this.buttonForExitApplication.Size = new System.Drawing.Size(422, 116);
            this.buttonForExitApplication.TabIndex = 13;
            this.buttonForExitApplication.Text = "EXIT";
            this.buttonForExitApplication.UseVisualStyleBackColor = false;
            this.buttonForExitApplication.Click += new System.EventHandler(this.button3_Click);
            // 
            // listboxSectionsList
            // 
            this.listboxSectionsList.FormattingEnabled = true;
            this.listboxSectionsList.Location = new System.Drawing.Point(319, 1);
            this.listboxSectionsList.Name = "listboxSectionsList";
            this.listboxSectionsList.ScrollAlwaysVisible = true;
            this.listboxSectionsList.Size = new System.Drawing.Size(160, 238);
            this.listboxSectionsList.TabIndex = 14;
            // 
            // listboxSubSectionList
            // 
            this.listboxSubSectionList.FormattingEnabled = true;
            this.listboxSubSectionList.Location = new System.Drawing.Point(485, 1);
            this.listboxSubSectionList.Name = "listboxSubSectionList";
            this.listboxSubSectionList.ScrollAlwaysVisible = true;
            this.listboxSubSectionList.Size = new System.Drawing.Size(256, 238);
            this.listboxSubSectionList.TabIndex = 15;
            // 
            // textboxResultSubSectionValue
            // 
            this.textboxResultSubSectionValue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textboxResultSubSectionValue.Location = new System.Drawing.Point(-2, 245);
            this.textboxResultSubSectionValue.Name = "textboxResultSubSectionValue";
            this.textboxResultSubSectionValue.Size = new System.Drawing.Size(292, 20);
            this.textboxResultSubSectionValue.TabIndex = 16;
            // 
            // textBoxUserInformationSectionNameForInputSetValue
            // 
            this.textBoxUserInformationSectionNameForInputSetValue.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxUserInformationSectionNameForInputSetValue.Location = new System.Drawing.Point(-2, 271);
            this.textBoxUserInformationSectionNameForInputSetValue.Name = "textBoxUserInformationSectionNameForInputSetValue";
            this.textBoxUserInformationSectionNameForInputSetValue.Size = new System.Drawing.Size(122, 20);
            this.textBoxUserInformationSectionNameForInputSetValue.TabIndex = 17;
            this.textBoxUserInformationSectionNameForInputSetValue.Text = "Enter Section Name";
            // 
            // textBoxtextBoxUserInputSectionNameForSetValue
            // 
            this.textBoxtextBoxUserInputSectionNameForSetValue.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxtextBoxUserInputSectionNameForSetValue.Location = new System.Drawing.Point(126, 271);
            this.textBoxtextBoxUserInputSectionNameForSetValue.Name = "textBoxtextBoxUserInputSectionNameForSetValue";
            this.textBoxtextBoxUserInputSectionNameForSetValue.Size = new System.Drawing.Size(164, 20);
            this.textBoxtextBoxUserInputSectionNameForSetValue.TabIndex = 18;
            // 
            // buttonForSetSubsectionValueMethod
            // 
            this.buttonForSetSubsectionValueMethod.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonForSetSubsectionValueMethod.Location = new System.Drawing.Point(126, 349);
            this.buttonForSetSubsectionValueMethod.Name = "buttonForSetSubsectionValueMethod";
            this.buttonForSetSubsectionValueMethod.Size = new System.Drawing.Size(164, 23);
            this.buttonForSetSubsectionValueMethod.TabIndex = 19;
            this.buttonForSetSubsectionValueMethod.Text = "Set SubSection Value";
            this.buttonForSetSubsectionValueMethod.UseVisualStyleBackColor = false;
            this.buttonForSetSubsectionValueMethod.Click += new System.EventHandler(this.buttonForSetSubsectionValueMethod_Click);
            // 
            // textBoxtextBoxUserInputSubsectionNameForSetValue
            // 
            this.textBoxtextBoxUserInputSubsectionNameForSetValue.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxtextBoxUserInputSubsectionNameForSetValue.Location = new System.Drawing.Point(126, 297);
            this.textBoxtextBoxUserInputSubsectionNameForSetValue.Name = "textBoxtextBoxUserInputSubsectionNameForSetValue";
            this.textBoxtextBoxUserInputSubsectionNameForSetValue.Size = new System.Drawing.Size(164, 20);
            this.textBoxtextBoxUserInputSubsectionNameForSetValue.TabIndex = 20;
            // 
            // textBoxtextBoxUserInputNewValueForSetValue
            // 
            this.textBoxtextBoxUserInputNewValueForSetValue.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxtextBoxUserInputNewValueForSetValue.Location = new System.Drawing.Point(126, 323);
            this.textBoxtextBoxUserInputNewValueForSetValue.Name = "textBoxtextBoxUserInputNewValueForSetValue";
            this.textBoxtextBoxUserInputNewValueForSetValue.Size = new System.Drawing.Size(164, 20);
            this.textBoxtextBoxUserInputNewValueForSetValue.TabIndex = 21;
            // 
            // textBoxUserInformationSubsectionNameForInputSetValue
            // 
            this.textBoxUserInformationSubsectionNameForInputSetValue.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxUserInformationSubsectionNameForInputSetValue.Location = new System.Drawing.Point(-2, 297);
            this.textBoxUserInformationSubsectionNameForInputSetValue.Name = "textBoxUserInformationSubsectionNameForInputSetValue";
            this.textBoxUserInformationSubsectionNameForInputSetValue.Size = new System.Drawing.Size(122, 20);
            this.textBoxUserInformationSubsectionNameForInputSetValue.TabIndex = 22;
            this.textBoxUserInformationSubsectionNameForInputSetValue.Text = "Enter SubsectionName";
            // 
            // textBoxUserInformationvalueForInputSetValue
            // 
            this.textBoxUserInformationvalueForInputSetValue.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxUserInformationvalueForInputSetValue.Location = new System.Drawing.Point(-2, 323);
            this.textBoxUserInformationvalueForInputSetValue.Name = "textBoxUserInformationvalueForInputSetValue";
            this.textBoxUserInformationvalueForInputSetValue.Size = new System.Drawing.Size(122, 20);
            this.textBoxUserInformationvalueForInputSetValue.TabIndex = 23;
            this.textBoxUserInformationvalueForInputSetValue.Text = "Enter New Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 376);
            this.Controls.Add(this.textBoxUserInformationvalueForInputSetValue);
            this.Controls.Add(this.textBoxUserInformationSubsectionNameForInputSetValue);
            this.Controls.Add(this.textBoxtextBoxUserInputNewValueForSetValue);
            this.Controls.Add(this.textBoxtextBoxUserInputSubsectionNameForSetValue);
            this.Controls.Add(this.buttonForSetSubsectionValueMethod);
            this.Controls.Add(this.textBoxtextBoxUserInputSectionNameForSetValue);
            this.Controls.Add(this.textBoxUserInformationSectionNameForInputSetValue);
            this.Controls.Add(this.textboxResultSubSectionValue);
            this.Controls.Add(this.listboxSubSectionList);
            this.Controls.Add(this.listboxSectionsList);
            this.Controls.Add(this.buttonForExitApplication);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBoxUserInformationForInputSubSectionName);
            this.Controls.Add(this.textBoxUserInformationForInputSectionName);
            this.Controls.Add(this.textBoxUserInformationForInput);
            this.Controls.Add(this.buttonGetSubsectionValueMethod);
            this.Controls.Add(this.textboxReturnTypeForGetValue);
            this.Controls.Add(this.textboxSubSectionNameForGetValue);
            this.Controls.Add(this.textboxSectionNameForGetValue);
            this.Controls.Add(this.buttonGetSubSectionsMethod);
            this.Controls.Add(this.textBoxSectionNameForGetSubSections);
            this.Controls.Add(this.buttonGetSectionsMethod);
            this.Controls.Add(this.buttonOpenFile);
            this.Name = "Form1";
            this.Text = "s";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonGetSectionsMethod;
        private System.Windows.Forms.TextBox textBoxSectionNameForGetSubSections;
        private System.Windows.Forms.Button buttonGetSubSectionsMethod;
        private System.Windows.Forms.TextBox textboxSectionNameForGetValue;
        private System.Windows.Forms.TextBox textboxSubSectionNameForGetValue;
        private System.Windows.Forms.TextBox textboxReturnTypeForGetValue;
        private System.Windows.Forms.Button buttonGetSubsectionValueMethod;
        private System.Windows.Forms.TextBox textBoxUserInformationForInput;
        private System.Windows.Forms.TextBox textBoxUserInformationForInputSectionName;
        private System.Windows.Forms.TextBox textBoxUserInformationForInputSubSectionName;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button buttonForExitApplication;
        private System.Windows.Forms.ListBox listboxSectionsList;
        private System.Windows.Forms.ListBox listboxSubSectionList;
        private System.Windows.Forms.TextBox textboxResultSubSectionValue;
        private System.Windows.Forms.TextBox textBoxUserInformationSectionNameForInputSetValue;
        private System.Windows.Forms.TextBox textBoxtextBoxUserInputSectionNameForSetValue;
        private System.Windows.Forms.Button buttonForSetSubsectionValueMethod;
        private System.Windows.Forms.TextBox textBoxtextBoxUserInputSubsectionNameForSetValue;
        private System.Windows.Forms.TextBox textBoxtextBoxUserInputNewValueForSetValue;
        private System.Windows.Forms.TextBox textBoxUserInformationSubsectionNameForInputSetValue;
        private System.Windows.Forms.TextBox textBoxUserInformationvalueForInputSetValue;
    }
}

