namespace Bm10RBS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BM10Voorspellingen
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string dateExcel { get; set; }

        public DateTime? Date { get; set; }

        public int? Temperatuur { get; set; }

        public int? TemperatuurARIMA { get; set; }

        public int? Bewolking { get; set; }

        public int? RelatieveVochtigeheid { get; set; }

        public int? SomNeerslag { get; set; }

        public int? Windrichting { get; set; }

        public int? Windsnelheid { get; set; }
    }
}
