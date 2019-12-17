using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HREFEntity
{
    public class EStudent
    {
        [Key]
        //Id, Name, Age
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
