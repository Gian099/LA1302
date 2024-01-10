using DnDRPG.Resources;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDRPG
{
    public class enemy
    {
        public int hp;
        public Image image;
        public List<string> attacks = new List<string>();
        public double damage;
        public int strength;
        public string enemyid;
        public enemy(string id,game g) 
        {
            g.enemies.Add(id);
            enemyid= id;
            switch (id)
            {
                case "goblin":
                    hp = 4;
                    strength = 2;
                    attacks.Add("knife_throw");
                    attacks.Add("punch");
                    image = new Bitmap(images.Goblin);
                    break;
                case "golem":
                    strength = 5;
                    hp = 15;
                    attacks.Add("punch");
                    attacks.Add("rock_throw");
                    image = new Bitmap(images.Golem);
                    break;
                case "dark_wizard":
                    strength = 5;
                    hp = 10;
                    attacks.Add("dark_spell");
                    attacks.Add("thunder_spell");
                    attacks.Add("fire_spell");
                    image = new Bitmap(images.darkmage);
                    break;
                case "dragon":
                    strength = 10;
                    hp = 25;
                    attacks.Add("fire_breath");
                    attacks.Add("thunder_spell");
                    attacks.Add("dark_spell");
                    image = new Bitmap(images.dragon);
                    break;
                case "wolf":
                    strength = 3;
                    hp = 4;
                    attacks.Add("bite");
                    image = new Bitmap(images.wolf);
                    break;
                case "demon":
                    strength = 7;
                    hp = 15;
                    attacks.Add("dark_spell");
                    image = new Bitmap(images.demon);
                    break;
                case "strongdemon":
                    strength = 16;
                    hp = 50;
                    attacks.Add("dark_spell");
                    image = new Bitmap(images.Goblin);
                    break;
                case "noah":
                    strength = 8;
                    hp = 20;
                    attacks.Add("dark_spell");
                    image = new Bitmap(images.Goblin);
                    attacks.Add("bite");
                    attacks.Add("rock_throw");
                    attacks.Add("fire_spell");
                    attacks.Add("thunder_spell");
                    attacks.Add("assembly");
                    attacks.Add("knife_throw");
                    break;
                case "slime":
                    strength = 1;
                    hp = 1;
                    attacks.Add("punch");
                    attacks.Add("evolve");
                    image = new Bitmap(images.slime);
                    break;
                case "bigslime":
                    strength = 3;
                    hp = 5;
                    attacks.Add("punch");
                    attacks.Add("rock_throw");
                    attacks.Add("superevolve");
                    image = new Bitmap(images.Goblin);
                    break;
                case "gigaslime":
                    strength = 9;
                    hp = 25;
                    attacks.Add("punch");
                    image = new Bitmap(images.Goblin);
                    break;
                case "steve":
                    strength = 12;
                    hp = 20;
                    attacks.Add("punch");
                    image = new Bitmap(images.Goblin);
                    break;
                default: break;
            }
        }
        public string Attackplayer()
        {
            Random rnd = new Random();
            int num1 = rnd.Next(0, attacks.Count);
            switch (attacks[num1])
            {
                case "punch":
                    damage = strength;
                    break;
                case "knife_throw":
                    damage = strength * 1.1;
                    break;
                case "rock_throw":
                    damage = strength * 1.5;
                    break;
                case "thunder_spell":
                    damage = strength * 1.5;
                    break;
                case "fire_spell":
                    damage = strength * 1.3;
                    break;
                case "dark_spell":
                    damage = strength * 2;
                    break;
                case "bite":
                    damage = strength * 0.8;
                    break;
                case "assembly":
                    damage = strength * 50;
                    break;
                case "evolve":
                    enemyid = "strongslime";
                    attacks.Clear();
                    strength = 3;
                    hp = 5;
                    attacks.Add("punch");
                    attacks.Add("rock_throw");
                    attacks.Add("superevolve");
                    break;
                case "superevolve":
                    enemyid = "gigaslime";
                    attacks.Clear();
                    strength = 9;
                    hp = 25;
                    attacks.Add("punch");
                    attacks.Add("rock_throw");
                    break;
                default: break;
            }
            return attacks[num1];
        }
        public double GetDamage()
        {
            return damage;
        }
    }
}
