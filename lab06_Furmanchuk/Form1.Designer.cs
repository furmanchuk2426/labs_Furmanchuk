namespace lab06_Furmanchuk
{
    partial class Form1
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
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.sumNumberTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Location = new System.Drawing.Point(105, 62);
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(668, 30);
            this.firstNumberTextBox.TabIndex = 0;
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Location = new System.Drawing.Point(105, 108);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(668, 30);
            this.secondNumberTextBox.TabIndex = 0;
            // 
            // sumNumberTextBox
            // 
            this.sumNumberTextBox.Location = new System.Drawing.Point(105, 184);
            this.sumNumberTextBox.Name = "sumNumberTextBox";
            this.sumNumberTextBox.Size = new System.Drawing.Size(668, 30);
            this.sumNumberTextBox.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(675, 238);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(98, 29);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Вийти";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(418, 146);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(94, 29);
            this.plusButton.TabIndex = 1;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(105, 238);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(115, 29);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Очистити";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 351);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.sumNumberTextBox);
            this.Controls.Add(this.secondNumberTextBox);
            this.Controls.Add(this.firstNumberTextBox);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "lab06: Довга сума";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNumberTextBox;
        private System.Windows.Forms.TextBox secondNumberTextBox;
        private System.Windows.Forms.TextBox sumNumberTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button clearButton;
    }
}

