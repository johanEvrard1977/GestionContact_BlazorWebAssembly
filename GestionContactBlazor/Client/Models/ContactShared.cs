using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionContact.Client.Models
{
    public class ContactShared
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public DateTime Date_De_Naissance { get; set; }
        public int UserId { get; set; }
    }
}
