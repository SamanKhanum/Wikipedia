using System;
using System.Collections.Generic;
using System.Text;

namespace Wikipedia.Data
{
    class FloweringPlantsData
    {

        public static IList<Plant> flower { get; set; }

        static FloweringPlantsData()
        {
            flower = new List<Plant>();

            flower.Add(new Plant
            {
                Name = "Pitcher Plant",
                Details = "Pitcher plant, any carnivorous plant with pitcher-shaped leaves that form a passive pitfall trap. Old World pitcher plants are members of the family Nepenthaceae (order Caryophyllales), while those of the New World belong to the family Sarraceniaceae (order Ericales). The Western Australian pitcher plant (Cephalotus follicularis) is the only species of the family Cephalotaceae (order Oxalidales). Pitcher plants are found in a wide range of habitats with poor soil conditions, from pine barrens to sandy coastal swamps, and rely on carnivory to obtain nutrients such as nitrogen and phosphorus.",
                Image = "pitcherplant"
            });
            flower.Add(new Plant
            {
                Name = "Burning Bush",
                Details = "Burning bush, any of several plants so called for their striking fall foliage, brilliant flower display, or emission of a volatile flammable vapour. Many are cultivated as garden ornamentals. One of the most popular burning bushes planted for fall colour is Euonymus atropurpureus, also called wahoo.",
                Image = "burningbush"
            });
            flower.Add(new Plant
            {
                Name = "Monocotyledon",
                Details = "Monocotyledon, byname monocot, one of the two great groups of flowering plants, or angiosperms, the other being the eudicotyledons (eudicots). There are approximately 60,000 species of monocots, including the most economically important of all plant families, Poaceae (true grasses), and the largest of all plant families, Orchidaceae (orchids). Other prominent monocot families include Liliaceae (lilies), Arecaceae (palms), and Iridaceae (irises). Most of them are distinguished by the presence of only one seed leaf, or cotyledon, in the embryo contained in the seed. Eudicotyledons, in contrast, ordinarily have two cotyledons.",
                Image = "monocotyledon"
            });
            flower.Add(new Plant
            {
                Name = "Dicotyledon",
                Details = "Dicotyledon, byname dicot, any member of the flowering plants, or angiosperms, that has a pair of leaves, or cotyledons, in the embryo of the seed. There are about 175,000 known species of dicots. Most common garden plants, shrubs and trees, and broad-leafed flowering plants such as magnolias, roses, geraniums, and hollyhocks are dicots.",
                Image = "dicotyledon"
            });
            flower.Add(new Plant
            {
                Name = "Angiosperm",
                Details = "Angiosperm, also called flowering plant, any of about 300,000 species of flowering plants, the largest and most diverse group within the kingdom Plantae. Angiosperms represent approximately 80 percent of all the known green plants now living. The angiosperms are vascular seed plants in which the ovule (egg) is fertilized and develops into a seed in an enclosed hollow ovary.",
                Image = "angiosperm"
            });
            flower.Add(new Plant
            {
                Name = "Wildflower",
                Details = "Wildflower, also spelled wild flower, any flowering plant that has not been genetically manipulated. Generally the term applies to plants growing without intentional human aid, particularly those flowering in spring and summer in woodlands, prairies, and mountains. Wildflowers are the source of all cultivated garden varieties of flowers. Although most wildflowers are native to the region in which they occur, some are the descendants of flowering plants introduced from other lands. The bright flowers characteristic of the Hawaiian Islands, for example, are nearly all native to other parts of the tropics and subtropics. Most were taken purposely to the islands for cultivation but spread rapidly into the fertile lowlands, displacing the less-colourful native species and leaving only the steep mountainsides to the original flora. In the lowlands of the United States and Europe most wildflower species are native; others are migrants",
                Image = "wildflower"
            });
        flower.Add(new Plant
            {
                Name = "Bloodroot",
                Details = "Bloodroot, (Sanguinaria canadensis), also called red puccoon, plant of the poppy family (Papaveraceae), native throughout eastern and midwestern North America. It grows in deciduous woodlands, where it blooms in early spring, and is sometimes cultivated as an ornamental. The orange-red sap of the rhizomes was formerly used by Native Americans for dye. The rhizomes also contain the medical alkaloid sanguinarine. Although the plant is considered toxic, overcollection for use as an herbal medicine and unfounded cancer treatment has depleted wild populations throughout much of its native range.",
                Image = "Bloodroot"
        });
        }
    }
}