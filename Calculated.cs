using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace kalk
{
	static class Calculated
	{
		public static List<double> digits = new List<double>();
		
		public static List<char> operand = new List<char>();

		public static string Factorial(string value)
		{
			if (int.Parse(value) == 0)
				return 0.ToString();
			int temp = 1;
			for (int i = 1; i <= int.Parse(value); i++) {
				temp *= i;
			}
			return temp.ToString();
		}
		/// <summary>
		/// Решает математическое выражение в заданной строке
		/// </summary>
		/// <param name="line"> математическое выражение </param>
		/// <returns> ответ </returns>
		public static string SolveString(string line)
		{
			try {
				ParsingString(line);
				if (operand.Contains('*') | operand.Contains('/')) {
					for (int i = 0; i <= operand.Count - 1;) {
						if (operand[i] == '*') {
							operand.RemoveAt(i);
							digits[i] *= digits[i + 1];
							digits.RemoveAt(i + 1);
						} else if (operand[i] == '/') {
							operand.RemoveAt(i);
							digits[i] /= digits[i + 1];
							digits.RemoveAt(i + 1);
						} else
							i++;
					}
				}
				if (digits.Count == 1) {
					return digits[0].ToString();
				} else {
					double amount = 0;
					amount = operand[0] == '+' ? (digits[0] + digits[1]) : (digits[0] - digits[1]);
					for (int o = 2, i = 1; i <= operand.Count - 1; i++, o++) {
						amount = operand[i] == '+' ? (amount + digits[o]) : (amount - digits[o]);
					}
					return amount.ToString();
				}
			} catch {
				MessageBox.Show("Something wrong", "Achtung");
				return null;
			} finally {
				digits.Clear();
				operand.Clear();
			}
		}

		/// <summary>
		/// Разбор строки математическое выражение на операнды и числа между ними (парсер)
		/// </summary>
		/// <param name="line"> математическое выражение </param>
		static void ParsingString(string line)
		{
			string str = line;
			char[] mas = str.ToCharArray();
			for (int i = 0; i <= mas.Length - 1; i++) {
				if (mas[i] == '(') {
					List<char> tempDigit = new List<char>();
					for (int _i = i + 1;; _i++) {
						if (mas[_i] == ')') {
							if (i != mas.Length - 1)
								i++;
							break;
						} else {
							tempDigit.Add(mas[_i]);
							i++;
						}
					}
					digits.Add(Convert.ToDouble(new string(tempDigit.ToArray())));
				}
				if (char.IsDigit(mas[i]) & mas[i] != ')') {
					List<char> tempDigit = new List<char>();
					for (int j = i; j <= mas.Length - 1; j++, i++) {
						if (Char.IsDigit(mas[j]) | mas[j] == ',')
							tempDigit.Add(mas[i]);
						else {
							i--;
							break;
						}
					}
					digits.Add(Convert.ToDouble(new string(tempDigit.ToArray())));
				} else if (mas[i] != ')')
					operand.Add(mas[i]);
			}
		}
	}
}
