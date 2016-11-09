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
		List<DeviceRomms> lstDevices;
		protected void Page_Load(object sender, EventArgs e) {

			if (!Page.IsPostBack) {

				// Showing devices against the roomID
				string roomid = null;

				string query = "SELECT * FROM devices d";
				if (Request.QueryString["roomid"] != null) {

					roomid = Request.QueryString["roomid"].ToString();
					query = "SELECT d.*,r.name as RoomName FROM devices d";
					query += " inner join rooms r on r.id= d.roomid where roomid=" + roomid;
				}

				lstDevices = new List<DeviceRomms>();
				using (var db = new SmartHomeDB()) {

					lstDevices = db.Database.SqlQuery<DeviceRomms>(query).ToList();
				}
				lblRoomName.Text = lstDevices[0].RoomName;
				gvDevices.DataSource = lstDevices;
				gvDevices.DataBind();


				Session["devices"] = lstDevices;
				//#region MQTT Connection
				//MqttClient MQTTclient;
				//MQTTclient = new MqttClient("test.mosquitto.org");
				//MQTTclient.Connect("esp");
				//MQTTclient.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
				//#endregion

			}
		}

		private void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e) {


		}

		protected void gvDevices_SelectedIndexChanged(object sender, EventArgs e) {

		}


		protected void CheckBox_CheckChanged(object sender, EventArgs e) {
			//write the client id of the control that triggered the event
			Response.Write(((CheckBox)sender).ClientID);
		}

		protected void cbxOperation_CheckedChanged(object sender, EventArgs e) {

		}

		protected void gvDevices_RowCommand(object sender, GridViewCommandEventArgs e) {


			lstDevices = (List<DeviceRomms>)Session["devices"];
			if (e.CommandName.ToString() == "OP") {


				using (var db = new SmartHomeDB()) {

					var a = db.MyDevices;//.ToList();
					var b=a.Where(d => d.ID.ToString() == e.CommandArgument.ToString()).FirstOrDefault();
					b.STATE = !b.STATE;
					db.SaveChanges();
					var device = lstDevices.Where(d => d.ID.ToString() == e.CommandArgument.ToString()).FirstOrDefault();//.STATE
					device.STATE = !device.STATE;
					gvDevices.DataSource = lstDevices;
					gvDevices.DataBind();
				}
				

			}

		}


	}



}