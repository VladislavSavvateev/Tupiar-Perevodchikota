using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tupiar_Perevodchikota {

	/// <summary>
	/// Абстрактный класс для хранения словаря.
	/// </summary>
	abstract class DictionaryClass {

		/// <summary>
		/// Возвращает словарь.
		/// </summary>
		/// <returns>Словарь.</returns>
		abstract public Dictionary<String, String> GetDictionary();
	}
}
