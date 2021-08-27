<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128609987/10.1.12%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3813)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [StringSample.cs](./CS/StringSample.cs) (VB: [StringSample.vb](./VB/StringSample.vb))
<!-- default file list end -->
# How to disable word wrapping in the Simple view


<p><strong>Problem:</strong></p><p>Is there any way to turn off word wrapping in the Simple view of RichEditControl?</p><p><strong>Solution:</strong></p><p>At present, the Simple view type of RichEditControl does not support this functionality. However, there is a simple workaround method. Switch RichEditControl to the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraRichEditRichEditViewTypeEnumtopic"><u>Draft</u></a> view and specify a large width for it via the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraRichEditAPINativeSectionPage_Widthtopic"><u>SectionPage.Width Property</u></a>. To emulate the Simple view, hide the ruler and scrollbar by setting the <strong>RichEditControl.Options.HorizontalRuler.Visibility</strong> and <strong>RichEditControl.Options.VerticalScrollbar.Visibility</strong> properties to the Hidden value. In addition, you can adjust document content padding in the manner illustrated in the <a href="https://www.devexpress.com/Support/Center/p/E3781">How to adjust left padding of a document in RichEditControl</a> example.</p>

<br/>


