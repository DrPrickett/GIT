using System;
using System.IO;
using System.IO.Compression;

namespace HybridXMLExperiment
{
    class Compression
    {
        public string CompressString(string text)
        {
            try
            {
                byte[] buffer = System.Text.Encoding.Unicode.GetBytes(text);
                MemoryStream ms = new MemoryStream();
                using (System.IO.Compression.GZipStream zip = new System.IO.Compression.GZipStream(ms, System.IO.Compression.CompressionMode.Compress, true))
                {
                    zip.Write(buffer, 0, buffer.Length);
                }

                ms.Position = 0;
                MemoryStream outStream = new MemoryStream();

                byte[] compressed = new byte[ms.Length];
                ms.Read(compressed, 0, compressed.Length);

                byte[] gzBuffer = new byte[compressed.Length + 4];
                
                System.Buffer.BlockCopy(compressed, 0, gzBuffer, 4, compressed.Length);
                System.Buffer.BlockCopy(BitConverter.GetBytes(buffer.Length), 0, gzBuffer, 0, 4);
                return Convert.ToBase64String(gzBuffer);
            }
            catch (Exception err)
            {
                return err.Message.ToString();
            }
        }
        public string CompressStringByte(string text)
        {
            try
            {
                byte[] buffer = System.Text.Encoding.Unicode.GetBytes(text);
                MemoryStream ms = new MemoryStream();
                using (System.IO.Compression.GZipStream zip = new System.IO.Compression.GZipStream(ms, System.IO.Compression.CompressionMode.Compress, true))
                {
                    zip.Write(buffer, 0, buffer.Length);
                }

                ms.Position = 0;
                MemoryStream outStream = new MemoryStream();

                byte[] compressed = new byte[ms.Length];
                ms.Read(compressed, 0, compressed.Length);

                byte[] gzBuffer = new byte[compressed.Length + 4];
                System.Buffer.BlockCopy(compressed, 0, gzBuffer, 4, compressed.Length);
                System.Buffer.BlockCopy(BitConverter.GetBytes(buffer.Length), 0, gzBuffer, 0, 4);
                return Convert.ToBase64String(gzBuffer);
            }
            catch (Exception err)
            {
                return err.Message.ToString();
            }
        }

        public string DeCompressString(string compressedText)
        {
            try
            {
                byte[] gzBuffer = Convert.FromBase64String(compressedText);
                using (MemoryStream ms = new MemoryStream())
                {
                    int msgLength = BitConverter.ToInt32(gzBuffer, 0);
                    ms.Write(gzBuffer, 4, gzBuffer.Length - 4);

                    byte[] buffer = new byte[msgLength];

                    ms.Position = 0;
                    using (System.IO.Compression.GZipStream zip = new System.IO.Compression.GZipStream(ms, System.IO.Compression.CompressionMode.Decompress))
                    {
                        zip.Read(buffer, 0, buffer.Length);
                    }

                    return System.Text.Encoding.Unicode.GetString(buffer, 0, buffer.Length);
                }
            }
            catch (Exception err)
            {
                return err.Message.ToString();
            }
        }
    }
}
