namespace HW_Lesson7_BronashkoAV
{
    partial class FormGuessingGame
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
            this.btnOk = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btnToMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(92, 90);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(13, 141);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(93, 13);
            this.lblHint.TabIndex = 2;
            this.lblHint.Text = "Кол-во попыток: ";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(92, 51);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(100, 20);
            this.tbInput.TabIndex = 3;
            // 
            // btnToMainMenu
            // 
            this.btnToMainMenu.Location = new System.Drawing.Point(197, 226);
            this.btnToMainMenu.Name = "btnToMainMenu";
            this.btnToMainMenu.Size = new System.Drawing.Size(75, 23);
            this.btnToMainMenu.TabIndex = 4;
            this.btnToMainMenu.Text = "Main Menu";
            this.btnToMainMenu.UseVisualStyleBackColor = true;
            this.btnToMainMenu.Click += new System.EventHandler(this.btnToMainMenu_Click);
            // 
            // FormGuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnToMainMenu);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.btnOk);
            this.Name = "FormGuessingGame";
            this.Text = "FormGuessingGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Button btnToMainMenu;
    }
}