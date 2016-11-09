using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using haiderWebApp.DB;
using System.ComponentModel.DataAnnotations.Schema;

namespace haiderWebApp {
	[NotMapped]
	public class DeviceRomms :Device
		
		{
		public string RoomName { get; set; }
	}
}