using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;

namespace blog.Models
    
{
    public class searchAcount
    {
        public BlogDataEntities4 db = null;
        public IEnumerable<Account>ListAllPaging(int page, int pageSize)
        {
            return db.Accounts.ToPagedList(page,pageSize);
        }
       
    }
}