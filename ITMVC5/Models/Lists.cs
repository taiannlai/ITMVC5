using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITMVC5.Models
{
    public class Lists
    {
        public int Id { get; set; }
        [DisplayName("重要度")]
        [Required(ErrorMessage = "重要度為必填")]
        public string Importance { get; set; }
        [DisplayName("部門")]
        [Required]
        public string Dep { get; set; }
        [DisplayName("提出人員")]
        [Required]
        public string Name { get; set; }
        [DisplayName("提出問題")]
        [Required]
        public string Problem { get; set; }
        [DisplayName("問題原因")]
        [Required]
        public string schedule { get; set; }
        [DisplayName("狀態")]
        [Required]
        public string status { get; set; }
        [DisplayName("完成度")]
        [Required]
        [Range(0,100)]
        public int Percent { get; set; }
    }
}