﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EmailValidation
{
    class RegEx
    {
        public void EmailIdValidation(string emailid)
        {
            Regex re = new Regex("^([a-z\\d-\\.]+)@([a-z\\d-]+)\\.([a-z]+)(\\.[a-z])?");
            if (re.IsMatch(emailid))
            {
                Console.WriteLine("Valid EmailId");
            }
            else
            {
                Console.WriteLine("Invalid EmailId");
            }
        }
    }
}
