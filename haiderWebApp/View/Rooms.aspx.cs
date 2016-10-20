using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using haiderWebApp.DB;
using haiderWebApp.GlobalVars;

namespace haiderWebApp {
	public partial class Rooms : System.Web.UI.Page {


		protected void Page_Load(object sender, EventArgs e) {

			// Showing rooms against the user ID
			//classGlobalVars.g_userID = "3";
			//string g = classGlobalVars.g_userID;

			List<Room> lstRooms = new List<Room>();

			if (!Page.IsPostBack) {
				using (var db = new SmartHomeDB()) {

					//string query = "SELECT * FROM rooms where userid=" + g;
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
					//btnUpload.Text = "Update";
					int roomid = Convert.ToInt32(e.CommandArgument);
					Response.Redirect("~/View/Devices.aspx?roomid="+roomid.ToString(),true);
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