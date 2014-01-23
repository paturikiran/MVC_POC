using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRD.UI.Models;

namespace CRD.UI.Controllers
{
    public class LoanController : Controller
    {
        private ILoanRepository _loanRepository;

        public LoanController(ILoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetLoansByLoanId(int id)
        {
            var loanRecords = _loanRepository.GetLoanRecordsById(id);
            return PartialView("_LoansGrid", loanRecords);
        }

        public ActionResult GetLoanDetails(int id)
        {
            return PartialView("_LoanData", _loanRepository.GetLoanDetails(id) );
        }
        
        [HttpPost]
        public string UpdateLoanDetails(Loan loan)
        {
            if (ModelState.IsValid)
            {
              
            }

            return "Success";
        }
    }
}
