namespace listview_task
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView = new System.Windows.Forms.ListView();
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surnameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ageHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.surnameInput = new System.Windows.Forms.TextBox();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.ageInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.editPersonButton = new System.Windows.Forms.Button();
            this.nameEditInput = new System.Windows.Forms.TextBox();
            this.surnameEditInput = new System.Windows.Forms.TextBox();
            this.ageEditInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.CheckBoxes = true;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.surnameHeader,
            this.ageHeader});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(31, 29);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(661, 222);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Name";
            this.nameHeader.Width = 200;
            // 
            // surnameHeader
            // 
            this.surnameHeader.Text = "Surname";
            this.surnameHeader.Width = 249;
            // 
            // ageHeader
            // 
            this.ageHeader.Text = "Age";
            this.ageHeader.Width = 121;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(307, 293);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 20);
            this.nameInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "surname";
            // 
            // surnameInput
            // 
            this.surnameInput.Location = new System.Drawing.Point(307, 323);
            this.surnameInput.Name = "surnameInput";
            this.surnameInput.Size = new System.Drawing.Size(100, 20);
            this.surnameInput.TabIndex = 4;
            // 
            // addPersonButton
            // 
            this.addPersonButton.Location = new System.Drawing.Point(307, 379);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(100, 23);
            this.addPersonButton.TabIndex = 5;
            this.addPersonButton.Text = "add Person";
            this.addPersonButton.UseVisualStyleBackColor = true;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // ageInput
            // 
            this.ageInput.Location = new System.Drawing.Point(307, 351);
            this.ageInput.Name = "ageInput";
            this.ageInput.Size = new System.Drawing.Size(100, 20);
            this.ageInput.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Age";
            // 
            // editPersonButton
            // 
            this.editPersonButton.Location = new System.Drawing.Point(540, 379);
            this.editPersonButton.Name = "editPersonButton";
            this.editPersonButton.Size = new System.Drawing.Size(100, 23);
            this.editPersonButton.TabIndex = 8;
            this.editPersonButton.Text = "Edit selected row";
            this.editPersonButton.UseVisualStyleBackColor = true;
            this.editPersonButton.Click += new System.EventHandler(this.editPersonButton_Click);
            // 
            // nameEditInput
            // 
            this.nameEditInput.Location = new System.Drawing.Point(540, 293);
            this.nameEditInput.Name = "nameEditInput";
            this.nameEditInput.Size = new System.Drawing.Size(100, 20);
            this.nameEditInput.TabIndex = 9;
            // 
            // surnameEditInput
            // 
            this.surnameEditInput.Location = new System.Drawing.Point(540, 323);
            this.surnameEditInput.Name = "surnameEditInput";
            this.surnameEditInput.Size = new System.Drawing.Size(100, 20);
            this.surnameEditInput.TabIndex = 10;
            // 
            // ageEditInput
            // 
            this.ageEditInput.Location = new System.Drawing.Point(540, 351);
            this.ageEditInput.Name = "ageEditInput";
            this.ageEditInput.Size = new System.Drawing.Size(100, 20);
            this.ageEditInput.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Surname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(506, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Age";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ageEditInput);
            this.Controls.Add(this.surnameEditInput);
            this.Controls.Add(this.nameEditInput);
            this.Controls.Add(this.editPersonButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ageInput);
            this.Controls.Add(this.addPersonButton);
            this.Controls.Add(this.surnameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.listView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox surnameInput;
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.TextBox ageInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader surnameHeader;
        private System.Windows.Forms.ColumnHeader ageHeader;
        private System.Windows.Forms.Button editPersonButton;
        private System.Windows.Forms.TextBox nameEditInput;
        private System.Windows.Forms.TextBox surnameEditInput;
        private System.Windows.Forms.TextBox ageEditInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

