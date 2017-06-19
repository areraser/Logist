namespace Logist
{
    partial class Main
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Route = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.ComboBox();
            this.end = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "З";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "В";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Знайти шлях";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Search);
            // 
            // Route
            // 
            this.Route.Location = new System.Drawing.Point(149, 67);
            this.Route.Name = "Route";
            this.Route.Size = new System.Drawing.Size(75, 23);
            this.Route.TabIndex = 5;
            this.Route.Text = "Маршрути";
            this.Route.UseVisualStyleBackColor = true;
            this.Route.Click += new System.EventHandler(this.AllRoute);
            // 
            // start
            // 
            this.start.FormattingEnabled = true;
            this.start.Location = new System.Drawing.Point(32, 16);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(247, 21);
            this.start.TabIndex = 6;
            // 
            // end
            // 
            this.end.FormattingEnabled = true;
            this.end.Location = new System.Drawing.Point(32, 40);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(247, 21);
            this.end.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 98);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.Route);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Route;
        private System.Windows.Forms.ComboBox start;
        private System.Windows.Forms.ComboBox end;
    }
}

