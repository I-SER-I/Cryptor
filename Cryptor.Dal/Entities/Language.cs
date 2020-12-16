using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cryptor.Dal.Entities
{
    public class Language
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public String Alphabet { get; set; }
        public Byte Count { get; set; }
    }
}