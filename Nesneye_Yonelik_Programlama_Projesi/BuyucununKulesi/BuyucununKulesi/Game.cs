using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyucununKulesi
{
    public class Game
    {
        public static void HelloScreen() 
        {
            //Welcoming screen
            Console.WriteLine("======================");
            Console.WriteLine("  Büyücünün Kulesi'ne ");
            Console.WriteLine("     Hoşgeldiniz      ");
            Console.WriteLine("======================");
            Console.WriteLine("\nDevam etmek için Enter tuşuna basınız...");
            Console.ReadKey();
            Console.Clear();
            
            //Asks players name
            Console.WriteLine("Maceracı adını giriniz...");
            string name = Console.ReadLine();
            
            
            Player currentPlayer = new Player(name);
            Console.Clear();
            //Information about player
            Console.WriteLine("======Maceracı======");
            Console.WriteLine("======Bilgileri======");
            Console.WriteLine();
            Console.WriteLine("Ad: {0}", currentPlayer.Name);
            Console.WriteLine("Saldırı: {0}", currentPlayer.AttackPower);
            Console.WriteLine("Savunma: {0}", currentPlayer.Defense);
            Console.WriteLine("Can: {0}", currentPlayer.Health);
            Console.WriteLine();
            Console.WriteLine("Devam etmek için Enter Tuşuna Basınız.");
            Console.ReadKey();
            Console.Clear();

            //First Scene
            Console.WriteLine("Yakınlardaki bir köyde duyduğun dedikodular seni ulu büyücünün kulesine getirdi.");
            Console.WriteLine("Rivayete göre kulenin tepesinde uğruna birçok savaşcının öldüğü büyük bir hazine vardı.");
            Console.WriteLine("Hazinenin getireceği zenginlik, şan ve şöhretin düşüncesi kanını kaynatarak kuleye vardın.");
            Console.WriteLine("Kulenin kapısına yaklaşıp onu ittin ve şansına kapı sana açıldı.");
            Console.WriteLine("Tabi bunun şans mı lanet mi olduğuna karar verecek olan sensin.");
            Console.WriteLine("\n\nDevam etmek için Enter Tuşuna Basınız...");
            Console.ReadKey();
            Console.Clear();

            //First Battle
            Goblin goblin = new Goblin();
            Console.WriteLine("Kulenin içinde sana saldırmaya hazır bir düşmanın varlığını fark ettin.");
            Battle battle1 = new Battle();
            battle1.BattleStart(currentPlayer, goblin);
            
            Console.WriteLine("Devam etmek için Enter tuşuna basınız...");
            Console.ReadKey();
            Console.Clear();

            //Second scene
            Console.WriteLine("İlk düşmanı zorlu ve tehlikeli bir mücadelenin ardından yenmeyi başardın.");
            Console.WriteLine("Kulenin üst basamaklarını çıkarken uğursuz takırtılar duymaya başladın.");
            Console.WriteLine("İkinci katın kapısını açtığında karşına sanki bir kabustan çıkmış gibi gözüken bir iskelet ile karşılaştın");
            Console.WriteLine("\n\nDevam etmek için Enter Tuşuna Basınız...");
            Console.ReadKey();
            Console.Clear();

            //Second battle
            Skeloton skeloton = new Skeloton();
            Console.WriteLine("Kulenin içinde sana saldırmaya hazır bir düşmanın varlığını fark ettin.");
            Battle battle2 = new Battle();
            battle2.BattleStart(currentPlayer, skeloton);

            //Third scene
            Console.WriteLine("Zorlu bir mücadeleden sonra iskeleti de alt etmeyi başardın.");
            Console.WriteLine("Artık kulenin son katındaki hazineyle aranda duran şey büyücüden başka biri değildi.");
            Console.WriteLine("Üçüncü katın kapısının önüne geldiğinde içeride öfkeden delirmiş büyücünün kahkahalarını duyuyordun.");
            Console.WriteLine("\n\nDevam etmek için Enter Tuşuna Basınız...");
            Console.ReadKey();
            Console.Clear();

            //Boss Battle
            Wizard wizard = new Wizard();
            Console.WriteLine("Kulenin içinde sana saldırmaya hazır bir düşmanın varlığını fark ettin.");
            Battle battle3 = new Battle();
            battle3.BattleStart(currentPlayer, wizard);

            //Ending Screen
            Console.WriteLine("Büyücüyü alt ettikten sonra onun önündeki sandıkta sakladığı  bahsettikleri değerli hazineyi buldun.");
            Console.WriteLine("Sandığı açtığında karşına çıkan şey anlamsız kelimelerle dolu bir kitaptan başka bir şey değildi.");
            Console.WriteLine("Bunca uğraşı ve fedakarlığın sonucunda meşhur hazinenin sadece bir kitap olduğunu öğrenmek seni öfkelendirdi");
            Console.WriteLine("Kitabı oradan bırakıp bir daha dönmemek üzere kuleden ayrıldın.");
            Console.WriteLine("SON.");
            Console.ReadKey();



        }
    }
}
