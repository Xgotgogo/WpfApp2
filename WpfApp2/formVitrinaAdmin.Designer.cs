namespace WpfApp2
{
    partial class formVitrinaAdmin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnDobavit = new System.Windows.Forms.Button();
            this.btnIzmenit = new System.Windows.Forms.Button();
            this.btnYdalit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(129, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(830, 442);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(220, 29);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Меню";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnDobavit
            // 
            this.btnDobavit.Location = new System.Drawing.Point(312, 29);
            this.btnDobavit.Name = "btnDobavit";
            this.btnDobavit.Size = new System.Drawing.Size(75, 23);
            this.btnDobavit.TabIndex = 2;
            this.btnDobavit.Text = "Добавить";
            this.btnDobavit.UseVisualStyleBackColor = true;
            this.btnDobavit.Click += new System.EventHandler(this.btnDobavit_Click);
            // 
            // btnIzmenit
            // 
            this.btnIzmenit.Location = new System.Drawing.Point(407, 29);
            this.btnIzmenit.Name = "btnIzmenit";
            this.btnIzmenit.Size = new System.Drawing.Size(75, 23);
            this.btnIzmenit.TabIndex = 3;
            this.btnIzmenit.Text = "Изменить";
            this.btnIzmenit.UseVisualStyleBackColor = true;
            this.btnIzmenit.Click += new System.EventHandler(this.btnIzmenit_Click);
            // 
            // btnYdalit
            // 
            this.btnYdalit.Location = new System.Drawing.Point(499, 29);
            this.btnYdalit.Name = "btnYdalit";
            this.btnYdalit.Size = new System.Drawing.Size(75, 23);
            this.btnYdalit.TabIndex = 4;
            this.btnYdalit.Text = "Удалить";
            this.btnYdalit.UseVisualStyleBackColor = true;
            // 
            // formVitrinaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 580);
            this.Controls.Add(this.btnYdalit);
            this.Controls.Add(this.btnIzmenit);
            this.Controls.Add(this.btnDobavit);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "formVitrinaAdmin";
            this.Text = "formVitrinaAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnDobavit;
        private System.Windows.Forms.Button btnIzmenit;
        private System.Windows.Forms.Button btnYdalit;
    }
}