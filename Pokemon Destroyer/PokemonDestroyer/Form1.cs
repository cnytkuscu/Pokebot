using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace PokemonDestroyer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        string pokemonName = "";       
        FirefoxDriver driver = new FirefoxDriver();
        IWebElement webElement;
        WebDriverWait wait = null;
        config cfg = new config();
        



        bool keepRolling = true;
        int direction = -1; // -1 herhangi bir yön değil. 0 yukarı , 1 sağ , 2 asagi , 3 sol
        string pokemonFullname = "";

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = false; // Aramaya bastığımda tekrarda arama yapamamak için bunu engelliyorum.   
            driver.Navigate().GoToUrl(cfg.map_link);

            while (keepRolling)
            {
                System.Threading.Thread.Sleep(rnd.Next(350, 550));
                direction = rnd.Next(1, 9); // yötü belirledim

                switch (direction)
                {
                    case 1:
                        {
                            try
                            {
                                driver.FindElement(By.XPath(config.up)).Click();
                                getPokemonName();
                            }
                            catch (Exception)
                            {
                                //System.Threading.Thread.Sleep(6000); // Büyük ihtimalle başka haritaya geçti. Bu yüzden bekletiyorum.
                                webElement = wait.Until(d => driver.FindElement(By.XPath(config.up)));
                                keepRolling = false;
                            }
                        }
                        break;
                    case 2:
                        {
                            try
                            {
                                driver.FindElement(By.XPath(config.rightUp)).Click();
                                getPokemonName();
                            }
                            catch (Exception)
                            {
                                //System.Threading.Thread.Sleep(6000); // Büyük ihtimalle başka haritaya geçti. Bu yüzden bekletiyorum.
                                webElement = wait.Until(d => driver.FindElement(By.XPath(config.up)));
                                keepRolling = false;
                            }
                        }
                        break;
                    case 3:
                        {
                            try
                            {
                                driver.FindElement(By.XPath(config.right)).Click();
                                getPokemonName();
                            }
                            catch (Exception)
                            {
                                //System.Threading.Thread.Sleep(6000); // Büyük ihtimalle başka haritaya geçti. Bu yüzden bekletiyorum.

                                webElement = wait.Until(d => driver.FindElement(By.XPath(config.up)));
                                keepRolling = false;
                            }
                        }
                        break;
                    case 4:
                        {
                            try
                            {
                                driver.FindElement(By.XPath(config.rightDown)).Click();
                                getPokemonName();
                            }
                            catch (Exception)
                            {
                                //System.Threading.Thread.Sleep(6000); // Büyük ihtimalle başka haritaya geçti. Bu yüzden bekletiyorum.

                                webElement = wait.Until(d => driver.FindElement(By.XPath(config.up)));
                                keepRolling = false;
                            }
                        }
                        break;
                    case 5:
                        {
                            try
                            {
                                driver.FindElement(By.XPath(config.down)).Click();
                                getPokemonName();
                            }
                            catch (Exception)
                            {
                                //System.Threading.Thread.Sleep(6000); // Büyük ihtimalle başka haritaya geçti. Bu yüzden bekletiyorum.
                                webElement = wait.Until(d => driver.FindElement(By.XPath(config.up)));
                                keepRolling = false;
                            }
                        }
                        break;
                    case 6:
                        {
                            try
                            {
                                driver.FindElement(By.XPath(config.leftDown)).Click();
                                getPokemonName();
                            }
                            catch (Exception)
                            {
                                //System.Threading.Thread.Sleep(6000); // Büyük ihtimalle başka haritaya geçti. Bu yüzden bekletiyorum.
                                webElement = wait.Until(d => driver.FindElement(By.XPath(config.up)));
                                keepRolling = false;
                            }
                        }
                        break;
                    case 7:
                        {
                            try
                            {
                                driver.FindElement(By.XPath(config.left)).Click();
                                getPokemonName();
                            }
                            catch (Exception)
                            {
                                //System.Threading.Thread.Sleep(6000); // Büyük ihtimalle başka haritaya geçti. Bu yüzden bekletiyorum.
                                webElement = wait.Until(d => driver.FindElement(By.XPath(config.up)));
                                keepRolling = false;
                            }
                        }
                        break;
                    case 8:
                        {
                            try
                            {
                                driver.FindElement(By.XPath(config.leftUp)).Click();
                                getPokemonName();
                            }
                            catch (Exception)
                            {
                                //System.Threading.Thread.Sleep(6000); // Büyük ihtimalle başka haritaya geçti. Bu yüzden bekletiyorum.
                                webElement = wait.Until(d => driver.FindElement(By.XPath(config.up)));
                                keepRolling = false;
                            }
                        }
                        break;

                    default:
                        {
                            MessageBox.Show("Hareket fonksiyonunda hata oluştu !");
                        }
                        break;
                }

            }
            if (!keepRolling)
            {
                MessageBox.Show("Aradigin Pokemonu Buldun. Gel ve yakala.");
                button2.Enabled = true;
            }
        }

        private void loginToPokemon()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));

            driver.Navigate().GoToUrl(cfg.login_page);
            driver.FindElement(By.ClassName("login-header")).Click(); // Login Butonuna Tıkladım.
            driver.FindElement(By.Name("myusername")).SendKeys(cfg.username); // Username Yazdim.
            driver.FindElement(By.Name("mypassword")).SendKeys(cfg.password); // şifre girdim
            driver.FindElement(By.Name("submit")).Click(); // oyuna girdim.           
            //driver.FindElement(By.Name("mapsTab")).Click();
            //driver.Navigate().GoToUrl(cfg.map_link);
        }

        void getPokemonName()
        {            
            try
            {                           
                if (driver.FindElement(By.XPath("//*[@id='pkmnappear']/b")).Text == "No wild Pokémon appeared")
                {                    
                    // eğer pokemon bulamazsa direk devam edecek.Ancak pokemon bulursa o zaman hata vereceği için catch'e girecek.
                }
            }
            catch (Exception)
            {                
                try
                {
                    System.Threading.Thread.Sleep(200);
                    // webElement = wait.Until(d => driver.FindElement(By.XPath("//*[@id='pkmnappear']/form/center/p")));

                    pokemonName = driver.FindElement(By.XPath("//*[@id='pkmnappear']/form/center/p")).Text;
                    pokemonName = getBetween(pokemonName, " ", " appeared.");
                    pokemonFullname = pokemonName; // İleride karşılaştırma yapmak için full adı türü lazım.

                    pokemonName = pokemonName.Replace("Shiny ", "");
                    pokemonName = pokemonName.Replace("Shadow ", "");
                    pokemonName = pokemonName.Replace("Dark ", "");
                    pokemonName = pokemonName.Replace("Metallic ", "");
                    pokemonName = pokemonName.Replace("Mystic ", "");

                    if (cfg.selected_poke.Contains(pokemonName))
                    {
                        if(cbNormal.Checked)
                        {
                            if(pokemonFullname == ""+pokemonName) // Eğer pokemon türü normalse
                            {
                                webElement = wait.Until(d => driver.FindElement(By.XPath("//*[@id='pkmnappear']/form/p/input[2]")));
                                driver.FindElement(By.XPath("//*[@id='pkmnappear']/form/p/input[2]")).Click();
                                keepRolling = false; // Pokemon Yakalandı.
                            }
                        }
                        if(cbDark.Checked)
                        {
                            if (pokemonFullname == "Dark " + pokemonName) // Eğer pokemon türü normalse
                            {
                                webElement = wait.Until(d => driver.FindElement(By.XPath("//*[@id='pkmnappear']/form/p/input[2]")));
                                driver.FindElement(By.XPath("//*[@id='pkmnappear']/form/p/input[2]")).Click();
                                keepRolling = false; // Pokemon Yakalandı.
                            }
                        }
                        if (cbMetallic.Checked)
                        {
                            if (pokemonFullname == "Metallic " + pokemonName) // Eğer pokemon türü normalse
                            {
                                webElement = wait.Until(d => driver.FindElement(By.XPath("//*[@id='pkmnappear']/form/p/input[2]")));
                                driver.FindElement(By.XPath("//*[@id='pkmnappear']/form/p/input[2]")).Click();
                                keepRolling = false; // Pokemon Yakalandı.
                            }
                        }
                        if (cbMystic.Checked)
                        {
                            if (pokemonFullname == "Mystic " + pokemonName) // Eğer pokemon türü normalse
                            {
                                webElement = wait.Until(d => driver.FindElement(By.XPath("//*[@id='pkmnappear']/form/p/input[2]")));
                                driver.FindElement(By.XPath("//*[@id='pkmnappear']/form/p/input[2]")).Click();
                                keepRolling = false; // Pokemon Yakalandı.
                            }
                        }
                        if (cbShadow.Checked)
                        {
                            if (pokemonFullname == "Shadow " + pokemonName) // Eğer pokemon türü normalse
                            {
                                webElement = wait.Until(d => driver.FindElement(By.XPath("//*[@id='pkmnappear']/form/p/input[2]")));
                                driver.FindElement(By.XPath("//*[@id='pkmnappear']/form/p/input[2]")).Click();
                                keepRolling = false; // Pokemon Yakalandı.
                            }
                        }
                         if (cbShiny.Checked)
                        {
                            if (pokemonFullname == "Shiny " + pokemonName) // Eğer pokemon türü normalse
                            {
                                webElement = wait.Until(d => driver.FindElement(By.XPath("//*[@id='pkmnappear']/form/p/input[2]")));
                                driver.FindElement(By.XPath("//*[@id='pkmnappear']/form/p/input[2]")).Click();
                                keepRolling = false; // Pokemon Yakalandı.
                            }
                        }                        
                    }
                }
                catch (Exception)
                {
                    //MessageBox.Show("HATA");

                }
            }
        }

        public static string getBetween(string strSource, string strStart, string strEnd)
        {
            int Start, End;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            else
            {
                return "";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            #region Seçilecek Pokemon Türleri
            cbNormal.Checked = true;
            cbDark.Checked = true;
            cbMetallic.Checked = true;
            cbMystic.Checked = true;
            cbShadow.Checked = true;
            cbShiny.Checked = true;
            #endregion

            button2.Enabled = false;
            loginToPokemon();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            keepRolling = true;
            button1.PerformClick();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        cfg.map_link = "https://pokemon-vortex.com/map/" + rnd.Next(24, 26);
                        cfg.selected_poke = cfg.ghost_poke;
                        break;
                    } // Ghost Map
                case 1:
                    {
                        cfg.map_link = "https://pokemon-vortex.com/map/"+ rnd.Next(1, 10);
                        cfg.selected_poke = cfg.grass_poke;
                        break;
                    } //Grass Map
                case 2:
                    {
                        cfg.map_link = "https://pokemon-vortex.com/map/" + rnd.Next(10, 16);
                        cfg.selected_poke = cfg.cave_poke;
                        break;
                    } //cave map
                case 3:
                    {
                        cfg.map_link = "https://pokemon-vortex.com/map/" + rnd.Next(16, 18);
                        cfg.selected_poke = cfg.electric_poke;
                        break;
                    } //electric map
                case 4:
                    {
                        cfg.map_link = "https://pokemon-vortex.com/map/" + rnd.Next(18, 22);
                        cfg.selected_poke = cfg.fire_poke;
                        break;
                    } //fire map
                case 5:
                    {
                        cfg.map_link = "https://pokemon-vortex.com/map/" + rnd.Next(22, 24);
                        cfg.selected_poke = cfg.ice_poke;
                        break;
                    } //ice map
                default:
                    break;
            }
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            driver.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                driver.FindElement(By.XPath(config.up)).Click();
                webElement = wait.Until(d => driver.FindElement(By.XPath(config.up)));
                MessageBox.Show("naber");


            }
            catch (Exception)
            {
                MessageBox.Show("Giderken hata oldu");
            }
        }

        
    }
}
