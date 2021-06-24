using System;
using System.Web;

namespace SomeWebApplication.Models
{
    static public class PostedFileHelper
    {
        static public byte[] GetBytesOfHttpPostedFile(HttpPostedFileBase file)
        {
            if (file == null) return null;

            System.IO.Stream stream = file.InputStream;
            int strLen = Convert.ToInt32(stream.Length);

            byte[] bytes = new byte[strLen];
            int strRead = stream.Read(bytes, 0, strLen);

            return bytes;
        }

        static public string GetFileContentFromBytes(byte[] bytes)
        {
            if (bytes == null) return null;

            return System.Text.Encoding.UTF8.GetString(bytes);
        }
    }
}