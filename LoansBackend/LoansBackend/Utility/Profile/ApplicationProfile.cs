using LoansBackend.Models;
using LoansBackend.ViewModels;

namespace LoansBackend.Utility.Profile
{
    public class ApplicationProfile : AutoMapper.Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Loan, LoanViewModel>()
                .ReverseMap();
        }
    }
}
