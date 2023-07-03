namespace MarkolaserGIC
{
    partial class Form2
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
            btnSelectAxis = new Button();
            btnExit2 = new Button();
            SuspendLayout();
            // 
            // btnSelectAxis
            // 
            btnSelectAxis.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSelectAxis.ForeColor = Color.Green;
            btnSelectAxis.Location = new Point(622, 200);
            btnSelectAxis.Name = "btnSelectAxis";
            btnSelectAxis.Size = new Size(166, 38);
            btnSelectAxis.TabIndex = 16;
            btnSelectAxis.Text = "Select Axis";
            btnSelectAxis.UseVisualStyleBackColor = true;
            btnSelectAxis.Click += btnSelectAxis_Click;
            // 
            // btnExit2
            // 
            btnExit2.AutoSize = true;
            btnExit2.Image = Properties.Resources.close;
            btnExit2.Location = new Point(757, 12);
            btnExit2.Name = "btnExit2";
            btnExit2.Size = new Size(31, 31);
            btnExit2.TabIndex = 26;
            btnExit2.UseVisualStyleBackColor = true;
            btnExit2.Click += btnExit2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit2);
            Controls.Add(btnSelectAxis);
            Name = "Form2";
            Text = "Recipe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSelectAxis;
        private Button btnExit2;
    }
}