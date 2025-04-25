using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace DAL.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        [ForeignKey("Grupa")]
        public int? IDGrupy { get; set; }
        public virtual Grupa Grupa { get; set; }
    }
}