using System;
using System.Collections.Generic;
using System.Text;

namespace Wikipedia.Data
{
    class Ferns_OtherLowerVascularPlantsData
    {
        public static IList<Plant> ferns { get; set; }

        static Ferns_OtherLowerVascularPlantsData()
        {
            ferns = new List<Plant>();

            ferns.Add(new Plant
            {
                Name = "Club Moss",
                Details = "Club moss, (family Lycopodiaceae), also called ground pine, order of a single family (Lycopodiaceae), comprising some 400 species of seedless vascular plants. The taxonomy of the family has been contentious, with the number of genera varying depending on the source. The plants are mainly native to tropical mountains but are also common in northern forests of both hemispheres. See also lycophyte and lower vascular plant.",
                Image = "Clubmoss"
            });
            ferns.Add(new Plant
            {
                Name = "Fern",
                Details = "Fern, (class Polypodiopsida), class of nonflowering vascular plants that possess true roots, stems, and complex leaves and that reproduce by spores. The number of known extant fern species is about 10,500, but estimates have ranged as high as 15,000, the number varying because certain groups are as yet poorly studied and because new species are still being found in unexplored tropical areas. The ferns constitute an ancient division of vascular plants, some of them as old as the Carboniferous Period (beginning about 358.9 million years ago) and perhaps older. Their type of life cycle, dependent upon spores for dispersal, long preceded the seed-plant life cycle. Another informal name for the group, monilophytes, has gained currency in modern botanical literature.",
                Image = "fern"
            });
            ferns.Add(new Plant
            {
                Name = "Bracken",
                Details = "Bracken, (Pteridium aquilinum), also called brake or bracken fern, widely distributed fern (family Dennstaedtiaceae), found throughout the world in temperate and tropical regions. The fronds are used as thatching for houses and as fodder and are cooked as vegetables or in soups in some parts of Asia. However, the leaves of bracken contain an array of poisonous and carcinogenic compounds and may be harmful to consume.",
                Image = "Bracken"
            });
            ferns.Add(new Plant
            {
                Name = "Tree Fern",
                Details = "Tree fern, any of a group of relatively primitive ferns in the order Cyatheales, most of them characterized by ascending trunklike stems and an arborescent (treelike) habit. Tree ferns are conspicuous plants of humid tropical forests around the world. Species found at lower elevations are often widespread colonizers of disturbed or successional habitats. A large number of species are restricted to very small ranges on islands or at higher elevations, often in more-mature forests on isolated tropical mountaintops.",
                Image = "Treefern"
            });
            ferns.Add(new Plant
            {
                Name = "Lady Fern",
                Details = "Lady fern, (Athyrium filix-femina), a large, feathery fern (family Athyriaceae) widely cultivated for ornamentation. Lady ferns occur in moist semi-shaded areas in the temperate zones of the world. There are numerous cultivars, and the taxonomy is sometimes divided into three species: common lady fern (Athyrium filix-femina), narrow lady fern (A. angustum), and southern lady fern (A. asplenioides).",
                Image = "Ladyfern"
            });
            ferns.Add(new Plant
            {
                Name = "Lower Vascular Plant",
                Details = "Lower vascular plant, formerly pteridophyte, also called vascular cryptogam, any of the spore-bearing vascular plants, including the ferns, club mosses, spike mosses, quillworts, horsetails, and whisk ferns. Once considered of the same evolutionary line, these plants were formerly placed in the single group Pteridophyta and were known as the ferns and fern allies. Although modern studies have shown that the plants are not in fact related, these terms are still used in discussion of the lower vascular plants. The Pteridophyte Phylogeny Group (PPG I) recognizes two unrelated classes of extant lower vascular plants: Polypodiopsida, the ferns and horsetails, and Lycopodiopsida, the lycophytes.",
                Image = "lowerVascularPlant"
            });
        }
    }
}