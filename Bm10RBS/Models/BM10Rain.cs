namespace Bm10RBS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BM10Rain
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string Date { get; set; }

        [StringLength(50)]
        public string GemiddeldeRelatieveVochtigheid { get; set; }

        [StringLength(50)]
        public string SomNeerslag { get; set; }

        [StringLength(50)]
        public string GemiddeldeBewolking { get; set; }
    }
}
