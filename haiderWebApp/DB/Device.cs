namespace haiderWebApp.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Device
    {
        public long ID { get; set; }

        [Required]
        [StringLength(100)]
        public string NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string MAC { get; set; }

        public long ROOMID { get; set; }

        public bool STATE { get; set; }

        public bool STATUS { get; set; }

        public virtual Room Room { get; set; }
    }
}
