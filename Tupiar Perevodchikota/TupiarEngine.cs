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

		public void SetDictionary(DictionaryClass dc) {
			if (dc.GetDictionary() != null) pairs = dc.GetDictionary();
		}
	}
}
