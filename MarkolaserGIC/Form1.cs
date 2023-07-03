using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using ExcelDataReader;
using OfficeOpenXml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MarkolaserGIC
{
    public partial class Form1 : Form
    {
        private int counterz = 0;
        private int counterx = 0;
        private bool isIncrementing = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void cmbAssets_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedIndex = cmbAssets.SelectedIndex.ToString();

            lblAssets1.Text = selectedIndex.ToString();


        }

        private void lblSelectAssets_Click(object sender, EventArgs e)
        {

        }

        private void btnZUp_Click(object sender, EventArgs e)
        {
            counterz++;
            if (counterz > 100)
                counterz = 100;

            lblZ1.Text = counterz.ToString();
        }

        private void btnZDown_Click(object sender, EventArgs e)
        {
            counterz--;
            if (counterz <= 0)
                counterz = 0;

            lblZ1.Text = counterz.ToString();
        }

        private void btnXUp_Click(object sender, EventArgs e)
        {
            counterx++;
            if (counterx > 100)
                counterx = 100;

            lblX1.Text = counterx.ToString();
        }

        private void btnXDown_Click(object sender, EventArgs e)
        {
            counterx--;
            if (counterx <= 0)
                counterx = 0;

            lblX1.Text = counterx.ToString();
        }

        private void btnResetZ_Click(object sender, EventArgs e)
        {
            counterz = 0;
            lblZ1.Text = "0";
            txtSetZ.Text = String.Empty;
        }

        private void btnResetX_Click(object sender, EventArgs e)
        {
            counterx = 0;
            lblX1.Text = "0";
            txtSetX.Text = String.Empty;
        }

        private void btnZUp_MouseDown(object sender, MouseEventArgs e)
        {
            isIncrementing = true;
            timerZUp.Start();
        }

        private void btnZUp_MouseUp(object sender, MouseEventArgs e)
        {
            isIncrementing = false;
            timerZUp.Stop();
        }
        private void btnZDown_MouseDown(object sender, MouseEventArgs e)
        {
            isIncrementing = true;
            timerZDown.Start();
        }

        private void btnZDown_MouseUp(object sender, MouseEventArgs e)
        {
            isIncrementing = false;
            timerXUp.Stop();
        }

        private void btnXUp_MouseDown(object sender, MouseEventArgs e)
        {
            isIncrementing = true;
            timerXUp.Start();
        }

        private void btnXUp_MouseUp(object sender, MouseEventArgs e)
        {
            isIncrementing = false;
            timerXUp.Stop();
        }

        private void btnXDown_MouseDown(object sender, MouseEventArgs e)
        {
            isIncrementing = true;
            timerXDown.Start();
        }

        private void btnXDown_MouseUp(object sender, MouseEventArgs e)
        {
            isIncrementing = false;
            timerXDown.Stop();
        }

        private void timerZUp_Tick(object sender, EventArgs e)
        {
            if (isIncrementing)
            {
                counterz++;
                if (counterz > 100)
                    counterz = 100;

                lblZ1.Text = counterz.ToString();
            }
            else
            {
                timerZUp.Stop();
            }
        }

        private void timerXUp_Tick(object sender, EventArgs e)
        {
            if (isIncrementing)
            {
                counterx++;
                if (counterx > 100)
                    counterx = 100;

                lblX1.Text = counterx.ToString();
            }
            else
            {
                timerXUp.Stop();
            }

        }

        private void timerZDown_Tick(object sender, EventArgs e)
        {
            if (isIncrementing)
            {
                counterz--;
                if (counterz <= 0)
                    counterz = 0;

                lblZ1.Text = counterz.ToString();
            }
            else
            {
                timerZDown.Stop();
            }

        }

        private void timerXDown_Tick(object sender, EventArgs e)
        {
            if (isIncrementing)
            {
                counterx--;
                if (counterx <= 0)
                    counterx = 0;

                lblX1.Text = counterx.ToString();
            }
            else
            {
                timerXDown.Stop();
            }

        }

        private void txtSetZ_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(txtSetZ.Text, out value))
            {
                if (value >= 0 && value <= 100)
                {
                    counterz = value;
                    lblZ1.Text = counterz.ToString();
                }
            }
        }

        private void txtSetX_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(txtSetX.Text, out value))
            {
                if (value >= 0 && value <= 100)
                {
                    counterx = value;
                    lblX1.Text = counterx.ToString();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string filePath = @"D:\Karan Bhardwaj\GIC\Assets\GIC I_O LIST.xlsx";
            string sheetName = "I_O_LIST";
            int columnName = 2;

            try
            {
                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    var worksheet = package.Workbook.Worksheets[sheetName];
                    var names = new List<string>();

                    for (int row = worksheet.Dimension.Start.Row + 1; row <= worksheet.Dimension.End.Row; row++)
                    {
                        var cellValue = worksheet.Cells[row, columnName].Value;
                        if (cellValue != null)
                        {
                            names.Add(cellValue.ToString());
                        }
                    }

                    cmbAssets.DataSource = names;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while reading the Excel file: " + ex.Message);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string filePath = @"D:\Karan Bhardwaj\GIC\config\demoConfigGIC.dat";

            DateTime currentDateTime = DateTime.Now;

            // Format the date and time as desired
            string formattedDateTime = currentDateTime.ToString("dd-MM-yyyy HH:mm:ss");

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    // Write the label data to the text file
                    writer.WriteLine(formattedDateTime + ";Z_Axis=" + lblZ1.Text + ";X_Axis=" + lblX1.Text);
                    //writer.WriteLine("");
                    // Add more labels as needed

                    MessageBox.Show("Label data saved successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while saving the label data: " + ex.Message);
            }
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt";
            saveFileDialog.Title = "Save Label Data";
            DateTime currentDateTime = DateTime.Now;

            // Format the date and time as desired
            string formattedDateTime = currentDateTime.ToString("dd-MM-yyyy HH:mm:ss");

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        // Write the label data to the text file
                        writer.WriteLine("Z Axis: " + lblZ1.Text);
                        writer.WriteLine("X Axis: " + lblX1.Text);
                        writer.WriteLine("Current Date/Time: " + formattedDateTime);
                        // Add more labels as needed

                        MessageBox.Show("Label data saved successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred while saving the label data: " + ex.Message);
                }
            }
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();

        }

        private void btnRecipeManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

    }
}