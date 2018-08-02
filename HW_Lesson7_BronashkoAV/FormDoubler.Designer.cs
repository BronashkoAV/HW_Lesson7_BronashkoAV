namespace HW_Lesson7_BronashkoAV
{
    partial class FormDoubler
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
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnToMainMenu = new System.Windows.Forms.Button();
            this.lblStep = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(13, 13);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(100, 30);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+1";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(13, 49);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(100, 30);
            this.btnMulti.TabIndex = 1;
            this.btnMulti.Text = "x2";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(13, 85);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(13, 121);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 30);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnToMainMenu
            // 
            this.btnToMainMenu.Location = new System.Drawing.Point(172, 219);
            this.btnToMainMenu.Name = "btnToMainMenu";
            this.btnToMainMenu.Size = new System.Drawing.Size(100, 30);
            this.btnToMainMenu.TabIndex = 4;
            this.btnToMainMenu.Text = "Exit to Main Menu";
            this.btnToMainMenu.UseVisualStyleBackColor = true;
            this.btnToMainMenu.Click += new System.EventHandler(this.btnToMainMenu_Click);
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Location = new System.Drawing.Point(119, 85);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(78, 13);
            this.lblStep.TabIndex = 5;
            this.lblStep.Text = "Кол-во шагов:";
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(119, 49);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(69, 13);
            this.lblCounter.TabIndex = 6;
            this.lblCounter.Text = "Ваше число:";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(119, 13);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(145, 13);
            this.lblTarget.TabIndex = 7;
            this.lblTarget.Text = "Вам нужно получить число:";
            // 
            // FormDoubler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.lblStep);
            this.Controls.Add(this.btnToMainMenu);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnPlus);
            this.Name = "FormDoubler";
            this.Text = "Doubler";
            this.Load += new System.EventHandler(this.Doubler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnToMainMenu;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Label lblTarget;
    }
}