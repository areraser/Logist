namespace Logist
{
    partial class AllRoutes
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
            this.table = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addRoute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToOrderColumns = true;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.cities});
            this.table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.table.Location = new System.Drawing.Point(13, 12);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.Size = new System.Drawing.Size(465, 178);
            this.table.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "#";
            this.id.Name = "id";
            this.id.Width = 20;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // cities
            // 
            this.cities.HeaderText = "Route";
            this.cities.Name = "cities";
            this.cities.Width = 300;
            // 
            // addRoute
            // 
            this.addRoute.Location = new System.Drawing.Point(12, 196);
            this.addRoute.Name = "addRoute";
            this.addRoute.Size = new System.Drawing.Size(114, 23);
            this.addRoute.TabIndex = 1;
            this.addRoute.Text = "Додати маршрут";
            this.addRoute.UseVisualStyleBackColor = true;
            this.addRoute.Click += new System.EventHandler(this.add);
            // 
            // AllRoutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 231);
            this.Controls.Add(this.addRoute);
            this.Controls.Add(this.table);
            this.Name = "AllRoutes";
            this.Text = "AllRoutes";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cities;
        private System.Windows.Forms.Button addRoute;
    }
}