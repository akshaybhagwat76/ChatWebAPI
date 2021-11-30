using ChatAppAPI.RepoDto;
using ChatAppAPI.Services;
using ChatAppAPI.Services.Interface;
using ChatWebAPI.ViewModel;
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
        public ChatController(IGetUserslist userListService,IHubContext<ChatHub> hubContext)
        {
            _userListService = userListService;
            _hubContext = hubContext;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
        [Route("send")]
        [HttpPost]
        public async Task<IActionResult> NewMessage([FromBody] Chat_OneToOneVM msg)
        {
            await _hubContext.Clients.All.SendAsync("MessageReceived",msg.Message);
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
        [Route("SearchCustomer")]
        [HttpGet]
        public async Task<IActionResult> SearchCustomer(String prefix)
        {
            try
            {
                return Ok(await _userListService.SearchCustomer(prefix));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [Route("ChatCustomer")]
        [HttpPost]
        public async Task<IActionResult> ChatCustomer(Chat_OneToOneVM Model)
        {
            try
            {
                return Ok(await _userListService.ChatCustomer(Model));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [Route("GetMessages")]
        [HttpGet]
        public async Task<IActionResult> GetMessages(int id)
        {
            try
            {
                return Ok(await _userListService.GetMessages(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [Route("GetCustomerAllMsg")]
        [HttpGet]
        public async Task<IActionResult> GetCustomerAllMsg(int id)
        {
            try
            {
                return Ok(await _userListService.GetCustomerAllMsg(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
