Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.Utils

Namespace RichEditDisableWordWrap
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			richEditControl1.Text = StringSample.SampleText
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			richEditControl1.BeginUpdate()
			richEditControl1.ActiveViewType = RichEditViewType.Draft
			richEditControl1.Document.Sections(0).Page.Width = Units.InchesToDocumentsF(100f)
			richEditControl1.Options.HorizontalRuler.Visibility = RichEditRulerVisibility.Hidden
			richEditControl1.Options.VerticalScrollbar.Visibility = RichEditScrollbarVisibility.Hidden
			richEditControl1.EndUpdate()
		End Sub
	End Class
End Namespace