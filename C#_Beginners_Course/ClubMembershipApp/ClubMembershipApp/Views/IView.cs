using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubMembershipApp.FieldValidators;


namespace ClubMembershipApp.Views
{
   public interface IView
    {
        void RunView();
        IFieldValidator FieldValidator { get; }
    }
}
