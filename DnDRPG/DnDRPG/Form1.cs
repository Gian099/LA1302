using DnDRPG.Resources;
using System.Threading;
namespace DnDRPG
{
    public partial class Form1 : Form
    {
        
        enemy Enemy1;
        enemy Enemy2;
        enemy Enemy3;
        enemy Enemy4;
        int playerhp;
        int maxdamage;
        int heal;
        string playertype;
        game g = new();
        public Form1()
        {
            InitializeComponent();
            string[] playerimages = {"tank", "mage", "warrior", "healer"};
            Random random = new Random();
            if (playerimages[random.Next(0,playerimages.Length)] == "tank")
            {
                player.Image = new Bitmap(images.tank);
                playerhp = 400;
                maxdamage = 10;
                heal = 25;
                playertype = "tank";
            }
            else if (playerimages[random.Next(0, playerimages.Length)] == "mage")
            {
                player.Image = new Bitmap(images.mage);
                playerhp = 150;
                maxdamage = 20;
                heal = 45;
                playertype = "mage";
            }
            else if (playerimages[random.Next(0, playerimages.Length)] == "healer")
            {
                player.Image = new Bitmap(images.healer);
                playerhp = 150;
                maxdamage = 6;
                heal = 100;
                playertype = "healer";
            }
            else if (playerimages[random.Next(0, playerimages.Length)] == "warrior")
            {
                player.Image = new Bitmap(images.warrior);
                playerhp = 250;
                maxdamage = 30;
                heal = 15;
                playertype = "warrior";
            }
            spawnenemies();
            losingscreen.Hide();
            losingtext.Hide();
        }
        void spawnenemies()
        {
            enemy1dead = false;
            enemy2dead = false;
            enemy3dead = false;
            enemy4dead = false;
            enemy1.Show();
            enemy2.Show();
            enemy3.Show();
            enemy4.Show();
            enemyhealth1.Show();
            enemyhealth2.Show();
            enemyhealth3.Show();
            enemyhealth4.Show();
            enemycontext.Show();
            enemycontext2.Show();
            enemycontext3.Show();
            enemycontext4.Show();
            button1.Show();
            button2.Show();
            button3.Show();
            button4.Show();
            enemy1dead = false;
            enemy2dead = false;
            enemy3dead = false;
            enemy4dead = false;
            playerhealth.Text = Convert.ToString(playerhp);
            Random random = new Random();
            Random random2 = new Random();
            Random random3 = new Random();
            string[] enemies = { "goblin", "goblin", "goblin", "goblin", "goblin", "wolf", "wolf", "wolf", "wolf", "wolf", "golem", "golem", "golem", "golem", "dark_wizard", "dark_wizard", "dark_wizard", "dark_wizard", "demon", "demon", "demon", "demon", "dragon", "dragon", "dragon", "noah" };
            string[] texts = { " looks at pictures of his childhood", " runs around in circles", " is minding their own business", " enjoys life as it is", " peacefully sings a song", " plans to overthrow the government", " looks at noahs browser history", " plans to eradicate the human race", " is living in the moment", " thinks about the value of life", " thinks about the meaning of life", " strolls around peacefully", " is a convicted criminal", " thinks about his girlfriend", " is playing chess with the others", " likes minecraft", " calmly watches a youtube video", " wants to be your friend"};
            Enemy1 = new(enemies[random.Next(0, enemies.Length)], g);
            enemy1.Image = Enemy1.image;
            enemyhealth1.Text = Convert.ToString(Enemy1.hp);
            enemycontext.Text = Convert.ToString(Enemy1.enemyid + texts[random2.Next(0,texts.Length)]);

            Enemy2 = new(enemies[random.Next(0, enemies.Length)], g);
            enemy2.Image = Enemy2.image;
            enemyhealth2.Text = Convert.ToString(Enemy2.hp);
            enemycontext2.Text = Convert.ToString(Enemy2.enemyid + texts[random2.Next(0, texts.Length)]);

            Enemy3 = new(enemies[random.Next(0, enemies.Length)], g);
            enemy3.Image = Enemy3.image;
            enemyhealth3.Text = Convert.ToString(Enemy3.hp);
            enemycontext3.Text = Convert.ToString(Enemy3.enemyid + texts[random2.Next(0, texts.Length)]);

            Enemy4 = new(enemies[random.Next(0, enemies.Length)], g);
            enemy4.Image = Enemy4.image;
            enemyhealth4.Text = Convert.ToString(Enemy4.hp);
            enemycontext4.Text = Convert.ToString(Enemy4.enemyid + texts[random2.Next(0, texts.Length)]);

            context.Text = ("You are a " + playertype + ". Who will you attack?");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Enemy1.hp = Enemy1.hp - random.Next(0,maxdamage);
            enemyhealth1.Text = Convert.ToString(Enemy1.hp);
            if (Enemy1.hp <= 0)
            {
                
                context.Text = Enemy1.enemyid + " fucking dies.";
                enemycontext.Text = null;
                enemycontext.Hide();
                button1.Hide();
                enemyhealth1.Hide();
                enemykilled(enemy1);
            }
            else
            {
                context.Text = "You stab " + Enemy1.enemyid + ". He fears for his life.";
                enemyturn1(Enemy1);
                enemyturn2(Enemy2);
                enemyturn3(Enemy3);
                enemyturn4(Enemy4);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Enemy2.hp = Enemy2.hp - random.Next(0, maxdamage);
            if (Enemy2.hp <= 0)
            {
                
                context.Text = Enemy2.enemyid + " fucking dies";
                enemycontext2.Text = null;
                enemycontext2.Hide();
                button2.Hide();
                enemyhealth2.Hide();
                enemykilled(enemy2);
            }
            else
            {
                context.Text = "You stab " + Enemy2.enemyid + ". He fears for his life.";
                if (enemy1dead == false)
                {
                    enemyturn1(Enemy1);
                }
                if (enemy2dead == false)
                {
                    enemyturn2(Enemy2);
                }
                if (enemy3dead == false)
                {
                    enemyturn3(Enemy3);
                }
                if (enemy4dead == false)
                {
                    enemyturn4(Enemy4);
                }
            }
        }
        void enemyturn1(enemy enemy)
        {
            enemycontext.Text = enemy.enemyid + " uses " + enemy.Attackplayer();
            playerhp = playerhp - (int)enemy.GetDamage();
            playerhealth.Text = Convert.ToString(playerhp);
            if(playerhp <= 0)
            {
                losingscreen.Show();
                losingtext.Show();
            }
        }
        void enemyturn2(enemy enemy)
        {
            enemycontext2.Text = enemy.enemyid + " uses " + enemy.Attackplayer();
            playerhp = playerhp - (int)enemy.GetDamage();
            playerhealth.Text = Convert.ToString(playerhp);
            if (playerhp <= 0)
            {
                losingscreen.Show();
                losingtext.Show();
            }
        }
        void enemyturn3(enemy enemy)
        {
            enemycontext3.Text = enemy.enemyid + " uses " + enemy.Attackplayer();
            playerhp = playerhp - (int)enemy.GetDamage();
            playerhealth.Text = Convert.ToString(playerhp);
            if (playerhp <= 0)
            {
                losingscreen.Show();
                losingtext.Show();
            }
        }
        void enemyturn4(enemy enemy)
        {
            enemycontext4.Text = enemy.enemyid + " uses " + enemy.Attackplayer();
            playerhp = playerhp - (int)enemy.GetDamage();
            playerhealth.Text = Convert.ToString(playerhp);
            if (playerhp <= 0)
            {
                losingscreen.Show();
                losingtext.Show();
            }
        }
        bool enemy1dead = false;
        bool enemy2dead = false;
        bool enemy3dead = false;
        bool enemy4dead = false;
        void Nextstage()
        {
            enemy1dead = false;
            enemy2dead = false;
            enemy3dead = false;
            enemy4dead = false;
            enemy1.Show();
            enemy2.Show();
            enemy3.Show();
            enemy4.Show();
            enemyhealth1.Show();
            enemyhealth2.Show();
            enemyhealth3.Show();
            enemyhealth4.Show();
            enemycontext.Show();
            enemycontext2.Show();
            enemycontext3.Show();
            enemycontext4.Show();
            button1.Show();
            button2.Show();
            button3.Show();
            button4.Show();
            enemy1dead = false;
            enemy2dead = false;
            enemy3dead = false;
            enemy4dead = false;
            Bitmap[] backgrounds = { images.cave, images.hell, images.grass };
            Random rnd = new Random();
            Form.ActiveForm.BackgroundImage = new Bitmap(backgrounds[rnd.Next(0,backgrounds.Length)]);
            
            spawnenemies();
        }
        void enemykilled(PictureBox enemy)
        {
            playerhp = playerhp + heal;
            playerhealth.Text = Convert.ToString(playerhp);
            enemy.Hide();
            if(enemy == enemy1)
            {
                enemy1dead = true;
            }
            if (enemy == enemy2)
            {
                enemy2dead = true;
            }
            if (enemy == enemy3)
            {
                enemy3dead = true;
            }
            if (enemy == enemy4)
            {
                enemy4dead = true;
            }
            if(enemy1dead==true && enemy2dead==true && enemy3dead==true && enemy4dead == true)
            {
                Nextstage();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Random random = new Random();
            Enemy2.hp = Enemy2.hp - random.Next(0, maxdamage);
            enemyhealth2.Text = Convert.ToString(Enemy2.hp);
            if (Enemy2.hp <= 0)
            {
                
                context.Text = Enemy2.enemyid + " fucking dies";
                enemycontext2.Text = null;
                enemycontext2.Hide();
                button2.Hide();
                enemyhealth2.Hide();
                enemykilled(enemy2);
            }
            else
            {
                context.Text = "You stab " + Enemy2.enemyid + ". He fears for his life.";
                if (enemy1dead == false)
                {
                    enemyturn1(Enemy1);
                }
                if (enemy2dead == false)
                {
                    enemyturn2(Enemy2);
                }
                if (enemy3dead == false)
                {
                    enemyturn3(Enemy3);
                }
                if (enemy4dead == false)
                {
                    enemyturn4(Enemy4);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Enemy3.hp = Enemy3.hp - random.Next(0, maxdamage);
            enemyhealth3.Text = Convert.ToString(Enemy3.hp);
            if (Enemy3.hp <= 0)
            {
                enemykilled(enemy3);
                context.Text = Enemy3.enemyid + " dies";
                enemycontext3.Text = null;
                enemycontext3.Hide();
                button3.Hide();
                enemyhealth3.Hide();
            }
            else
            {
                context.Text = "You stab " + Enemy3.enemyid + ".";
                if(enemy1dead == false)
                {
                    enemyturn1(Enemy1);
                }
                if(enemy2dead == false)
                {
                    enemyturn2(Enemy2);
                }
                if(enemy3dead == false)
                {
                    enemyturn3(Enemy3);
                }
                if(enemy4dead == false)
                {
                    enemyturn4(Enemy4);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Enemy4.hp = Enemy4.hp - random.Next(0, maxdamage);
            enemyhealth4.Text = Convert.ToString(Enemy4.hp);
            if (Enemy4.hp <= 0)
            {
                context.Text = Enemy4.enemyid + " dies";
                enemycontext4.Text = null;
                enemycontext4.Hide();
                button4.Hide();
                enemyhealth4.Hide();
                enemykilled(enemy4);
            }
            else
            {
                context.Text = "You stab " + Enemy4.enemyid + ".";
                if (enemy1dead == false)
                {
                    enemyturn1(Enemy1);
                }
                if (enemy2dead == false)
                {
                    enemyturn2(Enemy2);
                }
                if (enemy3dead == false)
                {
                    enemyturn3(Enemy3);
                }
                if (enemy4dead == false)
                {
                    enemyturn4(Enemy4);
                }
            }
        }
    }
}