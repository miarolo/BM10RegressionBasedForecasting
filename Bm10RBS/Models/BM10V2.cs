namespace Bm10RBS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BM10V2
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string STN { get; set; }

        public double? OldDate { get; set; }

        public DateTime? Date { get; set; }

        public int? Month { get; set; }

        [StringLength(50)]
        public string GemiddeldeWindrichting { get; set; }

        public int? GemiddeldeWindSnelheid { get; set; }

        public int? HoogsteUurgemiddeldeWindsnelheid { get; set; }

        public int? LaagsteUurgemiddeldeWindsnelhied { get; set; }

        public int? HoogsteWindstoot { get; set; }

        public int? EtmaalGemiddeldeTemperatuur { get; set; }

        public int? MinimumTemperatuur { get; set; }

        public int? MaximaleTemperatuur { get; set; }

        public int? Zonneschijnduur { get; set; }

        [StringLength(50)]
        public string PercentageZonneschijnduur { get; set; }

        public int? DuurNeerslag { get; set; }

        public int? EtmaalSomNeerslag { get; set; }

        public int? GemiddeldeLuchtdruk { get; set; }

        public int? GemiddeldeBewolking { get; set; }

        public int? EtmaalGemiddeldeRelatieveVochtigheid { get; set; }

        public int? MaximaleRelatieveVochtigheid { get; set; }

        public int? MinimaleRelatieveVochtigheid { get; set; }

        public int? ReferentieGewasVerdamping { get; set; }
    }
}
