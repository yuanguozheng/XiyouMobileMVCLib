﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XiyouMobileFoundation.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(XiyouMobileFoundation.EncryptUtil.XYMDesUtil.DesEncrypt("abcdef"));
        }
    }
}
