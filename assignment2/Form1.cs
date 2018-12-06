using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<String, String> dict = new Dictionary<string, string>();
            dict.Add("apply", "Make a formal application or request.");
            dict.Add("abdominal", "concerning the stomach and the area below it");
            dict.Add("a supply", "a battery or other source of power for heating the filament or cathode heater of an electron tube.");
            dict.Add("b-boy",  "a boy or young man who likes or is involved in hip-hop culture.");
            dict.Add("baal", "no; not.");
            dict.Add("bacha", "Hinglish informal a child or a young person");
            dict.Add("cabby", "a cabdriver.");
            dict.Add("cabin", "a small house or cottage, usually of simple design and construction");
            dict.Add("cache", "a hiding place, especially one in the ground, for ammunition, food, treasures, etc.");
            dict.Add("dace", "a small, freshwater cyprinoid fish, Leuciscus leuciscus, of Europe, having a stout, fusiform body.");
            dict.Add("dab", "to pat or tap gently, as with something soft or moist");
            dict.Add("damn", "to declare (something) to be bad, unfit, invalid, or illegal.");
            dict.Add("eared", "having ears or earlike appendages.");
            dict.Add("earn", "to gain or get in return for one's labor or service");
            dict.Add("earth", "the inhabitants of this planet, especially the human inhabitants");
            dict.Add("facebar", "a wrestling hold in which a wrestler stretches the skin on his opponent's face backwards");
            dict.Add("facebook", "the brand name of a social media service and website, launched in 2004.");
            dict.Add("facepalm", "the gesture of placing the palm of one's hand across the face, as to express embarrassment, frustration," +
                " disbelief, etc. (often used as an interjection)");
            dict.Add("gaeta", "a seaport in W central Italy, on the Gulf of Gaeta off the Tyrrhenian Sea.");
            dict.Add("gain", "to get (something desired), especially as a result of one's efforts");
            dict.Add("gaddi", "Italian painter and architect.");
            dict.Add("hackathon", "a usually competitive event in which people work in groups on software or hardware projects, " +
                "with the goal of creating a functioning product by the end of the event");
            dict.Add("haboob", "a thick dust storm or sandstorm that blows in the deserts of North Africa and Arabia or on the plains of India.");
            dict.Add("hack off", "informal to annoy, irritate, or disappoint");
            dict.Add("ibn Sina", "Arabic name of Avicenna.");
            dict.Add("icefall", "a jumbled mass of ice in a glacier.");
            dict.Add("idea", "any conception existing in the mind as a result of mental understanding, awareness, or activity.");
            dict.Add("jackpot", "the chief prize or the cumulative stakes in a game or contest, as in bingo, a quiz contest, or a slot machine.");
            dict.Add("jackson", "Andrew  Old Hickory , 1767–1845, U.S. general: 7th president of the U.S. 1829–37.");
            dict.Add("jailer", "a person who is in charge of a jail or section of a jail.");
            dict.Add("kajar", "a dynasty that ruled Persia 1794–1925.");
            dict.Add("kaaba", "a cube-shaped building in Mecca, the most sacred Muslim pilgrim shrine, " +
                "into which is built the black stone believed to have been given by Gabriel to Abraham. Muslims turn in its direction when praying");
            dict.Add("kabaddi", "a game played between two teams of seven players, " +
                "in which individuals take turns to chase and try to touch members of the opposing team without being captured by them");
            dict.Add("labor", "productive activity, especially for the sake of economic gain.");
            dict.Add("lawn", "a stretch of open, grass-covered land, especially one closely mowed, as near a house, on an estate, or in a park.");
            dict.Add("lamp", "any of various devices furnishing artificial light, as by electricity or gas.");
            dict.Add("ma'am", "(in Britain) a term used in addressing the queen or a royal princess.");
            dict.Add("ma", "a female parent.");
            dict.Add("macaroon", "a drop cookie made of egg whites, sugar, usually almond paste or coconut, and sometimes a little flour.");
            dict.Add("naggish", "tending to nag; somewhat nagging.");
            dict.Add("nail", "a thin, horny plate, consisting of modified epidermis, growing on the upper side of the end of a finger or toe.");
            dict.Add("naked eye", "Sight unassisted by an instrument such as a microscope or telescope.");
            dict.Add("obedient", "obeying or willing to obey; complying with or submissive to authority");
            dict.Add("obit", "the date of a person's death.");
            dict.Add("object", "anything that is visible or tangible and is relatively stable in form.");
            dict.Add("pacific", "tending to make or preserve peace; conciliatory");
            dict.Add("pack", "a group of things wrapped or tied together for easy handling or carrying; " +
                "a bundle, especially one to be carried on the back of an animal or a person");
            dict.Add("packman", "a peddler.");
            dict.Add("quaco", "a male day name for Wednesday.");
            dict.Add("quad", "a quadrangle, as on a college campus.");
            dict.Add("quarter", "one of the four equal or equivalent parts into which anything is or may be divided");
            dict.Add("rabot", "a hardwood block used for rubbing marble before polishing.");
            dict.Add("race", "a contest of speed, as in running, riding, driving, or sailing.");
            dict.Add("ratchet", "flashy, unrefined, etc.; low-class");
            dict.Add("sacred", "devoted or dedicated to a deity or to some religious purpose; consecrated.");
            dict.Add("safe surfing", "the practice of using security measures to protect one's computer while surfing the internet");
            dict.Add("safe", "secure from liability to harm, injury, danger, or risk");
            dict.Add("table tennis", "a game resembling tennis, played on a table with small paddles and a hollow celluloid or plastic ball.");
            dict.Add("tableside", "alongside or at a table, especially in a restaurant");
            dict.Add("tablet", "a number of sheets of writing paper, business forms, etc., fastened together at the edge; pad.");
            dict.Add("ugly", "very unattractive or unpleasant to look at; offensive to the sense of beauty; displeasing in appearance.");
            dict.Add("u.k", "United Kingdom.");
            dict.Add("ulcer", "Pathology . a sore on the skin or a mucous membrane, accompanied by the disintegration of tissue, the formation of pus, etc.");
            dict.Add("vague", "not clearly or explicitly stated or expressed");
            dict.Add("vail", "to let sink; lower.");
            dict.Add("vain", "excessively proud of or concerned about one's own appearance, qualities, achievements, etc.");
            dict.Add("wagga", "Australian a blanket or bed covering made out of sacks stitched together");
            dict.Add("wagon", "any of various kinds of four - wheeled vehicles designed to be pulled or having its own motor" +
                " and ranging from a child's toy to a commercial vehicle for the transport of heavy loads, delivery, etc.");
            dict.Add("waist", "the part of the body in humans between the ribs and the hips, usually the narrowest part of the torso.");
            dict.Add("xerox", "a brand name for a copying machine for reproducing printed, written, or pictorial matter by xerography.");
            dict.Add("xda", "trademark a combined computer and mobile phone");
            dict.Add("xing", "crossing (used especially on road signs)");
            dict.Add("yasht", "a hymn to a deity.");
            dict.Add("yahoo", "(an exclamation used to express joy, excitement, etc.)");
            dict.Add("yeah", "yes.");
            dict.Add("zebra body", "A granule found in Schwann cells and macrophages of individuals suffering from metachromatic leukodystrophy.");
            dict.Add("zero hour", "the time set for the beginning of a military attack or operation.");
            dict.Add("zero", "the figure or symbol 0, which in the Arabic notation for numbers stands for the absence of quantity; cipher.");
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter word first to find its meaning!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (dict.ContainsKey(textBox1.Text) == true)
                {
                    richTextBox1.Text = dict[textBox1.Text];
                }

            }
        }
    }
}
