using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
namespace Pocket_Navigation
{
    class Encryption
    {
        public Encryption(string NewEncrypt)
        {

            FileStream stream = new FileStream("Data\\Pocket.data", FileMode.OpenOrCreate, FileAccess.Write);

            DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();

            cryptic.Key = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");
            cryptic.IV = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");

            CryptoStream crStream = new CryptoStream(stream,
               cryptic.CreateEncryptor(), CryptoStreamMode.Write);


            byte[] data = ASCIIEncoding.ASCII.GetBytes(NewEncrypt);

            crStream.Write(data, 0, data.Length);

            crStream.Close();
            stream.Close();
            
        }

    }
    class Decryption
    {
        public string DecryptionReuslt;
        public Decryption()
        {
            string path = @"Data\\Pocket.data";
            var flen = new FileInfo(path).Length;
            if (flen != 0)
            {
                try
                {
                    FileStream stream = new FileStream(path,
                              FileMode.Open, FileAccess.Read);

                    DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();

                    cryptic.Key = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");
                    cryptic.IV = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");

                    CryptoStream crStream = new CryptoStream(stream,
                        cryptic.CreateDecryptor(), CryptoStreamMode.Read);

                    StreamReader reader = new StreamReader(crStream);

                    string data = reader.ReadToEnd();
                    DecryptionReuslt = data;

                    reader.Close();
                    stream.Close();
                }
                catch (Exception)
                {
                    
                }
                }
        }
    }
    class EncryptionSygicButton
    {
        public EncryptionSygicButton(string NewSBEncrypt)
        {
            var Button ="Sygic = " + NewSBEncrypt;
            string path = @"Data\\PocketInfopath.data";
            
             FileStream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);

             DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();

             cryptic.Key = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");
             cryptic.IV = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");

             CryptoStream crStream = new CryptoStream(stream,
                cryptic.CreateEncryptor(), CryptoStreamMode.Write);


             byte[] data = ASCIIEncoding.ASCII.GetBytes(Button + Environment.NewLine);

            crStream.Write(data, 0, data.Length);
 
            crStream.Close();
             stream.Close();
        }

    }
    class DecryptionSygicButton
    {
        public string DecryptionReuslt;
        public DecryptionSygicButton()
        {

                string path = @"Data\\PocketInfopath.data";
                var flen = new FileInfo(path).Length;
                if (flen != 0)
                {
                    try
                    {
                        FileStream stream = new FileStream(path,
                                 FileMode.Open, FileAccess.Read);

                        DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();

                        cryptic.Key = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");
                        cryptic.IV = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");

                        CryptoStream crStream = new CryptoStream(stream,
                            cryptic.CreateDecryptor(), CryptoStreamMode.Read);

                        StreamReader reader = new StreamReader(crStream);

                        string data = reader.ReadToEnd();
                        DecryptionReuslt = data;

                        reader.Close();
                        stream.Close();
                    }
                catch (Exception)
                {

                }
            }
        }

    }
    class EncryptionIGONButton
    {
        public EncryptionIGONButton(string NewIGONEncrypt)
        {
            var Button2 = "IGON = " + NewIGONEncrypt;
            string path = @"Data\\PocketInfopath1.data";


            FileStream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);

            DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();

            cryptic.Key = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");
            cryptic.IV = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");

            CryptoStream crStream = new CryptoStream(stream,
               cryptic.CreateEncryptor(), CryptoStreamMode.Write);


            byte[] data = ASCIIEncoding.ASCII.GetBytes(Button2 + Environment.NewLine);

            crStream.Write(data, 0, data.Length);
            crStream.Close();
            stream.Close();
        }

    }
    class DecryptionIGONButton
    {
        public string DecryptionReuslt;
        public DecryptionIGONButton()
        {
            string path = @"Data\\PocketInfopath1.data";
            var flen = new FileInfo(path).Length;
            if (flen != 0)
            {
                try
                {
                    FileStream stream = new FileStream(path,
                                 FileMode.Open, FileAccess.Read);

                    DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();

                    cryptic.Key = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");
                    cryptic.IV = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");

                    CryptoStream crStream = new CryptoStream(stream,
                        cryptic.CreateDecryptor(), CryptoStreamMode.Read);

                    StreamReader reader = new StreamReader(crStream);

                    string data = reader.ReadToEnd();
                    DecryptionReuslt = data;

                    reader.Close();
                    stream.Close();
                }
                catch (Exception)
                {

                }
            }
        }

    }
    class EncryptionIGOPButton
    {
        public EncryptionIGOPButton(string NewIGOPEncrypt)
        {
            var Button2 = "IGOP = " + NewIGOPEncrypt;
            string path = @"Data\\PocketInfopath2.data";
           
            
             FileStream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);

             DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();

             cryptic.Key = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");
             cryptic.IV = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");

             CryptoStream crStream = new CryptoStream(stream,
                cryptic.CreateEncryptor(), CryptoStreamMode.Write);


             byte[] data = ASCIIEncoding.ASCII.GetBytes(Button2 + Environment.NewLine);

             crStream.Write(data, 0, data.Length);
            crStream.Close();
             stream.Close();
        }

    }
    class DecryptionIGOPButton
    {
        public string DecryptionReuslt;
        public DecryptionIGOPButton()
        {
            string path = @"Data\\PocketInfopath2.data";
            var flen = new FileInfo(path).Length;
            if (flen != 0)
            {
                try
                {
                    FileStream stream = new FileStream(path,
                              FileMode.Open, FileAccess.Read);

                    DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();

                    cryptic.Key = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");
                    cryptic.IV = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");

                    CryptoStream crStream = new CryptoStream(stream,
                        cryptic.CreateDecryptor(), CryptoStreamMode.Read);

                    StreamReader reader = new StreamReader(crStream);

                    string data = reader.ReadToEnd();
                    DecryptionReuslt = data;

                    reader.Close();
                    stream.Close();
                }
                catch (Exception)
                {

                }
            }
        }

    }
    class EncryptionNavitelButton
    {
        public EncryptionNavitelButton(string NewNEncrypt)
        {
            var Button3 = "Navitel = " + NewNEncrypt;
            string path = @"Data\\PocketInfopath3.data";
            
              FileStream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);

              DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();

              cryptic.Key = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");
              cryptic.IV = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");

              CryptoStream crStream = new CryptoStream(stream,
                 cryptic.CreateEncryptor(), CryptoStreamMode.Write);


              byte[] data = ASCIIEncoding.ASCII.GetBytes(Button3 + Environment.NewLine);

              crStream.Write(data, 0, data.Length);
            crStream.Close();
              stream.Close();
        }

    }
    class DecryptionNavitelButton
    {
        public string DecryptionReuslt;
        public DecryptionNavitelButton()
        {
            string path = @"Data\\PocketInfopath3.data";
            var flen = new FileInfo(path).Length;
            if (flen != 0)
            {
                try
                {
                    FileStream stream = new FileStream(path,
                              FileMode.Open, FileAccess.Read);

                    DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();

                    cryptic.Key = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");
                    cryptic.IV = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");

                    CryptoStream crStream = new CryptoStream(stream,
                        cryptic.CreateDecryptor(), CryptoStreamMode.Read);

                    StreamReader reader = new StreamReader(crStream);

                    string data = reader.ReadToEnd();
                    DecryptionReuslt = data;

                    reader.Close();
                    stream.Close();
                }
                catch (Exception)
                {

                }
            }
        }

    }
}
  
            