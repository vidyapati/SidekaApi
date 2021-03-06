using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SidekaApi.Models {
    [Table("SdPbdt2015")]
    public class Pbdt2015 {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string RegionCode { get; set; }

        public bool IsImported { get; set; }

        public string Content { get; set; }

    }
}