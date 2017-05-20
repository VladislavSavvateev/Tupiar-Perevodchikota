using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tupiar_Perevodchikota.Dictionaries {
	class RussianToPseudoEnglish: DictionaryClass {

		Dictionary<String, String> pairs;

		public override bool IsCaseSensetive() {
			return false;
		}

		public RussianToPseudoEnglish() {
			pairs = new Dictionary<string, string>();
			pairs.Add("а", "A");
			pairs.Add("б", "6");
			pairs.Add("в", "B");
			pairs.Add("г", "┌"); // Needed to find
			pairs.Add("д", "Δ");
			pairs.Add("е", "E");
			pairs.Add("ё", "E");
			pairs.Add("ж", ">|<");
			pairs.Add("з", "3");
			pairs.Add("и", "N");
			pairs.Add("й", "N");
			pairs.Add("к", "K");
			pairs.Add("л", "/\\");
			pairs.Add("м", "M");
			pairs.Add("н", "H");
			pairs.Add("о", "O");
			pairs.Add("п", "π");
			pairs.Add("р", "P");
			pairs.Add("с", "C");
			pairs.Add("т", "T");
			pairs.Add("у", "Y");
			pairs.Add("ф", "<|>");
			pairs.Add("ц", "U,");
			pairs.Add("ч", "4");
			pairs.Add("ш", "|_|_|");
			pairs.Add("щ", "|_|_|,");
			pairs.Add("ъ", "`b");
			pairs.Add("ы", "b|");
			pairs.Add("ь", "b");
			pairs.Add("э", "€");
			pairs.Add("ю", "|-O");
			pairs.Add("я", "R");
		}

		public override Dictionary<string, string> GetDictionary() {
			return pairs;
		}
	}
}
