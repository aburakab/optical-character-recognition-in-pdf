#region Copyright Syncfusion Inc. 2001 - 2007
//
//  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Re-distribution in any form is strictly
//  prohibited. Any infringement will be prosecuted under applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.OCRProcessor;
using Syncfusion.Pdf.Parsing;
using System.Collections.Generic;

namespace EssentialPDFSamples
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : Form
    {
        private const string _syncfusionVersion = "18.4.0.30";

        #region Private Members

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Panel panelRegion;
        private GroupBox groupRegion;
        private Label lblXCoordinate;
        private Label lblHeight;
        private Label lblYCoordinate;
        private Label lblWidth;
        private NumericUpDown txtXCoordinate;
        private NumericUpDown txtWidth;
        private NumericUpDown txtYCoordinate;
        private NumericUpDown txtHeight;
        private RadioButton rbtnFullDocument;
        private RadioButton rbtnRegion;
        private GroupBox groupBox3;
        private TextBox textBox1;
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private Label label1;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        private string _tesseractBinaries;
        private string _version;

        # endregion

        # region Constructor
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.MinimizeBox = true;
            Application.EnableVisualStyles();
            this.openFileDialog1.Filter = "PDF files (*.pdf)|*.pdf";
            this.pictureBox1.Image = new Bitmap("../../Data/pdf_header.png");
            
            //textBox1.Tag = @"..\..\Data\english-sample.pdf";
            //textBox1.Text = "english-sample.pdf";
            textBox1.Tag = @"..\..\Data\arabic-sample.pdf";
            textBox1.Text = "arabic-sample.pdf";
            
            this.Height = 310;
            panelRegion.Visible = false;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            _version = "3.05/x86";
            _tesseractBinaries = $@"../../packages/Syncfusion.Pdf.OCR.WinForms.{_syncfusionVersion}/lib/TesseractBinaries/{_version}";
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRegion = new System.Windows.Forms.Panel();
            this.groupRegion = new System.Windows.Forms.GroupBox();
            this.txtHeight = new System.Windows.Forms.NumericUpDown();
            this.txtYCoordinate = new System.Windows.Forms.NumericUpDown();
            this.txtWidth = new System.Windows.Forms.NumericUpDown();
            this.txtXCoordinate = new System.Windows.Forms.NumericUpDown();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblYCoordinate = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblXCoordinate = new System.Windows.Forms.Label();
            this.rbtnFullDocument = new System.Windows.Forms.RadioButton();
            this.rbtnRegion = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRegion.SuspendLayout();
            this.groupRegion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYCoordinate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXCoordinate)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(283, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "PDF";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 89);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // panelRegion
            // 
            this.panelRegion.Controls.Add(this.groupRegion);
            this.panelRegion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRegion.Location = new System.Drawing.Point(0, 278);
            this.panelRegion.Name = "panelRegion";
            this.panelRegion.Size = new System.Drawing.Size(377, 106);
            this.panelRegion.TabIndex = 26;
            this.panelRegion.Visible = false;
            // 
            // groupRegion
            // 
            this.groupRegion.Controls.Add(this.txtHeight);
            this.groupRegion.Controls.Add(this.txtYCoordinate);
            this.groupRegion.Controls.Add(this.txtWidth);
            this.groupRegion.Controls.Add(this.txtXCoordinate);
            this.groupRegion.Controls.Add(this.lblHeight);
            this.groupRegion.Controls.Add(this.lblYCoordinate);
            this.groupRegion.Controls.Add(this.lblWidth);
            this.groupRegion.Controls.Add(this.lblXCoordinate);
            this.groupRegion.Location = new System.Drawing.Point(4, -1);
            this.groupRegion.Name = "groupRegion";
            this.groupRegion.Size = new System.Drawing.Size(365, 82);
            this.groupRegion.TabIndex = 0;
            this.groupRegion.TabStop = false;
            this.groupRegion.Text = "Region";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(209, 58);
            this.txtHeight.Maximum = new decimal(new int[] {
            1684,
            0,
            0,
            0});
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(40, 20);
            this.txtHeight.TabIndex = 30;
            // 
            // txtYCoordinate
            // 
            this.txtYCoordinate.Location = new System.Drawing.Point(209, 21);
            this.txtYCoordinate.Maximum = new decimal(new int[] {
            1684,
            0,
            0,
            0});
            this.txtYCoordinate.Name = "txtYCoordinate";
            this.txtYCoordinate.Size = new System.Drawing.Size(40, 20);
            this.txtYCoordinate.TabIndex = 29;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(51, 58);
            this.txtWidth.Maximum = new decimal(new int[] {
            1190,
            0,
            0,
            0});
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(40, 20);
            this.txtWidth.TabIndex = 28;
            // 
            // txtXCoordinate
            // 
            this.txtXCoordinate.Location = new System.Drawing.Point(51, 18);
            this.txtXCoordinate.Maximum = new decimal(new int[] {
            1190,
            0,
            0,
            0});
            this.txtXCoordinate.Name = "txtXCoordinate";
            this.txtXCoordinate.Size = new System.Drawing.Size(42, 20);
            this.txtXCoordinate.TabIndex = 27;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(162, 58);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(44, 13);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = "Height :";
            // 
            // lblYCoordinate
            // 
            this.lblYCoordinate.AutoSize = true;
            this.lblYCoordinate.Location = new System.Drawing.Point(162, 21);
            this.lblYCoordinate.Name = "lblYCoordinate";
            this.lblYCoordinate.Size = new System.Drawing.Size(44, 13);
            this.lblYCoordinate.TabIndex = 4;
            this.lblYCoordinate.Text = "Y         :";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(10, 57);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(41, 13);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Width :";
            // 
            // lblXCoordinate
            // 
            this.lblXCoordinate.AutoSize = true;
            this.lblXCoordinate.Location = new System.Drawing.Point(10, 20);
            this.lblXCoordinate.Name = "lblXCoordinate";
            this.lblXCoordinate.Size = new System.Drawing.Size(41, 13);
            this.lblXCoordinate.TabIndex = 0;
            this.lblXCoordinate.Text = "X        :";
            // 
            // rbtnFullDocument
            // 
            this.rbtnFullDocument.AutoSize = true;
            this.rbtnFullDocument.Checked = true;
            this.rbtnFullDocument.Location = new System.Drawing.Point(9, 75);
            this.rbtnFullDocument.Name = "rbtnFullDocument";
            this.rbtnFullDocument.Size = new System.Drawing.Size(142, 17);
            this.rbtnFullDocument.TabIndex = 27;
            this.rbtnFullDocument.TabStop = true;
            this.rbtnFullDocument.Text = "Complete Document";
            this.rbtnFullDocument.UseVisualStyleBackColor = true;
            // 
            // rbtnRegion
            // 
            this.rbtnRegion.AutoSize = true;
            this.rbtnRegion.Location = new System.Drawing.Point(166, 75);
            this.rbtnRegion.Name = "rbtnRegion";
            this.rbtnRegion.Size = new System.Drawing.Size(64, 17);
            this.rbtnRegion.TabIndex = 28;
            this.rbtnRegion.TabStop = true;
            this.rbtnRegion.Text = "Region";
            this.rbtnRegion.UseVisualStyleBackColor = true;
            this.rbtnRegion.CheckedChanged += new System.EventHandler(this.rbtnRegion_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.rbtnRegion);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.rbtnFullDocument);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(4, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(365, 104);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Choose a PDF file to process OCR";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 21);
            this.textBox1.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(331, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 22);
            this.button2.TabIndex = 33;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(-3, 99);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Size = new System.Drawing.Size(382, 46);
            this.label1.TabIndex = 34;
            this.label1.Text = "This sample demonstrates the process of OCR an existing scanned PDF document and " +
    "this will convert scanned PDF document to searchable PDF document.";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(377, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panelRegion);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OCR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRegion.ResumeLayout(false);
            this.groupRegion.ResumeLayout(false);
            this.groupRegion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYCoordinate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXCoordinate)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }

        #endregion

        #region Events
        private void button1_Click(object sender, EventArgs e)
        {
            var tesseractVersion = TesseractVersion.Version3_05;

            var result = MessageBox.Show(
                "Would you like to use 4.0 instead of 3.05?", "Tesseract Version",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                tesseractVersion = TesseractVersion.Version4_0;
                _version = "4.0/x64";
                _tesseractBinaries =
                    $@"../../packages/Syncfusion.Pdf.OCR.WinForms.{_syncfusionVersion}/lib/TesseractBinaries/{_version}";
            }

            //Initialize the OCR processor
            using (var processor = new OCRProcessor(_tesseractBinaries))
            {
                //Load the PDF document 
                var lDoc = new PdfLoadedDocument(textBox1.Tag.ToString());

                //Language to process the OCR
                processor.Settings.Language = (result == DialogResult.Yes ? "ara" : Languages.English);
                processor.Settings.Performance = Performance.Slow;
                processor.Settings.TesseractVersion = tesseractVersion;

                if (rbtnRegion.Checked)
                {
                    int.TryParse(txtXCoordinate.Text, out var x);
                    int.TryParse(txtYCoordinate.Text, out var y);
                    int.TryParse(txtWidth.Text, out var width);
                    int.TryParse(txtHeight.Text, out var height);
                    var rect = new RectangleF(x, y, width, height);

                    //Assign the rectangles to the page
                    var region = new PageRegion();
                    var pageRegions = new List<PageRegion>();
                    region.PageIndex = 0;
                    region.PageRegions = new RectangleF[] { rect };
                    pageRegions.Add(region);
                    processor.Settings.Regions = pageRegions;
                }

                //Process OCR by providing loaded PDF document, Data dictionary and language
                var text = processor.PerformOCR(lDoc, tesseractVersion == TesseractVersion.Version4_0 ?
                    $@"../../packages/Syncfusion.Pdf.OCR.WinForms.{_syncfusionVersion}/lib/LanguagePack-4.0/" :
                    $@"../../packages/Syncfusion.Pdf.OCR.WinForms.{_syncfusionVersion}/lib/LanguagePack-3.05/");

                //Save the OCR processed PDF document in the disk
                lDoc.Save("OCRedPDF.pdf");
                lDoc.Close(true);

                MessageBox.Show(text);
            }
            //Message box confirmation to view the created PDF document.
            if (MessageBox.Show("Do you want to view the PDF file?", "PDF File Created",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                //Launching the PDF file using the default Application.[Acrobat Reader]
                System.Diagnostics.Process.Start("OCRedPDF.pdf");
                this.Close();
            }
            else
            {
                // Exit
                this.Close();
            }
        }
        /// <summary>
        /// Gets the full path of the PDF template or image.
        /// </summary>
        /// <param name="fileName">Name of the file</param>
        /// <param name="image">True if image</param>
        /// <returns>Path of the file</returns>
        private string GetFullTemplatePath(string fileName)
        {
            string fullPath = @"..\..\..\..\..\..\..\..\Common\";
            string folder = "Data\\PDF";

            return string.Format(@"{0}{1}\{2}", fullPath, folder, fileName);
        }
        /// <summary>
        /// Gets the full path of the PDF template or image.
        /// </summary>
        /// <param name="fileName">Name of the file</param>
        /// <param name="image">True if image</param>
        /// <returns>Path of the file</returns>
        private string GetFullTemplatePath(string fileName, bool image)
        {
            string fullPath = @"..\..\..\..\..\..\..\..\Common\";
            string folder = image ? "Images" : "Data";

            return string.Format(@"{0}{1}\PDF\{2}", fullPath, folder, fileName);
        }
        # endregion

        private void rbtnRegion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRegion.Checked)
            {
                this.Height = 428;
                panelRegion.Visible = true;
            }
            else
            {
                this.Height = 310;
                panelRegion.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");
            //this.Height = 218;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.SafeFileName;
                textBox1.Tag = openFileDialog1.FileName;
            }
        }
    }
}