// (Board.Text == "") - проверка на пустоту текстБокса
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace kalk
{
	public partial class calculatorByPrusov : Form
	{
		static string line;

		public calculatorByPrusov()
		{
			InitializeComponent();

			Board.ReadOnly = true;

			this.KeyPreview = true;

			MaximizeBox = false;

			Width = 420;
			Height = 395;
		}
		void TabContro1SelectedIndexChanged(object sender, EventArgs e)// Если вкладки переключаются, размеры формы меняются
		{
			if (tabControl1.SelectedIndex == 0) {
				Width = 420;
				Height = 395;
			}
			if (tabControl1.SelectedIndex == 1) {
				Width = 523;
				Height = 261;
			}
		}
		void MainFormKeyDown(object sender, KeyEventArgs e) // Работа с клавиатурой
		{
			if (tabControl1.SelectedIndex == 0) {
				if (e.KeyCode == Keys.D1 | e.KeyCode == Keys.NumPad1)
					One(sender, e);
				if (e.KeyCode == Keys.D2 | e.KeyCode == Keys.NumPad2)
					Two(sender, e);
				if (e.KeyCode == Keys.D3 | e.KeyCode == Keys.NumPad3)
					Three(sender, e);
				if (e.KeyCode == Keys.D4 | e.KeyCode == Keys.NumPad4)
					Four(sender, e);
				if (e.KeyCode == Keys.D5 | e.KeyCode == Keys.NumPad5)
					Five(sender, e);
				if (e.KeyCode == Keys.D6 | e.KeyCode == Keys.NumPad6)
					Six(sender, e);
				if (e.KeyCode == Keys.D7 | e.KeyCode == Keys.NumPad7)
					Seven(sender, e);
				if (e.KeyCode == Keys.D8 | e.KeyCode == Keys.NumPad8)
					Eight(sender, e);
				if (e.KeyCode == Keys.D9 | e.KeyCode == Keys.NumPad9)
					Nine(sender, e);
				if (e.KeyCode == Keys.D0 | e.KeyCode == Keys.NumPad0)
					@null(sender, e);
				if (e.KeyCode == Keys.C)
					Clear(sender, e);
				if (e.KeyCode == Keys.Oemcomma)
					Comma(sender, e);
				if (e.KeyCode == Keys.Subtract)
					Minus(sender, e);
				if (e.KeyCode == Keys.Divide)
					Div(sender, e);
				if (e.KeyCode == Keys.Add)
					Plus(sender, e);
				if (e.KeyCode == Keys.Multiply)
					Mult(sender, e);
			}
			if (e.KeyCode == Keys.Escape) // завершение программы на ESC
				Close();
		}

		//
		// Калькулятор
		//

		void One(object sender, EventArgs e)
		{
			if (!Board.Text.Contains(")"))
				Board.Text += "1";
			else
				Board.Text = Board.Text.Remove(Board.Text.Length - 1, 1) + "1" + ")";
		}
		void Two(object sender, EventArgs e)
		{
			if (!Board.Text.Contains(")"))
				Board.Text += "2";
			else
				Board.Text = Board.Text.Remove(Board.Text.Length - 1, 1) + "2" + ")";
		}
		void Three(object sender, EventArgs e)
		{
			if (!Board.Text.Contains(")"))
				Board.Text += "3";
			else
				Board.Text = Board.Text.Remove(Board.Text.Length - 1, 1) + "3" + ")";
		}
		void Four(object sender, EventArgs e)
		{
			if (!Board.Text.Contains(")"))
				Board.Text += "4";
			else
				Board.Text = Board.Text.Remove(Board.Text.Length - 1, 1) + "4" + ")";
		}
		void Five(object sender, EventArgs e)
		{
			if (!Board.Text.Contains(")"))
				Board.Text += "5";
			else
				Board.Text = Board.Text.Remove(Board.Text.Length - 1, 1) + "5" + ")";
		}
		void Six(object sender, EventArgs e)
		{
			if (!Board.Text.Contains(")"))
				Board.Text += "6";
			else
				Board.Text = Board.Text.Remove(Board.Text.Length - 1, 1) + "6" + ")";
		}
		void Seven(object sender, EventArgs e)
		{
			if (!Board.Text.Contains(")"))
				Board.Text += "7";
			else
				Board.Text = Board.Text.Remove(Board.Text.Length - 1, 1) + "7" + ")";
		}
		void Eight(object sender, EventArgs e)
		{
			if (!Board.Text.Contains(")"))
				Board.Text += "8";
			else
				Board.Text = Board.Text.Remove(Board.Text.Length - 1, 1) + "8" + ")";
		}
		void Nine(object sender, EventArgs e)
		{
			if (!Board.Text.Contains(")"))
				Board.Text += "9";
			else
				Board.Text = Board.Text.Remove(Board.Text.Length - 1, 1) + "9" + ")";
		}
		void @null(object sender, EventArgs e)
		{
			if (!Board.Text.Contains(")")) {
				if (Board.Text != "0") {
					Board.Text += "0";
				}
			} else
				Board.Text = Board.Text.Remove(Board.Text.Length - 1, 1) + "0" + ")";

		}

		void Comma(object sender, EventArgs e)
		{
			if (Board.Text != "") {
				if (!(Board.Text.Contains(",")))
					Board.Text += ",";
			}
		}
		void Clear(object sender, EventArgs e)
		{
			line = "";
			Board.Text = "";
			digit.Text = "";

		}
		void Equal(object sender, EventArgs e)
		{
			if (Board.Text == "0" & line.EndsWith("/")) {
				Board.Text = "";
				MessageBox.Show("На ноль делить нельзя", "Achtung");
				return;
			}
			if (Board.Text != "") {
				line += Board.Text;
				string temp = Calculated.Kalk(line);
				if (!temp.Contains("-")) {
					Board.Text = temp;
				} else
					Board.Text = "(" + temp + ")";
				line = "";
				digit.Text = "";
			}
		}

		void Plus(object sender, EventArgs e)
		{
			if (Board.Text != "") {
				line += Board.Text + "+";
				digit.Text = line;
				Board.Text = "";
			}

		}
		void Minus(object sender, EventArgs e)
		{
			if (Board.Text != "") {
				line += Board.Text + "-";
				digit.Text = line;
				Board.Text = "";
			}

		}
		void Mult(object sender, EventArgs e)
		{
			if (Board.Text != "") {
				line += Board.Text + "*";
				digit.Text = line;
				Board.Text = "";
			}
		}
		void Div(object sender, EventArgs e)
		{

			if (Board.Text != "") {
				line += Board.Text + "/";
				digit.Text = line;
				Board.Text = "";
			}
		}

		void Plus_Minus(object sender, EventArgs e)
		{
			if (Board.Text != "" & Board.Text != "0") {
				if (Board.Text.Contains("-"))
					Board.Text = Board.Text.Trim('(', '-', ')');
				else
					Board.Text = "(-" + Board.Text + ")";
			}
		}
		void _Delete(object sender, EventArgs e)
		{
			try {
				if (!Board.Text.Contains(")")) {
					if (Board.Text != "")
						Board.Text = Board.Text.Remove(Board.Text.Length - 1, 1);
				} else {
					if (Board.Text.Length == 4)
						Board.Text = "";
					else {
						Board.Text = Board.Text.Remove(Board.Text.Length - 2, 2) + ")";
					}
				}
			} catch {
				MessageBox.Show("произошла ошибОчка в _Delete()", "Achtung");
			}
		}
		void Factorial(object sender, EventArgs e)
		{
			try {
				if (Board.Text != "")
					Board.Text = Calculated.Factorial(Board.Text);
			} catch {
				MessageBox.Show("Значение должно быть целым и положительным", "Achtung");
				Board.Text = "";
			}
		}
		void Sqrt(object sender, EventArgs e)
		{
			if (Board.Text != "") {
				if (Board.Text.Contains("-")) {
					MessageBox.Show("Невозможно извлечь квадратный корень отрицательного числа", "Achtung");
					Board.Text = "";
				} else
					Board.Text = Math.Sqrt(Convert.ToDouble(Board.Text)).ToString();
			}
		}
		void Sqr(object sender, EventArgs e)
		{
			if (Board.Text != "") {
				Board.Text = Math.Pow(Convert.ToDouble(Board.Text.Trim('(', ')')), 2).ToString();
			}
		}
		void ClipBoard(object sender, EventArgs e)
		{
			Clipboard.SetText(Board.Text);
		}
		void Sin(object sender, EventArgs e)
		{
			if (Board.Text != "") {
				Board.Text = Board.Text.Trim('(', ')');
				Board.Text = (Math.Sin(Convert.ToDouble(Board.Text))).ToString();
				if (Board.Text.Contains("-"))
					Board.Text = "(" + Board.Text + ")";
				
			}
		}
		void Cos(object sender, EventArgs e)
		{
			if (Board.Text != "") {
				Board.Text = Board.Text.Trim('(', ')');
				Board.Text = (Math.Sin(Convert.ToDouble(Board.Text))).ToString();
				if (Board.Text.Contains("-"))
					Board.Text = "(" + Board.Text + ")";
			}
		}
		void Pi(object sender, EventArgs e)
		{
			if (Board.Text == "")
				Board.Text = Math.PI.ToString();
		}
		void Ln(object sender, EventArgs e)
		{
			if (Convert.ToDouble(Board.Text) > 0) {
				if (Board.Text != "") {
					Board.Text = Board.Text.Trim('(', ')');
					Board.Text = (Math.Log(Convert.ToDouble(Board.Text))).ToString();
				}
			}
		}
		
		//
		// Системы счисления
		//

		void CheckIsNeedReadOnly()
		{
			BoardDigit.ReadOnly &= !((FromBin.Checked | FromOctal.Checked | FromDecimal.Checked | FromHexaDecimal.Checked) & (ToBinary.Checked | ToOctal.Checked | ToDecimal.Checked | ToHexaDecimal.Checked));
		}
		void ReadOnlyForBoard()
		{
			BoardDigit.Text = "";
			BoardDigit.ReadOnly = true;

		}
		void FromBinCheckedChanged(object sender, EventArgs e)
		{
			if (FromBin.Checked) {
				CheckIsNeedReadOnly();
				FromOctal.Enabled = false;
				FromDecimal.Enabled = false;
				FromHexaDecimal.Enabled = false;
			} else {
				ReadOnlyForBoard();
				FromOctal.Enabled = true;
				FromDecimal.Enabled = true;
				FromHexaDecimal.Enabled = true;
			}
		}
		void FromOctalCheckedChanged(object sender, EventArgs e)
		{
			if (FromOctal.Checked) {
				CheckIsNeedReadOnly();
				FromBin.Enabled = false;
				FromDecimal.Enabled = false;
				FromHexaDecimal.Enabled = false;
			} else {
				ReadOnlyForBoard();
				FromBin.Enabled = true;
				FromDecimal.Enabled = true;
				FromHexaDecimal.Enabled = true;
			}

		}
		void FromDecimalCheckedChanged(object sender, EventArgs e)
		{
			if (FromDecimal.Checked) {
				CheckIsNeedReadOnly();
				FromBin.Enabled = false;
				FromOctal.Enabled = false;
				FromHexaDecimal.Enabled = false;
			} else {
				ReadOnlyForBoard();
				FromBin.Enabled = true;
				FromOctal.Enabled = true;
				FromHexaDecimal.Enabled = true;
			}
		}
		void FromHexaDecimalCheckedChanged(object sender, EventArgs e)
		{
			if (FromHexaDecimal.Checked) {
				CheckIsNeedReadOnly();
				FromBin.Enabled = false;
				FromOctal.Enabled = false;
				FromDecimal.Enabled = false;
			} else {
				ReadOnlyForBoard();
				FromBin.Enabled = true;
				FromOctal.Enabled = true;
				FromDecimal.Enabled = true;
			}
		}
		void ToBinaryCheckedChanged(object sender, EventArgs e)
		{
			if (ToBinary.Checked) {
				CheckIsNeedReadOnly();
				ToOctal.Enabled = false;
				ToDecimal.Enabled = false;
				ToHexaDecimal.Enabled = false;
			} else {
				ReadOnlyForBoard();
				ToOctal.Enabled = true;
				ToDecimal.Enabled = true;
				ToHexaDecimal.Enabled = true;
			}
		}
		void ToOctalCheckedChanged(object sender, EventArgs e)
		{
			if (ToOctal.Checked) {
				CheckIsNeedReadOnly();
				ToBinary.Enabled = false;
				ToDecimal.Enabled = false;
				ToHexaDecimal.Enabled = false;
			} else {
				ReadOnlyForBoard();
				ToBinary.Enabled = true;
				ToDecimal.Enabled = true;
				ToHexaDecimal.Enabled = true;
			}
		}
		void ToDecimalCheckedChanged(object sender, EventArgs e)
		{
			if (ToDecimal.Checked) {
				CheckIsNeedReadOnly();
				ToBinary.Enabled = false;
				ToOctal.Enabled = false;
				ToHexaDecimal.Enabled = false;
			} else {
				ReadOnlyForBoard();
				ToBinary.Enabled = true;
				ToOctal.Enabled = true;
				ToHexaDecimal.Enabled = true;
			}
		}
		void ToHexaDecimalCheckedChanged(object sender, EventArgs e)
		{
			if (ToHexaDecimal.Checked) {
				CheckIsNeedReadOnly();
				ToBinary.Enabled = false;
				ToOctal.Enabled = false;
				ToDecimal.Enabled = false;
			} else {
				ReadOnlyForBoard();
				ToBinary.Enabled = true;
				ToOctal.Enabled = true;
				ToDecimal.Enabled = true;
			}
		}
		void BoardTextChanged(object sender, EventArgs e)
		{
			if (BoardDigit.Text != "") {
				try {
					if (FromBin.Checked) {
						try {
							if (ToBinary.Checked)
								Result.Text = Convert.ToString(Convert.ToInt64(BoardDigit.Text, 2), 2);
							if (ToOctal.Checked)
								Result.Text = Convert.ToString(Convert.ToInt64(BoardDigit.Text, 2), 8);
							if (ToDecimal.Checked)
								Result.Text = Convert.ToString(Convert.ToInt64(BoardDigit.Text, 2), 10);
							if (ToHexaDecimal.Checked)
								Result.Text = Convert.ToString(Convert.ToInt64(BoardDigit.Text, 2), 16);
							;
						} catch {
							
							throw new Exception("Введенный символ не является двоичным, либо число больше числового диапазона типа (long)");
						}
					}
					if (FromOctal.Checked) {
						try {
							if (ToBinary.Checked)
								Result.Text = Convert.ToString(Convert.ToInt64(BoardDigit.Text, 8), 2);
							if (ToOctal.Checked)
								Result.Text = Convert.ToString(Convert.ToInt64(BoardDigit.Text, 8), 8);
							if (ToDecimal.Checked)
								Result.Text = Convert.ToString(Convert.ToInt64(BoardDigit.Text, 8), 10);
//									Result.Text = WorkWithDigit.OctToDec(BoardDigit.Text).ToString();
							if (ToHexaDecimal.Checked)
								Result.Text = Convert.ToString(Convert.ToInt64(BoardDigit.Text, 8), 16);
//									Result.Text = Convert.ToString(WorkWithDigit.OctToDec(BoardDigit.Text), 16);
						} catch {
							throw new Exception("Введенный символ не является восьмиричным, либо число больше числового диапазона типа (long)");
						}
					}
					if (FromDecimal.Checked) {
						try {
							if (ToBinary.Checked)
								Result.Text = Convert.ToString(Convert.ToInt64(BoardDigit.Text), 2);
							if (ToOctal.Checked)
								Result.Text = Convert.ToString(Convert.ToInt64(BoardDigit.Text), 8);
							if (ToDecimal.Checked)
								Result.Text = Convert.ToInt64(BoardDigit.Text).ToString();// написано по-индусски, чтобы выбрасывало ошибку если в строке символ
							if (ToHexaDecimal.Checked)
								Result.Text = Convert.ToString(Convert.ToInt64(BoardDigit.Text), 16);
						} catch {
							throw new Exception("Введенный символ не является числом, либо число больше числового диапазона типа (long)");
						}
					}
					if (FromHexaDecimal.Checked) {
						try {
							if (ToBinary.Checked)
								Result.Text = Convert.ToString(Convert.ToInt64(BoardDigit.Text, 16), 2);
//									Result.Text = Convert.ToString(WorkWithDigit.HexToDec(Board.Text), 2);
							if (ToOctal.Checked)
								Result.Text = Convert.ToString(Convert.ToInt64(BoardDigit.Text, 16), 8);
//									Result.Text = Convert.ToString(WorkWithDigit.HexToDec(Board.Text), 8);
							if (ToDecimal.Checked)
								Result.Text = Convert.ToInt64(BoardDigit.Text, 16).ToString();
//									Result.Text = WorkWithDigit.HexToDec(Board.Text).ToString();
							if (ToHexaDecimal.Checked)
								Result.Text = Convert.ToString(Convert.ToInt64(BoardDigit.Text, 16), 16);// написано по-индусски, чтобы выбрасывало ошибку, если число не шестнадцатиричное
						} catch {
							throw new Exception("Введенный символ не является шестнадцатиричным, либо число больше числового диапазона типа (long)");
						}
					}
				} catch (Exception ex) {
					BoardDigit.Text = BoardDigit.Text.Remove(BoardDigit.Text.Length - 1, 1);
					MessageBox.Show(ex.Message, "Achtung");
				}
			} else
				Result.Text = "";
		}
		void divOnX(object sender, EventArgs e)
		{
			if (Board.Text != "") {
				if (!Board.Text.Contains(")"))
					Board.Text = (1 / Convert.ToDouble(Board.Text)).ToString();
				else {
					Board.Text = Board.Text.Trim('(', '-', ')');
					Board.Text = "(-" + (1 / Convert.ToDouble(Board.Text)).ToString() + ")";
				}
			}
		}
		void TabPage2Click(object sender, EventArgs e)
		{
	
		}


	}
}
