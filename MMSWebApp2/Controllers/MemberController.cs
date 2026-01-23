using Microsoft.AspNetCore.Mvc;
using MMSWebApp2.Models;
using MMSWebApp2.Service.Interface;
using MMSWebApp2.ViewModel;
using System.Threading.Tasks;


namespace MMSWebApp2.Controllers
{
    public class MemberController : Controller
    {

        private readonly IMemberService _memberService;

        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        //View All Members
        //Index to show current Members
        public async Task<IActionResult> Index()
        {
            IEnumerable<MemberIndexViewModel> members = await _memberService.GetAll();
            return View(members);
        }

        //View details of a Member
        public async Task<IActionResult> Detail(int id)
        {
            if(_memberService.CheckId(id))
            {
                return NotFound();
            }
                
            var member = await _memberService.DetailMember(id);
            if (member == null)
            {
                return NotFound();
            }
            return View(member);
        }

        //Add a new Member
        public IActionResult Create()
        {
            var memberAddViewModel = new MemberCreateViewModel();
            return View(memberAddViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MemberCreateViewModel memberVM)
        {
            if (ModelState.IsValid)
            {
                _memberService.AddMember(memberVM);
                return RedirectToAction(nameof(Index));
            }
            return View(memberVM);
        }

        //Edit a Member
        public async Task<IActionResult> Edit(int id)
        {
            if (_memberService.CheckId(id))
            {
                return NotFound();
            }

            var member = await _memberService.EditMember(id);
            if (member == null)
            {
                return NotFound();
            }
            return View(member);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, MemberEditViewModel memberViewModel)
        {
            if(id != memberViewModel.MemberID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                await _memberService.SaveEditMember(id, memberViewModel);
                return RedirectToAction("Index");
            }
            return View(memberViewModel);
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (_memberService.CheckId(id)) 
            {
                return NotFound();
            }
            var member = await _memberService.DeleteMember(id);
            return View(member);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_memberService.CheckId(id))
            {
                return NotFound();
            }
            await _memberService.DeleteConfirmed(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
