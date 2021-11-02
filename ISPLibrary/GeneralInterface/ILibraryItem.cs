using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPLibrary
{
    public interface ILibraryItem
    {
        string LibraryId { get; set; }
        string Title { get; set; }
        //string Author { get; set; }
        //DateTime BorrowDate { get; set; }
        //string Borrower { get; set; }
        //int CheckoutDurationInDays { get; set; }        
        //int Pages { get; set; }
        //void CheckIn();
        //void CheckOut(string borrower);
        //DateTime GetDueDate();
    }
}
