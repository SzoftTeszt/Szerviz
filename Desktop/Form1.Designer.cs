namespace Desktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstSzerelok = new ListBox();
            label1 = new Label();
            label2 = new Label();
            dvgAdatok = new DataGridView();
            lblEredmeny = new Label();
            btnOsszesInclude = new Button();
            btnOsszesJoin = new Button();
            btnSzereléoOsszesites = new Button();
            btnDragabb = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgAdatok).BeginInit();
            SuspendLayout();
            // 
            // lstSzerelok
            // 
            lstSzerelok.FormattingEnabled = true;
            lstSzerelok.Location = new Point(37, 117);
            lstSzerelok.Name = "lstSzerelok";
            lstSzerelok.Size = new Size(206, 289);
            lstSzerelok.TabIndex = 0;
            lstSzerelok.SelectedIndexChanged += lstSzerelok_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(31, 26);
            label1.Name = "label1";
            label1.Size = new Size(373, 30);
            label1.TabIndex = 1;
            label1.Text = "Autószervíz - EF Core Include és Join";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 80);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Szerelők:";
            // 
            // dvgAdatok
            // 
            dvgAdatok.AllowUserToAddRows = false;
            dvgAdatok.AllowUserToDeleteRows = false;
            dvgAdatok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgAdatok.Location = new Point(270, 210);
            dvgAdatok.Name = "dvgAdatok";
            dvgAdatok.ReadOnly = true;
            dvgAdatok.Size = new Size(688, 244);
            dvgAdatok.TabIndex = 2;
            // 
            // lblEredmeny
            // 
            lblEredmeny.AutoSize = true;
            lblEredmeny.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblEredmeny.Location = new Point(270, 174);
            lblEredmeny.Name = "lblEredmeny";
            lblEredmeny.Size = new Size(0, 21);
            lblEredmeny.TabIndex = 1;
            // 
            // btnOsszesInclude
            // 
            btnOsszesInclude.Location = new Point(266, 88);
            btnOsszesInclude.Name = "btnOsszesInclude";
            btnOsszesInclude.Size = new Size(153, 49);
            btnOsszesInclude.TabIndex = 3;
            btnOsszesInclude.Text = "Összes - Include";
            btnOsszesInclude.UseVisualStyleBackColor = true;
            btnOsszesInclude.Click += btnOsszesInclude_Click_1;
            // 
            // btnOsszesJoin
            // 
            btnOsszesJoin.Location = new Point(442, 88);
            btnOsszesJoin.Name = "btnOsszesJoin";
            btnOsszesJoin.Size = new Size(150, 49);
            btnOsszesJoin.TabIndex = 3;
            btnOsszesJoin.Text = "Összes - Join";
            btnOsszesJoin.UseVisualStyleBackColor = true;
            btnOsszesJoin.Click += btnOsszesJoin_Click_1;
            // 
            // btnSzereléoOsszesites
            // 
            btnSzereléoOsszesites.Location = new Point(811, 88);
            btnSzereléoOsszesites.Name = "btnSzereléoOsszesites";
            btnSzereléoOsszesites.Size = new Size(147, 49);
            btnSzereléoOsszesites.TabIndex = 3;
            btnSzereléoOsszesites.Text = "Szerelő összesítés";
            btnSzereléoOsszesites.UseVisualStyleBackColor = true;
            btnSzereléoOsszesites.Click += btnSzereléoOsszesites_Click;
            // 
            // btnDragabb
            // 
            btnDragabb.Location = new Point(628, 88);
            btnDragabb.Name = "btnDragabb";
            btnDragabb.Size = new Size(152, 49);
            btnDragabb.TabIndex = 3;
            btnDragabb.Text = "100 000 Ft felett";
            btnDragabb.UseVisualStyleBackColor = true;
            btnDragabb.Click += btnDragabb_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 494);
            Controls.Add(btnDragabb);
            Controls.Add(btnSzereléoOsszesites);
            Controls.Add(btnOsszesJoin);
            Controls.Add(btnOsszesInclude);
            Controls.Add(dvgAdatok);
            Controls.Add(lblEredmeny);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstSzerelok);
            Name = "Form1";
            Text = "Autoszerviz";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dvgAdatok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstSzerelok;
        private Label label1;
        private Label label2;
        private DataGridView dvgAdatok;
        private Label lblEredmeny;
        private Button btnOsszesInclude;
        private Button btnOsszesJoin;
        private Button btnSzereléoOsszesites;
        private Button btnDragabb;
    }
}
