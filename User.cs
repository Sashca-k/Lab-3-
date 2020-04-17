namespace Артём
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [Key]
        [StringLength(50)]
        public string login { get; set; }

        [StringLength(50)]
        public string psw { get; set; }

        [StringLength(50)]
        public string role { get; set; }

        [StringLength(200)]
        public string name { get; set; }
    }
}
