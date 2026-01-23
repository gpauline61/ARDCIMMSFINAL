using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MMSWebApp2.Data;
using MMSWebApp2.Models;
using MMSWebApp2.Repository.Interface;
using MMSWebApp2.ViewModel;
using System.Linq;

namespace MMSWebApp2.Repository
{
    public class MemberRepository : IMemberRepository
    {
        private readonly MMSWebAppDbContext _context;

        public MemberRepository(MMSWebAppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<MemberIndexViewModel>> GetAll()
        {
            var members = await _context.Members
                .Where(m => m.IsActive)
                .OrderBy(m => m.LastName)
                .ToListAsync();
            List<MemberIndexViewModel> memres = new List<MemberIndexViewModel>();
<<<<<<< HEAD
            foreach (var member in members)
=======
            foreach (var member in members) 
>>>>>>> a8db1a0c69ee9b9742531a333a065774e882d37d
            {
                var memberViewModel = new MemberIndexViewModel()
                {
                    MemberID = member.MemberID,
                    LastName = member.LastName,
                    FirstName = member.FirstName,
                    Birthdate = member.Birthdate,
                    Address = member.Address,
                    Branch = member.Branch,
                    ContactNo = member.ContactNo,
                    Email = member.Email,
                };
                memres.Add(memberViewModel);
            }
            return memres;
        }

        public bool Add(MemberCreateViewModel memberVM)
        {
            var mem = new Member
            {
                LastName = memberVM.LastName,
                FirstName = memberVM.FirstName,
                Birthdate = memberVM.Birthdate,
                Address = memberVM.Address,
                Branch = memberVM.Branch,
                ContactNo = memberVM.ContactNo,
                Email = memberVM.Email,
            };
            mem.IsActive = true;
            mem.DateCreated = DateTime.Now;
            _context.Add(mem);
            return Save();
        }

        public bool Delete(Member member)
        {
<<<<<<< HEAD
            member.IsActive = false;
            Update(member);
            return Save();
=======
            throw new NotImplementedException();
>>>>>>> a8db1a0c69ee9b9742531a333a065774e882d37d
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Member member)
        {
            _context.Update(member);
            return Save();
        }

        public async Task<Member> GetIdAsync(int id)
        {
            var member = await _context.Members.FirstAsync(m => m.MemberID == id);

            return member;
        }

        public async Task<MemberDetailViewModel> DetailMember(int id)
        {
            var member = await GetIdAsync(id);
<<<<<<< HEAD
            if (member != null)
=======
            if(member != null)
>>>>>>> a8db1a0c69ee9b9742531a333a065774e882d37d
            {
                var memberViewModel = new MemberDetailViewModel()
                {
                    MemberID = member.MemberID,
                    LastName = member.LastName,
                    FirstName = member.FirstName,
                    Birthdate = member.Birthdate,
                    Address = member.Address,
                    Branch = member.Branch,
                    ContactNo = member.ContactNo,
                    Email = member.Email,
                    IsActive = member.IsActive,
                };
                return memberViewModel;
            }

            else
            {
                return null;
            }
        }

        public async Task<MemberEditViewModel> EditMember(int id)
        {
            var member = await GetIdAsync(id);
<<<<<<< HEAD
            if (member != null)
=======
            if (member != null) 
>>>>>>> a8db1a0c69ee9b9742531a333a065774e882d37d
            {
                var memberViewModel = new MemberEditViewModel()
                {
                    MemberID = member.MemberID,
                    LastName = member.LastName,
                    FirstName = member.FirstName,
                    Birthdate = member.Birthdate,
                    Address = member.Address,
                    Branch = member.Branch,
                    ContactNo = member.ContactNo,
                    Email = member.Email,
                    IsActive = member.IsActive,
                };
                return memberViewModel;
            }
            else
            {
                return null;
            }
        }

        public async Task SaveEditMember(int id, MemberEditViewModel memberEditViewModel)
        {
            var member = await GetIdAsync(id);
<<<<<<< HEAD
            if (member != null)
=======
            if (member != null) 
>>>>>>> a8db1a0c69ee9b9742531a333a065774e882d37d
            {
                member.LastName = memberEditViewModel.LastName;
                member.FirstName = memberEditViewModel.FirstName;
                member.Birthdate = memberEditViewModel.Birthdate;
                member.Address = memberEditViewModel.Address;
                member.Branch = memberEditViewModel.Branch;
                member.ContactNo = memberEditViewModel.ContactNo;
                member.Email = memberEditViewModel.Email;
                Update(member);
            }
        }
<<<<<<< HEAD

        public async Task<Member> DeleteMember(int id)
        {
            return await GetIdAsync(id);
        }

        public async Task DeleteConfirmed(int id)
        {
            var member = await GetIdAsync(id);
            if (member != null)
            {
                Delete(member);
            }

        }
=======
>>>>>>> a8db1a0c69ee9b9742531a333a065774e882d37d
    }
}
