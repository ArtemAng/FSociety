using FSociety.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSociety.Domain.Entities
{
    public class Novel
    {
        public int NovelID { get; set; }
        public string Name { get; set; }
        public string Сontent { get; set; }
        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual ApplicationUser User { get; set; }
    }
}
