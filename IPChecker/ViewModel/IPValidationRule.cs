using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace IPChecker.ViewModel
{
    public class IpValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var ip = value as string;

            if (Regex.IsMatch(ip, @"^((25[0-5]|(2[0-4]|1[0-9]|[1-9]|)[0-9])(\.(?!$)|$)){4}$"))
            {
                return ValidationResult.ValidResult;
            }

            return new ValidationResult(false, "IP Адрес должен выглядеть так: 255.255.255.255");
        }
    }
}
