
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.DAL.Entities
{
    [Table("X",Schema ="HR")]
    [Index(nameof(name))]
    public class Employee
    {
        #region Annotation لو ليا صلاحيه علي الكود
        /*  
         *  
            [PrimaryKey]
            [MaxLength(100)]
            [Required]
            [Column(TypeName ="varchar(200)")]
            
        */
        #endregion

        public int ID { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int salary { get; set; }
        public int? createOn { get; set; }
    }
}
