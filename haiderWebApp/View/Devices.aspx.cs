using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using haiderWebApp.DB;
using haiderWebApp.GlobalVars;


namespace haiderWebApp {
	public partial class Devices : System.Web.UI.Page {
		protected void Page_Load(object sender, EventArgs e) {


			// Showing devices against the roomID
			string r = null;
			string roomName = "";

			string query = "SELECT * FROM devices";
			if (Request.QueryString["roomid"] != null) {

				r = Request.QueryString["roomid"].ToString();

				query += " where roomid=" + r;

			}

			List<Device> lstDevices = new List<Device>();
			using (var db = new SmartHomeDB()) {


				lstDevices = db.Database.SqlQuery<Device>(query).ToList();
				roomName = db.Database.SqlQuery<Device>(query).ToString();

			}

			gvDevices.DataSource = lstDevices;
			gvDevices.DataBind();



			//#region MQTT Connection
			//MqttClient MQTTclient;
			//MQTTclient = new MqttClient("test.mosquitto.org");
			//MQTTclient.Connect("esp");
			//MQTTclient.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
			//#endregion


		}

		private void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e) {


		}

		protected void gvDevices_SelectedIndexChanged(object sender, EventArgs e) {

		}

		//protected void CheckBox1_CheckChanged(object sender, System.EventArgs e) {

		//	if (CheckBox1.Checked == true) {
		//		Label1.Text = "WOW! You are a member of an asp.net user group.";
		//		Label1.ForeColor = System.Drawing.Color.Green;
		//	}
		//	else {
		//		Label1.Text = "You are not a member of any asp.net user group.";
		//		Label1.ForeColor = System.Drawing.Color.Crimson;
		//	}
		//}
	}
}