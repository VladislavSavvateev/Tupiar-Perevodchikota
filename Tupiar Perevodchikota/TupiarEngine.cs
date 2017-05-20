using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tupiar_Perevodchikota {

	/// <summary>
	/// Класс, реализующий конвертирование по принципу замены символов на другие.
	/// </summary>
	class TupiarEngine {
		Dictionary<String, String> pairs;

		/// <summary>
		/// Стандартный конструктор. Словарь по умолчанию пуст.
		/// </summary>
		public TupiarEngine() {
			pairs = new Dictionary<string, string>();
		}

		/// <summary>
		/// Выполняет процедуру конвертации.
		/// </summary>
		/// <param name="source">Исходная строка.</param>
		/// <returns>Преобразованная строка.</returns>
		public String Convert(String source) {
			String result = "";
			foreach (char ch in source) {
				String str = ch.ToString().ToLower();
				String part;
				if (pairs.ContainsKey(str)) part = pairs[str];
				else part = str;
				if (Char.IsUpper(ch)) part = Char.ToUpper(part[0]) + part.Substring(1);
				result += part;
			}
			return result;
		}

		/// <summary>
		/// Устанавливает словарь.
		/// </summary>
		/// <param name="dc">Класс-хранилище для словаря.</param>
		public void SetDictionary(DictionaryClass dc) {
			if (dc.GetDictionary() != null) pairs = dc.GetDictionary();
		}
	}
}
