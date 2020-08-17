using System;
using System.Collections.Generic;
using System.Text;

namespace AdminVentas.Business.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int StatusId { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
