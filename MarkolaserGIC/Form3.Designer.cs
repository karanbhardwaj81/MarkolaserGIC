namespace MarkolaserGIC
{
    partial class Form3
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
            chkPickPlace = new CheckBox();
            chkSensor = new CheckBox();
            lblPositionZ2 = new Label();
            txtZAxisSet = new TextBox();
            btnGoZ = new Button();
            txtMouseClickZ = new TextBox();
            txtZAxisPosition = new TextBox();
            lblPositionZ1 = new Label();
            btnZAxisDown = new Button();
            btnZAxisUp = new Button();
            lblZ_Axis = new Label();
            txtZAxis = new TextBox();
            label9 = new Label();
            label3 = new Label();
            btnPassword = new Button();
            btnExit = new Button();
            cmbRecipeManagement = new ComboBox();
            lblTempName = new Label();
            label6 = new Label();
            label5 = new Label();
            lblRecipeName = new Label();
            button1 = new Button();
            lblSelectedId = new Label();
            txtID = new TextBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            txtTemplateName = new TextBox();
            txtName = new TextBox();
            button7 = new Button();
            label2 = new Label();
            lblPositionX2 = new Label();
            txtXAxisSet = new TextBox();
            btnGoX = new Button();
            txtMouseClickX = new TextBox();
            txtXAxisPosition = new TextBox();
            lblPositionX1 = new Label();
            btnXAxisDown = new Button();
            btnXAxisUp = new Button();
            lblX_Axis = new Label();
            txtXAxis = new TextBox();
            btnHome1 = new Button();
            SuspendLayout();
            // 
            // chkPickPlace
            // 
            chkPickPlace.AutoSize = true;
            chkPickPlace.Location = new Point(162, 458);
            chkPickPlace.Name = "chkPickPlace";
            chkPickPlace.Size = new Size(141, 19);
            chkPickPlace.TabIndex = 229;
            chkPickPlace.Text = "ByPass Pick and Place";
            chkPickPlace.UseVisualStyleBackColor = true;
            // 
            // chkSensor
            // 
            chkSensor.AutoSize = true;
            chkSensor.Location = new Point(162, 422);
            chkSensor.Name = "chkSensor";
            chkSensor.Size = new Size(100, 19);
            chkSensor.TabIndex = 228;
            chkSensor.Text = "ByPass Sensor";
            chkSensor.UseVisualStyleBackColor = true;
            // 
            // lblPositionZ2
            // 
            lblPositionZ2.AutoSize = true;
            lblPositionZ2.Location = new Point(34, 265);
            lblPositionZ2.Name = "lblPositionZ2";
            lblPositionZ2.Size = new Size(90, 15);
            lblPositionZ2.TabIndex = 227;
            lblPositionZ2.Text = "Position Z-Axis:";
            // 
            // txtZAxisSet
            // 
            txtZAxisSet.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtZAxisSet.Location = new Point(162, 256);
            txtZAxisSet.Name = "txtZAxisSet";
            txtZAxisSet.Size = new Size(118, 29);
            txtZAxisSet.TabIndex = 226;
            txtZAxisSet.TextAlign = HorizontalAlignment.Center;
            // 
            // btnGoZ
            // 
            btnGoZ.Location = new Point(291, 255);
            btnGoZ.Name = "btnGoZ";
            btnGoZ.Size = new Size(105, 29);
            btnGoZ.TabIndex = 225;
            btnGoZ.Text = "Go";
            btnGoZ.UseVisualStyleBackColor = true;
            // 
            // txtMouseClickZ
            // 
            txtMouseClickZ.Location = new Point(404, 217);
            txtMouseClickZ.Name = "txtMouseClickZ";
            txtMouseClickZ.Size = new Size(36, 23);
            txtMouseClickZ.TabIndex = 224;
            txtMouseClickZ.Text = "Ok";
            txtMouseClickZ.TextAlign = HorizontalAlignment.Center;
            txtMouseClickZ.Visible = false;
            // 
            // txtZAxisPosition
            // 
            txtZAxisPosition.Location = new Point(162, 220);
            txtZAxisPosition.Name = "txtZAxisPosition";
            txtZAxisPosition.ReadOnly = true;
            txtZAxisPosition.Size = new Size(119, 23);
            txtZAxisPosition.TabIndex = 223;
            txtZAxisPosition.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPositionZ1
            // 
            lblPositionZ1.AutoSize = true;
            lblPositionZ1.Location = new Point(34, 226);
            lblPositionZ1.Name = "lblPositionZ1";
            lblPositionZ1.Size = new Size(90, 15);
            lblPositionZ1.TabIndex = 222;
            lblPositionZ1.Text = "Position Z-Axis:";
            lblPositionZ1.Click += label23_Click;
            // 
            // btnZAxisDown
            // 
            btnZAxisDown.ImageAlign = ContentAlignment.TopCenter;
            btnZAxisDown.Location = new Point(349, 217);
            btnZAxisDown.Margin = new Padding(0);
            btnZAxisDown.Name = "btnZAxisDown";
            btnZAxisDown.Size = new Size(47, 30);
            btnZAxisDown.TabIndex = 221;
            btnZAxisDown.Text = "Down";
            btnZAxisDown.TextAlign = ContentAlignment.BottomCenter;
            btnZAxisDown.UseVisualStyleBackColor = true;
            // 
            // btnZAxisUp
            // 
            btnZAxisUp.ImageAlign = ContentAlignment.TopCenter;
            btnZAxisUp.Location = new Point(290, 217);
            btnZAxisUp.Margin = new Padding(0);
            btnZAxisUp.Name = "btnZAxisUp";
            btnZAxisUp.Size = new Size(47, 30);
            btnZAxisUp.TabIndex = 220;
            btnZAxisUp.Text = "Up";
            btnZAxisUp.TextAlign = ContentAlignment.BottomCenter;
            btnZAxisUp.UseVisualStyleBackColor = true;
            // 
            // lblZ_Axis
            // 
            lblZ_Axis.AutoSize = true;
            lblZ_Axis.Location = new Point(34, 185);
            lblZ_Axis.Name = "lblZ_Axis";
            lblZ_Axis.Size = new Size(44, 15);
            lblZ_Axis.TabIndex = 219;
            lblZ_Axis.Text = "Z AXIS:";
            // 
            // txtZAxis
            // 
            txtZAxis.Location = new Point(162, 182);
            txtZAxis.Name = "txtZAxis";
            txtZAxis.Size = new Size(236, 23);
            txtZAxis.TabIndex = 218;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(744, 257);
            label9.Name = "label9";
            label9.Size = new Size(37, 15);
            label9.TabIndex = 217;
            label9.Text = "ASSY:";
            label9.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(694, 217);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 216;
            label3.Text = "PART NUMBER:";
            label3.Visible = false;
            // 
            // btnPassword
            // 
            btnPassword.Location = new Point(470, 296);
            btnPassword.Name = "btnPassword";
            btnPassword.Size = new Size(154, 30);
            btnPassword.TabIndex = 215;
            btnPassword.Text = "Reset Password";
            btnPassword.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(470, 332);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(155, 29);
            btnExit.TabIndex = 214;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // cmbRecipeManagement
            // 
            cmbRecipeManagement.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRecipeManagement.FormattingEnabled = true;
            cmbRecipeManagement.Location = new Point(209, 66);
            cmbRecipeManagement.Name = "cmbRecipeManagement";
            cmbRecipeManagement.Size = new Size(412, 23);
            cmbRecipeManagement.TabIndex = 213;
            // 
            // lblTempName
            // 
            lblTempName.AutoSize = true;
            lblTempName.Location = new Point(34, 151);
            lblTempName.Name = "lblTempName";
            lblTempName.Size = new Size(102, 15);
            lblTempName.TabIndex = 212;
            lblTempName.Text = "TEMPLATE NAME:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(684, 181);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 211;
            label6.Text = "SERIAL NUMBER:";
            label6.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(663, 143);
            label5.Name = "label5";
            label5.Size = new Size(118, 15);
            label5.TabIndex = 210;
            label5.Text = "CAGE/NCAGE CODE:";
            label5.Visible = false;
            label5.Click += label5_Click;
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.Location = new Point(34, 108);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(84, 15);
            lblRecipeName.TabIndex = 209;
            lblRecipeName.Text = "RECIPE NAME:";
            lblRecipeName.Click += lblRecipeName_Click;
            // 
            // button1
            // 
            button1.Location = new Point(470, 257);
            button1.Name = "button1";
            button1.Size = new Size(154, 30);
            button1.TabIndex = 208;
            button1.Text = "Remove Recipe";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblSelectedId
            // 
            lblSelectedId.AutoSize = true;
            lblSelectedId.Location = new Point(34, 70);
            lblSelectedId.Name = "lblSelectedId";
            lblSelectedId.Size = new Size(68, 15);
            lblSelectedId.TabIndex = 207;
            lblSelectedId.Text = "Selected ID:";
            // 
            // txtID
            // 
            txtID.Location = new Point(162, 67);
            txtID.Name = "txtID";
            txtID.Size = new Size(42, 23);
            txtID.TabIndex = 206;
            // 
            // button4
            // 
            button4.Location = new Point(470, 218);
            button4.Name = "button4";
            button4.Size = new Size(154, 30);
            button4.TabIndex = 205;
            button4.Text = "Update Recipe";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(470, 181);
            button5.Name = "button5";
            button5.Size = new Size(154, 30);
            button5.TabIndex = 204;
            button5.Text = "Get Recipe";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(470, 143);
            button6.Name = "button6";
            button6.Size = new Size(154, 30);
            button6.TabIndex = 203;
            button6.Text = "Add Recipe";
            button6.UseVisualStyleBackColor = true;
            // 
            // txtTemplateName
            // 
            txtTemplateName.Location = new Point(162, 147);
            txtTemplateName.Name = "txtTemplateName";
            txtTemplateName.Size = new Size(236, 23);
            txtTemplateName.TabIndex = 202;
            // 
            // txtName
            // 
            txtName.Location = new Point(162, 105);
            txtName.Name = "txtName";
            txtName.Size = new Size(236, 23);
            txtName.TabIndex = 201;
            // 
            // button7
            // 
            button7.Location = new Point(470, 104);
            button7.Name = "button7";
            button7.Size = new Size(154, 30);
            button7.TabIndex = 200;
            button7.Text = "Number of Recipe";
            button7.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(124, 9);
            label2.Name = "label2";
            label2.Size = new Size(303, 29);
            label2.TabIndex = 199;
            label2.Text = "Recipe Data Management";
            // 
            // lblPositionX2
            // 
            lblPositionX2.AutoSize = true;
            lblPositionX2.Location = new Point(34, 386);
            lblPositionX2.Name = "lblPositionX2";
            lblPositionX2.Size = new Size(90, 15);
            lblPositionX2.TabIndex = 239;
            lblPositionX2.Text = "Position X-Axis:";
            // 
            // txtXAxisSet
            // 
            txtXAxisSet.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtXAxisSet.Location = new Point(162, 377);
            txtXAxisSet.Name = "txtXAxisSet";
            txtXAxisSet.Size = new Size(118, 29);
            txtXAxisSet.TabIndex = 238;
            txtXAxisSet.TextAlign = HorizontalAlignment.Center;
            // 
            // btnGoX
            // 
            btnGoX.Location = new Point(291, 376);
            btnGoX.Name = "btnGoX";
            btnGoX.Size = new Size(105, 29);
            btnGoX.TabIndex = 237;
            btnGoX.Text = "Go";
            btnGoX.UseVisualStyleBackColor = true;
            // 
            // txtMouseClickX
            // 
            txtMouseClickX.Location = new Point(404, 338);
            txtMouseClickX.Name = "txtMouseClickX";
            txtMouseClickX.Size = new Size(36, 23);
            txtMouseClickX.TabIndex = 236;
            txtMouseClickX.Text = "Ok";
            txtMouseClickX.TextAlign = HorizontalAlignment.Center;
            txtMouseClickX.Visible = false;
            // 
            // txtXAxisPosition
            // 
            txtXAxisPosition.Location = new Point(162, 341);
            txtXAxisPosition.Name = "txtXAxisPosition";
            txtXAxisPosition.ReadOnly = true;
            txtXAxisPosition.Size = new Size(119, 23);
            txtXAxisPosition.TabIndex = 235;
            txtXAxisPosition.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPositionX1
            // 
            lblPositionX1.AutoSize = true;
            lblPositionX1.Location = new Point(34, 347);
            lblPositionX1.Name = "lblPositionX1";
            lblPositionX1.Size = new Size(90, 15);
            lblPositionX1.TabIndex = 234;
            lblPositionX1.Text = "Position X-Axis:";
            // 
            // btnXAxisDown
            // 
            btnXAxisDown.ImageAlign = ContentAlignment.TopCenter;
            btnXAxisDown.Location = new Point(349, 338);
            btnXAxisDown.Margin = new Padding(0);
            btnXAxisDown.Name = "btnXAxisDown";
            btnXAxisDown.Size = new Size(47, 30);
            btnXAxisDown.TabIndex = 233;
            btnXAxisDown.Text = "Down";
            btnXAxisDown.TextAlign = ContentAlignment.BottomCenter;
            btnXAxisDown.UseVisualStyleBackColor = true;
            // 
            // btnXAxisUp
            // 
            btnXAxisUp.ImageAlign = ContentAlignment.TopCenter;
            btnXAxisUp.Location = new Point(290, 338);
            btnXAxisUp.Margin = new Padding(0);
            btnXAxisUp.Name = "btnXAxisUp";
            btnXAxisUp.Size = new Size(47, 30);
            btnXAxisUp.TabIndex = 232;
            btnXAxisUp.Text = "Up";
            btnXAxisUp.TextAlign = ContentAlignment.BottomCenter;
            btnXAxisUp.UseVisualStyleBackColor = true;
            // 
            // lblX_Axis
            // 
            lblX_Axis.AutoSize = true;
            lblX_Axis.Location = new Point(34, 306);
            lblX_Axis.Name = "lblX_Axis";
            lblX_Axis.Size = new Size(44, 15);
            lblX_Axis.TabIndex = 231;
            lblX_Axis.Text = "X AXIS:";
            // 
            // txtXAxis
            // 
            txtXAxis.Location = new Point(162, 303);
            txtXAxis.Name = "txtXAxis";
            txtXAxis.Size = new Size(236, 23);
            txtXAxis.TabIndex = 230;
            // 
            // btnHome1
            // 
            btnHome1.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome1.ForeColor = Color.DarkRed;
            btnHome1.Location = new Point(706, 439);
            btnHome1.Name = "btnHome1";
            btnHome1.Size = new Size(75, 38);
            btnHome1.TabIndex = 241;
            btnHome1.Text = "Home";
            btnHome1.UseVisualStyleBackColor = true;
            btnHome1.Click += btnHome1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 492);
            Controls.Add(btnHome1);
            Controls.Add(lblPositionX2);
            Controls.Add(txtXAxisSet);
            Controls.Add(btnGoX);
            Controls.Add(txtMouseClickX);
            Controls.Add(txtXAxisPosition);
            Controls.Add(lblPositionX1);
            Controls.Add(btnXAxisDown);
            Controls.Add(btnXAxisUp);
            Controls.Add(lblX_Axis);
            Controls.Add(txtXAxis);
            Controls.Add(chkPickPlace);
            Controls.Add(chkSensor);
            Controls.Add(lblPositionZ2);
            Controls.Add(txtZAxisSet);
            Controls.Add(btnGoZ);
            Controls.Add(txtMouseClickZ);
            Controls.Add(txtZAxisPosition);
            Controls.Add(lblPositionZ1);
            Controls.Add(btnZAxisDown);
            Controls.Add(btnZAxisUp);
            Controls.Add(lblZ_Axis);
            Controls.Add(txtZAxis);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(btnPassword);
            Controls.Add(btnExit);
            Controls.Add(cmbRecipeManagement);
            Controls.Add(lblTempName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblRecipeName);
            Controls.Add(button1);
            Controls.Add(lblSelectedId);
            Controls.Add(txtID);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(txtTemplateName);
            Controls.Add(txtName);
            Controls.Add(button7);
            Controls.Add(label2);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkPickPlace;
        private CheckBox chkSensor;
        private Label label11;
        private TextBox txtZAxisSet;
        private Button btnGo;
        private TextBox txtMouseClick;
        private TextBox txtZAxisPosition;
        private Label label23;
        private Button btnZAxisDown;
        private Button btnZAxisUp;
        private Label label10;
        private TextBox txtZAxis;
        private Label label9;
        private Label label3;
        private Button btnPassword;
        private Button btnExit;
        private ComboBox combo;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button button1;
        private Label label1;
        private TextBox txtID;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox txtTemplateName;
        private TextBox txtName;
        private Button button7;
        private Label label2;
        private Label lblRecipeName;
        private Label lblSelectedId;
        private Label lblPositionZ2;
        private Label lblPositionZ1;
        private Label lblZ_Axis;
        private ComboBox cmbRecipeManagement;
        private Label lblTempName;
        private Label lblPositionX2;
        private TextBox textBox1;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label lblPositionX1;
        private Button button3;
        private Button button8;
        private Label lblX_Axis;
        private TextBox textBox4;
        private Button btnGoZ;
        private TextBox txtMouseClickZ;
        private TextBox txtXAxisSet;
        private Button btnGoX;
        private TextBox txtMouseClickX;
        private TextBox txtXAxisPosition;
        private Button btnXAxisDown;
        private Button btnXAxisUp;
        private TextBox txtXAxis;
        private Button btnHome1;
    }
}