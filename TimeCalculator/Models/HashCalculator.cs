using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CalculatorCode.Models
{
    public class HashCalculator : Calculator
    {
        [MaxLength(100)]
        new public String InputOne { get; set; }

        new public String Result { get; set; }

        public String SelectedAlgorithm { get; set; }

        public String ComputeSHA256Hash()
        {
 
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(InputOne));
                StringBuilder builder = bytesToStringBuilder(bytes);
                return builder.ToString();
            }
        }

        public String ComputeSHA1Hash()
        {

            using (SHA1 shaHash = SHA1.Create())
            {
                byte[] bytes = shaHash.ComputeHash(Encoding.UTF8.GetBytes(InputOne));
                StringBuilder builder = bytesToStringBuilder(bytes);
                return builder.ToString();
            }
        }

        public String ComputeSHA512Hash()
        {
            using (SHA512 shaHash = SHA512.Create())
            {
                byte[] bytes = shaHash.ComputeHash(Encoding.UTF8.GetBytes(InputOne));
                StringBuilder builder = bytesToStringBuilder(bytes);
                return builder.ToString();
            }
        }

        public String ComputeSHA384Hash()
        {
            using (SHA384 shaHash = SHA384.Create())
            {
                byte[] bytes = shaHash.ComputeHash(Encoding.UTF8.GetBytes(InputOne));
                StringBuilder builder = bytesToStringBuilder(bytes);
                return builder.ToString();
            }
        }

        public String ComputeMD5Hash()
        {

            using (MD5 shaHash = MD5.Create())
            {
                byte[] bytes = shaHash.ComputeHash(Encoding.UTF8.GetBytes(InputOne));
                StringBuilder builder = bytesToStringBuilder(bytes);
                return builder.ToString();
            }
        }

        private StringBuilder bytesToStringBuilder(byte[] bytes)
        {
            StringBuilder builder = new StringBuilder();
            foreach (byte b in bytes)
            {
                builder.Append(b.ToString("x2"));
            }

            return builder;
        }
    }


    public enum HashAlgorithms
    {
        SHA1,
        SHA256,
        SHA384,
        SHA512,
        MD5
    }

}

