using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISP_Lab15
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public int Money { get; set; }
        public override string ToString()
        {
            return string.Format("User: {0}, {1}, {2}, {3}", Id, Name, Phone, Money);
        }
    }
}
