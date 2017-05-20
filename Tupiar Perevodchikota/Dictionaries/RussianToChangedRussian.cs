using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tupiar_Perevodchikota.Dictionaries {
	class RussianToChangedRussian: DictionaryClass {

		Dictionary<String, String> pairs;

		public RussianToChangedRussian() {
			pairs = new Dictionary<string, string>();
			pairs.Add("б", "шесть");
			pairs.Add("в", "б");
			pairs.Add("г", "л");
			pairs.Add("д", "дельта");
			pairs.Add("ж", "большеилименьше");
			pairs.Add("и", "н");
			pairs.Add("й", "н");
			pairs.Add("л", "слешобрслеш");
			pairs.Add("н", "х");
			pairs.Add("п", "пи");
			pairs.Add("р", "п");
			pairs.Add("с", "ц");
			pairs.Add("ф", "меньшеилибольше");
			pairs.Add("х", "икс");
			pairs.Add("ц", "узапятэ");
			pairs.Add("ч", "четыре");
			pairs.Add("ш", "илиподчёркилиподчёркили");
			pairs.Add("щ", "илиподчёркилиподчёркилизапятэ");
			pairs.Add("ъ", "кавычкаб");
			pairs.Add("ы", "били");
			pairs.Add("ь", "б");
			pairs.Add("ю", "илитирео");
			pairs.Add("я", "р");
		}
		public override Dictionary<String, String> GetDictionary() {
			return pairs;
		}
	}
}
