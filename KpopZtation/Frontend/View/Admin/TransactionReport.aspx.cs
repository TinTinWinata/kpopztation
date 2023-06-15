using KpopZtation.Backend.Service;
using KpopZtation.Frontend.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.Frontend.View.Admin
{
    public partial class TransactionReport : System.Web.UI.Page
    {

        private void SetCrystalReport()
        {
            Report.CrystalReport Report = new Report.CrystalReport();
            CrystalReportViewer1.ReportSource = Report;
            Dataset.DataSet Data = GetData();
            Report.SetDataSource(Data);
        }

        private Dataset.DataSet GetData()
        {
            Dataset.DataSet Data = new Dataset.DataSet();
            var HeaderTable = Data.TransactionHeader;
            var DetailTable = Data.TransactionDetail;

            String Result = TransactionService.WSGetAllTransaction();
            Data<List<TransactionHeader>> BackendData = Json.Decode<Data<List<TransactionHeader>>>(Result);
            if (BackendData.Succeed)
            {
                List<TransactionHeader> TransactionList = BackendData.Object;
                foreach (TransactionHeader CurrHeader in TransactionList)
                {
                    // Calculate Grand Total Price
                    int GrandTotal = 0;

                    foreach (TransactionDetail CurrDetail in CurrHeader.TransactionDetails)
                    {
                        // Calculate Sub Price
                        int SubTotal = CurrDetail.Album.AlbumPrice * CurrDetail.Qty;
                        GrandTotal += SubTotal;
                    }

                    var hrow = HeaderTable.NewRow();
                    hrow["TransactionID"] = CurrHeader.TransactionID;
                    hrow["CustomerID"] = CurrHeader.CustomerID;
                    hrow["TransactionDate"] = CurrHeader.TransactionDate;
                    hrow["GrandTotal"] = GrandTotal;
                    HeaderTable.Rows.Add(hrow);

                    foreach (TransactionDetail CurrDetail in CurrHeader.TransactionDetails)
                    {
                        // Calculate Sub Price
                        int SubTotal = CurrDetail.Album.AlbumPrice * CurrDetail.Qty;

                        var drow = DetailTable.NewRow();
                        drow["TransactionID"] = CurrDetail.TransactionID;
                        drow["AlbumName"] = CurrDetail.Album.AlbumName;
                        drow["AlbumPrice"] = CurrDetail.Album.AlbumPrice;
                        drow["Qty"] = CurrDetail.Qty;
                        drow["SubTotal"] = SubTotal;
                        DetailTable.Rows.Add(drow);
                    }
                }
            }
            return Data;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            SetCrystalReport();
        }


    }
}