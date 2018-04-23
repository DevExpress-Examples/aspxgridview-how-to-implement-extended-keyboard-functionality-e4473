using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _Default : System.Web.UI.Page {

    //remove all event handlers for using
    protected void Page_Init(object sender, EventArgs e) {
        gridView.RowDeleting += new DevExpress.Web.Data.ASPxDataDeletingEventHandler(gridView_RowDeleting);
        gridView.RowInserting += new DevExpress.Web.Data.ASPxDataInsertingEventHandler(gridView_RowInserting);
        gridView.RowUpdating += new DevExpress.Web.Data.ASPxDataUpdatingEventHandler(gridView_RowUpdating);
    }

    void gridView_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e) {
        e.Cancel = true;
        gridView.CancelEdit();
    }

    void gridView_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e) {
        e.Cancel = true;
        gridView.CancelEdit();
    }

    void gridView_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e) {
        throw new Exception("Deleting is not allowed in the online example");
    }

}
