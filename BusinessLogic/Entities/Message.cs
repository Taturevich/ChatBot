using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Enums;

namespace BusinessLogic.Entities
{
    public class Message
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime Date { get; set; }

        public string Text { get; set; }

        public SenderType SenderType { get; set; }

        public virtual User User { get; set; }
    }
}
