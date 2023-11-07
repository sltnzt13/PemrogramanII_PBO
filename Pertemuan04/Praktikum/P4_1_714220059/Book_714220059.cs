using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4_1_714220059
{
    public class Book_714220059 : Product_714220059
    {
        protected string pagecount;

        public Book_714220059(string type, string title, string pagecount) : base(type, title)
        {
            this.pagecount = pagecount;
        }
        public string PageCount
        {
            get
            {
                return this.pagecount;
            }
            set
            {
                pagecount = value;
            }
        }

    }
}