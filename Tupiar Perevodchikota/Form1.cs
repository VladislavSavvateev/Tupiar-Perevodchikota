using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tupiar_Perevodchikota.Dictionaries;

namespace Tupiar_Perevodchikota {
	public partial class Form1 : Form {
		TupiarEngine te;
		RussianToChangedRussian r_crDictionary;

		public Form1() {
			InitializeComponent();
			te = new TupiarEngine();
			r_crDictionary = new RussianToChangedRussian();
			te.SetDictionary(r_crDictionary);
		}

		private void txtSource_TextChanged(object sender, EventArgs e) {
			txtDestination.Text = te.Convert(txtSource.Text);
		}
	}
}
