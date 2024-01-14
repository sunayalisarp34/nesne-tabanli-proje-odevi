using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BuyucununKulesi
{
    //Base weapon interface
    public interface IWeapons
    {
        string Name { get; }
        int Damage { get; }

    }
    

    public class IronSword : IWeapons
    {
        public string Name { get; } = "Demir Kılıç";

        public int Damage { get; } = 10;
    }

    public class  Club: IWeapons
    {
        public string Name { get; } = "Sopa";

        public int Damage { get; } = 5;
    }

    public class RustySword: IWeapons 
    {
        public string Name { get; } = "Paslı Kılıç";
        public int Damage { get; } = 8;
    }

    public class Staff: IWeapons
    {
        public string Name { get; } = "Asa";
        public int Damage { get; } = 9;

    }
}
