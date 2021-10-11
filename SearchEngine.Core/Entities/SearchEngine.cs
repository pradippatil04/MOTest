using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngines.Core.Entities
{
    [Table("searchengines")]
    public class SearchEngine
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(32)]
        public string Name { get; set; }
        
        [Required]
        [StringLength(256)]
        public string Address { get; set; }
    }
}
