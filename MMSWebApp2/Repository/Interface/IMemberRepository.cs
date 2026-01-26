using MMSWebApp2.Models;
using MMSWebApp2.ViewModel;

namespace MMSWebApp2.Repository.Interface
{
    public interface IMemberRepository
    {
        Task<IEnumerable<MemberIndexViewModel>> GetAll();
        Task<Member> GetIdAsync(int id);
        Task<MemberDetailViewModel> DetailMember(int id);
        Task<MemberEditViewModel> EditMember(int id);
        Task SaveEditMember(int id, MemberEditViewModel memberEditViewModel);
        Task<Member> DeleteMember(int id);
        Task DeleteConfirmed(int id);
        Task<MemberCountViewModel> GetMemberCount();
        Task<IEnumerable<MemberActiveInactiveViewModel>> GetAllActive();
        Task<IEnumerable<MemberActiveInactiveViewModel>> GetAllInactive();
        bool Add(MemberCreateViewModel memberVM);
        bool Update(Member member);
        bool Delete(Member member);
        bool Save();
    }
}
