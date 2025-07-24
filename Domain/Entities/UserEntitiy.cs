using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using conecta_jobs_dotnet.Domain.Enums;

namespace conecta_jobs_dotnet.Domain.Models
{
    public class UserEntitiy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
       public string Password{ get; set; }
    [Required]
    [Column(TypeName = "varchar(20)")]
    public TypeUser type{ get; set; }
 




    }
}