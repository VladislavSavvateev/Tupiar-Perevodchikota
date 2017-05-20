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

		public Form1() {
			InitializeComponent();
			te = new TupiarEngine();
			te.SetDictionary(new RussianToChangedRussian());
		}

		private void txtSource_TextChanged(object sender, EventArgs e) {
			txtDestination.Text = te.Convert(txtSource.Text);
		}

		private void rbR2E_CheckedChanged(object sender, EventArgs e) {
			te.SetDictionary(new RussianToPseudoEnglish());
			txtDestination.Text = te.Convert(txtSource.Text);
		}

		private void rbR2CR_CheckedChanged(object sender, EventArgs e) {
			te.SetDictionary(new RussianToChangedRussian());
			txtDestination.Text = te.Convert(txtSource.Text);
		}
	}
}
