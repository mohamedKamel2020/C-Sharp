using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubMembershipApp.Models;

namespace ClubMembershipApp.Data
{
    public interface ILogin
    {
        User Login(string emailAddress, string password);
    }
}
