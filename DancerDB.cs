using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrodnik_lab2
{
    internal class DancerDB
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public string? danceclass { get; set; }
        public string? dancePartnerName { get; set; }
        [Required]
        public string danceClubName { get; set; }

        public override string ToString()
        {
            return $"Id: {id}, Name: {name}, DanceClass: {danceclass}, Dance Partner Name: {dancePartnerName}, Dance Club: {danceClubName}";
        }
    }
}
