using StarWarsApi.ErrorHandler;
using System.Linq;
using System.Web.Http;

namespace StarWarsApi.Controllers
{
    [AiHandleError]
    public class CharacterController : ApiController
    {
        (int id, string name, int home, string allegiance)[] characters = {
            (1, "Luke Skywalker", 1, "jedi"),
            (2, "C-3PO", 1, "rebel"),
            (3, "R2-D2", 8, "rebel"),
            (4, "Darth Vader", 1, "sith"),
            (5, "Leia Organa", 2, "rebel"),
            (6, "Owen Lars", 1, string.Empty),
            (7, "Beru Whitesun lars", 1, string.Empty),
            (8, "R5-D4", 1, "rebel"),
            (9, "Biggs Darklighter", 1, "rebel"),
            (10, "Obi-Wan Kenobi", 20, "jedi"),
            (11, "Anakin Skywalker", 1, "jedi"),
            (12, "Wilhuff Tarkin", 21, "imperial"),
            (13, "Chewbacca", 14, "rebel"),
            (14, "Han Solo", 22, "rebel"),
            (15, "Greedo", 23, "bounty hunter"),
            (16, "Jabba Desilijic Tiure", 24, string.Empty),
            (17, "Wedge Antilles", 22, "rebel"),
            (18, "Jek Tono Porkins", 26, string.Empty),
            (19, "Yoda", 28, "jedi"),
            (20, "Palpatine", 8, "sith"),
            (21, "Boba Fett", 10, "bounty hunter"),
            (22, "IG-88", 28, "bounty hunter"),
            (23, "Bossk", 29, "bounty hunter"),
            (24, "Lando Calrissian", 30, "rebel"),
            (25, "Lobot", 6, string.Empty),
            (26, "Ackbar", 31, "rebel"),
            (27, "Mon Mothma", 32, "rebel"),
            (28, "Arvel Crynyd", 28, string.Empty),
            (29, "Wicket Systri Warrick", 7, "rebel"),
            (30, "Nien Nunb", 33, string.Empty),
            (31, "Qui-Gon Jinn", 28, "jedi"),
            (32, "Nute Gunray", 18, "rebel"),
            (33, "Finis Valorum", 9, string.Empty),
            (34, "Jar Jar Binks", 8, "rebel"),
            (35, "Roos Tarpals", 8, string.Empty),
            (36, "Rugor Nass", 8, string.Empty),
            (37, "Ric Olié", 8, string.Empty),
            (38, "Watto", 34, string.Empty),
            (39, "Sebulba", 35, string.Empty),
            (40, "Quarsh Panaka", 8, string.Empty),
            (41, "Shmi Skywalker", 1, string.Empty),
            (42, "Darth Maul", 36, "sith"),
            (43, "Bib Fortuna", 37, string.Empty),
            (44, "Ayla Secura", 37, "jedi"),
            (45, "Dud Bolt", 39, string.Empty),
            (46, "Gasgano", 40, string.Empty),
            (47, "Ben Quadinaros", 41, string.Empty),
            (48, "Mace Windu", 42, "jedi"),
            (49, "Ki-Adi-Mundi", 43, "jedi"),
            (50, "Kit Fisto", 44, "jedi"),
            (51, "Eeth Koth", 45, "jedi"),
            (52, "Adi Gallia", 9, string.Empty),
            (53, "Saesee Tiin", 47, string.Empty),
            (54, "Yarael Poof", 48, string.Empty),
            (55, "Plo Koon", 49, "jedi"),
            (56, "Mas Amedda", 50, string.Empty),
            (57, "Gregar Typho", 8, string.Empty),
            (58, "Cordé", 8, "rebel"),
            (59, "Cliegg Lars", 1, string.Empty),
            (60, "Poggle the Lesser", 11, string.Empty),
            (61, "Luminara Unduli", 51, "jedi"),
            (62, "Barriss Offee", 51, string.Empty),
            (63, "Dormé", 8, string.Empty),
            (64, "Dooku", 52, "sith"),
            (65, "Bail Prestor Organa", 2, "rebel"),
            (66, "Jango Fett", 53, "bounty hunter"),
            (67, "Zam Wesell", 54, "bounty hunter"),
            (68, "Dexter Jettster", 55, string.Empty),
            (69, "Lama Su", 10, string.Empty),
            (70, "Taun We", 10, string.Empty),
            (71, "Jocasta Nu", 9, string.Empty),
            (72, "Ratts Tyerell", 38, string.Empty),
            (73, "R4-P17", 28, string.Empty),
            (74, "Wat Tambor", 56, string.Empty),
            (75, "San Hill", 57, string.Empty),
            (76, "Shaak Ti", 58, "jedi"),
            (77, "Grievous", 59, "imperial"),
            (78, "Tarfful", 14, string.Empty),
            (79, "Raymus Antilles", 2, "rebel"),
            (80, "Sly Moore", 60, string.Empty),
            (81, "Tion Medon", 12, string.Empty),
            (82, "Finn", 28, "rebel"),
            (83, "Rey", 28, "jedi"),
            (84, "Poe Dameron", 28, "rebel"),
            (85, "BB8", 28, "rebel"),
            (86, "Captain Phasma", 28, "imperial"),
            (87, "Padmé Amidala", 8, "rebel"),
            (101, "K-2S0", 39, "rebel"),
            (102, "Jyn Erso", 101, "rebel"),
            (103, "Cassian Andor", 102, "rebel"),
            (104, "Saw Gererra", 103, "rebel"),
            (105, "Chirrut Îmwe", 104, "rebel"),
            (106, "Baze Malbus", 104, "rebel"),
            (107, "Bodhi Rook", 104, "rebel"),
            (108, "Galen Erso", 105, "rebel"),
            (109, "Lyra Erso", 106, "rebel"),
            (110, "Orson Krennic", 107, "imperial"),
            (111, "Kylo Ren", 32, "imperial"),
            (112, "Armitage Hux", 108, "imperial"),
            (113, "Snoke", 28, "imperial")
        };

        [HttpGet]
        public (int id, string name, int home, string allegiance)[] Get()
        {
            return characters;
        }

        [HttpGet]
        public (int id, string name, int home, string allegiance) Get(int id)
        {
            return characters.Where(f => f.id == id).Single();
        }
    }
}