using ChatAppAPI.RepoDto;
using ChatAppAPI.Services;
using ChatAppAPI.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalRChat.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatAppAPI.Controllers
{
    [Route("api/chat")]
    [ApiController]
    public class ChatController : Controller
    {
        private readonly IHubContext<ChatHub> _hubContext;
        private readonly IGetUserslist _userListService;
        // private readonly IHubContext<ChatHub> _hubContext;
        public ChatController(IGetUserslist userListService)
        {
            _userListService = userListService;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
        //[Route("send")]
        [HttpPost]
        public IActionResult SendRequest([FromBody] MessageDto msg)
        {
            _hubContext.Clients.All.SendAsync("ReceiveOne", msg.user, msg.msgText);

            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetCustomerList()
        {
            try
            {
                return Ok(await _userListService.GetCustomerList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
