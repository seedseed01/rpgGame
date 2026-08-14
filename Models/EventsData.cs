using System;
using System.ComponentModel.DataAnnotations;

namespace rpgGame.Models
{
    public class EventsData
    {
        public int Id { get; set; } // 主鍵 (自動遞增)

        /// <summary>
        /// 對象名稱
        /// </summary>
        [Display(Name = "對象名稱")]
        [Required(ErrorMessage = "請輸入對象名稱")]
        public string Person { get; set; } = string.Empty;

        /// <summary>
        /// 對話內容
        /// </summary>
        [Display(Name = "對話內容")]
        [Required(ErrorMessage = "請輸入對話內容")]
        public string Talk { get; set; } = string.Empty;

        /// <summary>
        /// 事件內容
        /// </summary>
        [Display(Name = "事件內容")]
        [Required(ErrorMessage = "請輸入事件內容")]
        public string EventInfo { get; set; } = string.Empty;

        /// <summary>
        /// 影響
        /// </summary>
        [Display(Name = "影響")]
        [Required(ErrorMessage = "請輸入影響能力")]
        public string Affect { get; set; } = string.Empty;

        /// <summary>
        /// 正負面
        /// </summary>
        public int Porm { get; set; } = 0;

        /// <summary>
        /// 數值
        /// </summary>
        public int Value { get; set; } = 0;
    }
}