using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tupiar_Perevodchikota {
	public partial class Form1 : Form {
		TupiarEngine te;

		public Form1() {
			InitializeComponent();
			te = new TupiarEngine();
		}

		private void txtSource_TextChanged(object sender, EventArgs e) {
			txtDestination.Text = te.Convert(txtSource.Text);
		}
	}
}
