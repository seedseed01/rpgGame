using Microsoft.AspNetCore.Mvc;
using rpgGame.Data;
using rpgGame.Models;
using System;
using System.Linq;

namespace rpgGame.Controllers
{
    [Route("api/forum")]
    [ApiController]
    public class ForumApiController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ForumApiController(AppDbContext context)
        {
            _context = context;
        }

        // 📍 1. GET: api/forum (取得所有留言)
        [HttpGet]
        public IActionResult GetMessages()
        {
            var messages = _context.ForumMessages
                .OrderByDescending(m => m.CreatedAt)
                .Select(m => new 
                {
                    m.Id,
                    m.Username,
                    m.Content,
                    CreatedAt = m.CreatedAt.ToString("yyyy-MM-dd HH:mm")
                    // 💡 注意：密碼欄位切勿在 API 回傳，保護隱私！
                })
                .ToList();

            return Ok(messages);
        }

        // 📍 2. POST: api/forum (新增留言)
        [HttpPost]
        public IActionResult CreateMessage([FromBody] ForumMessage message)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { success = false, message = "輸入格式不正確，密碼需為 8 碼！" });
            }

            message.CreatedAt = DateTime.Now;
            _context.ForumMessages.Add(message);
            _context.SaveChanges();

            return Ok(new { success = true, message = "留言成功發送！" });
        }

        // 📍 3. PUT: api/forum/5 (修改留言，需驗證密碼)
        [HttpPut("{id}")]
        public IActionResult UpdateMessage(int id, [FromBody] ForumActionDto dto)
        {
            var msg = _context.ForumMessages.Find(id);
            if (msg == null)
            {
                return NotFound(new { success = false, message = "找不到該筆留言！" });
            }

            // 比對密碼
            if (msg.Password != dto.Password)
            {
                return BadRequest(new { success = false, message = "密碼不正確！無法修改。" });
            }

            if (string.IsNullOrWhiteSpace(dto.Content))
            {
                return BadRequest(new { success = false, message = "修改內容不可為空！" });
            }

            msg.Content = dto.Content;
            _context.SaveChanges();

            return Ok(new { success = true, message = "留言修改成功！" });
        }

        // 📍 4. DELETE: api/forum/5 (刪除留言，需驗證密碼)
        [HttpDelete("{id}")]
        public IActionResult DeleteMessage(int id, [FromBody] ForumActionDto dto)
        {
            var msg = _context.ForumMessages.Find(id);
            if (msg == null)
            {
                return NotFound(new { success = false, message = "找不到該筆留言！" });
            }

            // 比對密碼
            if (msg.Password != dto.Password)
            {
                return BadRequest(new { success = false, message = "密碼不正確！無法刪除。" });
            }

            _context.ForumMessages.Remove(msg);
            _context.SaveChanges();

            return Ok(new { success = true, message = "留言已成功刪除！" });
        }
    }
}