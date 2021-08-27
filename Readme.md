<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128533561/16.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T441828)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/Default.aspx)
* [Default.aspx.cs](./CS/Default.aspx.cs)
<!-- default file list end -->
# ASPxGridView - How to copy an alternative row style to the preview row for a grouped grid
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t441828/)**
<!-- run online end -->


<p>For this task, handle the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridView_HtmlRowPreparedtopic">ASPxGridView.HtmlRowPrepared</a> event to add the required CSS class for the alternating preview rows:</p>


```cs
bool isPrevRowIsAlterRow;
protected void grid_HtmlRowPrepared(object sender, DevExpress.Web.ASPxGridViewTableRowEventArgs e) {
	if (e.RowType == GridViewRowType.Data) {
		isPrevRowIsAlterRow = e.Row.CssClass.Contains("dxgvDataRowAlt");
	}
	else if (e.RowType == GridViewRowType.Preview) {
		if (isPrevRowIsAlterRow)
			e.Row.CssClass += " previewRowAlt";
	}
}

```



<br/>


