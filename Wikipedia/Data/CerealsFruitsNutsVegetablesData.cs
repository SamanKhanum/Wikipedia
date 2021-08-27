using System.Collections.Generic;

namespace Wikipedia.Data
{
    public static class Cereals_Fruits_Nuts_VegetablesData
    {
        public static IList<Plant> Cereals { get; private set; }

        static Cereals_Fruits_Nuts_VegetablesData()
        {
            Cereals = new List<Plant>();

            Cereals.Add(new Plant
            {
                Name = "Peanut",
                Details = "Peanut, (Arachis hypogaea), also called groundnut, earthnut, or goober, legume of the pea family (Fabaceae), grown for its edible seeds. Native to tropical South America, the peanut was at an early time introduced to the Old World tropics. The seeds are a nutritionally dense food, rich in protein and fat. Despite its several common names, the peanut is not a true nut. As with other legumes, the plant adds nitrogen to the soil by means of nitrogen-fixing bacteria and is thus particularly valuable as a soil-enriching crop.",
                Image = "Peanut"

            });


            Cereals.Add(new Plant
            {
                Name = "Avocado",
                Details = "Avocado, also called alligator pear, fruit of Persea americana of the family Lauraceae, a tree native to the Western Hemisphere from Mexico south to the Andean regions. Avocado fruits have greenish or yellowish flesh with a buttery consistency and a rich, nutty flavour. They are often eaten in salads, and in many parts of the world they are eaten as a dessert. Mashed avocado is the principal ingredient of guacamole, a characteristic sauce in Mexican cuisine. Avocados provide thiamin, riboflavin, and vitamin A, and in some varieties the flesh contains as much as 25 percent unsaturated oil.",
                Image = "Avocado"
            });
            Cereals.Add(new Plant
            {
                Name = "Tomato",
                Details = "Tomato, (Solanum lycopersicum), flowering plant of the nightshade family (Solanaceae), cultivated extensively for its edible fruits. Labelled as a vegetable for nutritional purposes, tomatoes are a good source of vitamin C and the phytochemical lycopene. The fruits are commonly eaten raw in salads, served as a cooked vegetable, used as an ingredient of various prepared dishes, and pickled. Additionally, a large percentage of the world’s tomato crop is used for processing; products include canned tomatoes, tomato juice, ketchup, puree, paste, and “sun-dried” tomatoes or dehydrated pulp.",
                Image = "tomato"
            });
            Cereals.Add(new Plant
            {
                Name = "Eggplant",
                Details = "Eggplant, (Solanum melongena), also called aubergine or Guinea squash, tender perennial plant of the nightshade family (Solanaceae), grown for its edible fruits. Eggplant requires a warm climate and has been cultivated in its native Southeast Asia since remote antiquity. A staple in cuisines of the Mediterranean region, eggplant figures prominently in such classic dishes as the Greek moussaka, the Italian eggplant parmigiana, and the Middle Eastern relish baba ghanoush. It is also frequently served as a baked, grilled, fried, or boiled vegetable and is used as a garnish and in stews. The plant is closely related to the tomato (Solanum lycopersicum) and the potato (S. tuberosum) as well as to several poisonous nightshades",
                Image = "Eggplant"
            });
            Cereals.Add(new Plant
            {
                Name = "Carrot",
                Details = "Carrot, (Daucus carota), herbaceous, generally biennial plant of the Apiaceae family that produces an edible taproot. Among common varieties root shapes range from globular to long, with lower ends blunt to pointed. Besides the orange-coloured roots, white-, yellow-, and purple-fleshed varieties are known.",
                Image = "Carrot"
            });
            Cereals.Add(new Plant
            {
                Name = "Barley",
                Details = "Barley, (Hordeum vulgare), cereal plant of the grass family Poaceae and its edible grain. Grown in a variety of environments, barley is the fourth largest grain crop globally, after wheat, rice, and corn. Barley is commonly used in breads, soups, stews, and health products, though it is primarily grown as animal fodder and as a source of malt for alcoholic beverages, especially beer.",
                Image = "Barley"
            });
        }
    }
}
