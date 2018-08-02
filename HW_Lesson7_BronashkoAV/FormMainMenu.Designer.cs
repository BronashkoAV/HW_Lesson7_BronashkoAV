namespace HW_Lesson7_BronashkoAV
{
    partial class FormMainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDoubler = new System.Windows.Forms.Button();
            this.btnGuessing = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDoubler
            // 
            this.btnDoubler.AutoSize = true;
            this.btnDoubler.Location = new System.Drawing.Point(40, 44);
            this.btnDoubler.Name = "btnDoubler";
            this.btnDoubler.Size = new System.Drawing.Size(200, 50);
            this.btnDoubler.TabIndex = 0;
            this.btnDoubler.Text = "Doubler";
            this.btnDoubler.UseVisualStyleBackColor = true;
            this.btnDoubler.Click += new System.EventHandler(this.btnDoubler_Click);
            // 
            // btnGuessing
            // 
            this.btnGuessing.AutoSize = true;
            this.btnGuessing.Location = new System.Drawing.Point(40, 100);
            this.btnGuessing.Name = "btnGuessing";
            this.btnGuessing.Size = new System.Drawing.Size(200, 50);
            this.btnGuessing.TabIndex = 1;
            this.btnGuessing.Text = "Guessing game";
            this.btnGuessing.UseVisualStyleBackColor = true;
            this.btnGuessing.Click += new System.EventHandler(this.btnGuessing_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(40, 156);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 50);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGuessing);
            this.Controls.Add(this.btnDoubler);
            this.Name = "FormMainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoubler;
        private System.Windows.Forms.Button btnGuessing;
        private System.Windows.Forms.Button btnExit;
    }
}

