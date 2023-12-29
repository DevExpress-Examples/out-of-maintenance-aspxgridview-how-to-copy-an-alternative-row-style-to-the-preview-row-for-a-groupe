<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/Default.aspx)
* [Default.aspx.cs](./CS/Default.aspx.cs)
<!-- default file list end -->
# ASPxGridView - How to copy an alternative row style to the preview row for a grouped grid


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


