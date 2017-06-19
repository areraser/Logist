namespace Logist
{
    partial class NewRoute
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
            this.label1 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cities = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(13, 30);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(148, 20);
            this.Name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Міста(через пробіл)";
            // 
            // Cities
            // 
            this.Cities.Location = new System.Drawing.Point(13, 70);
            this.Cities.Name = "Cities";
            this.Cities.Size = new System.Drawing.Size(148, 20);
            this.Cities.TabIndex = 3;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(12, 96);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(149, 23);
            this.Add.TabIndex = 4;
            this.Add.Text = "Додати";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.AddClick);
            // 
            // NewRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 138);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Cities);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label1);
            this.Text = "NewRoute";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Cities;
        private System.Windows.Forms.Button Add;
    }
}