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
			string roomid = null;

			string query = "SELECT * FROM devices d";
			if (Request.QueryString["roomid"] != null) {

				roomid = Request.QueryString["roomid"].ToString();
				query = "SELECT d.*,r.name as RoomName FROM devices d";
				query += " inner join rooms r on r.id= d.roomid where roomid=" + roomid;
			}

			List<DeviceRomms> lstDevices = new List<DeviceRomms>();
			using (var db = new SmartHomeDB()) {

				lstDevices = db.Database.SqlQuery<DeviceRomms>(query).ToList();
			}
			Label1.Text = lstDevices[0].RoomName;
			gvDevices.DataSource = lstDevices;
			gvDevices.DataBind();

			//txtValueA.Text = roomName;

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