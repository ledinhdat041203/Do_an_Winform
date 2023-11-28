﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Utils
    {
        private static Utils instance;
        public static Utils Instance
        {
            get
            {
                if (instance == null)
                    instance = new Utils();
                return instance;
            }
        }
        public byte[] ImageLocationToByteArray(string AvartarDirec)
        {
            byte[] imageData = null;
            try
            {
                using (FileStream fs = new FileStream(AvartarDirec, FileMode.Open, FileAccess.Read))
                {
                    imageData = new byte[fs.Length];
                    fs.Read(imageData, 0, (int)fs.Length);
                    return imageData;
                }

            }
            catch
            {
                return null;
            }
        }

        public Image converByteToImage(Byte[] byteArr)
        {
            if (byteArr == null)
                return null;
            using (MemoryStream memoryStream = new MemoryStream(byteArr))
            {
                return Image.FromStream(memoryStream);
            }
        }
        public byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
    }
}