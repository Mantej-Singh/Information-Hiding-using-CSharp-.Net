using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Steganography;

namespace StaGno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   

        private void picCover_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Filter = "Windows Bitmap (*.bmp)|*.bmp| JPEG (*.jpg)|*.jpg|All files (*.*)|*.*";
            ofd.InitialDirectory = @"C:\Users\Jarvis\Pictures";
            try
            {
                if (ofd.ShowDialog(this) != DialogResult.Cancel)
                {
                    txtCover.Text = ofd.FileName;
                    Image pic = new Bitmap(txtCover.Text);
                    // FitPic(pic, picCover);
                    picCover.Image = new Bitmap(pic);
                    pic.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk.", "Error : " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        
        private void btnEncode_Click_1(object sender, EventArgs e)
        {

            string pic = txtCover.Text;
            string message = txtMessageEnc.Text;
            
            if (pic == "")
            {
                MessageBox.Show("Select the Cover(source BMP File)", "Inappropriate Jump " , MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (message == "")
            {
                MessageBox.Show("Type the Message to hide", "Inappropriate Jump ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Windows Bitmap (*.bmp)|*.bmp";
            sfd.RestoreDirectory = true;
            sfd.CheckFileExists = false;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                txtStegoFileEnc.Text = sfd.FileName;
            }
            string stegoFile = txtStegoFileEnc.Text;
            /*
            if (stegoFile == "")
            {
                MessageBox.Show("Type the name of the stego file");
                return;
            } */

            if (!stegoFile.ToLower().EndsWith(".bmp"))
                stegoFile += ".bmp";

           

            try
            {

                // Open the cover
                ICoverFile cover = new BMPCoverFile(pic);

                // Create the stego file
                cover.CreateStegoFile(stegoFile, message, "mhd9"); //<---- Professor,here i have hardcoded the password string
                //Thus making this application dependent.

                MessageBox.Show("Message hidden successfully", "Success :)", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Image stegoPic = new Bitmap(stegoFile);
                //FitPic(stegoPic, picStegoFileEnc);
                picStegoFileEnc.Image = new Bitmap(stegoPic);
                stegoPic.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Critical error.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }


        private void btnDecode_Click(object sender, EventArgs e)
        {
            string stegoFile = txtStegoFileDec.Text;
          
            if (stegoFile == "")
            {
                MessageBox.Show("Select the Stegnographed file to decode");
                return;
            }


            try
            {

                // Open the stego file
                IStegoFile stego = new BMPStegoFile(stegoFile, "mhd9");

                // Show the hidden message
                txtMessageDec.Text = stego.HiddenMessage;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Critical error.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void picStegoFileDec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Filter = "Windows Bitmap (*.bmp)|*.bmp";
            if (ofd.ShowDialog(this) != DialogResult.Cancel)
            {
                txtStegoFileDec.Text = ofd.FileName;
                Image pic = new Bitmap(txtStegoFileDec.Text);
                picStegoFileDec.Image = new Bitmap(pic);
                pic.Dispose();

            }	
        }

        private void Form1_Unload(object sender, EventArgs e)
        {
            //Application.Exit();

        }
      protected override void OnFormClosing(FormClosingEventArgs e)
      {
          base.OnFormClosing(e);

          if (e.CloseReason == CloseReason.WindowsShutDown) return;

          // Confirm user wants to close
          switch (MessageBox.Show(this, "Are you sure you want to close?", "See You Again :) ", MessageBoxButtons.YesNo,MessageBoxIcon.Question))
          {
              case DialogResult.No:
                  e.Cancel = true;
                  break;

              default:
                  Application.Exit();
                  break;
                  

          }
      }
    }
 }

