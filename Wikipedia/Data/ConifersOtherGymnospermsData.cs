using System;
using System.Collections.Generic;
using System.Text;

namespace Wikipedia.Data
{
   public static class Conifers_OtherGymnospermsData
    {
        public static IList<Plant> conifers { get; set; }

        static Conifers_OtherGymnospermsData()
        {
            conifers = new List<Plant>();

            conifers.Add(new Plant
            {
                Name = "Cedar",
                Details = "Cedar, any of four species of ornamental and timber evergreen conifers of the genus Cedrus (family Pinaceae), three native to mountainous areas of the Mediterranean region and one to the western Himalayas. Many other coniferous trees known as “cedars” resemble true cedars in being evergreen and in having aromatic, often red or red-tinged wood that in many cases is decay-resistant and insect-repellent. The giant arborvitae, incense cedar, and some junipers (viz., red cedar; q.v.) provide the familiar “cedarwood” of pencils, chests, closet linings, and fence posts; an oil distilled from the wood is used in many toiletries.",
                Image = "Cedar"
            });
            conifers.Add(new Plant
            {
                Name = "Pine",
                Details = "Pine, (genus Pinus), genus of about 120 species of evergreen conifers of the pine family (Pinaceae), distributed throughout the world but native primarily to northern temperate regions. The chief economic value of pines is in the construction and paper-products industries, but they are also sources of turpentine, rosin, oils, and wood tars. Edible pine seeds, which are sold commercially as pine nuts, piñons, or pinyons, are produced by several species. Many pines are cultivated as ornamentals, including black, white, Himalayan, and stone pines, and some are planted in reforestation projects or for windbreaks. Pine-leaf oil, used medicinally, is a distillation product of the leaves; charcoal, lampblack, and fuel gases are distillation by-products.",
                Image = "Pine"
            });
            conifers.Add(new Plant
            {
                Name = "Cypress",
                Details = "Cypress, any of 12 species of ornamental and timber evergreen conifers constituting the genus Cupressus of the family Cupressaceae, distributed throughout warm-temperate and subtropical regions of Asia, Europe, and North America. Many resinous, aromatic evergreen trees called cypress belong to other genera of the same family, especially species of false cypress and cypress pine. The name “cypress” is occasionally used for some species of fustic and for bald cypress; in eastern Canada it often denotes jack pine.",
                Image = "cypress"
            });
            conifers.Add(new Plant
            {
                Name = "Juniper",
                Details = "Juniper, (genus Juniperus), genus of about 60 to 70 species of aromatic evergreen trees or shrubs of the cypress family (Cupressaceae), distributed throughout the Northern Hemisphere. A number of species are cultivated as ornamentals and are useful for their timber.",
                Image = "juniper"
            });
            conifers.Add(new Plant
            {
                Name = "Seed Fern",
                Details = "seed fern, loose confederation of seed plants from the Carboniferous and Permian periods (about 360 to 250 million years ago). Some, such as Medullosa, grew as upright, unbranched woody trunks topped with a crown of large fernlike fronds; others, such as Callistophyton, were woody vines. All had fernlike foliage; however, they reproduced by seeds, with ovules and pollen organs attached to the fronds. Gamete-producing structures in the seeds were surrounded by a hard inner integument and a fleshy outer layer. These features have led some authorities to speculate that these seeds may have been dispersed by animals. Some seeds were large. (Pachytesta gigantea, a seed of Medullosa, grew up to 7 cm [2.7 inches] long.) Pollen organs of seed ferns were also large and complex and were commonly made up of many pollen sacs fused into a large structure. Some authorities suggest that these large structures and the large pollen grains they contained were evidence of pollination by animals.",
                Image = "seedfern"
            });
            conifers.Add(new Plant
            {
                Name = "Yew",
                Details = "Yew, any tree or shrub of the genus Taxus (family Taxaceae), approximately eight species of ornamental evergreens, distributed throughout the Northern Hemisphere. Other trees called yew but not in this genus are the plum-yew, Prince Albert yew (see Podocarpaceae), and stinking yew. Two species are always shrubby, but the others may become trees up to 25 metres (about 80 feet) tall. Yews have rich, dark-green foliage. The branches are erect or spreading and are closely covered with flattened, linear leaves about 1/2 to 3 centimetres (about 1/5 to 1 1/5 inches) long. The leaves have two yellowish- or grayish-green bands along the underside. They are attached in spirals around the branch but, because of a twist at their bases, appear to grow in two rows along the sides of the branch. The reproductive structures, small, rounded, scaly, and conelike on pollen-bearing plants and minute, green, and solitary on ovule-bearing plants, are located between the leafstalk and the stem. The seeds are usually solitary, borne at the ends of short branches. As a seed matures, it is enveloped by a fleshy, red, cup-shaped aril. The foliage and seeds, but not the arils, contain a poisonous alkaloid, sometimes fatal to livestock.",
                Image = "yew"
            });
       conifers.Add(new Plant
            {
                Name = "Gymnosperm",
                Details = "Gymnosperm, any vascular plant that reproduces by means of an exposed seed, or ovule—unlike angiosperms, or flowering plants, whose seeds are enclosed by mature ovaries, or fruits. The seeds of many gymnosperms (literally “naked seeds”) are borne in cones and are not visible until maturity. Taxonomists recognize four distinct divisions of extant (nonextinct) gymnospermous plants—Coniferophyta, Cycadophyta, Ginkgophyta, and Gnetophyta—with 88 genera and more than 1,000 species distributed throughout the world.",
                Image = "gymnosperms"
       });
       conifers.Add(new Plant
            {
                Name = "Conifer",
                Details = "Conifer, any member of the division Pinophyta, class Pinopsida, order Pinales, made up of living and fossil gymnospermous plants that usually have needle-shaped evergreen leaves and seeds attached to the scales of a woody bracted cone. Among living gymnosperm divisions, the conifers show little similarity to the Cycadophyta and Gnetophyta but share several vegetative and reproductive traits with the Ginkgophyta. Conifers are most abundant in cool temperate and boreal regions, where they are important timber trees and ornamentals, but they are most diverse in warmer areas, including tropical mountains.",
                Image = "conifer"
       });
        }
    }
}