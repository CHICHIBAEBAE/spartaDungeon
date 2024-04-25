using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparta_Dungeon
{
    internal class Item
    {
        public string name;
        public int atStat;
        public int shStat;
        public string ex;
        public int price;
        public Item(string name, int atStat, int shStat, string ex, int price)
        {
            this.name = name;
            this.atStat = atStat;
            this.shStat = shStat;
            this.ex = ex;
            this.price = price;
        }

        public List<Item> items = new List<Item>();
        

        Item item1 = new Item("수련자 갑옷", 0, 5, "수련에 도움을 주는 갑옷입니다.", 1000);
        Item item2 = new Item("무쇠 갑옷", 0, 9, "무쇠로 만들어져 튼튼한 갑옷입니다.", 1500);
        Item item3 = new Item("스파르타의 갑옷", 0, 15, "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", 3500);
        Item item4 = new Item("낡은 검", 2, 0, "쉽게 볼 수 있는 낡은 검 입니다.", 600);
        Item item5 = new Item("청동 도끼", 5, 0, "어디선가 사용됐던거 같은 도끼입니다.", 1500);
        Item item6 = new Item("스파르타의 창", 7, 0, "스파르타의 전사들이 사용했다는 전설의 창입니다.", 2500);

        public void ItemList()
        {
            items.Add(item1);
            items.Add(item2);
            items.Add(item3);
            items.Add(item4);
            items.Add(item5);
            items.Add(item6);
        }
    }
}
