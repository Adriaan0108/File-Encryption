using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace File_Encryption
{
    public partial class Encryption_Program : Form
    {
        public Encryption_Program()
        {
            InitializeComponent();
        }

        string fileOrigional = "";  //Declaring global variables
        string fileEncrypted = "";

        public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null; //Declaring empty array of salt bytes

            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 }; //Assigning values to the array

            using (MemoryStream memorystrm = new MemoryStream()) //Encapsulating data to be accessed by memory
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256; //Setting key size
                    AES.BlockSize = 128; //Setting block size

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000); //Implementing password-based key derivation functionality
                    AES.Key = key.GetBytes(AES.KeySize / 8); //Gets the size of the secret key
                    AES.IV = key.GetBytes(AES.BlockSize / 8); //Gets initialization vector from the block size

                    AES.Mode = CipherMode.CBC; //Setting block cipher mode to Cipher Block Chaining (CBC)

                    using (var cs = new CryptoStream(memorystrm, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length); //Writes bytes to CryptoStream 
                        cs.Close();
                    }
                    encryptedBytes = memorystrm.ToArray();
                }
            }

            return encryptedBytes;
        }

        public static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null; //Declaring empty array of salt bytes

            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };  //Assigning values to the array

            using (MemoryStream memorystrm = new MemoryStream()) //Encapsulating data to be accessed by memory
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256; //Setting key size
                    AES.BlockSize = 128; //Setting block size

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8); //Gets the size of the secret key
                    AES.IV = key.GetBytes(AES.BlockSize / 8); //Gets initialization vector

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(memorystrm, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length); //Writes bytes to CryptoStream 
                        cs.Close();
                    }
                    decryptedBytes = memorystrm.ToArray();
                }
            }

            return decryptedBytes;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = false; //Disallows multiple file selections
            if (od.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = od.FileName; //Obtaining filepath for hidden textbox
                fileOrigional = od.FileName; //File to be encrypt set as file selected
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            Boolean doNotEncrypt = false;  //Variable to ensure that file is ready to be encrypted (file selected + password filled in)

            try
            {
                if (!File.Exists(tbPath.Text)) //Input validation
                {
                    MessageBox.Show("File does not exist."); //Error if no fileis selected or the file does not exist
                    doNotEncrypt = true;
                    return;
                }
                if (String.IsNullOrEmpty(tbPassword.Text))
                {
                    MessageBox.Show("Password empty. Please enter your password"); //Error if no password is filled in
                    doNotEncrypt = true;
                    return;
                }
                if (!doNotEncrypt) //Case if file is ready to be encrypted
                {
                    EncryptFile();
                    File.Delete(tbPath.Text); //Deleting origional file after encrypted file has been saved
                    MessageBox.Show("Encryption successful!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!");
            }
        }

        private void btnBrowseDecrypt_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = false;
            if (od.ShowDialog() == DialogResult.OK) //File to be decrypt set as file selected
            {
                fileEncrypted = od.FileName;
                tbFilePathDecrypt.Text = od.FileName;  //Obtaining filepath for hidden textbox
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            Boolean noFileSelected = true; //Variable to ensure that file is ready to be decrypted (file selected + password filled in)

            if (tbFilePathDecrypt.Text != "")
            {
                noFileSelected = false; //Case is file path is selected
            }

            try
            {
                DecryptFile();
                File.Delete(tbFilePathDecrypt.Text); //Deleting ecrypted file after decrypted file has been saved
                MessageBox.Show("Decryption successful!");
            }
            catch (Exception ex)
            {
                if (noFileSelected)
                {
                    MessageBox.Show("No file selected"); //Error if no file was selected
                }
                else
                {
                    MessageBox.Show("Password incorrect"); //Error if password is incorrect
                }
            }
        }

        public void EncryptFile()
        {
            string password = ""; //Declaring password as empty string

            password = tbPassword.Text; //Setting password to the user provided password

            byte[] bytesToBeEncrypted = File.ReadAllBytes(fileOrigional); //Reads the contents of the file into the byte array
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password); //Encoding characters using password

            passwordBytes = SHA256.Create().ComputeHash(passwordBytes); //Hashing the password with SHA256

            byte[] bytesEncrypted = AES_Encrypt(bytesToBeEncrypted, passwordBytes); //Calling AES_Encrypt method

            String fileExt = Path.GetExtension(tbPath.Text); //Obtaining file extention from file path
            SaveFileDialog sd = new SaveFileDialog(); //Showing Save File Diaglog box to save te encrypted file
            sd.Filter = "Files (*" + fileExt + ") | *" + fileExt; //Adding file extention of the origional file
            if (sd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(sd.FileName, bytesEncrypted); //Saving encrypted file to selected location
            }
        }

        public void DecryptFile()
        {
            string password = "";

            password = tbpasswordDecrypt.Text;

            byte[] bytesToBeDecrypted = File.ReadAllBytes(fileEncrypted); //Reads the contents of the file into the byte array
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password); //Encoding characters using password
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesDecrypted = AES_Decrypt(bytesToBeDecrypted, passwordBytes); //Calling AES_Decrypt method

            String fileExt = Path.GetExtension(tbFilePathDecrypt.Text);
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Files (*" + fileExt + ") | *" + fileExt;
            if (sd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(sd.FileName, bytesDecrypted); //Saving decrypted file to selected location
            }
        }
        
    }
}
