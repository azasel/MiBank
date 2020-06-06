using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.CodeDom.Compiler;
using System.IO;

namespace MiBank
{
    class saltyHash
    {
        string drowssap;
        RNGCryptoServiceProvider _RNGC;
        byte[] _salt;
      

        public saltyHash(string input){
            drowssap = "Testsgdjd";
            byte[] pass = Encoding.ASCII.GetBytes(drowssap);
            _salt = getSalt(32);
            string bitString = Encoding.UTF8.GetString(_salt, 0, _salt.Length);
            int iterations = 50000;
            Console.WriteLine(bitString);
            Console.WriteLine("Hello World!");
            // using a generate key k1
            using (Rfc2898DeriveBytes k1 = new Rfc2898DeriveBytes(pass, _salt, iterations)){
                // get the encryption algorithm with tripple Des
                TripleDES encryptionAlgorithm = TripleDES.Create();
                // set the key from k1 derived key
                encryptionAlgorithm.Key = k1.GetBytes(16);
                // create memory stream to store encyption
                MemoryStream encryptionStream = new MemoryStream();
                CryptoStream encrypt = new CryptoStream(encryptionStream, encryptionAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);

                string enc = Encoding.UTF8.GetString(encryptionAlgorithm.Key, 0, encryptionAlgorithm.Key.Length);
                Console.WriteLine(enc);
            }
      
        }

       /* public static saltyHash CreateInstance(string someCriteria)
        {
           *//* if (someCriteria.Length > 2){
                return new SomeClass(someCriteria);
            }
            return null;*//*
        }*/

        static Boolean testInput(){
            return false;
        }
 /*       static  encrpyt (int saltBytes)
        {
            // Create a byte array to hold the random value.
            byte[] salt = new byte[saltBytes];
            using (RNGCryptoServiceProvider tempRNGC = new RNGCryptoServiceProvider()){
                // Fill salt with a random value.
                tempRNGC.GetBytes(salt);
            }
            return salt;
        }
    }*/


    static byte[] getSalt(int saltBytes){
            // Create a byte array to hold the random value.
            byte[] salt = new byte[saltBytes];
            using (RNGCryptoServiceProvider tempRNGC = new RNGCryptoServiceProvider()){
                // Fill salt with a random value.
                tempRNGC.GetBytes(salt);
            }
            return salt;
        }
    }
}
