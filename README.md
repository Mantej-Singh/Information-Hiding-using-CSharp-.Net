<p align="center">
  <img src="http://s19.postimg.org/vg0dp27cj/Pampa_ds160.png">
</p>

# Information Hiding using C#.Net
## Steganography Application

### It's much more difficult to decrypt a message if you don't know that there is a message.

Information Hiding is a branch of computer science that deals with concealing the existence of a message.
It is related to cryptography whose intent is to render messages unreadable except by the intended recipients

<p align="center">
  <img src="http://s19.postimg.org/5vy3imlyr/Pampa_ds160.png">
</p>

### Steganography- 
 •	Took from the Greek word steganos meaning “covered” and the Greek word graphie meaning “writing”
 
 •	Steganography is the process of hiding of a secret message within an ordinary message and extracting it at its destination
 
 •	Anyone else viewing the message will fail to know it contains hidden/encrypted data

-----

## Installation
### From a DLL File: stego.dll
`using Steganography;`


## Implementation:
`
if (!stegoFile.ToLower().EndsWith(".bmp"))stegoFile += ".bmp";

             try
            {

                // Open the cover
                ICoverFile cover = new BMPCoverFile(pic);

                // Create the stego file
                cover.CreateStegoFile(stegoFile, message, "password"); //<---- Here I'm hardcoding the password string
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
`
## Outputs:
### Loading the bmp files-
[![Pampa ds160.png](https://s19.postimg.org/x93addsj7/Pampa_ds160.png)](https://postimg.org/image/v4ixcaqwf/)
### Encodein the image-
[![Pampa ds160.png](https://s19.postimg.org/pudyl06nn/Pampa_ds160.png)](https://postimg.org/image/zexl7vvzj/)
### Success in Encoding-
[![Pampa ds160.png](https://s19.postimg.org/moxy8jdf7/Pampa_ds160.png)](https://postimg.org/image/go09bgqsv/)
[![Pampa ds160.png](https://s19.postimg.org/5pozta27n/Pampa_ds160.png)](https://postimg.org/image/rc40ab0rz/)
### Decoding the bmp file-
[![Pampa ds160.png](https://s19.postimg.org/51g5ac3hv/Pampa_ds160.png)](https://postimg.org/image/6ghpz24kv/)
[![Pampa ds160.png](https://s19.postimg.org/6uj1ynooj/Pampa_ds160.png)](https://postimg.org/image/6509mao4v/)

