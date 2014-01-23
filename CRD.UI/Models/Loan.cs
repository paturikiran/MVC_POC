using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CRD.UI.Models
{
    public class Loan:ILoanRepository
    {  
        [DisplayName("Loan Id")]
        public int LoanId { get; set; }
       
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }
       
        [DisplayName ("Last Name")]
        public string LastName { get; set; }
       
        [DisplayName("Created Date")]
        public DateTime CreatedDate { get; set; }
      
        [DisplayName("Updated Date")]
        public DateTime UpdateDate { get; set; }

        public IEnumerable<Loan> GetLoanRecordsById(int id)
        {
            return GetLoans().Where(i => i.LoanId == id);
        }

        public IEnumerable<Loan> GetLoans()
        {
            return new List<Loan>
                {
                    new Loan()
                        {
                            LoanId = 1000,
                            Id = 1,
                            FirstName = "kiran",
                            LastName = "kk",
                            CreatedDate = DateTime.Now.AddHours(-1),
                            UpdateDate = DateTime.Now
                        },
                    new Loan()
                        {
                            LoanId = 1000,
                            Id = 2,
                            FirstName = "Ravi",
                            LastName = "trim",
                            CreatedDate = DateTime.Now.AddHours(-1),
                            UpdateDate = DateTime.Now
                        },
                    new Loan()
                        {
                            LoanId = 1000,
                            Id = 3,
                            FirstName = "Jagan",
                            LastName = "kean",
                            CreatedDate = DateTime.Now.AddHours(-1),
                            UpdateDate = DateTime.Now
                        },
                    new Loan()
                        {
                            LoanId = 1000,
                            Id = 4,
                            FirstName = "John",
                            LastName = "Swap",
                            CreatedDate = DateTime.Now.AddHours(-1),
                            UpdateDate = DateTime.Now
                        },
                    new Loan()
                        {
                            LoanId = 1001,
                            Id = 5,
                            FirstName = "Attain",
                            LastName = "Matt",
                            CreatedDate = DateTime.Now.AddHours(-1),
                            UpdateDate = DateTime.Now
                        },
                    new Loan()
                        {
                            LoanId = 1002,
                            Id = 6,
                            FirstName = "Bob",
                            LastName = "Fat",
                            CreatedDate = DateTime.Now.AddHours(-1),
                            UpdateDate = DateTime.Now
                        },
                    new Loan()
                        {
                            LoanId = 1001,
                            Id = 7,
                            FirstName = "Tim",
                            LastName = "slim",
                            CreatedDate = DateTime.Now.AddHours(-1),
                            UpdateDate = DateTime.Now
                        }
                };
        }

        public Loan GetLoanDetails(int id)
        {
            return GetLoans().SingleOrDefault(x => x.Id == id);
        }
    }
}