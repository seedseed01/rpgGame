using System;
using System.Linq;
using rpgGame.Models;

namespace rpgGame.Data
{
    public static class DbSeeder
    {
        public static void Seed(AppDbContext context)
        {
            // 1. 職業資料 (JobDatas)
            if (!context.JobDatas.Any())
            {
                context.JobDatas.AddRange(
                    new JobData { JobName = "樵夫", Content = "村莊中的樵夫，因長年揮舞斧頭，爆發力不可小覷，也是村莊中力量最大的，肌肉與長年累積的厚繭也增加自身不少保護力，但腳程較慢，對魔法不擅長", Hp = 100, Mp = 50, Attack = 40, Defense = 25, MagicAttack = 10, MagicDefense = 10, Speed = 10 },
                    new JobData { JobName = "農夫", Content = "村莊中的農夫，日出而作，日落而息，因長期下田耕地，擁有扎實的下盤功夫，跟樵夫比相撲從沒輸過，像是牆一樣屹立不倒，但腳程較慢，對魔法不擅長", Hp = 100, Mp = 50, Attack = 25, Defense = 40, MagicAttack = 10, MagicDefense = 10, Speed = 10 },
                    new JobData { JobName = "獵人", Content = "村莊中的獵人，成天在山林狩獵，適應各種地形移動，雖然力量與體魄沒有樵夫和農夫來的強，但也是村莊中排名前幾的存在，對魔法相關小小有研究。", Hp = 100, Mp = 50, Attack = 30, Defense = 30, MagicAttack = 15, MagicDefense = 15, Speed = 30 },
                    new JobData { JobName = "學者", Content = "住在村莊邊緣的學者，說是村莊中最有智慧的也不為過，整天關在房裡研究外地買來的各種書籍，對魔法書籍研究興趣極高，因常廢寢忘食的研究，導致體力不好。", Hp = 80, Mp = 70, Attack = 15, Defense = 20, MagicAttack = 50, MagicDefense = 30, Speed = 15 },
                    new JobData { JobName = "扒手", Content = "流浪到村莊的扒手，腳程極快，雖然常常被發現行竊，但沒有一次被抓到，常去學者家偷快放到過期的食物，理解力好，不知不覺記下放在食物旁的魔法防禦書籍的內容。", Hp = 80, Mp = 70, Attack = 20, Defense = 15, MagicAttack = 20, MagicDefense = 50, Speed = 35 }
                );
            }

            // 2. 個性資料 (NatureDatas)
            if (!context.NatureDatas.Any())
            {
                context.NatureDatas.AddRange(
                    new NatureData { NatureName = "平衡", Ability = "能力平均成長" },
                    new NatureData { NatureName = "暴躁", Ability = "攻擊成長高，防禦成長低" },
                    new NatureData { NatureName = "謹慎", Ability = "防禦成長高，攻擊成長低" },
                    new NatureData { NatureName = "專注", Ability = "魔法攻擊成長高，魔法防禦成長低" },
                    new NatureData { NatureName = "冥想", Ability = "魔法防禦成長高，魔法攻擊成長低" },
                    new NatureData { NatureName = "神行", Ability = "速度成長高，防禦與魔法防禦成長低" }
                );
            }

            // 3. 怪物資料 (MonsterDatas)
            if (!context.MonsterDatas.Any())
            {
                context.MonsterDatas.AddRange(
                    new MonsterData 
                    { 
                        MonsterName = "哥布林", 
                        Content = "魔王軍裡的初階士兵，綠皮膚大肚子，時常揮舞著狼牙棒在森林裡襲擊落單旅人。", 
                        Skill1 = "狼牙棒攻擊: 一般攻擊", 
                        Skill2 = "狂暴揮擊: 當血量少於20時，進入狂暴狀態，攻擊力增加", 
                        Skill3 = "", 
                        Skill4 = "",
                        Skill5 = "",
                        Hp = 50, Mp = 30, Attack = 25, Defense = 20, MagicAttack = 7, MagicDefense = 3, Speed = 14,
                        Element = "風"
                    },
                    new MonsterData 
                    { 
                        MonsterName = "幽靈大樹", 
                        Content = "枯木般身體，以及像是樹葉般的鬼火罩在上頭，深夜徘徊在樹林間，準備隨時燒烤旅人來飽餐一頓。", 
                        Skill1 = "揮舞樹枝: 一般攻擊", 
                        Skill2 = "鬼火飛濺: 特殊攻擊", 
                        Skill3 = "大鬼火飛濺: 當血量少於20時，會進入狂暴狀態，魔法攻擊力大增", 
                        Skill4 = "",
                        Skill5 = "",
                        Hp = 150, Mp = 150, Attack = 20, Defense = 30, MagicAttack = 40, MagicDefense = 60, Speed = 20,
                        Element = "火"
                    },
                    new MonsterData 
                    { 
                        MonsterName = "石像鬼", 
                        Content = "魔王城堡外的石像守衛，守衛著城堡的同時也在監視城外的一舉一動。", 
                        Skill1 = "揮舞石頭: 一般攻擊", 
                        Skill2 = "捨身衝撞: 威力較大的物理攻擊，石像鬼本身也會損傷", 
                        Skill3 = "石化: 當血量少於100時，石像鬼會加強時畫大幅提升防禦力",
                        Skill4 = "",
                        Skill5 = "",
                        Hp = 200, Mp = 30, Attack = 70, Defense = 70, MagicAttack = 50, MagicDefense = 60, Speed = 10,
                        Element = "土"
                    },
                    new MonsterData 
                    { 
                        MonsterName = "絨絨鳥", 
                        Content = "全身覆蓋棉花般柔軟的魔法絨毛，可以吸收一切的魔法攻擊，因長期吸收大量各屬性的魔法，所以可以自在變化自身屬性。", 
                        Skill1 = "尖嘴攻擊: 一般攻擊", 
                        Skill2 = "魔力風箭: 特殊攻擊", 
                        Skill3 = "絨毛炸彈: 全身絨毛當做炸彈丟出，會暫時無絨毛狀態，但炸彈威力驚人", 
                        Skill4 = "絨毛吸收: 血量少於100時，身體會吸收絨毛大幅提伸全能力，會暫時為無絨毛狀態", 
                        Skill5 = "【常駐狀態】每回合會隨機變化自身屬性",
                        Hp = 300, Mp = 500, Attack = 85, Defense = 50, MagicAttack = 85, MagicDefense = 60, Speed = 50,
                        Element = "水"
                    },
                    new MonsterData 
                    { 
                        MonsterName = "死靈英雄", 
                        Content = "前一代的英雄，在擊敗魔王後安然度過晚年，安眠時人民將英雄生前裝備當陪葬品一起下葬。之後魔王再現時，用死靈術復活英雄並控制為手下去破壞他曾保護的這片大陸。", 
                        Skill1 = "揮劍劈展: 一般攻擊", 
                        Skill2 = "元素攻擊: 特殊攻擊", 
                        Skill3 = "雙手大盾: 左右手隨機開啟兩回合防禦大盾，開啟期間物理或是魔法攻擊將無效化，也有可能開啟大盾失敗",
                        Skill4 = "劍氣護身: 當血量少於100時，手中長劍會爆出藍光，讓劍氣不但飛向敵人，也讓劍氣壟罩全身，具有反彈敵人攻擊的效用",
                        Skill5 = "【常駐狀態】脖子上擁有受祝福的項鍊，每回合會隨機提升自身能力",
                        Hp = 1000, Mp = 1000, Attack = 100, Defense = 100, MagicAttack = 100, MagicDefense = 100, Speed = 50,
                        Element = "暗"
                    }
                );
            }

            // 4. 道具資料 (ItemDatas)
            if (!context.ItemDatas.Any())
            {
                context.ItemDatas.AddRange(
                    new ItemData { ItemName = "力量藥水", Content = "可增加攻擊力10點", Able = "攻擊", Porm = 1, Value = 10, CreatedAt = DateTime.Parse("2026-08-14 10:00:00") },
                    new ItemData { ItemName = "防禦藥水", Content = "可增加防禦力10點", Able = "防禦", Porm = 1, Value = 10, CreatedAt = DateTime.Parse("2026-08-14 10:00:00") },
                    new ItemData { ItemName = "魔法藥水", Content = "可增加魔力10點", Able = "魔攻", Porm = 1, Value = 10, CreatedAt = DateTime.Parse("2026-08-14 10:00:00") },
                    new ItemData { ItemName = "魔防藥水", Content = "可增加魔防10點", Able = "魔防", Porm = 1, Value = 10, CreatedAt = DateTime.Parse("2026-08-14 10:00:00") },
                    new ItemData { ItemName = "速度藥水", Content = "可增加速度10點", Able = "速度", Porm = 1, Value = 10, CreatedAt = DateTime.Parse("2026-08-14 10:00:00") },
                    new ItemData { ItemName = "血量藥水", Content = "可增加HP 50點", Able = "HP", Porm = 1, Value = 50, CreatedAt = DateTime.Parse("2026-08-14 10:00:00") },
                    new ItemData { ItemName = "能量藥水", Content = "可增加MP 50點", Able = "MP", Porm = 1, Value = 50, CreatedAt = DateTime.Parse("2026-08-14 10:00:00") },
                    new ItemData { ItemName = "元素藥水", Content = "可隨機改變屬性", Able = "屬性", Porm = 0, Value = 0, CreatedAt = DateTime.Parse("2026-08-14 10:00:00") },
                    new ItemData { ItemName = "萬能藥水", Content = "可解異常狀態", Able = "狀態", Porm = 0, Value = 0, CreatedAt = DateTime.Parse("2026-08-14 10:00:00") },
                    new ItemData { ItemName = "升級藥水", Content = "可提升自己的等級5等", Able = "等級", Porm = 1, Value = 5, CreatedAt = DateTime.Parse("2026-08-14 10:00:00") },
                    new ItemData { ItemName = "降級藥水", Content = "可降低魔物的等級5等", Able = "等級", Porm = 2, Value = 5, CreatedAt = DateTime.Parse("2026-08-14 10:00:00") },
                    new ItemData { ItemName = "解讀藥水", Content = "可知曉該回合的魔物能力", Able = "特殊", Porm = 0, Value = 0, CreatedAt = DateTime.Parse("2026-08-14 10:00:00") }
                );
            }

            // 5. 事件資料 (EventsDatas)
            if (!context.EventsDatas.Any())
            {
                context.EventsDatas.AddRange(
                    new EventsData { Person = "村長", Talk = "年輕人加油啊，都靠你了!", EventInfo = "得到村長的激勵，經驗增加!", Affect = "經驗值", Porm = 1, Value = 100 },
                    new EventsData { Person = "旅人勇者阿飛", Talk = "這是你們村的考驗，我不會幫你，但我可以給你一些經驗談", EventInfo = "專心聽著阿飛的分享，結果都是他的當年勇，但還是有些收穫", Affect = "經驗值", Porm = 1, Value = 200 },
                    new EventsData { Person = "餐館老闆阿力", Talk = "老頭我關於戰鬥幫不上忙，但幫你填飽肚子不是問題", EventInfo = "喝了老闆給的十全大補湯，感到活力充沛", Affect = "HP", Porm = 1, Value = 100 },
                    new EventsData { Person = "吟遊詩人", Talk = "啦啦啦啦啦~~嗚啦啦啦啦~~", EventInfo = "聽了吟遊詩人演唱，信心加持，感覺力量湧現", Affect = "攻擊", Porm = 1, Value = 10 },
                    new EventsData { Person = "好友阿塚", Talk = "我來陪你做特訓吧!", EventInfo = "與好友阿塚做特訓，越來越得心應手", Affect = "攻擊", Porm = 1, Value = 10 },
                    new EventsData { Person = "好友阿塚", Talk = "我來陪你做特訓吧!", EventInfo = "與好友阿塚做特訓，越來越得心應手", Affect = "防禦", Porm = 1, Value = 10 },
                    new EventsData { Person = "圖書館蘇婆婆", Talk = "想做英雄也是要有智慧的，來!進來讀書", EventInfo = "被蘇婆婆抓進圖書館念書，從書中得到啟發強化精神", Affect = "魔攻", Porm = 1, Value = 20 },
                    new EventsData { Person = "阿薛", Talk = "嘻嘻~我在外面放了超多陷阱，踩到算你活該!嘻嘻~", EventInfo = "你揍了阿薛一拳，心情大好，精神煥然一發", Affect = "魔攻", Porm = 1, Value = 20 },
                    new EventsData { Person = "阿明", Talk = "阿薛在村莊附近擺了超多陷阱，你走路要小心不要踩到喔", EventInfo = "為避免踩到陷阱，你專注在走路上，但走幾分鐘後就放棄了，但專注時間也鍛鍊了你危機感知力。", Affect = "魔防", Porm = 1, Value = 10 },
                    new EventsData { Person = "光頭長老", Talk = "小子，我家的那隻猴子又跑掉了。你去幫我追回來", EventInfo = "你在森林裡費盡千辛萬苦才終於抓到牠，也學習了猴子的移動方式", Affect = "速度", Porm = 1, Value = 10 },
                    new EventsData { Person = "狗", Talk = "汪汪汪汪汪汪汪汪!", EventInfo = "不小心踩到狗，被狗咬傷...", Affect = "HP", Porm = 2, Value = 20 },
                    new EventsData { Person = "三姑", Talk = "哎呀呀，這不是那個小英雄嗎? 來來來聊天吧!", EventInfo = "被村裡長舌婦纏上，精神疲憊", Affect = "MP", Porm = 2, Value = 50 },
                    new EventsData { Person = "漁夫", Talk = "欸同學同學，這個你拿一下，我是前面那艘船上的漁夫啦，這是我們自己做的小魚乾...", EventInfo = "被強迫推銷不好吃又沒營養的小魚乾，一直耿耿於懷，精神力不集中", Affect = "魔攻", Porm = 2, Value = 5 },
                    new EventsData { Person = "隔壁村倖存者", Talk = "嗚哇嗚哇哇哇哇!嗚嗚嗚哇!!嗚哇阿!", EventInfo = "原本要聽他哭訴的，但完全聽不懂他在講啥，反而腿被他抱的有點發麻", Affect = "速度", Porm = 2, Value = 5 },
                    new EventsData { Person = "貓", Talk = "喵.....", EventInfo = "貓愛理不理的，為了逗貓浪費太多時間", Affect = "行動力", Porm = 2, Value = 1 }
                );
            }

            // 6. 狀態資料 (StatusDatas)
            if (!context.StatusDatas.Any())
            {
                context.StatusDatas.AddRange(
                    new StatusData { StatusName = "一般", Content = "無" },
                    new StatusData { StatusName = "中毒", Content = "每回合減少HP。" },
                    new StatusData { StatusName = "迷幻", Content = "每回合減少MP。" },
                    new StatusData { StatusName = "麻痺", Content = "每回合有機率無法行動。" },
                    new StatusData { StatusName = "無力", Content = "攻擊力會暫時降低。" },
                    new StatusData { StatusName = "無神", Content = "魔法攻擊力會暫時降低。" }
                );
            }

            // 一次性儲存變更至 SQLite
            context.SaveChanges();
        }
    }
}