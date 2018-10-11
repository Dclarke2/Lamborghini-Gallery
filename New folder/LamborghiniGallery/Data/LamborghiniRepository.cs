using LamborghiniGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LamborghiniGallery.Data
{
    public class LamborghiniRepository
    {
        private static Lamborghini[] _lamborghini = new Lamborghini[] //Array because of multiple lamborghini variations. 
        {
            new Lamborghini()
            {
                Id = 1,
                CarModel = "Lamborghini Huracan",
                YearModel = 2018,
                DescriptionHtml = "<p>The Lamborghini Huracán (Spanish for \"hurricane\"; [uɾaˈkan]) is a sports car manufactured by Italian automotive manufacturer Lamborghini replacing the previous V10 flagship, the Gallardo. The Huracán made its worldwide debut at the 2014 Geneva Auto Show, and was released in the market the second quarter of 2014. The LP 610-4 designation comes from the fact that this car has 610 metric horsepower and 4 wheel drive, while LP stands for \"Longitudinale Posteriore\", which refers to the longitudinal mid-rear engine position. The Huracán was named \"The Supercar of the Year 2014\" by automotive magazine <strong>Top Gear</strong>.</p>",
                Variants = new Variant[]
                {
                    new Variant(){ModelName = "2.1 huracán lp 610-4 coupe", ModelYearRelease = "(2014–present)"},
                    new Variant(){ModelName = "2.2 huracán lp 610-4 polizia", ModelYearRelease = "(2015-present)"},
                    new Variant(){ModelName = "2.3 huracán lp 610-4 avio", ModelYearRelease = "(2015-present)"},
                    new Variant(){ModelName = "2.4 huracán lp 610-4 spyder ", ModelYearRelease = "(2016–present)"},
                    new Variant(){ModelName = "2.5 huracán lp 580-2", ModelYearRelease = "(2016-present)"},
                    new Variant(){ModelName = "2.6 huracán lp 580-2 pope francis", ModelYearRelease = "(2016-present)"},
                    new Variant(){ModelName = "2.7 huracán lp 580-2 spyder", ModelYearRelease = "(2016-present)"},
                    new Variant(){ModelName = "2.8 huracán lp 640-4 performante", ModelYearRelease = " (2017-present)"},
                    new Variant(){ModelName = "2.9 huracán lp 640-4 performante spyder", ModelYearRelease = "(2018–present)"},


                },
                Favorite = false

            },

            new Lamborghini()
            {
                Id = 2,
                CarModel = "Lamborghini Huracan Performante",
                YearModel = 2017,
                DescriptionHtml = "<p>Somehow, though, this thing is idiotically fast. In a straight line it will leave a Ferrari 458 Special Needs for dead. And around the Nürburgring, it’s faster than any of the million-quid hypercars. You won’t believe this — very few test drivers that witnessed it did — but it went round in six minutes and 52 seconds. And it’s not just fast. It’s exciting. It may be making the sound of a universe forming and your head may be pinned back against the headrest but you can still feel it blowing gently on the hairs on your arms. This is a car that roars and purrs at the same time. It’s like an Italian tomato — little and bright and so full of taste sensations it makes your eyes go crossed.<strong>Jeremy Clarkson - Top Gear</strong>.</p>",
                Variants = new Variant[]
                {
                    new Variant(){ModelName = "2.1 huracán lp 610-4 coupe", ModelYearRelease = "(2014–present)"},
                    new Variant(){ModelName = "2.2 huracán lp 610-4 polizia", ModelYearRelease = "(2015-present)"},
                    new Variant(){ModelName = "2.3 huracán lp 610-4 avio", ModelYearRelease = "(2015-present)"},
                    new Variant(){ModelName = "2.4 huracán lp 610-4 spyder ", ModelYearRelease = "(2016–present)"},
                    new Variant(){ModelName = "2.5 huracán lp 580-2", ModelYearRelease = "(2016-present)"},
                    new Variant(){ModelName = "2.6 huracán lp 580-2 pope francis", ModelYearRelease = "(2016-present)"},
                    new Variant(){ModelName = "2.7 huracán lp 580-2 spyder", ModelYearRelease = "(2016-present)"},
                    new Variant(){ModelName = "2.8 huracán lp 640-4 performante", ModelYearRelease = " (2017-present)"},
                    new Variant(){ModelName = "2.9 huracán lp 640-4 performante spyder", ModelYearRelease = "(2018–present)"},


                },
                Favorite = false

            },
            new Lamborghini()
            {
                Id = 3,
                CarModel = "Lamborghini Huracan Performante Spyder",
                YearModel = 2018,
                DescriptionHtml = "<p>Leaner, tighter and more rewarding than any Huracan before it, the Performante was the V10 Lamborghini we had been waiting for. Now, the Spyder has received the very same treatment. The 5.2-litre V10 has been wrung out to 631bhp, while torque jumps up from 413 to 443lb ft. The weight saving is 35kg like for like, mostly down to the use of a lightweight exhaust system and what Lamborghini calls Forged Composites, which to you and I looks like chopped rather than woven carbon fibre. The chassis has been completely reworked for sharper, more focussed dynamics and the tyres are stupendously grippy Pirelli P Zero Corsas.<strong>AutoCar</strong>.</p>",
                Variants = new Variant[]
                {
                    new Variant(){ModelName = "2.1 huracán lp 610-4 coupe", ModelYearRelease = "(2014–present)"},
                    new Variant(){ModelName = "2.2 huracán lp 610-4 polizia", ModelYearRelease = "(2015-present)"},
                    new Variant(){ModelName = "2.3 huracán lp 610-4 avio", ModelYearRelease = "(2015-present)"},
                    new Variant(){ModelName = "2.4 huracán lp 610-4 spyder ", ModelYearRelease = "(2016–present)"},
                    new Variant(){ModelName = "2.5 huracán lp 580-2", ModelYearRelease = "(2016-present)"},
                    new Variant(){ModelName = "2.6 huracán lp 580-2 pope francis", ModelYearRelease = "(2016-present)"},
                    new Variant(){ModelName = "2.7 huracán lp 580-2 spyder", ModelYearRelease = "(2016-present)"},
                    new Variant(){ModelName = "2.8 huracán lp 640-4 performante", ModelYearRelease = " (2017-present)"},
                    new Variant(){ModelName = "2.9 huracán lp 640-4 performante spyder", ModelYearRelease = "(2018–present)"},


                },
                Favorite = false

            }





    };
        public Lamborghini GetLamborghini(int id) //id will allow caller of method to pick out a different type of Lambo.
        {
            Lamborghini lamborghiniToReturn = null;

            foreach (var lamborghini in _lamborghini)//Foreach loop will go through all elements in array. The variable you define for the loop (lamborghini) will be set to one of the elements of the array. 
            {                                       //So the first time the loop runs lamborghini, lamborghini will be set to the first item in the private array _lamborghini. Second time it will be set to the second item etc. 
                if (lamborghini.Id == id) //If statement checking if lamborghini item id property equals the id passed into method. 
                {
                    lamborghiniToReturn = lamborghini; //Matches id we're looking for to id inputted. So if 1 is performante and you type in 1 it will check it's matched. 
                    break; //<-- breaks out of loop when matching id is found.
                    //If id is matched lamborghiniToReturn wont be null it'll be a value matched in _lamborghini. 

                }
            }
            return lamborghiniToReturn; //<- if loop finishes then means that none of the lamborghini in the items array had an id that matched what was passed into method, so will return null.
            
        }


    }
}