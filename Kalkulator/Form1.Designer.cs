namespace Kalkulator
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
            this.InsertIP = new System.Windows.Forms.TextBox();
            this.StartProcess = new System.Windows.Forms.Button();
            this.CityResult = new System.Windows.Forms.TextBox();
            this.CountryResult = new System.Windows.Forms.TextBox();
            this.RegionResult = new System.Windows.Forms.TextBox();
            this.TimezoneResult = new System.Windows.Forms.TextBox();
            this.IPaddress = new System.Windows.Forms.TextBox();
            this.GoogleMapsLink = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InsertIP
            // 
            this.InsertIP.Location = new System.Drawing.Point(12, 12);
            this.InsertIP.Multiline = true;
            this.InsertIP.Name = "InsertIP";
            this.InsertIP.Size = new System.Drawing.Size(180, 37);
            this.InsertIP.TabIndex = 0;
            this.InsertIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InsertIP.TextChanged += new System.EventHandler(this.InsertIP_TextChanged);
            // 
            // StartProcess
            // 
            this.StartProcess.Location = new System.Drawing.Point(198, 12);
            this.StartProcess.Name = "StartProcess";
            this.StartProcess.Size = new System.Drawing.Size(75, 37);
            this.StartProcess.TabIndex = 1;
            this.StartProcess.Text = "ENTER";
            this.StartProcess.UseVisualStyleBackColor = true;
            this.StartProcess.Click += new System.EventHandler(this.StartProcess_Click);
            // 
            // CityResult
            // 
            this.CityResult.Location = new System.Drawing.Point(90, 55);
            this.CityResult.Name = "CityResult";
            this.CityResult.Size = new System.Drawing.Size(183, 20);
            this.CityResult.TabIndex = 3;
            this.CityResult.TextChanged += new System.EventHandler(this.CityResult_TextChanged);
            // 
            // CountryResult
            // 
            this.CountryResult.Location = new System.Drawing.Point(90, 81);
            this.CountryResult.Name = "CountryResult";
            this.CountryResult.Size = new System.Drawing.Size(183, 20);
            this.CountryResult.TabIndex = 4;
            this.CountryResult.TextChanged += new System.EventHandler(this.CountryResult_TextChanged);
            // 
            // RegionResult
            // 
            this.RegionResult.Location = new System.Drawing.Point(90, 107);
            this.RegionResult.Name = "RegionResult";
            this.RegionResult.Size = new System.Drawing.Size(183, 20);
            this.RegionResult.TabIndex = 5;
            this.RegionResult.TextChanged += new System.EventHandler(this.RegionResult_TextChanged);
            // 
            // TimezoneResult
            // 
            this.TimezoneResult.Location = new System.Drawing.Point(90, 133);
            this.TimezoneResult.Name = "TimezoneResult";
            this.TimezoneResult.Size = new System.Drawing.Size(183, 20);
            this.TimezoneResult.TabIndex = 6;
            this.TimezoneResult.TextChanged += new System.EventHandler(this.TimezoneResult_TextChanged);
            // 
            // IPaddress
            // 
            this.IPaddress.Location = new System.Drawing.Point(90, 159);
            this.IPaddress.Name = "IPaddress";
            this.IPaddress.Size = new System.Drawing.Size(183, 20);
            this.IPaddress.TabIndex = 7;
            this.IPaddress.TextChanged += new System.EventHandler(this.IPaddress_TextChanged);
            // 
            // GoogleMapsLink
            // 
            this.GoogleMapsLink.Location = new System.Drawing.Point(12, 185);
            this.GoogleMapsLink.Name = "GoogleMapsLink";
            this.GoogleMapsLink.Size = new System.Drawing.Size(261, 20);
            this.GoogleMapsLink.TabIndex = 8;
            this.GoogleMapsLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GoogleMapsLink.TextChanged += new System.EventHandler(this.GoogleMapsLink_TextChanged);
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(12, 55);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(72, 20);
            this.City.TabIndex = 9;
            this.City.Text = "Grad";
            this.City.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(72, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "IP";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(72, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "Zona";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(72, 20);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "Region";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 81);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(72, 20);
            this.textBox4.TabIndex = 13;
            this.textBox4.Text = "Drzava";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 222);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.City);
            this.Controls.Add(this.GoogleMapsLink);
            this.Controls.Add(this.IPaddress);
            this.Controls.Add(this.TimezoneResult);
            this.Controls.Add(this.RegionResult);
            this.Controls.Add(this.CountryResult);
            this.Controls.Add(this.CityResult);
            this.Controls.Add(this.StartProcess);
            this.Controls.Add(this.InsertIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InsertIP;
        private System.Windows.Forms.Button StartProcess;
        private System.Windows.Forms.TextBox CityResult;
        private System.Windows.Forms.TextBox CountryResult;
        private System.Windows.Forms.TextBox RegionResult;
        private System.Windows.Forms.TextBox TimezoneResult;
        private System.Windows.Forms.TextBox IPaddress;
        private System.Windows.Forms.TextBox GoogleMapsLink;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}
