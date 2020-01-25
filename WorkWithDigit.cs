// (Board.Text == "") - проверка на пустоту текстБокса
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace kalk
{
	class WorkWithDigit
	{
		public static int HexToDec(string hexadecimal)
		{
			int @decimal = 0;
			for (int i = 0, j = hexadecimal.Length - 1; i < hexadecimal.Length; i++, j--) {
				// i - число j - разряд числа
				if (hexadecimal[i] == 'a' | hexadecimal[i] == 'A') {
					@decimal += 10 * (int)Math.Pow(16, j);
				}
				else if (hexadecimal[i] == 'b' | hexadecimal[i] == 'B') {
					@decimal += 11 * (int)Math.Pow(16, j);
				}
				else if (hexadecimal[i] == 'c' | hexadecimal[i] == 'C') {
					@decimal += 12 * (int)Math.Pow(16, j);
				}
				else if (hexadecimal[i] == 'd' | hexadecimal[i] == 'D') {
					@decimal += 13 * (int)Math.Pow(16, j);
				}
				else if (hexadecimal[i] == 'e' | hexadecimal[i] == 'E') {
					@decimal += 14 * (int)Math.Pow(16, j);
				}
				else if (hexadecimal[i] == 'f' | hexadecimal[i] == 'F') {
					@decimal += 15 * (int)Math.Pow(16, j);
				}
				else {
					if (char.IsDigit(hexadecimal[i]))
						@decimal += (hexadecimal[i] - '0') * (int)Math.Pow(16, j);
					else {
						throw new Exception();
					}
				}
			}
			return @decimal;
		}

		public static int OctToDec(string octal)
		{
			int @decimal = 0;
			for (int i = 0, j = octal.Length - 1; i < octal.Length; i++, j--) {
				// i - число j - разряд числа
				if (char.IsDigit(octal[i]) & octal[i] != '8' & octal[i] != '9')
					@decimal += (octal[i] - '0') * (int)Math.Pow(8, j);
				else {
					throw new Exception();
				}
			}
			return @decimal;
		}

		//		public static int BinToDec(string binary)
		//		{
		//			int @decimal = 0;
		//			for (int i = 0, j = binary.Length - 1; i < binary.Length; i++, j--) { // i - число j - разряд числа
		//				if (char.IsDigit(binary[i]))
		//					@decimal += (binary[i] - '0') * (int)Math.Pow(2, j);
		//				else {
		//					MessageBox.Show("Присутствует неизвестный символ", "Achtung");
		//					break;
		//				}
		//			}
		//			return @decimal;
		//		}
		public static int BinToDex(string binary)
		{
			int dex = 0;
			try {
				char[] tempMas = binary.ToCharArray();
				for (int i = 0, j = binary.Length - 1; i <= binary.Length - 1; i++, j--) {
					if (!binary[i].Equals('1') & !binary[i].Equals('0'))
						throw new Exception("Присутствует неизвестный символ");
					else {
						dex += (binary[i] - '0') * (int)Math.Pow(2, j);
					}
				}
			}
			catch {
				throw new Exception();
			}
			return dex;
		}
	}
}



