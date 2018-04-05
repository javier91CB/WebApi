using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ERPQuala.Crosscutting.Model
{
    [Table("sag.user", Schema = "GandS")]
    public class User
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string SecondName { get; set; }
        public string FirstName { get; set; }
        public string Dni { get; set; }
        public bool IsProvider { get; set; }

    }
}
