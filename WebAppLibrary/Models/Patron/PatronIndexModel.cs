using System.Collections.Generic;

namespace WebAppLibrary.Models.Patron
{
    public class PatronIndexModel
    {
        public  IEnumerable<PatronDetailModel> Patrons { get; set; }
    }
}
