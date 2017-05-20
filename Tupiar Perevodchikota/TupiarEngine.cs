using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tupiar_Perevodchikota.Dictionaries;

namespace Tupiar_Perevodchikota {

	/// <summary>
	/// Класс, реализующий конвертирование по принципу замены символов на другие.
	/// </summary>
	class TupiarEngine {
		DictionaryClass mDict;

		/// <summary>
		/// Стандартный конструктор. Словарь по умолчанию пуст.
		/// </summary>
		public TupiarEngine() {
			mDict = new EmptyDictionary();
		}

		/// <summary>
		/// Выполняет процедуру конвертации.
		/// </summary>
		/// <param name="source">Исходная строка.</param>
		/// <returns>Преобразованная строка.</returns>
		public String Convert(String source) {
			String result = "";
			Dictionary<String, String> pairs = mDict.GetDictionary();
			foreach (char ch in source) {
				String str = ch.ToString().ToLower();
				String part;
				if (pairs.ContainsKey(str)) part = pairs[str];
				else part = str;
				if (Char.IsUpper(ch)) {
					if (mDict.IsCaseSensetive())
						part = part.ToUpper();
				}
				result += part;
			}
			return result;
		}

		private bool IsLower(String str) {
			bool result = true;
			foreach (char ch in str) {
				if (!Char.IsLower(ch)) {
					result = false;
					break;
				}
			}
			return result;
		}

		/// <summary>
		/// Устанавливает словарь.
		/// </summary>
		/// <param name="dc">Класс-хранилище для словаря.</param>
		public void SetDictionary(DictionaryClass dc) {
			mDict = dc;
		}
	}
}
