using HomeWork2020._03._01.AbstractModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork2020._03._01.Web.Controllers
{
    public class MoneyBoxController : Controller
    {
        private readonly IRepository<string> _repository;
        public MoneyBoxController(IRepository<string> repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void PutOn(int money)
        {
            int currentMoney;
            if(!int.TryParse(_repository.GetAll(), out currentMoney))
            {
                currentMoney = 0;
            }
            currentMoney += money;
            _repository.Add(currentMoney.ToString());
        }
        public int GetMoneyAmount()
        {
            int moneyAmount;
            if(int.TryParse(_repository.GetAll(), out moneyAmount))
            {
                return moneyAmount;
            }

            return 0;
        }
    }
}