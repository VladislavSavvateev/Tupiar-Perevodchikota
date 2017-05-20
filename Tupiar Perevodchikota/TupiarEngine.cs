using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tupiar_Perevodchikota {
	class TupiarEngine {
		Dictionary<String, String> pairs;

		public String Convert(String source) {
			String result = "";
			foreach (char ch in source.ToLower()) {
				string str = ch.ToString();
				if (pairs.ContainsKey(str)) result += pairs[str];
				else result += str;
			}
			return result;
		}

		public void SetDictionary(DictionaryClass dc) {
			if (dc.GetDictionary() != null) pairs = dc.GetDictionary();
		}
	}
}
