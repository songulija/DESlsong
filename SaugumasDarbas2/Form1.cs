using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaugumasDarbas2
{
    
    public partial class Form1 : Form
    {
        

        // Create a string to encrypt.
        string passwordECB = "password";
        string passwordCBC = "password";
        //string FileName = "CText.txt";
        string FileNameECB = @"c:\Users\PC\source\repos\SaugumasDarbas2\SaugumasDarbas2\ecbEncrypt.txt";
        string FileNameCBC = @"C:\Users\PC\source\repos\SaugumasDarbas2\SaugumasDarbas2\cbcEncrypt.txt";

        string desType = "";
        string decryptType = "";

        string decryptTypeFile = "";

        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Encrypt combobox
            comboBox1.Items.Insert(0, "ECB");
            comboBox1.Items.Insert(1, "CBC");

            //decrypt combobox
            comboBox2.Items.Insert(0, "ECB");
            comboBox2.Items.Insert(1, "CBC");

            //decrypt file combobox
            comboBox3.Items.Insert(0, "ECB");
            comboBox3.Items.Insert(1, "CBC");


        }



        private void Encrypt_Click(object sender, EventArgs e)
        {
            try
            {

                if (encryptTextbox.Text != "" && encryptTextbox.Text != null)
                {
                    if (desType == "ECB")
                    {
                        // Create or open the specified file.
                        FileStream fileStreamECB = File.Open(FileNameECB, FileMode.OpenOrCreate);
                        fileStreamECB.SetLength(0);
                        fileStreamECB.Close(); // This flushes the content, too.

                        //ECB ENCRYPTION VARS
                        string unencryptedStringEBC = encryptTextbox.Text;//text to encrypt from textbox
                        string encryptedStringECB;

                        //ECB ENCRYPTION
                        Console.WriteLine("ECB ENCRYPTION ...: ");
                        Console.WriteLine("Unencrypted String: " + unencryptedStringEBC);
                        Console.WriteLine("Password: " + passwordECB);

                        encryptedStringECB = EncryptionECB(unencryptedStringEBC, passwordECB, FileNameECB);
                        Console.WriteLine("Encrypted String: " + encryptedStringECB);


                    }
                    else if(desType == "CBC")
                    {
                        // Create or open the specified file.
                        FileStream fileStreamCBC = File.Open(FileNameCBC, FileMode.OpenOrCreate);
                        fileStreamCBC.SetLength(0);
                        fileStreamCBC.Close(); // This flushes the content, too.

                        //CBC ENCRYPTION VARS
                        string unencryptedStringCBC = encryptTextbox.Text;//text to encrypt from textbox
                        string encryptedStringCBC;

                        //CBC ENCRYPTION
                        Console.WriteLine("CBC ENCRYPTION ...: ");
                        Console.WriteLine("Unencrypted String: " + unencryptedStringCBC);
                        Console.WriteLine("Password: " + passwordCBC);

                        encryptedStringCBC = EncryptionCBC(unencryptedStringCBC, passwordCBC, FileNameCBC);
                        Console.WriteLine("Encrypted String CBC: " + encryptedStringCBC);

                    }
                }
                else//if there is no text typed to encrypt
                {
                    MessageBox.Show("Write text to textbox to encrypt it!!!");

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void descrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (decryptTextbox.Text != "" && decryptTextbox.Text != null)
                {
                    if (decryptType == "ECB")
                    {
                        
                        //ECB ENCRYPTION VARS
                        string decryptedStringECB;
                        string encryptedStringECB = decryptTextbox.Text;
                        
                        decryptedStringECB = DecryptionECB(encryptedStringECB, passwordECB, FileNameECB);
                        Console.WriteLine("Decrypted String: " + decryptedStringECB);

                        decriptionResultTextbox.Text = decryptedStringECB;//show decripted text in decriptionResultTextbox


                    }
                    else if (decryptType == "CBC")
                    {
                        //ECB ENCRYPTION VARS
                        string decryptedStringCBC;
                        string encryptedStringCBC = decryptTextbox.Text;

                        decryptedStringCBC = DecryptionCBC(encryptedStringCBC, passwordCBC, FileNameCBC);
                        Console.WriteLine("Decrypted String: " + decryptedStringCBC);

                        decriptionResultTextbox.Text = decryptedStringCBC;//show decripted text in decriptionResultTextbox
                    }
                }
                else//if there is no text typed to encrypt
                {
                    MessageBox.Show("Write text to textbox to encrypt it!!!");

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void decryptFromFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (decryptTypeFile == "ECB")//if decryptTypeFile is equal to ECB THEH...
                {
                    // Create a StreamReader using the CryptoStream. to read from file ECB txt
                    StreamReader sReader = new StreamReader(FileNameECB);

                    // Read the data from the stream to decrypt it.
                    string val = sReader.ReadLine();
                    Console.WriteLine(val.ToString());

                    sReader.Close();

                    //ECB ENCRYPTION VARS
                    string decryptedStringECB;
                    string encryptedStringECB = val;//setting encryptedStrinEcb to encrypted string that i got from ecb.txt file

                    decryptedStringECB = DecryptionECB(encryptedStringECB, passwordECB, FileNameECB);
                    Console.WriteLine("Decrypted String: " + decryptedStringECB);

                    decryptFileResultTextbox.Text = decryptedStringECB;//show decripted text in decriptionResultTextbo
                    


                }
                else if (decryptTypeFile == "CBC")//if decryptTypeFile is equal to CBC THEH...
                {
                    // Create a StreamReader using the CryptoStream. to read from file CBC txt
                    StreamReader sReader = new StreamReader(FileNameCBC);

                    // Read the data from the stream to decrypt it.
                    string val = sReader.ReadLine();
                    Console.WriteLine(val.ToString());

                    sReader.Close();

                    //ECB ENCRYPTION VARS
                    string decryptedStringCBC;
                    string encryptedStringCBC = val;

                    decryptedStringCBC = DecryptionCBC(encryptedStringCBC, passwordCBC, FileNameCBC);
                    Console.WriteLine("Decrypted String: " + decryptedStringCBC);

                    decryptFileResultTextbox.Text = decryptedStringCBC;//show decripted text in decriptionResultTextbox
                }
                else//if decryptTypeFile is not selected
                {
                    MessageBox.Show("Pasirinkite Desifravimo moda!!!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //ECB
        public static string EncryptionECB(string message, string password, string fileName)
        {
            try
            {
                //Open or Create file
                FileStream fStream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                //ENCODE MESSAGE AND PASSWORD
                byte[] messageBytes = ASCIIEncoding.ASCII.GetBytes(message);
                byte[] passwordBytes = ASCIIEncoding.ASCII.GetBytes(password);

                //Set Encryption Setting
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                provider.Mode = CipherMode.ECB;
                ICryptoTransform transform = provider.CreateEncryptor(passwordBytes, passwordBytes);
                CryptoStreamMode mode = CryptoStreamMode.Write;

                //Set Up Streams
                MemoryStream memStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memStream, transform, mode);
                cryptoStream.Write(messageBytes, 0, messageBytes.Length);
                cryptoStream.FlushFinalBlock();

                //Read encrypted message from the memory stream
                byte[] encryptedMessageBytes = new byte[memStream.Length];
                memStream.Position = 0;
                memStream.Read(encryptedMessageBytes, 0, encryptedMessageBytes.Length);

                //encode the encrypted message as base64 string
                string encryptedMessage = Convert.ToBase64String(encryptedMessageBytes);

                //write to file
                StreamWriter writetext = new StreamWriter(fileName);
                writetext.WriteLine(encryptedMessage);
                writetext.Close();


                fStream.Close();

                return encryptedMessage;

            }catch(Exception exc)
            {
                Console.Write(exc.Message);
                return null;
            }
            

        }

        private static string DecryptionECB(string encryptedMessage, string password, string fileName)
        {
            //Convert encrypted messae and password to bytes
            byte[] encryptedMessageBytes = Convert.FromBase64String(encryptedMessage);
            byte[] passwordBytes = ASCIIEncoding.ASCII.GetBytes(password);

            //Set encryption settings
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            provider.Mode = CipherMode.ECB;
            ICryptoTransform transform = provider.CreateDecryptor(passwordBytes, passwordBytes);
            CryptoStreamMode mode = CryptoStreamMode.Write;

            //Set Up Streams
            MemoryStream memStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memStream, transform, mode);
            cryptoStream.Write(encryptedMessageBytes, 0, encryptedMessageBytes.Length);
            cryptoStream.FlushFinalBlock();

            //Read decrypted message from the memory stream
            byte[] decryptedMessageBytes = new byte[memStream.Position];
            memStream.Position = 0;
            memStream.Read(decryptedMessageBytes, 0, decryptedMessageBytes.Length);

            //encode decrypted message data to base64 string
            string message = ASCIIEncoding.ASCII.GetString(decryptedMessageBytes);

            return message;


        }



        public static string EncryptionCBC(string message, string password, string fileName)
        {
            try
            {
                //Open or Create file
                FileStream fStream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                //ENCODE MESSAGE AND PASSWORD
                byte[] messageBytes = ASCIIEncoding.ASCII.GetBytes(message);
                byte[] passwordBytes = ASCIIEncoding.ASCII.GetBytes(password);

                //Set Encryption Setting
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                provider.Mode = CipherMode.CBC;
                ICryptoTransform transform = provider.CreateEncryptor(passwordBytes, passwordBytes);
                CryptoStreamMode mode = CryptoStreamMode.Write;

                //Set Up Streams
                MemoryStream memStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memStream, transform, mode);
                cryptoStream.Write(messageBytes, 0, messageBytes.Length);
                cryptoStream.FlushFinalBlock();

                //Read encrypted message from the memory stream
                byte[] encryptedMessageBytes = new byte[memStream.Length];
                memStream.Position = 0;
                memStream.Read(encryptedMessageBytes, 0, encryptedMessageBytes.Length);

                //encode the encrypted message as base64 string
                string encryptedMessage = Convert.ToBase64String(encryptedMessageBytes);

                //write to file
                StreamWriter writetext = new StreamWriter(fileName);
                writetext.WriteLine(encryptedMessage);
                writetext.Close();

                fStream.Close();

                return encryptedMessage;
            }
            catch (Exception exc)
            {
                Console.Write(exc.Message);
                return null;
            }


        }

        private static string DecryptionCBC(string encryptedMessage, string password, string fileName)
        {
            //Convert encrypted messae and password to bytes
            byte[] encryptedMessageBytes = Convert.FromBase64String(encryptedMessage);
            byte[] passwordBytes = ASCIIEncoding.ASCII.GetBytes(password);

            //Set encryption settings
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            provider.Mode = CipherMode.CBC;
            ICryptoTransform transform = provider.CreateDecryptor(passwordBytes, passwordBytes);
            CryptoStreamMode mode = CryptoStreamMode.Write;

            //Set Up Streams
            MemoryStream memStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memStream, transform, mode);
            cryptoStream.Write(encryptedMessageBytes, 0, encryptedMessageBytes.Length);
            cryptoStream.FlushFinalBlock();

            //Read decrypted message from the memory stream
            byte[] decryptedMessageBytes = new byte[memStream.Position];
            memStream.Position = 0;
            memStream.Read(decryptedMessageBytes, 0, decryptedMessageBytes.Length);

            //encode decrypted message data to base64 string
            string message = ASCIIEncoding.ASCII.GetString(decryptedMessageBytes);

            return message;


        }
        


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            desType = comboBox1.SelectedItem.ToString();
            Console.WriteLine(desType);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            decryptType = comboBox2.SelectedItem.ToString();
            Console.WriteLine(decryptType);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            decryptTypeFile = comboBox3.SelectedItem.ToString();
            Console.WriteLine(decryptTypeFile);
        }

        
    }
}

