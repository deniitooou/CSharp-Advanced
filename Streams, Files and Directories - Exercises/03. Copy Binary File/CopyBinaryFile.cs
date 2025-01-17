﻿using System.IO;

namespace CopyBinaryFile
{
    public class CopyBinaryFile
    {
        static void Main(string[] args)
        {
            string inputPath = @"..\..\..\Files\copyMe.png";
            string outputPath = @"..\..\..\Files\copyMe-copy.png";

            CopyFile(inputPath, outputPath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using (FileStream reader = new FileStream(inputFilePath, FileMode.Open))
            {
                using (FileStream writer = new FileStream(outputFilePath, FileMode.Create))
                {
                    while (true)
                    {
                        byte[] buffer = new byte[512];

                        int size = reader.Read(buffer, 0, buffer.Length);

                        if (size == 0)
                        {
                            break;
                        }

                        writer.Write(buffer, 0, size);
                    }
                }
            }
        }
    }
}
