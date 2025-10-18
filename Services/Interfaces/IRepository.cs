using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IRepository
    {
        tbl_User AddUpdateUser(tbl_User _user);
    }
}
