using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tupiar_Perevodchikota.Dictionaries {
	class EmptyDictionary: DictionaryClass {
		public override bool IsCaseSensetive() {
			return false;
		}
		public override Dictionary<string, string> GetDictionary() {
			return new Dictionary<string, string>();
		}
	}
}
