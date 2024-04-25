using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparta_Dungeon
{
    internal class DataManager
    {


        public int gold = 1500;
        public bool equip = false;
         


        public string[,] status = new string[4, 2]
        {
            {"Lv. ", "01" },
            {"공격력 : ", "10"},
            {"방어력 : ", "5" },
            {"체 력 : ", "100" }
        };
            
        public string[,] shopItem = new string[6, 4]
        {
            {"수련자 갑옷    | ", "방어력 +5 |", "수련에 도움을 주는 갑옷입니다. | ", "1000 G"},
            {"무쇠갑옷       | ", "방어력 +9 | ", "무쇠로 만들어져 튼튼한 갑옷입니다. | ", "1500 G"},
            {"스파르타의 갑옷 | ", "방어력 +15 | ", "스파르타의 전사들이 사용했다는 전설의 갑옷입니다. | ", "3500 G"},
            {"낡은 검        | ", "공격력 +2 | ", "쉽게 볼 수 있는 낡은 검 입니다. | ", "600 G"},
            {"청동 도끼      | ", "공격력 +5 | ", "어디선가 사용됐던거 같은 도끼입니다. | ", "1500 G"},
            {"스파르타의 창  | ", "공격력 +7 | ", "스파르타의 전사들이 사용했다는 전설의 창입니다. | ", "2500 G"}
        };
        public List<string> inventory = new List<string>
        {
           
        };
        

        }
 }

