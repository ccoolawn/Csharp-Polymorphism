namespace IntroToPolymorphism
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
            this.btnCreateCone = new System.Windows.Forms.Button();
            this.btnCreateShpere = new System.Windows.Forms.Button();
            this.btnCreateCylinder = new System.Windows.Forms.Button();
            this.btnCreateCircle = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnCreateCone
            // 
            this.btnCreateCone.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreateCone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateCone.Location = new System.Drawing.Point(790, 413);
            this.btnCreateCone.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCreateCone.Name = "btnCreateCone";
            this.btnCreateCone.Size = new System.Drawing.Size(200, 52);
            this.btnCreateCone.TabIndex = 9;
            this.btnCreateCone.Text = "Create Cone";
            this.btnCreateCone.UseVisualStyleBackColor = false;
            this.btnCreateCone.Click += new System.EventHandler(this.btnCreateCone_Click);
            // 
            // btnCreateShpere
            // 
            this.btnCreateShpere.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreateShpere.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateShpere.Location = new System.Drawing.Point(534, 413);
            this.btnCreateShpere.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCreateShpere.Name = "btnCreateShpere";
            this.btnCreateShpere.Size = new System.Drawing.Size(200, 52);
            this.btnCreateShpere.TabIndex = 8;
            this.btnCreateShpere.Text = "Create Sphere";
            this.btnCreateShpere.UseVisualStyleBackColor = false;
            this.btnCreateShpere.Click += new System.EventHandler(this.btnCreateShpere_Click);
            // 
            // btnCreateCylinder
            // 
            this.btnCreateCylinder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreateCylinder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateCylinder.Location = new System.Drawing.Point(278, 413);
            this.btnCreateCylinder.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCreateCylinder.Name = "btnCreateCylinder";
            this.btnCreateCylinder.Size = new System.Drawing.Size(200, 52);
            this.btnCreateCylinder.TabIndex = 7;
            this.btnCreateCylinder.Text = "Create Cylinder";
            this.btnCreateCylinder.UseVisualStyleBackColor = false;
            this.btnCreateCylinder.Click += new System.EventHandler(this.btnCreateCylinder_Click);
            // 
            // btnCreateCircle
            // 
            this.btnCreateCircle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreateCircle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateCircle.Location = new System.Drawing.Point(22, 413);
            this.btnCreateCircle.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCreateCircle.Name = "btnCreateCircle";
            this.btnCreateCircle.Size = new System.Drawing.Size(200, 52);
            this.btnCreateCircle.TabIndex = 6;
            this.btnCreateCircle.Text = "Create Circle";
            this.btnCreateCircle.UseVisualStyleBackColor = false;
            this.btnCreateCircle.Click += new System.EventHandler(this.btnCreateCircle_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader6,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Location = new System.Drawing.Point(22, 67);
            this.listView1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(967, 335);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Radius";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Height";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Perimeter";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Area";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Volume";
            this.columnHeader5.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 500);
            this.Controls.Add(this.btnCreateCone);
            this.Controls.Add(this.btnCreateShpere);
            this.Controls.Add(this.btnCreateCylinder);
            this.Controls.Add(this.btnCreateCircle);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(27, 78, 27, 26);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Introduction To Poymorphism";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateCone;
        private System.Windows.Forms.Button btnCreateShpere;
        private System.Windows.Forms.Button btnCreateCylinder;
        private System.Windows.Forms.Button btnCreateCircle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

