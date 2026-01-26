using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MMSWebApp2.Models;
using MMSWebApp2.Service.Interface;

namespace MMSWebApp2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMemberService _memberService;

        public HomeController(IMemberService memberService)
        {
            _memberService = memberService;
        }
        public async Task<IActionResult> Index()
        {
            var memberCount = await _memberService.GetMemberCount();
            return View(memberCount);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
