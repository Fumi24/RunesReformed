using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunesReformed1._1.Translators
{
    public class RiotTranslator
    {
        public int[] Translate(string riotURL)
        {

            // Split URL at '='.
            string[] splitURL = riotURL.Split('=');

            // Get the Last of the split, which has the rune data we want.
            string buildString = splitURL.Last();

            // Long long list of lists that has our Rune Data we will be calling.
            // If we want to get runes for Precision, we need the index from the 'runePaths' List of the one we want.
            // Ex:   runeDataCollection[ runePaths.indexOf(  ID  ) ][ theIndexOfTheRow ][ theIndexOfRuneInThatRow ]
            //  |    runeDataCollection[ runePaths.indexOf( 8000 ) ][         0        ][            1            ]
            // The above example returns '8008|Lethal Tempo', then split the string at '|' and '[#]' with 0 or 1 to get the ID (0) or the Name (1).   
            List<long> runePaths = new List<long>() { 8000, 8100, 8200, 8300, 8400 };
            List<List<List<string>>> runeDataCollection =
                new List<List<List<string>>> {
                    // Precision // Slots
                    new List<List<string>>() {
                        new List<string>() { "8005|Press The Attack", "8008|Lethal Tempo", "8021|Fleet Footwork" },
                        new List<string>() { "9101|Overheal", "9111|Triumph", "8009|Presence of Mind" },
                        new List<string>() { "9104|Legend: Alacrity", "9105|Legend: Tenacity", "9103|Legend: Bloodline" },
                        new List<string>() { "8014|Coup de Grace", "8017|Cut Down", "8299|Last Stand" }
                    },
                    // Domination // Slots
                    new List<List<string>>() {
                        new List<string>() { "8112|Electrocute", "8124|Predator", "8128|Dark Harvest" },
                        new List<string>() { "8126|Cheap Shot", "8139|Taste of Blood", "8143|Sudden Impact" },
                        new List<string>() { "8136|Zombie Ward", "8120|Ghost Poro", "8138|Eyeball Collection" },
                        new List<string>() { "8135|Ravenous Hunter", "8134|Ingenious Hunter", "8105|Relentless Hunter" }
                    },
                    // Sorcery // Slots
                    new List<List<string>>() {
                        new List<string>() { "8214|Summon Aery", "8229|Arcane Comet", "8230|Phase Rush" },
                        new List<string>() { "8224|Nullifying Orb", "8226|Manaflow Band", "8243|The Ultimate Hat" },
                        new List<string>() { "8210|Transcendence", "8234|Celerity", "8233|Absolute Focus" },
                        new List<string>() { "8237|Scorch", "8232|Waterwalking", "8236|Gathering Storm" }
                    },
                    // Inspiration // Slots
                    new List<List<string>>() {
                        new List<string>() { "8326|Unsealed Spellbook", "8351|Glacial Augment", "8359|Kleptomancy" },
                        new List<string>() { "8306|Hextech Flashtraption", "8345|Biscuit Delivery", "8313|Perfect Timing" },
                        new List<string>() { "8304|Magical Footwear", "8321|Future's Market", "8316|Minion Dematerializer" },
                        new List<string>() { "8347|Cosmic Insight", "8410|Approach Velocity", "8339|Celestial Body" }
                    },
                    // Resolve // Slots
                    new List<List<string>>() {
                        new List<string>() { "8437|Grasp of the Undying", "8439|Aftershock", "8465|Guardian" },
                            new List<string>() { "8242|Unflinching", "8446|Demolish", "8463|Font of Life" },
                            new List<string>() { "8430|Iron Skin", "8435|Mirror Shell", "8429|Conditioning" },
                            new List<string>() { "8451|Overgrowth", "8453|Revitalize", "8444|Second Wind" }
                    }
                };

            // The Array we are saving the ids once we firgure out what they each are.
            int[] Build = buildString.ToString().Select(num => int.Parse(num.ToString())).ToArray();
            // This sets the 0th and 5th numbers in the 'buildString' (Primary and Secondary ids) in the 'Build' Array. It's messy, but works. 
            void setBuild(int index)
            {
                int temp = int.Parse(buildString[5].ToString());
                if (index == 5)
                {
                    if (int.Parse(buildString[0].ToString()) < int.Parse(buildString[5].ToString()) + 1)
                    {
                        temp = int.Parse(buildString[5].ToString()) + 1;
                    }
                    Build[index] = int.Parse(runePaths[temp].ToString());
                }
                else
                {
                    Build[index] = int.Parse(runePaths[int.Parse(buildString[index].ToString())].ToString());
                }
            }
            // As explained above, these two statement will set the 0th and 5th to the Primary and Secondary ids.
            setBuild(0);
            setBuild(5);

            // This variable is not completely needed. But makes the code all cleaner to use it.
            // Also, I use this because when the Primary ids index is greater than the Secondary's: the secondary's
            // id will be one lower than it's index actually should be. See when it's used after the first 'for' loop with 'tempPath'.
            var path = int.Parse(buildString[0].ToString());
            // The int 'z' is used for the value at that index in the 'buildString' variable.
            for (int z = 1; z <= 4; z++)
            {
                // Value at the index 'z' as int.
                var index = int.Parse(buildString[z].ToString());
                // Use 'path' as index, then use 'z' minus 1 (since our 'for' starts at 1), finally use the number within the
                // 'buildString' (at the index 'z') to get the String in that list. 
                var runeData = runeDataCollection[path][z - 1][int.Parse(buildString[z].ToString())];
                // At index 'z' set that Id we got.
                Build[z] = int.Parse(runeData.Split(char.Parse("|"))[0].ToString());
            }
            // [For: Testing] -> System.Windows.Forms.MessageBox.Show("DONE");

            // How the site works is, if the Primary index is less than the Secondary's the Secondary index
            // (in 'buildString' at index 5) will be one lower than it should be. So that's what this takes care of.
            int tempPath;
            if (int.Parse(buildString[0].ToString()) < int.Parse(buildString[5].ToString()) + 1)
            {
                tempPath = int.Parse(buildString[5].ToString()) + 1;
            }
            else
            {
                tempPath = int.Parse(buildString[5].ToString());
            }

            // Assign the new path index.
            path = tempPath;
            // Do the same looping we did before, but with different range.
            for (int z = 6; z <= 7; z++)
            {
                // Get the value at index 'z'.
                var index = int.Parse(buildString[z].ToString());
                // Get the row number: Divide the 'index' by 3, take the first character in the string (to round),
                // and add 1 (because we are not including Keystones with the Secondary).
                var row = int.Parse((double.Parse(index.ToString()) / 3.0).ToString()[0].ToString()) + 1;
                // Get the index of rune in that 'row' it is: get the modulo result of the 'index' and 3. Modulo is getting the remainder, so this result
                // will never be more than 2, because it will have a remainder of 0.
                var iteminrow = (index % 3); // System.Windows.Forms.MessageBox.Show(iteminrow.ToString());
                // Gets the string from: List with index to get List of paths, index again for the path, and index again for the rune at that index in the row.
                var runeData = runeDataCollection[path][row][int.Parse(iteminrow.ToString())];
                // At index 'z' set that Id we got.
                Build[z] = int.Parse(runeData.Split(char.Parse("|"))[0].ToString());
            }
            // [For: Testing] -> System.Windows.Forms.MessageBox.Show(String.Join(", ", Array.ConvertAll(Build.ToArray(), n => n.ToString())));
            // [For: Testing] -> System.Windows.Forms.MessageBox.Show("DONE");

            // Return the completed Array of Ids.
            return Build;
        }
    }
}
