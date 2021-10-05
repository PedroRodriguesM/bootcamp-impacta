﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JWTTeste.Utils
{
    public static class PasswordUtil
    {
        public static string GeneratePassword(string openPassword)
        {
            var md5Hash = MD5.Create();
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(openPassword));

            StringBuilder sb = new StringBuilder();

            foreach (var d in data)
            {
                sb.Append(d.ToString("x2"));
            }

            return sb.ToString();
        }
    }
}
