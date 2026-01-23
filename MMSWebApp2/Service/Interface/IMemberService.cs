using MMSWebApp2.Models;
using MMSWebApp2.ViewModel;

namespace MMSWebApp2.Service.Interface
{
    public interface IMemberService
    {
        Task<IEnumerable<MemberIndexViewModel>> GetAll();
        Task<MemberDetailViewModel> DetailMember(int id);

        Task<MemberEditViewModel> EditMember(int id);
        Task SaveEditMember(int id, MemberEditViewModel memberEditViewModel);

        Task<Member> DeleteMember(int id);
        Task DeleteConfirmed(int id);
        bool CheckId(int id);
        bool AddMember(MemberCreateViewModel memberVM);
    }
}
