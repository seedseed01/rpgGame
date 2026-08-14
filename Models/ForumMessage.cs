using System;
using System.ComponentModel.DataAnnotations;

namespace rpgGame.Models
{
    public class ForumMessage
    {
        public int Id { get; set; } // 主鍵 (自動遞增)

        [Required(ErrorMessage = "請輸入玩家暱稱")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "請輸入留言內容")]
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// 8碼自訂密碼 (含英數與特殊符號)
        /// </summary>
        [Required(ErrorMessage = "請輸入 8 碼管理密碼")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "密碼必須剛好為 8 碼")]
        [RegularExpression(@"^[a-zA-Z0-0!@#$%^&*()_+\-=\[\]{};':""\\|,.<>\/?]{8}$", ErrorMessage = "密碼格式不符")]
        public string Password { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now; // 留言時間
    }

    /// <summary>
    /// 用於接收修改與刪除請求的 DTO (Data Transfer Object)
    /// </summary>
    public class ForumActionDto
    {
        public string Password { get; set; } = string.Empty;
        public string? Content { get; set; } // 修改時才會用到
    }
}