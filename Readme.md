<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128609987/16.2.12%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3813)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to disable word wrapping in the Simple view and use the horizontal scroll bar to scroll a long text

<p><strong>This example is obsolete. Starting with version 16.2.12, our RichEditControl supports horizontal auto-scrolling in disabled word wrap mode out of the box. Please refer to the <a href="https://supportcenter.devexpress.com/ticket/details/t552541/the-horizontal-scrollbar-incorrectly-operates-in-simpleview-when-the-simpleview-wordwrap">The horizontal scrollbar incorrectly operates in SimpleView when the SimpleView.WordWrap property is disabled</a> thread for more information.</strong></p>

<p>At present, the Simple view does not support auto-scrolling. As a workaround, switch RichEditControl to the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraRichEditRichEditViewTypeEnumtopic"><u>Draft</u></a> view and specify a large width for it via the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraRichEditAPINativeSectionPage_Widthtopic"><u>SectionPage.Width Property</u></a>. To emulate the Simple view, hide the ruler and scrollbar by setting the <strong>RichEditControl.Options.HorizontalRuler.Visibility</strong> and <strong>RichEditControl.Options.VerticalScrollbar.Visibility</strong> properties to the Hidden value. In addition, you can adjust document content padding in the manner illustrated in the <a href="https://www.devexpress.com/Support/Center/p/E3781">How to adjust left padding of a document in RichEditControl</a> example.</p>

<br/>


