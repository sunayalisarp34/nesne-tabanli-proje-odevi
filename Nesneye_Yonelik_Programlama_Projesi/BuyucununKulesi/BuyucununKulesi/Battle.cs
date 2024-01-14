using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyucununKulesi
{
    public class Battle
    {
        public void BattleStart(IMobs player, IMobs enemy)
        {

            while (player.IsAlive && enemy.IsAlive)
            {
                //Battle Screen
                Console.WriteLine("===============");
                Console.WriteLine("{0} Canı: {1}", player.Name, player.Health);
                Console.WriteLine("{0} Canı: {1}", enemy.Name, enemy.Health);
                Console.WriteLine("===============");

                Console.WriteLine("Yapmak istediğiniz eylemi seçiniz");
                Console.WriteLine("Saldır: 1");
                Console.WriteLine("Savun: 2");
                Console.WriteLine("Can Bas: 3");
                Console.WriteLine("Kaç: 4");
                Console.WriteLine("Type help if you wanted to be guided.");
                Console.Write("\nEylem: ");

                string userInput = Console.ReadLine();
                Console.Clear();
                //Core battle flow
                switch (userInput.ToLower())
                {
                    case "1":
                        //Attack move.
                        player.Attack(enemy);
                        if (enemy.IsAlive)
                        {
                            enemy.Attack(player);
                        }
                        break;

                    case "2":
                        //Player is defending so the damage of enemy gets halved.
                        double defensePositionDamage = enemy.AttackPower / 2 - player.Defense;
                        if (defensePositionDamage > 0)
                        {
                            player.Health -= defensePositionDamage;
                            Console.WriteLine("{0} saldırıyor {1}. Verilen hasar: {2}", enemy.Name, player.Name, defensePositionDamage);
                        }
                        else
                        {
                            Console.WriteLine("{0} saldırdı ama başarılı olamadı.", enemy.Name);
                        }
                        break;

                    case "3":
                        //Healing control.
                        if (player.Health == 100) 
                        {
                            Console.WriteLine("Canınız tamamen dolu.");
                            break;
                        }
                        else
                        {
                            double healAmount = 15;
                            player.Health += healAmount;
                            Console.WriteLine("{0} canını {1} arttırdı.", player.Name, healAmount);
                            enemy.Attack(player);
                            break;
                        }

                    case "4":
                        //To quit the battle
                        
                        Console.WriteLine("Emin Misiniz?(Evet için E, Hayır için H yazınız.)");//Ensures for quiting the battle
                        string answer = Console.ReadLine().ToLower();
                        switch (answer)
                        {
                            case "e":

                                Console.WriteLine("Savaştan başarıyla kaçtın.");

                                Console.WriteLine("Kuleden yavaşça uzaklaşırken en tepedeki hazinenin ne olduğunu düşündün.");
                                
                                if (PlayAgain())
                                {
                                    Console.Clear();
                                    Game.HelloScreen();
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("Oyundan Çıkılıyor...");
                                    Console.ReadKey();
                                    Environment.Exit(0);
                                }
                                return;
                            case "h":
                                Console.Clear();
                                Console.WriteLine("Savaş devam ediyor.");
                                continue;
                            default:
                                Console.WriteLine("Yanlış seçim. Menüden geçerli olan bir seçenek seçiniz.");
                                break;
                        }
                        break;


                    //help menu
                    case "help":
                        Console.Clear();
                        Console.WriteLine("=======HELP MENU========");
                        Console.WriteLine("Press 1 to attack the enemy");
                        Console.WriteLine("Press 2 to defend yourself from the enemy");
                        Console.WriteLine("Press 3 to heal yourself.");
                        Console.WriteLine("Press 4 to quit the battle.");
                        Console.WriteLine();
                        Console.WriteLine("Press Enter to return the battle...");
                        Console.ReadKey(); 
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Yanlış seçim. Menüden geçerli olan bir seçenek seçiniz.");
                        break;
                }
            }


            CheckWinner(player, enemy);
            
        }
        //Checking the result of battle
        public void CheckWinner(IMobs player, IMobs enemy)
        {
            bool winner = player.IsAlive && !enemy.IsAlive;
            if (winner)
            {
                Console.WriteLine("Tebrikler! Dövüşü Kazandınız.");
                
            }
            else
            {
                Console.WriteLine("Yenildiniz.");
                if (PlayAgain())
                {
                    Console.Clear();
                    Game.HelloScreen();
                }
                else
                {
                    Console.WriteLine("Oyundan Çıkılıyor...");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }

        }
        private bool PlayAgain()
        {
            Console.WriteLine("Tekrar Oynamak İster Misiniz? (Evet/Hayır)");
            string response = Console.ReadLine().ToLower();
            return (response == "evet") || (response == "e"); 
        }
    }
}
