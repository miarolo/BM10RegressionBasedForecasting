namespace Bm10RBS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BM10Temperatuur
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string Date { get; set; }

        [StringLength(50)]
        public string GemiddeldeTemperatuur { get; set; }

        [StringLength(50)]
        public string MinimumTemperatuur { get; set; }

        [StringLength(50)]
        public string MaximumTemperatuur { get; set; }
    }
}
