using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Enums;

namespace BusinessLogic.Entities
{
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        public Role Role { get; set; }

        public string Name { get; set; }
    }
}
