using Microsoft.AspNetCore.Mvc;
using MMSWebApp2.Models;
using MMSWebApp2.Repository.Interface;
using MMSWebApp2.Service.Interface;
using MMSWebApp2.ViewModel;

namespace MMSWebApp2.Service
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _memberRepository;

        public MemberService(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        //Get all members to GetAll MemberRepository
        public async Task<IEnumerable<MemberIndexViewModel>> GetAll()
        {
            return await _memberRepository.GetAll();
        }

        public bool AddMember(MemberCreateViewModel memberVM)
        {
            return _memberRepository.Add(memberVM);
        }


        public async Task<MemberDetailViewModel> DetailMember(int id)
        {
            return await _memberRepository.DetailMember(id);
        }

        public bool CheckId(int id)
        {
            if(id == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<MemberEditViewModel> EditMember(int id)
        {
            return await _memberRepository.EditMember(id);
        }

        public async Task SaveEditMember(int id, MemberEditViewModel memberEditViewModel)
        {
             await _memberRepository.SaveEditMember(id, memberEditViewModel);
        }


        public async Task<Member> DeleteMember(int id)
        {
            return await _memberRepository.DeleteMember(id);
            
        }

        public async Task DeleteConfirmed(int id)
        {
            await _memberRepository.DeleteConfirmed(id);
        }

    }
}
