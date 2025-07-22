using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductApp.Models
{
    [Table("SOFTWARE_METRICS")]
    public class SoftwareMetrics
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int WMC { get; set; }
        public int DIT { get; set; }
        public int NOC { get; set; }
        public int CBO { get; set; }
        public int RFC { get; set; }
        public int LCOM { get; set; }
        public int CA { get; set; }
        public int CE { get; set; }
        public int NPM { get; set; }
        public float LCOM3 { get; set; }
        public int LOC { get; set; }
        public float DAM { get; set; }
        public int MOA { get; set; }
        public float MFA { get; set; }
        public float CAM { get; set; }
        public int IC { get; set; }
        public int CBM { get; set; }
        public float AMC { get; set; }
        public int MAX_CC { get; set; }
        public float AVG_CC { get; set; }
        public int BUG { get; set; }

        [NotMapped]
        public bool IsBuggy => BUG > 0;
    }
}
