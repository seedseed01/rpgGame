using System;
using System.ComponentModel.DataAnnotations;

namespace rpgGame.Models
{
    public class MonsterData
    {
        public int Id { get; set; } // 主鍵 (自動遞增)

        /// <summary>
        /// 怪物名稱
        /// </summary>
        [Display(Name = "怪物名稱")]
        [Required(ErrorMessage = "請輸入怪物名稱")]
        public string MonsterName { get; set; } = string.Empty;

        /// <summary>
        /// 怪物解說
        /// </summary>
        [Display(Name = "怪物解說")]
        [Required(ErrorMessage = "請輸入怪物解說")]
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// 怪物技能1
        /// </summary>
        [Display(Name = "怪物技能1")]
        [Required(ErrorMessage = "請輸入怪物技能1")]
        public string Skill1 { get; set; } = string.Empty;

        /// <summary>
        /// 怪物技能2
        /// </summary>
        [Display(Name = "怪物技能2")]
        [Required(ErrorMessage = "請輸入怪物技能2")]
        public string Skill2 { get; set; } = string.Empty;

        /// <summary>
        /// 怪物技能3
        /// </summary>
        [Display(Name = "怪物技能3")]
        [Required(ErrorMessage = "請輸入怪物技能3")]
        public string Skill3 { get; set; } = string.Empty;

        /// <summary>
        /// 怪物技能4
        /// </summary>
        [Display(Name = "怪物技能4")]
        [Required(ErrorMessage = "請輸入怪物技能4")]
        public string Skill4 { get; set; } = string.Empty;

        /// <summary>
        /// 怪物技能5
        /// </summary>
        [Display(Name = "怪物技能5")]
        [Required(ErrorMessage = "請輸入怪物技能5")]
        public string Skill5 { get; set; } = string.Empty;

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

        /// <summary>
        /// 屬性
        /// </summary>
        [Display(Name = "屬性")]
        [Required(ErrorMessage = "請輸入屬性")]
        public string Element { get; set; } = string.Empty;
    }
}