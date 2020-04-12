using System;
using System.Security.Cryptography;

namespace BusinessLogic.Helpers
{
    internal class Sha256Hasher
    {
        private readonly SHA256 sha256;

        internal Sha256Hasher(SHA256 sha256)
        {
            this.sha256 = sha256;
        } 

        internal byte[] CalcHash(byte[] data)
        {
            var hashValue = sha256.ComputeHash(data);

            return hashValue;
        }

        internal byte[] CalcFileHash(byte[] data, uint fileSizeBytes, string fileName)
        {
            var sizeData = BitConverter.GetBytes(fileSizeBytes);
            var nameData = fileName.ToCharArray();

            var hashData = new byte[data.Length + sizeData.Length + nameData.Length];
            data.CopyTo(hashData, 0);
            sizeData.CopyTo(hashData, data.Length);
            nameData.CopyTo(hashData, data.Length + sizeData.Length);

            var result = CalcHash(hashData);
            return result;
        }
    }
}