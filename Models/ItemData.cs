using System;
using System.ComponentModel.DataAnnotations;

namespace rpgGame.Models
{
    public class ItemData
    {
        public int Id { get; set; } // 主鍵 (自動遞增)

        /// <summary>
        /// 道具名稱
        /// </summary>
        [Display(Name = "道具名稱")]
        [Required(ErrorMessage = "請輸入道具名稱")]
        public string ItemName { get; set; } = string.Empty;

        /// <summary>
        /// 道具解說/背景故事
        /// </summary>
        [Display(Name = "道具解說")]
        [Required(ErrorMessage = "請輸入道具解說")]
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// 影響的能力 (例如：HP、Attack、Defense)
        /// </summary>
        [Display(Name = "影響能力")]
        [Required(ErrorMessage = "請輸入影響的能力")]
        public string Able { get; set; } = string.Empty;

        /// <summary>
        /// 正負面狀態 (預設為 0，例如：1 為正面BUFF, -1 為負面DEBUFF)
        /// </summary>
        [Display(Name = "正負面")]
        public int Porm { get; set; } = 0;

        /// <summary>
        /// 影響的數值大小 (例如：+50 或 -20)
        /// </summary>
        [Display(Name = "影響值")]
        public int Value { get; set; } = 0;

        /// <summary>
        /// 建立時間
        /// </summary>
        [Display(Name = "建立時間")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}