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
        static List<Lists> data = new List<Lists>()
            {
                new Lists() {Id = 1, Importance = "本週重點", Dep = "採購課", Name = "蔣麗雅", Problem = "採購單無法開立", schedule = "操作錯誤",Percent = 100, status = "已完成"},
                new Lists() {Id = 2, Importance = "本週重點", Dep = "物控課", Name = "郭伶琳", Problem = "MIGO過帳錯誤", schedule = "操作錯誤",Percent = 100, status = "已完成"},
                new Lists() {Id = 3, Importance = "一般工作", Dep = "生管課", Name = "李姿緣", Problem = "ZIM004無法過帳", schedule = "程式BUG",Percent = 90, status = "進行中"},
                new Lists() {Id = 4, Importance = "一般工作", Dep = "財務部", Name = "林沂潔", Problem = "需求開發新的程式", schedule = "需求評估中",Percent = 85, status = "進行中"},
                new Lists() {Id = 5, Importance = "其他工作", Dep = "工務部", Name = "陳興業", Problem = "繳交環安衛作業", schedule = "作業繳交",Percent = 78, status = "進行中"},
                new Lists() {Id = 6, Importance = "其他工作", Dep = "裝配課", Name = "陳俊宏", Problem = "自動倉程式修改", schedule = "需求確認中",Percent = 88, status = "進行中"},

            };
        // GET: WorkList
        public ActionResult Index()
        {

            return View(data);
        }

        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Lists lists)
        {
            if (ModelState.IsValid)
            {
                lists.Id = data.Max(c => c.Id) + 1;
                data.Add(lists);
                return RedirectToAction("Index");
            }

            return View(lists);
        }

        public ActionResult Edit(int id)
        {

            return View(data.FirstOrDefault(p => p.Id == id));

        }
        [HttpPost]
        public ActionResult Edit(int id, Lists lists)
        {
            if (ModelState.IsValid)
            {
                var one = data.FirstOrDefault(p => p.Id == id);
                one.Importance = lists.Importance;
                one.Name = lists.Name;
                one.Percent = lists.Percent;
                one.Problem = lists.Problem;
                one.schedule = lists.schedule;
                one.status = lists.status;
                one.Dep = lists.Dep;

                return RedirectToAction("Index");
            }

            return View(lists);
        }

        public ActionResult Delete(int id)
        {

            return View(data.FirstOrDefault(p => p.Id == id));
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection form)
        {
            if (ModelState.IsValid)
            {
                data.Remove(data.First(p => p.Id == id));
                return RedirectToAction("Index");
            }

            return View(data);
        }
        public ActionResult Details(int id)
        {

            return View(data.FirstOrDefault(p => p.Id == id));
        }
        [HttpPost]
        public ActionResult Details(int id, Lists lists)
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("Index");
            }

            return View(lists);
        }
    }
}