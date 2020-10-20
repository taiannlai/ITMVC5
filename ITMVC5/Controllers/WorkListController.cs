using ITMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITMVC5.Controllers
{
    public class WorkListController : Controller
    {
        // GET: WorkList
        public ActionResult Index()
        {
            var data = new List<Lists>()
            {
                new Lists() {Id = 1, Importance = "本週重點", Dep = "採購課", Name = "蔣麗雅", Problem = "採購單無法開立", schedule = "操作錯誤", status = "已完成"},
                new Lists() {Id = 2, Importance = "本週重點", Dep = "物控課", Name = "郭伶琳", Problem = "MIGO過帳錯誤", schedule = "操作錯誤", status = "已完成"},
                new Lists() {Id = 3, Importance = "一般工作", Dep = "生管課", Name = "李姿緣", Problem = "ZIM004無法過帳", schedule = "程式BUG", status = "進行中"},
                new Lists() {Id = 4, Importance = "一般工作", Dep = "財務部", Name = "林沂潔", Problem = "需求開發新的程式", schedule = "需求評估中", status = "進行中"},
                new Lists() {Id = 5, Importance = "其他工作", Dep = "工務部", Name = "陳興業", Problem = "繳交環安衛作業", schedule = "作業繳交", status = "進行中"},
                new Lists() {Id = 6, Importance = "其他工作", Dep = "裝配課", Name = "陳俊宏", Problem = "自動倉程式修改", schedule = "需求確認中", status = "進行中"},

            };
            return View(data);
        }
    }
}