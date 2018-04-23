using System;
using System.Windows.Forms;
using DevExpress.XtraRichEdit;
using DevExpress.Office.Utils;

namespace RichEditDisableWordWrap {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            richEditControl1.Text = StringSample.SampleText;
        }

        private void button1_Click(object sender, EventArgs e) {
            richEditControl1.BeginUpdate();
            richEditControl1.ActiveViewType = RichEditViewType.Draft;
            richEditControl1.Document.Sections[0].Page.Width = Units.InchesToDocumentsF(100f);
            richEditControl1.Options.HorizontalRuler.Visibility = RichEditRulerVisibility.Hidden;
            richEditControl1.Options.VerticalScrollbar.Visibility = RichEditScrollbarVisibility.Hidden;
            richEditControl1.EndUpdate();
        }
    }
}