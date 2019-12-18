using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDestroyer
{
    class config
    {
        public string map_link = "";
        public string login_page = "https://www.pokemon-vortex.com/";
        public string username = "siyahcay";
        public string password = "26791982486";
        public string pokeName = "";
        public List<string> selected_poke = new List<string>();

        public List<string> ghost_poke = new List<string>()
        {
            "Baltoy",
            "Sandile",
            "Porygon",
            "Rotom",
            "Malamar",
            "Venomoth",
            "Haunter",
            "Dusclops",
            "Mimikyu",


            "Azelf",
            "Celebi",
            "Darkrai",
            "Darkrown",
            "Mesprit",
            "Mew",
            "Tapu Lele",
            "Uxie",
            "Yveltal",
            "Guzzlord",
            "Necrozma",
            "Poipole",
            "Giratina" };
        public List<string> grass_poke = new List<string>()
        {
            #region Rare Pokemon List
            /*
            "Mew",
            "Celebi",
            "Latias",
            "Shaymin",
            "Shaymin (Sky)",
            "Virizion",
            "Tornadus",
            "Xerneas (Active)",
            "Tapu Bulu",
            "Latios",
            "Rayquaza",
            "Uxie",
            "Mesprit",
            "Azelf",
            "Cresselia",
            "Genesect",
            "Yveltal",
            "Buzzwole",
            "Pheromosa",
            "Kartana",
            "Pheromosa",
            "Suicune",
            "Phione",
            "Manaphy",
            "Keldeo",
            "Tapu Fini",
            "Pheromosa",
            "Celesteela",
            "Vaporeon"
            */
            #endregion

            "Aipom",
            "Audino",
            "Beedrill",
            "Bellsprout",
            "Bidoof",
            "Blitzle",
            "Bouffalant",
            "Bounsweet",
            "Budew",
            "Bulbasaur",
            "Buneary",
            "Bunnelby",
            "Burmy (Plant)",
            "Burmy (Steel)",
            "Butterfree",
            "Castform",
            "Caterpie",
            "Chatot",
            "Cherubi",
            "Chespin",
            "Chikorita",
            "Combee",
            "Comfey",
            "Cottonee",
            "Cutiefly",
            "Dedenne",
            "Doduo",
            "Drilbur",
            "Dunsparce",
            "Eevee",
            "Ekans",
            "Espurr",
            "Exeggcute",
            "Farfetchd",
            "Ferroseed",
            "Flabebe (Blue)",
            "Flabebe (Orange)",
            "Flabebe (Red)",
            "Flabebe (White)",
            "Flabebe (Yellow)",
            "Fletchinder",
            "Fletchling",
            "Foongus",
            "Furfrou",
            "Girafarig",
            "Glameow",
            "Goomy",
            "Grubbin",
            "Happiny",
            "Hawlucha",
            "Heracross",
            "Herdier",
            "Hoppip",
            "Igglybuff",
            "Inkay",
            "Karrablast",
            "Kecleon",
            "Klefki",
            "Komala",
            "Kricketot",
            "Leafeon",
            "Ledyba",
            "Lickitung",
            "Lillipup",
            "Litleo",
            "Lopunny",
            "Lotad",
            "Mankey",
            "Maractus",
            "Meowth",
            "Miltank",
            "Minccino",
            "Mudbray",
            "Munchlax",
            "Nidoran (F)",
            "Nincada",
            "Oddish",
            "Pancham",
            "Pansage",
            "Patrat",
            "Petilil",
            "Phanpy",
            "Pidgeotto",
            "Pidgey",
            "Pidove",
            "Pikipek",
            "Pineco",
            "Plusle",
            "Ponyta",
            "Raticate",
            "Rattata",
            "Rufflet",
            "Scatterbug",
            "Scyther",
            "Sentret",
            "Seviper",
            "Sewaddle",
            "Shelmet",
            "Shroomish",
            "Skarmory",
            "Skiddo",
            "Skitty",
            "Slakoth",
            "Smeargle",
            "Snivy",
            "Snubbull",
            "Spewpa",
            "Spinda",
            "Spritzee",
            "Stantler",
            "Starly",
            "Sunkern",
            "Swablu",
            "Swirlix",
            "Taillow",
            "Tauros",
            "Togepi",
            "Tranquill",
            "Treecko",
            "Tropius",
            "Turtwig",
            "Tyrogue",
            "Volbeat",
            "Weepinbell",
            "Whismur",
            "Wurmple",
            "Yanma",
            "Yungoos",
            "Zangoose"
        };
        public List<string> cave_poke = new List<string>()
        {
            #region Legendary Pokemonlar Burada
            /*
            "Arceus",
            "Coballion",
            "Deoxys",
            "Dialga",
            "Diancie",
            "Groudon",
            "Jirachi",
            "Kyurem",
            "Landorus",
            "Mewtwo",
            "Palkia",
            "Regigigas",
            "Regirock",
            "Registeel",
            "Reshiram",
            "Terrakion",
            "Virizion",
            "Zekrom" ,
            "Zygarde",
            "Kartana",
            "Nihilego",
            "Stakataka",
            "Kyogre",
            "Lugia"
            */
            #endregion

            "Sandshrew",
            "Onix",
            "Unown (B)",
            "Unown (H)",
            "Gligar",
            "Mawile",
            "Gible",
            "Sawk",
            "Druddigon",
            "Helioptile",
            "Minior (Core)",
            "Dugtrio",
            "Lairon",
            "Boldore",
            "Zweilous",
            "Zubat",
            "Cubone",
            "Unown (C)",
            "Unown (I)",
            "Shuckle",
            "Aron",
            "Hippopotas",
            "Sandile",
            "Golett",
            "Carbink",
            "Minior (Meteor)",
            "Machoke",
            "Vibrava",
            "Excadrill",
            "Barbaracle",
            "Paras",
            "Rhyhorn",
            "Unown (D)",
            "Unown (J)",
            "Teddiursa",
            "Trapinch",
            "Roggenrola",
            "Dwebble",
            "Pawniard",
            "Noibat",
            "Drampa",
            "Graveler",
            "Bagon",
            "Gurdurr",
            "Heliolisk",
            "Diglett",
            "Kangaskhan",
            "Unown (E)",
            "Unown (K)",
            "Phanpy",
            "Beldum",
            "Drilbur",
            "Scraggy",
            "Durant",
            "Ditto",
            "Metang",
            "Ferrothorn",
            "Noivern"

        };
        public List<string> electric_poke = new List<string>()
        {
            "Pidgey",
            "Starly",
            "Muk",

            "Jirachi",
            "Darkrown",
            "Darkrai",
            "Genesect",
            "Raikou",
            "Tapu Koko",
            "Thundurus",
            "Zapdos",
            "Zekrom",
            "Celesteela",
            "Xurkitree"};
        public List<string> fire_poke = new List<string>()
        {
            "Charmander",
            "Flareon",
            "Houndoom",

            "Entei",
            "Heatran",
            "Ho-Oh",
            "Moltres",
            "Reshiram",
            "Victini",
            "Blacephalon",
            "Xurkitree"};
        public List<string> ice_poke = new List<string>()
        {
            "Glaceon",


            "Articuno",
            "Suicune",
            "Lugia",
            "Regice",
            "Kyurem",
            "Diancie",
            "Type-Null",
            "Buzzwole",
            "Guzzlord"};

        #region Directions
        public static string up = "html/body/div[5]/div/div/div[1]/div/div[1]/table/tbody/tr[1]/td[2]";
        public static string rightUp = "html/body/div[5]/div/div/div[1]/div/div[1]/table/tbody/tr[1]/td[3]";
        public static string right = "html/body/div[5]/div/div/div[1]/div/div[1]/table/tbody/tr[2]/td[3]";
        public static string rightDown = "html/body/div[5]/div/div/div[1]/div/div[1]/table/tbody/tr[3]/td[3]";
        public static string down = "html/body/div[5]/div/div/div[1]/div/div[1]/table/tbody/tr[3]/td[2]";
        public static string leftDown = "html/body/div[5]/div/div/div[1]/div/div[1]/table/tbody/tr[3]/td[1]";
        public static string left = "html/body/div[5]/div/div/div[1]/div/div[1]/table/tbody/tr[2]/td[1]";
        public static string leftUp = "html/body/div[5]/div/div/div[1]/div/div[1]/table/tbody/tr[1]/td[1]";

        #endregion



    }
}
