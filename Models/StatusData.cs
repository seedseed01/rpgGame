using System;
using System.ComponentModel.DataAnnotations;

namespace rpgGame.Models
{
    public class StatusData
    {
        public int Id { get; set; } // 主鍵 (自動遞增)

        /// <summary>
        /// 狀態名稱
        /// </summary>
        [Display(Name = "狀態名稱")]
        [Required(ErrorMessage = "請輸入狀態名稱")]
        public string StatusName { get; set; } = string.Empty;

        /// <summary>
        /// 狀態說明
        /// </summary>
        [Display(Name = "狀態說明")]
        [Required(ErrorMessage = "請輸入狀態說明")]
        public string Content { get; set; } = string.Empty;
    }
}