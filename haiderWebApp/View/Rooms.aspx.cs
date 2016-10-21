using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using haiderWebApp.DB;
using haiderWebApp.GlobalVars;

namespace haiderWebApp {

	public partial class Rooms : System.Web.UI.Page {


		protected void Page_Load(object sender, EventArgs e) {
			
			List<Room> lstRooms = new List<Room>();

			if (!Page.IsPostBack) {
				using (var db = new SmartHomeDB()) {

					lstRooms = db.Database.SqlQuery<Room>("SELECT * FROM rooms where userid=1").ToList();
				}

				gvRooms.DataSource = lstRooms;
				gvRooms.DataBind();
			}
		}

		protected void btnName_Click(object sender, EventArgs e) {


		
		}

		protected void gvRooms_RowCommand(object sender, GridViewCommandEventArgs e) {
			try {

				if (e.CommandName.ToString() == "GetDevices") {
	
					int roomid = Convert.ToInt32(e.CommandArgument);

					Response.Redirect("~/View/Devices.aspx?roomid="+roomid+"&roomname=".ToString(),true);
				}

				else if (e.CommandName.ToString() == "DeleteMe") {

				//	int ReceiverID = Convert.ToInt32(e.CommandArgument);




				}
			}
			catch (Exception Exp) {
				//Master.ShowMessage("Error Occured in Deleting Record", MessageType.Error);
			}
		}
	}
}