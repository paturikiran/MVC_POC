using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRD.UI.Models
{
    public interface ILoanRepository
    {
        IEnumerable<Loan> GetLoans();
        IEnumerable<Loan> GetLoanRecordsById(int id);
        Loan GetLoanDetails(int id);
    }
}
