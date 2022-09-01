using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace IPChecker.Model
{
    internal class IPValidator
    {
        string Check(string ip)
        {
            Regex.IsMatch(textBox1.Text, @"[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}");

            if (Regex.IsMatch(textBox1.Text, "[^0-9.]"))
            {
                MessageBox.Show("IP должен содержать, только цифры.\nПример: 255.255.255.255", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                textBox1.SelectionStart = textBox1.TextLength;
            }


            return "";
        }
    }
}
