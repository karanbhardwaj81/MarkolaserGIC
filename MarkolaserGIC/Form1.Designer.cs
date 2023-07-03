namespace MarkolaserGIC
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cmbAssets = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblZ1 = new Label();
            lblX1 = new Label();
            btnZUp = new Button();
            btnZDown = new Button();
            btnXDown = new Button();
            btnXUp = new Button();
            txtSetZ = new TextBox();
            txtSetX = new TextBox();
            btnAddRecipe = new Button();
            btnUpdateRecipe = new Button();
            lblSelectAssets = new Label();
            lblZMain = new Label();
            lblXMain = new Label();
            btnSave = new Button();
            btn1 = new Button();
            btnResetZ = new Button();
            btnResetX = new Button();
            timerZUp = new System.Windows.Forms.Timer(components);
            timerXUp = new System.Windows.Forms.Timer(components);
            timerZDown = new System.Windows.Forms.Timer(components);
            timerXDown = new System.Windows.Forms.Timer(components);
            btnExit = new Button();
            btnSaveAs = new Button();
            btnRecipeManagement = new Button();
            lblAssets1 = new Label();
            lblAssets2 = new Label();
            SuspendLayout();
            // 
            // cmbAssets
            // 
            cmbAssets.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAssets.FormattingEnabled = true;
            cmbAssets.Location = new Point(123, 31);
            cmbAssets.Name = "cmbAssets";
            cmbAssets.Size = new Size(360, 23);
            cmbAssets.TabIndex = 0;
            cmbAssets.SelectedIndexChanged += cmbAssets_SelectedIndexChanged;
            // 
            // lblZ1
            // 
            lblZ1.AutoSize = true;
            lblZ1.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblZ1.Location = new Point(151, 204);
            lblZ1.Name = "lblZ1";
            lblZ1.Size = new Size(14, 15);
            lblZ1.TabIndex = 3;
            lblZ1.Text = "0";
            // 
            // lblX1
            // 
            lblX1.AutoSize = true;
            lblX1.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblX1.Location = new Point(151, 306);
            lblX1.Name = "lblX1";
            lblX1.Size = new Size(14, 15);
            lblX1.TabIndex = 6;
            lblX1.Text = "0";
            // 
            // btnZUp
            // 
            btnZUp.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnZUp.Location = new Point(254, 200);
            btnZUp.Name = "btnZUp";
            btnZUp.Size = new Size(109, 23);
            btnZUp.TabIndex = 9;
            btnZUp.Text = "Up";
            btnZUp.UseVisualStyleBackColor = true;
            btnZUp.Click += btnZUp_Click;
            btnZUp.MouseDown += btnZUp_MouseDown;
            btnZUp.MouseUp += btnZUp_MouseUp;
            // 
            // btnZDown
            // 
            btnZDown.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnZDown.Location = new Point(369, 200);
            btnZDown.Name = "btnZDown";
            btnZDown.Size = new Size(114, 23);
            btnZDown.TabIndex = 10;
            btnZDown.Text = "Down";
            btnZDown.UseVisualStyleBackColor = true;
            btnZDown.Click += btnZDown_Click;
            btnZDown.MouseDown += btnZDown_MouseDown;
            btnZDown.MouseUp += btnZDown_MouseUp;
            // 
            // btnXDown
            // 
            btnXDown.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnXDown.Location = new Point(369, 302);
            btnXDown.Name = "btnXDown";
            btnXDown.Size = new Size(114, 23);
            btnXDown.TabIndex = 12;
            btnXDown.Text = "Down";
            btnXDown.UseVisualStyleBackColor = true;
            btnXDown.Click += btnXDown_Click;
            btnXDown.MouseDown += btnXDown_MouseDown;
            btnXDown.MouseUp += btnXDown_MouseUp;
            // 
            // btnXUp
            // 
            btnXUp.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnXUp.Location = new Point(254, 302);
            btnXUp.Name = "btnXUp";
            btnXUp.Size = new Size(109, 23);
            btnXUp.TabIndex = 11;
            btnXUp.Text = "Up";
            btnXUp.UseVisualStyleBackColor = true;
            btnXUp.Click += btnXUp_Click;
            btnXUp.MouseDown += btnXUp_MouseDown;
            btnXUp.MouseUp += btnXUp_MouseUp;
            // 
            // txtSetZ
            // 
            txtSetZ.Location = new Point(151, 238);
            txtSetZ.Name = "txtSetZ";
            txtSetZ.Size = new Size(204, 23);
            txtSetZ.TabIndex = 13;
            txtSetZ.TextChanged += txtSetZ_TextChanged;
            // 
            // txtSetX
            // 
            txtSetX.Location = new Point(151, 339);
            txtSetX.Name = "txtSetX";
            txtSetX.Size = new Size(204, 23);
            txtSetX.TabIndex = 14;
            txtSetX.TextChanged += txtSetX_TextChanged;
            // 
            // btnAddRecipe
            // 
            btnAddRecipe.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddRecipe.ForeColor = Color.DarkRed;
            btnAddRecipe.Location = new Point(596, 141);
            btnAddRecipe.Name = "btnAddRecipe";
            btnAddRecipe.Size = new Size(166, 38);
            btnAddRecipe.TabIndex = 15;
            btnAddRecipe.Text = "Add Recipe";
            btnAddRecipe.UseVisualStyleBackColor = true;
            btnAddRecipe.Click += btnAddRecipe_Click;
            // 
            // btnUpdateRecipe
            // 
            btnUpdateRecipe.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateRecipe.ForeColor = Color.DarkRed;
            btnUpdateRecipe.Location = new Point(596, 185);
            btnUpdateRecipe.Name = "btnUpdateRecipe";
            btnUpdateRecipe.Size = new Size(166, 38);
            btnUpdateRecipe.TabIndex = 16;
            btnUpdateRecipe.Text = "Update Recipe";
            btnUpdateRecipe.UseVisualStyleBackColor = true;
            // 
            // lblSelectAssets
            // 
            lblSelectAssets.AutoSize = true;
            lblSelectAssets.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSelectAssets.Location = new Point(43, 34);
            lblSelectAssets.Name = "lblSelectAssets";
            lblSelectAssets.Size = new Size(72, 14);
            lblSelectAssets.TabIndex = 17;
            lblSelectAssets.Text = "Select Assets";
            lblSelectAssets.Click += lblSelectAssets_Click;
            // 
            // lblZMain
            // 
            lblZMain.AutoSize = true;
            lblZMain.Font = new Font("Impact", 11.25F, FontStyle.Underline, GraphicsUnit.Point);
            lblZMain.ForeColor = Color.DarkRed;
            lblZMain.Location = new Point(43, 204);
            lblZMain.Name = "lblZMain";
            lblZMain.Size = new Size(44, 19);
            lblZMain.TabIndex = 18;
            lblZMain.Text = "Z-Axis";
            // 
            // lblXMain
            // 
            lblXMain.AutoSize = true;
            lblXMain.Font = new Font("Impact", 11.25F, FontStyle.Underline, GraphicsUnit.Point);
            lblXMain.ForeColor = Color.DarkRed;
            lblXMain.Location = new Point(43, 310);
            lblXMain.Name = "lblXMain";
            lblXMain.Size = new Size(46, 19);
            lblXMain.TabIndex = 19;
            lblXMain.Text = "X-axis";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.DarkRed;
            btnSave.Location = new Point(596, 273);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(166, 38);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.ForeColor = Color.DarkRed;
            btn1.Location = new Point(596, 229);
            btn1.Name = "btn1";
            btn1.Size = new Size(166, 38);
            btn1.TabIndex = 20;
            btn1.UseVisualStyleBackColor = true;
            // 
            // btnResetZ
            // 
            btnResetZ.Font = new Font("Calibri", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnResetZ.Location = new Point(361, 237);
            btnResetZ.Name = "btnResetZ";
            btnResetZ.Size = new Size(122, 23);
            btnResetZ.TabIndex = 23;
            btnResetZ.Text = "Reset Z-Axis";
            btnResetZ.UseVisualStyleBackColor = true;
            btnResetZ.Click += btnResetZ_Click;
            // 
            // btnResetX
            // 
            btnResetX.Font = new Font("Calibri", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnResetX.Location = new Point(361, 338);
            btnResetX.Name = "btnResetX";
            btnResetX.Size = new Size(122, 23);
            btnResetX.TabIndex = 24;
            btnResetX.Text = "Reset X-Axis";
            btnResetX.UseVisualStyleBackColor = true;
            btnResetX.Click += btnResetX_Click;
            // 
            // timerZUp
            // 
            timerZUp.Interval = 200;
            timerZUp.Tick += timerZUp_Tick;
            // 
            // timerXUp
            // 
            timerXUp.Interval = 200;
            timerXUp.Tick += timerXUp_Tick;
            // 
            // timerZDown
            // 
            timerZDown.Interval = 200;
            timerZDown.Tick += timerZDown_Tick;
            // 
            // timerXDown
            // 
            timerXDown.Interval = 200;
            timerXDown.Tick += timerXDown_Tick;
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.Image = Properties.Resources.close;
            btnExit.Location = new Point(758, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(31, 31);
            btnExit.TabIndex = 25;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSaveAs
            // 
            btnSaveAs.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveAs.ForeColor = Color.DarkRed;
            btnSaveAs.Location = new Point(596, 317);
            btnSaveAs.Name = "btnSaveAs";
            btnSaveAs.Size = new Size(166, 38);
            btnSaveAs.TabIndex = 26;
            btnSaveAs.Text = "Save as";
            btnSaveAs.UseVisualStyleBackColor = true;
            btnSaveAs.Click += btnSaveAs_Click;
            // 
            // btnRecipeManagement
            // 
            btnRecipeManagement.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecipeManagement.ForeColor = Color.DarkRed;
            btnRecipeManagement.Location = new Point(596, 97);
            btnRecipeManagement.Name = "btnRecipeManagement";
            btnRecipeManagement.Size = new Size(166, 38);
            btnRecipeManagement.TabIndex = 27;
            btnRecipeManagement.Text = "Recipe Management";
            btnRecipeManagement.UseVisualStyleBackColor = true;
            btnRecipeManagement.Click += btnRecipeManagement_Click;
            // 
            // lblAssets1
            // 
            lblAssets1.AutoSize = true;
            lblAssets1.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAssets1.Location = new Point(123, 86);
            lblAssets1.Name = "lblAssets1";
            lblAssets1.Size = new Size(15, 15);
            lblAssets1.TabIndex = 28;
            lblAssets1.Text = "--";
            // 
            // lblAssets2
            // 
            lblAssets2.AutoSize = true;
            lblAssets2.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAssets2.Location = new Point(123, 120);
            lblAssets2.Name = "lblAssets2";
            lblAssets2.Size = new Size(15, 15);
            lblAssets2.TabIndex = 29;
            lblAssets2.Text = "--";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAssets2);
            Controls.Add(lblAssets1);
            Controls.Add(btnRecipeManagement);
            Controls.Add(btnSaveAs);
            Controls.Add(btnExit);
            Controls.Add(btnResetX);
            Controls.Add(btnResetZ);
            Controls.Add(btnSave);
            Controls.Add(btn1);
            Controls.Add(lblXMain);
            Controls.Add(lblZMain);
            Controls.Add(lblSelectAssets);
            Controls.Add(btnUpdateRecipe);
            Controls.Add(btnAddRecipe);
            Controls.Add(txtSetX);
            Controls.Add(txtSetZ);
            Controls.Add(btnXDown);
            Controls.Add(btnXUp);
            Controls.Add(btnZDown);
            Controls.Add(btnZUp);
            Controls.Add(lblX1);
            Controls.Add(lblZ1);
            Controls.Add(cmbAssets);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "MarkolaserGIC";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbAssets;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblZ1;
        private Label lblX1;
        private Button btnZUp;
        private Button btnZDown;
        private Button btnXDown;
        private Button btnXUp;
        private TextBox txtSetZ;
        private TextBox txtSetX;
        private Button btnAddRecipe;
        private Button btnUpdateRecipe;
        private Label lblSelectAssets;
        private Label lblZMain;
        private Label lblXMain;
        private Button btnSave;
        private Button btn1;
        private Button btnResetZ;
        private Button btnResetX;
        private System.Windows.Forms.Timer timerZUp;
        private System.Windows.Forms.Timer timerXUp;
        private System.Windows.Forms.Timer timerZDown;
        private System.Windows.Forms.Timer timerXDown;
        private Button btnExit;
        private Button btnSaveAs;
        private Button btnRecipeManagement;
        private Label lblAssets1;
        private Label lblAssets2;
    }
}