using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class _Default: System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {

    }
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


}