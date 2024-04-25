namespace Sparta_Dungeon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();
            
            while (true)
            {
                gameManager.Process();
            }
        }
    }
}
