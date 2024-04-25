namespace Sparta_Dungeon
{
    public enum GameMode
    {
        None,
        Home,
        Status,
        Inventory,
        Shop,
        Equipment,
        BuyItem
    }
    internal class GameManager : DataManager
    {
        private GameMode mode = GameMode.Home;
        public void Process()
        {
            switch (mode)
            {
                case GameMode.Home:
                    ProcessHome();
                    Console.Clear();
                    break;
                case GameMode.Status:
                    ProcessStatus();
                    Console.Clear();
                    break;
                case GameMode.Inventory:
                    ProcessInventory();
                    Console.Clear();
                    break;
                case GameMode.Shop:
                    ProcessShop();
                    Console.Clear();
                    break;
                case GameMode.Equipment:
                    ProcessEquipment();
                    Console.Clear();
                    break;
                case GameMode.BuyItem:
                    ProcessBuyItem();
                    Console.Clear();
                    break;
            }
        }
        public void ProcessHome()
        {
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.\n");
            Console.WriteLine("1. 상태 보기\n2. 인벤토리 \n3. 상점\n");
            Console.Write("원하시는 행동을 입력해주세요.\n>> ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    mode = GameMode.Status;
                    break;
                case "2":
                    mode = GameMode.Inventory;
                    break;
                case "3":
                    mode = GameMode.Shop;
                    break;
            }
        }

        private void ProcessStatus()
        {
            Console.WriteLine("상태 보기");
            Console.WriteLine("캐릭터의 정보가 표시됩니다.\n");
            Console.WriteLine("CHICHI (암살자)");
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(status[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Gold : " + gold + " G");
            
            Console.WriteLine(" ");
            Console.WriteLine("0. 나가기\n");
            Console.Write("원하시는 행동을 입력해주세요.\n>> ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "0":
                    mode = GameMode.Home;
                    break;

            }

        }

        private void ProcessInventory()
        {
            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");
            Console.WriteLine("[아이템 목록]\n");
            for(int i = 0;i < inventory.Count;i++) 
            {
                Console.WriteLine($"- {inventory[i]}");
            }
            Console.WriteLine("1. 장착 관리\n0. 나가기\n");
            Console.Write("원하시는 행동을 입력해주세요.\n>> ");
            string input = Console.ReadLine();

            if (input != "0" && input != "1")
            {
                Console.Write("잘못된 입력입니다.");
                Thread.Sleep(1000);
            }
            else
            {
                switch (input)
                {
                    case "0":
                        mode = GameMode.Home;
                        break;
                    case "1":
                        mode = GameMode.Equipment;
                        break;

                }
            }
        }

        private void ProcessShop()
        {
            Console.WriteLine("상점");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");

            Console.WriteLine("[보유 골드]");
            Console.WriteLine(gold + " G\n");

            Console.WriteLine("[아이템 목록]");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(shopItem[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine(" ");
            Console.WriteLine("1. 아이템 구매\n0. 나가기\n");

            Console.Write("원하시는 행동을 입력해주세요.\n>> ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "0":
                    mode = GameMode.Home;
                    break;
                case "1":
                    mode = GameMode.BuyItem;
                    break;
            }
        }

        private void ProcessEquipment()
        {
            

            Console.WriteLine("인벤토리 - 장착 관리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");
            Console.WriteLine("[아이템 목록]");
            for(int i = 0;i < inventory.Count;i++)
            {
                Console.WriteLine("- " + (i+1) + $". {inventory[i]}");
            }

            Console.WriteLine("0. 나가기\n");
            Console.WriteLine("원하시는 행동을 입력해주세요.\n>>");
            string input = Console.ReadLine();
            //if (input !=  )

            switch (input)
            {
                

                case "0":
                    mode = GameMode.Home;
                    break;
                    case "1":
                    if (equip == false)
                    {
                    inventory[0] = "[E] " + inventory[0];
                    equip = true;
                    }
                    else
                    {
                        inventory[0] = inventory[0];
                        equip = false;
                    }

                    break;
                    case "2":
                    if (equip == false)
                    {
                        inventory[1] = "[E] " + inventory[1];
                        equip = true;
                    }
                    else
                    {
                        inventory[1] = inventory[1];
                        equip = false;
                    }
                    break;
                case "3":
                    if (equip == false)
                    {
                        inventory[2] = "[E] " + inventory[2];
                        equip = true;
                    }
                    else
                    {
                        inventory[2] = inventory[2];
                        equip = false;
                    }
                    break;
                case "4":
                    if (equip == false)
                    {
                        inventory[3] = "[E] " + inventory[3];
                        equip = true;
                    }
                    else
                    {
                        inventory[3] = inventory[3];
                        equip = false;
                    }
                    break;
                case "5":
                    if (equip == false)
                    {
                        inventory[4] = "[E] " + inventory[4];
                        equip = true;
                    }
                    else
                    {
                        inventory[4] = inventory[4];
                        equip = false;
                    }
                    break;
                case "6":
                    if (equip == false)
                    {
                        inventory[5] = "[E] " + inventory[5];
                        equip = true;
                    }
                    else
                    {
                        inventory[5] = inventory[5];
                        equip = false;
                    }
                    break;
            }
        }

        private void ProcessBuyItem()
        {
            Console.WriteLine("상점 - 아이템 구매");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.\n");

            Console.WriteLine("[보유 골드]");
            Console.WriteLine(gold + " G\n");

            Console.WriteLine("[아이템 목록]");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(shopItem[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("");
            Console.Write("0. 나가기\n");
            Console.Write("원하시는 행동을 입력해주세요.");
            string input = Console.ReadLine();



            switch (input)
            {
                case "0": mode = GameMode.Shop; break;
                case "1":
                    if (gold >= 1000)
                    {
                        Console.WriteLine("구매를 완료했습니다.");
                        gold -= 1000;
                        shopItem[0, 3] = "구매완료";
                        inventory.Add("수련자 갑옷    |  방어력 +5 |  수련에 도움을 주는 갑옷입니다. | ");
                        status[2, 1] += " (+5)";
                        mode = GameMode.BuyItem;
                    }
                    else
                    {
                        Console.WriteLine("Gold 가 부족합니다.");
                    }
                    break;
                case "2":
                    if (gold >= 1500)
                    {
                        Console.WriteLine("구매를 완료했습니다.");
                        gold -= 1500;
                        shopItem[1, 3] = "구매완료";
                        inventory.Add("무쇠갑옷       | 방어력 +9 | 무쇠로 만들어져 튼튼한 갑옷입니다. | ");
                        status[2, 1] += " (+9)";
                        mode = GameMode.BuyItem;
                    }
                    else
                    {
                        Console.WriteLine("Gold 가 부족합니다.");
                    }
                    break;
                case "3":
                    if (gold >= 3500)
                    {
                        Console.WriteLine("구매를 완료했습니다.");
                        gold -= 3500;
                        shopItem[2, 3] = "구매완료";
                        inventory.Add("스파르타의 갑옷 | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다. | ");
                        status[2, 1] += " (+15)";
                        mode = GameMode.BuyItem;
                    }
                    else
                    {
                        Console.WriteLine("Gold 가 부족합니다.");
                    }
                    break;
                case "4":
                    if (gold >= 600)
                    {
                        Console.WriteLine("구매를 완료했습니다.");
                        gold -= 600;
                        shopItem[3, 3] = "구매완료";
                        inventory.Add("낡은 검        | 공격력 +2 | 쉽게 볼 수 있는 낡은 검 입니다. | ");
                        status[1, 1] += " (+2)";
                        mode = GameMode.BuyItem;
                    }
                    else
                    {
                        Console.WriteLine("Gold 가 부족합니다.");
                    }
                    break;
                case "5":
                    if (gold >= 1500)
                    {
                        Console.WriteLine("구매를 완료했습니다.");
                        gold -= 1500;
                        shopItem[4, 3] = "구매완료";
                        inventory.Add("청동 도끼      | 공격력 +5 | 어디선가 사용됐던거 같은 도끼입니다. | ");
                        status[1, 1] += " (+5)";
                        mode = GameMode.BuyItem;
                    }
                    else
                    {
                        Console.WriteLine("Gold 가 부족합니다.");
                    }
                    break;
                case "6":
                    if (gold >= 2500)
                    {
                        Console.WriteLine("구매를 완료했습니다.");
                        gold -= 2500;
                        shopItem[5, 3] = "구매완료";
                        inventory.Add("스파르타의 창  | 공격력 +7 | 스파르타의 전사들이 사용했다는 전설의 창입니다. | ");
                        status[1, 1] += " (+7)";
                        mode = GameMode.BuyItem;
                    }
                    else
                    {
                        Console.WriteLine("Gold 가 부족합니다.");
                    }
                    break;
            }
        }
    }
}
