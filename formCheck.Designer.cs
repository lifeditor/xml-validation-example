namespace XmlCheck
{
    partial class formCheck
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCheck = new System.Windows.Forms.Button();
            this.tbXmlFile = new System.Windows.Forms.TextBox();
            this.tbXsdFile = new System.Windows.Forms.TextBox();
            this.buttonOpenXmlFile = new System.Windows.Forms.Button();
            this.buttonOpenXsdFile = new System.Windows.Forms.Button();
            this.sfDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.labelXmlName = new System.Windows.Forms.Label();
            this.labelXsdName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(21, 152);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(270, 23);
            this.buttonCheck.TabIndex = 0;
            this.buttonCheck.Text = "Проверить";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheckClick);
            // 
            // tbXmlFile
            // 
            this.tbXmlFile.Location = new System.Drawing.Point(21, 43);
            this.tbXmlFile.Name = "tbXmlFile";
            this.tbXmlFile.Size = new System.Drawing.Size(526, 20);
            this.tbXmlFile.TabIndex = 1;
            // 
            // tbXsdFile
            // 
            this.tbXsdFile.Location = new System.Drawing.Point(21, 103);
            this.tbXsdFile.Name = "tbXsdFile";
            this.tbXsdFile.Size = new System.Drawing.Size(526, 20);
            this.tbXsdFile.TabIndex = 2;
            // 
            // buttonOpenXmlFile
            // 
            this.buttonOpenXmlFile.Location = new System.Drawing.Point(549, 43);
            this.buttonOpenXmlFile.Name = "buttonOpenXmlFile";
            this.buttonOpenXmlFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenXmlFile.TabIndex = 3;
            this.buttonOpenXmlFile.Text = "Открыть";
            this.buttonOpenXmlFile.UseVisualStyleBackColor = true;
            this.buttonOpenXmlFile.Click += new System.EventHandler(this.buttonOpenXmlFileClick);
            // 
            // buttonOpenXsdFile
            // 
            this.buttonOpenXsdFile.Location = new System.Drawing.Point(549, 100);
            this.buttonOpenXsdFile.Name = "buttonOpenXsdFile";
            this.buttonOpenXsdFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenXsdFile.TabIndex = 4;
            this.buttonOpenXsdFile.Text = "Открыть";
            this.buttonOpenXsdFile.UseVisualStyleBackColor = true;
            this.buttonOpenXsdFile.Click += new System.EventHandler(this.buttonOpenXsdFileClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // labelXmlName
            // 
            this.labelXmlName.AutoSize = true;
            this.labelXmlName.Location = new System.Drawing.Point(21, 24);
            this.labelXmlName.Name = "labelXmlName";
            this.labelXmlName.Size = new System.Drawing.Size(61, 13);
            this.labelXmlName.TabIndex = 5;
            this.labelXmlName.Text = "Файл XML";
            // 
            // labelXsdName
            // 
            this.labelXsdName.AutoSize = true;
            this.labelXsdName.Location = new System.Drawing.Point(24, 84);
            this.labelXsdName.Name = "labelXsdName";
            this.labelXsdName.Size = new System.Drawing.Size(61, 13);
            this.labelXsdName.TabIndex = 6;
            this.labelXsdName.Text = "Файл XSD";
            // 
            // formCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 199);
            this.Controls.Add(this.labelXsdName);
            this.Controls.Add(this.labelXmlName);
            this.Controls.Add(this.buttonOpenXsdFile);
            this.Controls.Add(this.buttonOpenXmlFile);
            this.Controls.Add(this.tbXsdFile);
            this.Controls.Add(this.tbXmlFile);
            this.Controls.Add(this.buttonCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Валидация XML по XSD схеме";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.TextBox tbXmlFile;
        private System.Windows.Forms.TextBox tbXsdFile;
        private System.Windows.Forms.Button buttonOpenXmlFile;
        private System.Windows.Forms.Button buttonOpenXsdFile;
        private System.Windows.Forms.SaveFileDialog sfDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label labelXmlName;
        private System.Windows.Forms.Label labelXsdName;
    }
}

