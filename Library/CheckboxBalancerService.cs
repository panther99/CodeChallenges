using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Library
{
    public class CheckboxBalancerService
    {
        private static string CleanUpCheckbox(string checkbox)
        {
            var regex = new Regex(@"^[A-Za-z0-9. \n]$");
            return new String(checkbox.Where(c => regex.IsMatch(c.ToString())).ToArray());
        }

        private static (int? CheckNumber, string Category, double? Expense) ParseCheckboxLine(string line)
        {
            try
            {
                string[] fields = line.Split(' ');
                int checkNumber = int.Parse(fields[0]);
                string category = fields[1];
                double expense = double.Parse(fields[2]);

                return (CheckNumber: checkNumber, Category: category, Expense: expense);
            }
            catch
            {
                return (CheckNumber: null, Category: null, Expense: null);
            }
        }

        private static bool IsValidCheckboxLine((int? CheckNumber, string Category, double? Expense) tuple)
        {
            var (CheckNumber, Category, Expense) = tuple;
            return new object[] { CheckNumber, Category, Expense }
                        .Where(value => value == null).Count() == 0;
        }

        public string BalanceCheckbox(string checkbox)
        {
            double balance = 0;
            var expenses = new List<double>();
            string cleanedUpCheckbox = CheckboxBalancerService.CleanUpCheckbox(checkbox);
            string balancedCheckbox = "";

            foreach (var line in cleanedUpCheckbox.Split('\n'))
            {
                try
                {
                    balance = double.Parse(line);
                    balancedCheckbox += string.Format("Current balance: {0:F2}\n", balance);
                }
                catch (FormatException)
                {
                    var tuple = CheckboxBalancerService.ParseCheckboxLine(line);
                    (int? CheckNumber, string Category, double? Expense) = tuple;

                    if (!CheckboxBalancerService.IsValidCheckboxLine(tuple))
                    {
                        continue;
                    }

                    balance -= (double)Expense;
                    expenses.Add((double)Expense);
                    balancedCheckbox += string.Format(
                        "{0} {1} {2:F2} Balance {3:F2}\n",
                        CheckNumber, Category, Expense, balance
                    );
                }
            }

            if (expenses.Count == 0)
            {
                return null;
            }

            balancedCheckbox += string.Format("Total expense: {0:F2}\n", expenses.Sum());
            balancedCheckbox += string.Format("Average expense: {0:F2}\n", expenses.Average());

            return balancedCheckbox;
        }
    }
}
