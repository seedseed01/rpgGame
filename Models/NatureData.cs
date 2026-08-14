using System;
using System.ComponentModel.DataAnnotations;

namespace rpgGame.Models
{
    public class NatureData
    {
        public int Id { get; set; } // 主鍵 (自動遞增)

        /// <summary>
        /// 個性名稱
        /// </summary>
        [Display(Name = "個性名稱")]
        [Required(ErrorMessage = "請輸入個性名稱")]
        public string NatureName { get; set; } = string.Empty;

        /// <summary>
        /// 能力成長變化
        /// </summary>
        [Display(Name = "能力成長變化")]
        [Required(ErrorMessage = "請輸入能力成長變化")]
        public string Ability { get; set; } = string.Empty;
    }
}