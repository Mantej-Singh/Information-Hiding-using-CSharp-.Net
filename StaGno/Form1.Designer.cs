namespace StaGno
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picCover = new System.Windows.Forms.PictureBox();
            this.grpMessageEnc = new System.Windows.Forms.GroupBox();
            this.txtMessageEnc = new System.Windows.Forms.TextBox();
            this.txtCover = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picStegoFileEnc = new System.Windows.Forms.PictureBox();
            this.btnEncode = new System.Windows.Forms.Button();
            this.txtStegoFileEnc = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtStegoFileDec = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMessageDec = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picStegoFileDec = new System.Windows.Forms.PictureBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            this.grpMessageEnc.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStegoFileEnc)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStegoFileDec)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Location = new System.Drawing.Point(-2, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(608, 392);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.grpMessageEnc);
            this.tabPage1.Controls.Add(this.txtCover);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnEncode);
            this.tabPage1.Controls.Add(this.txtStegoFileEnc);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(600, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encoding";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picCover);
            this.groupBox1.Location = new System.Drawing.Point(31, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 198);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source File";
            // 
            // picCover
            // 
            this.picCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCover.Location = new System.Drawing.Point(6, 19);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(236, 173);
            this.picCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCover.TabIndex = 1;
            this.picCover.TabStop = false;
            this.toolTip1.SetToolTip(this.picCover, "Click me :)");
            this.picCover.Click += new System.EventHandler(this.picCover_Click_1);
            // 
            // grpMessageEnc
            // 
            this.grpMessageEnc.Controls.Add(this.txtMessageEnc);
            this.grpMessageEnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMessageEnc.ForeColor = System.Drawing.Color.Black;
            this.grpMessageEnc.Location = new System.Drawing.Point(68, 252);
            this.grpMessageEnc.Name = "grpMessageEnc";
            this.grpMessageEnc.Size = new System.Drawing.Size(463, 61);
            this.grpMessageEnc.TabIndex = 27;
            this.grpMessageEnc.TabStop = false;
            this.grpMessageEnc.Text = " Message to Hide:";
            // 
            // txtMessageEnc
            // 
            this.txtMessageEnc.Location = new System.Drawing.Point(8, 16);
            this.txtMessageEnc.Multiline = true;
            this.txtMessageEnc.Name = "txtMessageEnc";
            this.txtMessageEnc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessageEnc.Size = new System.Drawing.Size(444, 32);
            this.txtMessageEnc.TabIndex = 4;
            // 
            // txtCover
            // 
            this.txtCover.Enabled = false;
            this.txtCover.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtCover.Location = new System.Drawing.Point(31, 226);
            this.txtCover.Name = "txtCover";
            this.txtCover.Size = new System.Drawing.Size(248, 20);
            this.txtCover.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picStegoFileEnc);
            this.groupBox2.Location = new System.Drawing.Point(304, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 198);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encrypted Stegno File";
            // 
            // picStegoFileEnc
            // 
            this.picStegoFileEnc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picStegoFileEnc.Location = new System.Drawing.Point(0, 19);
            this.picStegoFileEnc.Name = "picStegoFileEnc";
            this.picStegoFileEnc.Size = new System.Drawing.Size(249, 173);
            this.picStegoFileEnc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStegoFileEnc.TabIndex = 2;
            this.picStegoFileEnc.TabStop = false;
            // 
            // btnEncode
            // 
            this.btnEncode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncode.Image = ((System.Drawing.Image)(resources.GetObject("btnEncode.Image")));
            this.btnEncode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncode.Location = new System.Drawing.Point(244, 319);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(88, 36);
            this.btnEncode.TabIndex = 28;
            this.btnEncode.Text = "  &Encode";
            this.toolTip1.SetToolTip(this.btnEncode, "Press to hide the message in image ");
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click_1);
            // 
            // txtStegoFileEnc
            // 
            this.txtStegoFileEnc.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtStegoFileEnc.Location = new System.Drawing.Point(304, 226);
            this.txtStegoFileEnc.Name = "txtStegoFileEnc";
            this.txtStegoFileEnc.Size = new System.Drawing.Size(255, 20);
            this.txtStegoFileEnc.TabIndex = 31;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.txtStegoFileDec);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.btnDecode);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(600, 366);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decoding";
            // 
            // txtStegoFileDec
            // 
            this.txtStegoFileDec.Enabled = false;
            this.txtStegoFileDec.Location = new System.Drawing.Point(147, 217);
            this.txtStegoFileDec.Name = "txtStegoFileDec";
            this.txtStegoFileDec.Size = new System.Drawing.Size(292, 20);
            this.txtStegoFileDec.TabIndex = 34;
            this.txtStegoFileDec.Text = "Input Stagnographed image path....";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtMessageDec);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(77, 284);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(463, 54);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hidden Message:";
            // 
            // txtMessageDec
            // 
            this.txtMessageDec.Location = new System.Drawing.Point(9, 19);
            this.txtMessageDec.Multiline = true;
            this.txtMessageDec.Name = "txtMessageDec";
            this.txtMessageDec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessageDec.Size = new System.Drawing.Size(444, 32);
            this.txtMessageDec.TabIndex = 19;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.picStegoFileDec);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(147, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 191);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stegno File";
            // 
            // picStegoFileDec
            // 
            this.picStegoFileDec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picStegoFileDec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picStegoFileDec.Location = new System.Drawing.Point(6, 19);
            this.picStegoFileDec.Name = "picStegoFileDec";
            this.picStegoFileDec.Size = new System.Drawing.Size(280, 166);
            this.picStegoFileDec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStegoFileDec.TabIndex = 1;
            this.picStegoFileDec.TabStop = false;
            this.picStegoFileDec.Click += new System.EventHandler(this.picStegoFileDec_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.Image = ((System.Drawing.Image)(resources.GetObject("btnDecode.Image")));
            this.btnDecode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecode.Location = new System.Drawing.Point(240, 241);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(88, 36);
            this.btnDecode.TabIndex = 20;
            this.btnDecode.Text = "   &Decode";
            this.toolTip1.SetToolTip(this.btnDecode, "Extract the secret message");
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightGray;
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(600, 366);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(600, 366);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(608, 389);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SteGno: NMS Project";
            this.Load += new System.EventHandler(this.Form1_Unload);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            this.grpMessageEnc.ResumeLayout(false);
            this.grpMessageEnc.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStegoFileEnc)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStegoFileDec)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picCover;
        private System.Windows.Forms.GroupBox grpMessageEnc;
        private System.Windows.Forms.TextBox txtMessageEnc;
        private System.Windows.Forms.TextBox txtCover;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picStegoFileEnc;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.TextBox txtStegoFileEnc;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox picStegoFileDec;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMessageDec;
        private System.Windows.Forms.TextBox txtStegoFileDec;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RichTextBox richTextBox1;

    }
}

