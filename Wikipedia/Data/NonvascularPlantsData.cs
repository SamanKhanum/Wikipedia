using System;
using System.Collections.Generic;
using System.Text;

namespace Wikipedia.Data
{
    class NonvascularPlantsData
    {

        public static IList<Plant> nonvascular { get; set; }

        static NonvascularPlantsData()
        {
            nonvascular = new List<Plant>();

            nonvascular.Add(new Plant
            {
                Name = "Hornwort",
                Details = "Hornwort, (division Anthocerotophyta), also called horned liverwort, any of about 300 species of small nonvascular plants. Hornworts usually grow on damp soils or on rocks in tropical and warm temperate regions. The largest genus, Anthoceros, has a worldwide distribution. Dendroceros and Megaceros are mainly tropical genera. Hornworts have an ancient lineage and are thought to be some of the earliest plants to have evolved on land.",
                Image = "Hornwort"
            });
            nonvascular.Add(new Plant
            {
                Name = "Peat Moss",
                Details = "peat moss, also called bog moss or sphagnum moss, any of more than 150–300 species of plants in the subclass Sphagnidae, of the division Bryophyta, comprising the family Sphagnaceae, which contains one genus, Sphagnum. The taxonomy of Sphagnum species remains controversial, with various botanists accepting quite different numbers of species. The pale green to deep red plants, up to 30 cm (about 12 inches) tall, form dense clumps around ponds, in swamps and bogs, on moist, acid cliffs, and on lakeshores from tropical to subpolar regions. The veinless leaves and stem cortex contain many interconnected, enlarged dead cells, with external openings through which water can enter; the plants hold up to 20 times their weight in water.",
                Image = "Peatmoss"
            });
            nonvascular.Add(new Plant
            {
                Name = "Bryophyte",
                Details = "Bryophyte, traditional name for any nonvascular seedless plant—namely, any of the mosses (division Bryophyta), hornworts (division Anthocerotophyta), and liverworts (division Marchantiophyta). Most bryophytes lack complex tissue organization, yet they show considerable diversity in form and ecology. They are widely distributed throughout the world and are relatively small compared with most seed-bearing plants.",
                Image = "Bryophyte"
            });
            nonvascular.Add(new Plant
            {
                Name = "Liverwort",
                Details = "Liverwort, (division Marchantiophyta), any of more than 9,000 species of small nonvascular spore-producing plants. Liverworts are distributed worldwide, though most commonly in the tropics. Thallose liverworts, which are branching and ribbonlike, grow commonly on moist soil or damp rocks, while leafy liverworts are found in similar habitats as well as on tree trunks in damp woods. The thallus (body) of thallose liverworts resembles a lobed liver—hence the common name liverwort (“liver plant”). The plants are not economically important to humans but do provide food for animals, facilitate the decay of logs, and aid in the disintegration of rocks by their ability to retain moisture.",
                Image = "liverwort"
            });
           
        }
    }
}