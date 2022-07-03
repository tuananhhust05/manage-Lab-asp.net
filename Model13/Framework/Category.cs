namespace Model13.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category   // m?i ??i t??ng c� ??c t�nh c?a class n�y l� 1 d�ng d? li?u trong database
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Alias { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? ParentID { get; set; }

        public int? Order { get; set; }

        public bool? Status { get; set; }
    }
}
