using StarWarsApi.ErrorHandler;
using System.Linq;
using System.Web.Http;

namespace StarWarsApi.Controllers
{
    public class PlanetController : ApiController
    {
        (int id, string name)[] planets = {
            (1, "Tatooine"),
            (2, "Alderaan"),
            (3, "Yavin IV"),
            (4, "Hoth"),
            (5, "Dagobah"),
            (6, "Bespin"),
            (7, "Endor"),
            (8, "Naboo"),
            (9, "Coruscant"),
            (10, "Kamino"),
            (11, "Geonosis"),
            (12, "Utapau"),
            (13, "Mustafar"),
            (14, "Kashyyyk"),
            (15, "Polis Massa"),
            (16, "Mygeeto"),
            (17, "Felucia"),
            (18, "Cato Neimoidia"),
            (19, "Saleucami"),
            (20, "Stewjon"),
            (21, "Eriadu"),
            (21, "Corellia"),
            (23, "Rodia"),
            (24, "Nal Hutta"),
            (25, "Dantooine"),
            (26, "Bestine IV"),
            (27, "Ord Mantell"),
            (28, "unknown"),
            (29, "Trandosha"),
            (30, "Socorro"),
            (31, "Mon Cala"),
            (32, "Chandrila"),
            (33, "Sullust"),
            (34, "Toydaria"),
            (35, "Malastare"),
            (36, "Dathomir"),
            (37, "Ryloth"),
            (38, "Aleen Minor"),
            (39, "Vulpter"),
            (40, "Troiken"),
            (41, "Tund"),
            (42, "Haruun Kal"),
            (43, "Cerea"),
            (44, "Glee Anselm"),
            (45, "Iridonia"),
            (46, "Tholoth"),
            (47, "Iktotch"),
            (48, "Quermia"),
            (49, "Dorin"),
            (50, "Champala"),
            (51, "Mirial"),
            (52, "Serenno"),
            (53, "Concord Dawn"),
            (54, "Zolan"),
            (55, "Ojom"),
            (56, "Skako"),
            (57, "Muunilinst"),
            (58, "Shili"),
            (59, "Kalee"),
            (60, "Umbara"),
            (61, "Jakku"),
            (101, "Vallt"),
            (102, "Fest"),
            (103, "Onderon"),
            (104, "Jedha"),
            (105, "Grange"),
            (106, "Aria Prime"),
            (107, "Lexrul"),
            (108, "Arkanis")
        };

        [HttpGet]
        public (int id, string title)[] Get()
        {
            return planets;
        }

        [HttpGet]
        public (int id, string title) Get(int id)
        {
            return planets.Where(f => f.id == id).Single();
        }
    }
}