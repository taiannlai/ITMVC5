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
        [Required(ErrorMessageResourceName = "Importance_Required", ErrorMessageResourceType = typeof(Resource1))]
        public string Importance { get; set; }
        [DisplayName("部門")]
        [Required(ErrorMessageResourceName = "Dep_Required", ErrorMessageResourceType = typeof(Resource1))]
        public string Dep { get; set; }
        [DisplayName("提出人員")]
        [Required(ErrorMessageResourceName = "Name_Required", ErrorMessageResourceType = typeof(Resource1))]
        public string Name { get; set; }
        [DisplayName("提出問題")]
        [Required(ErrorMessageResourceName = "Problem_Required", ErrorMessageResourceType = typeof(Resource1))]
        public string Problem { get; set; }
        [DisplayName("問題原因")]
        [Required(ErrorMessageResourceName = "schedule_Required", ErrorMessageResourceType = typeof(Resource1))]
        public string schedule { get; set; }
        [DisplayName("狀態")]
        [Required(ErrorMessageResourceName = "status_Required", ErrorMessageResourceType = typeof(Resource1))]
        public string status { get; set; }
        [DisplayName("完成度")]
        [Required(ErrorMessageResourceName = "Percent_Required", ErrorMessageResourceType = typeof(Resource1))]
        [Range(0,100)]
        public int Percent { get; set; }
    }
}