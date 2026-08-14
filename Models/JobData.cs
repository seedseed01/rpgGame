using System;
using System.ComponentModel.DataAnnotations;

namespace rpgGame.Models
{
    public class JobData
    {
        public int Id { get; set; } // 主鍵 (自動遞增)

        /// <summary>
        /// 職業名稱
        /// </summary>
        [Display(Name = "職業名稱")]
        [Required(ErrorMessage = "請輸入職業名稱")]
        public string JobName { get; set; } = string.Empty;

        /// <summary>
        /// 職業解說/背景故事
        /// </summary>
        [Display(Name = "職業解說")]
        [Required(ErrorMessage = "請輸入職業解說")]
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// HP
        /// </summary>
        [Display(Name = "HP")]
        public int Hp { get; set; } = 0;

        /// <summary>
        /// MP
        /// </summary>
        [Display(Name = "MP")]
        public int Mp { get; set; } = 0;

        /// <summary>
        /// Attack
        /// </summary>
        [Display(Name = "攻擊力")]
        public int Attack { get; set; } = 0;

        /// <summary>
        /// Defense
        /// </summary>
        [Display(Name = "防禦力")]
        public int Defense { get; set; } = 0;

        /// <summary>
        /// 魔法攻擊力
        /// </summary>
        [Display(Name = "魔法攻擊力")]
        public int MagicAttack { get; set; } = 0;

        /// <summary>
        /// 魔法防禦力
        /// </summary>
        [Display(Name = "魔法防禦力")]
        public int MagicDefense { get; set; } = 0;

        /// <summary>
        /// 速度
        /// </summary>
        [Display(Name = "速度")]
        public int Speed { get; set; } = 0;
    }
}