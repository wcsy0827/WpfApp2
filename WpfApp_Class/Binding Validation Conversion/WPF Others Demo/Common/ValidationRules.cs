using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfApplication1.Common
{
    class FutureDateRule  : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            DateTime date;
            try
            {
                date = DateTime.Parse(value.ToString());
            }
            catch (FormatException)
            {
                return new ValidationResult(false, "Value is not a valid date.");
            }
            if (DateTime.Now.Date > date)
            {
                return new ValidationResult(false, "Please enter a date in the future.");
            }
            else
            {
                return ValidationResult.ValidResult;
            }
        }
    }

    class RangeValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int n;
            if (int.TryParse(value.ToString(), out n))
            {
                if (n >= 8 && n <= 32)
               
                    return ValidationResult.ValidResult;
                else
                    return new ValidationResult(false, "Please enter a number between 8 and 32.");
            }
            else
            {
                return new ValidationResult(false, "Value is not a valid number.");
            }
        }
    }


    public class MandatoryRule : ValidationRule
    {
        public string Name
        {
            get;
            set;
        }

        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if (String.IsNullOrEmpty((string)value))
            {
                if (Name.Length == 0)
                    Name = "Field";
                return new ValidationResult(false, Name + " is mandatory.");
            }
            return ValidationResult.ValidResult;
        }
    }

    public class IntegerRangeRule : ValidationRule
    {
        public string Name
        {
            get;
            set;
        }

        int min = int.MinValue;
        public int Min
        {
            get { return min; }
            set { min = value; }
        }

        int max = int.MaxValue;
        public int Max
        {
            get { return max; }
            set { max = value; }
        }

        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if (!String.IsNullOrEmpty((string)value))
            {
                if (Name.Length == 0)
                    Name = "Field";
                try
                {
                    if (((string)value).Length > 0)
                    {
                        int val = Int32.Parse((String)value);
                        if (val > max)
                            return new ValidationResult(false, Name + " must be <= " + Max + ".");
                        if (val < min)
                            return new ValidationResult(false, Name + " must be >= " + Min + ".");
                    }
                }
                catch (Exception)
                {
                    // Try to match the system generated error message so it does not look out of place.
                    return new ValidationResult(false, Name + " is not in a correct numeric format.");
                }
            }
            return ValidationResult.ValidResult;
        }
    }

    



}
