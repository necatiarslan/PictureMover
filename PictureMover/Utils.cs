using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureMover
{
    internal class Utils
    {

        public static List<string> GetListArgument(string commaSeparatedValues)
        {
            List<string> result = new List<string>();
            commaSeparatedValues.Replace(" ", "");

            string[] valuesArray = commaSeparatedValues.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string value in valuesArray)
            {
                string trimmedValue = value.Trim();
                result.Add(trimmedValue);
            }

            return result;
        }
    }
}
