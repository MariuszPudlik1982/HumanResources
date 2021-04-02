
namespace HumanResources
{
    partial class AddEditEmployee
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
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbDateOfEmployment = new System.Windows.Forms.TextBox();
            this.tbDateOfDismissal = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbAmountOfEarnings = new System.Windows.Forms.TextBox();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnDismiss = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(160, 69);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(365, 22);
            this.tbFirstName.TabIndex = 0;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(160, 116);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(365, 22);
            this.tbLastName.TabIndex = 1;
            // 
            // tbDateOfEmployment
            // 
            this.tbDateOfEmployment.Location = new System.Drawing.Point(160, 175);
            this.tbDateOfEmployment.Name = "tbDateOfEmployment";
            this.tbDateOfEmployment.Size = new System.Drawing.Size(365, 22);
            this.tbDateOfEmployment.TabIndex = 2;
            // 
            // tbDateOfDismissal
            // 
            this.tbDateOfDismissal.Location = new System.Drawing.Point(160, 239);
            this.tbDateOfDismissal.Name = "tbDateOfDismissal";
            this.tbDateOfDismissal.Size = new System.Drawing.Size(365, 22);
            this.tbDateOfDismissal.TabIndex = 3;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(160, 12);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(365, 22);
            this.tbId.TabIndex = 4;
            // 
            // tbAmountOfEarnings
            // 
            this.tbAmountOfEarnings.Location = new System.Drawing.Point(160, 297);
            this.tbAmountOfEarnings.Name = "tbAmountOfEarnings";
            this.tbAmountOfEarnings.Size = new System.Drawing.Size(364, 22);
            this.tbAmountOfEarnings.TabIndex = 5;
            // 
            // rtbComments
            // 
            this.rtbComments.Location = new System.Drawing.Point(158, 373);
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.Size = new System.Drawing.Size(367, 109);
            this.rtbComments.TabIndex = 6;
            this.rtbComments.Text = "";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(286, 507);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 27);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(424, 507);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(101, 26);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Zatwierdz";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnDismiss
            // 
            this.btnDismiss.Location = new System.Drawing.Point(12, 508);
            this.btnDismiss.Name = "btnDismiss";
            this.btnDismiss.Size = new System.Drawing.Size(138, 26);
            this.btnDismiss.TabIndex = 9;
            this.btnDismiss.Text = "ZwolnijPracownika";
            this.btnDismiss.UseVisualStyleBackColor = true;
            this.btnDismiss.Click += new System.EventHandler(this.btnDismiss_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Imię pracownika:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nazwisko pracownika:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Data zatrudnienia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Data zwolnienia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Wysokość wypłaty:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Komentarz:";
            // 
            // AddEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 682);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDismiss);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.rtbComments);
            this.Controls.Add(this.tbAmountOfEarnings);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbDateOfDismissal);
            this.Controls.Add(this.tbDateOfEmployment);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.MaximumSize = new System.Drawing.Size(574, 729);
            this.MinimumSize = new System.Drawing.Size(574, 729);
            this.Name = "AddEditEmployee";
            this.Text = "DodawaniePracownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbDateOfEmployment;
        private System.Windows.Forms.TextBox tbDateOfDismissal;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbAmountOfEarnings;
        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnDismiss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}