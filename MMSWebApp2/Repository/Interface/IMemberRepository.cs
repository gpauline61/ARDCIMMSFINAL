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
<<<<<<< HEAD
        Task<Member> DeleteMember(int id);
        Task DeleteConfirmed(int id);
=======
>>>>>>> a8db1a0c69ee9b9742531a333a065774e882d37d
        bool Add(MemberCreateViewModel memberVM);
        bool Update(Member member);
        bool Delete(Member member);
        bool Save();
    }
}
