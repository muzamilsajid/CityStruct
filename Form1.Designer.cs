namespace SoloLearn
{
    partial class Form1
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
            this.btnAddCity = new System.Windows.Forms.Button();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.txtCityPopulation = new System.Windows.Forms.TextBox();
            this.txtCityArea = new System.Windows.Forms.TextBox();
            this.listCityNames = new System.Windows.Forms.ListBox();
            this.listCityDetails = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddCity
            // 
            this.btnAddCity.Location = new System.Drawing.Point(127, 104);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(75, 23);
            this.btnAddCity.TabIndex = 0;
            this.btnAddCity.Text = "Add City";
            this.btnAddCity.UseVisualStyleBackColor = true;
            this.btnAddCity.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(127, 78);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(100, 20);
            this.txtCityName.TabIndex = 2;
            // 
            // txtCityPopulation
            // 
            this.txtCityPopulation.Location = new System.Drawing.Point(233, 78);
            this.txtCityPopulation.Name = "txtCityPopulation";
            this.txtCityPopulation.Size = new System.Drawing.Size(100, 20);
            this.txtCityPopulation.TabIndex = 3;
            // 
            // txtCityArea
            // 
            this.txtCityArea.Location = new System.Drawing.Point(339, 78);
            this.txtCityArea.Name = "txtCityArea";
            this.txtCityArea.Size = new System.Drawing.Size(100, 20);
            this.txtCityArea.TabIndex = 4;
            // 
            // listCityNames
            // 
            this.listCityNames.FormattingEnabled = true;
            this.listCityNames.Location = new System.Drawing.Point(127, 161);
            this.listCityNames.Name = "listCityNames";
            this.listCityNames.Size = new System.Drawing.Size(100, 277);
            this.listCityNames.TabIndex = 5;
            this.listCityNames.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // listCityDetails
            // 
            this.listCityDetails.FormattingEnabled = true;
            this.listCityDetails.Location = new System.Drawing.Point(233, 161);
            this.listCityDetails.Name = "listCityDetails";
            this.listCityDetails.Size = new System.Drawing.Size(301, 277);
            this.listCityDetails.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "New City Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "New City Population";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "New City Area";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(541, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(541, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Load";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listCityDetails);
            this.Controls.Add(this.listCityNames);
            this.Controls.Add(this.txtCityArea);
            this.Controls.Add(this.txtCityPopulation);
            this.Controls.Add(this.txtCityName);
            this.Controls.Add(this.btnAddCity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.TextBox txtCityPopulation;
        private System.Windows.Forms.TextBox txtCityArea;
        private System.Windows.Forms.ListBox listCityNames;
        private System.Windows.Forms.ListBox listCityDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

