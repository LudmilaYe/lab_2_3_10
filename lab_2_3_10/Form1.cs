using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2_3_10 {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
      SearchWords();
    }
    private void SearchWords() {

    }
    private void InputChanged(object sender, KeyEventArgs e) {
      SearchWords();
    }
    private void ShowTask(object sender, EventArgs e) {

    }
    private void ClearInput(object sender, EventArgs e) {

    }
  }
}
