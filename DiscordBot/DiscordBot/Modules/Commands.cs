/* Made by Erika Fermin and Colin Pytlik
 * to make fun of our friend Graham. 
 * 10/25/2019*/


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace DiscordBot.Modules
{


    public class Commands : ModuleBase<SocketCommandContext>
    {
        private string[] array = {"I'm going to make him an offer he can't refuse.",
                                    "Toto, I've got a feeling we're not in Kansas anymore.",
                                    "May the Force be with you.",
                                    "Fasten your seatbelts.It's going to be a bumpy night.",
                                    "You talking to me?",
                                    "E.T. phone home.",
                                    "A census taker once tried to test me. I ate his liver with some fava beans and a nice Chianti.",
                                    "Bond. James Bond.",
                                    "There's no place like home.",
                                    "I'm walking here! I'm walking here!",
                                    "Show me the money!" ,
                                    "You can't handle the truth!" ,
                                    "I'll have what she's having.",
                                    "You're gonna need a bigger boat.",
                                    "I'll be back.",
                                    "Mama always said life was like a box of chocolates. You never know what you're gonna get.",
                                    "I see dead people.",
                                    "Houston, we have a problem.",
                                    "It's alive! It's alive!",
                                    "You've got to ask yourself one question: 'Do I feel lucky?' Well, do ya, punk?",
                                    "Keep your friends close, but your enemies closer.",
                                    "Say \"hello\" to my little friend!",
                                    "Elementary, my dear Watson." ,
                                    "Get your stinking paws off me, you damned dirty ape.",
                                    "Hmm did somebody say MURRRRRRRRRRRRRRRRDDDDER?!",
                                    "I found DIAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAMONDS!!!!",
                                    "Here's Johnny!",
                                    "Hasta la vista, baby." ,
                                    "My precious.",
                                    "Carpe diem. Seize the day, boys. Make your lives extraordinary.",
                                    "I feel the need - the need for speed!",
                                    "Nobody puts Baby in a corner.",
                                    "I'm king of the world!","It's just a flesh wound.",
                                    "I'm about to do to you what Limp Bizkit did to music in the late '90s.",
                                    "Martini. Gin, not vodka. Obviously. Stirred for 10 seconds while glancing at an unopened bottle of vermouth.",
                                    "'Greater good?' I am your wife! I'm the greatest good you're ever gonna get!",
                                    "We get the warhead and we hold the world ransom for…. One million dollars.",
                                    "I'm in a glass case of emotion!",
                                    "That rug really tied the room together, did it not?",
                                    "It's not a man purse. It's called a satchel. Indiana Jones wears one.",
                                    "Who ya gonna call?",
                                    "Hello, my name is Inigo Montoya. You killed my father. Prepare to die.",
                                    "Schwing",
                                    "This one time, at band camp . . .",
                                    "You sit on a throne of lies.",
                                    "Stop trying to make fetch happen",
                                    "I’m not like a regular mom, I’m a cool mom.",
                                    "I got a Stage 5 clinger.",
                                    "Am I not turtley enough for your turtle club?",
                                    "Do you ever stroke your Necluda?",
                                    "It's Dangerous to go Alone take this",
                                    "Your Mother was a Hamster, and your Father smelt of Elderberries!",
                                    "War.War never Changes" ,
                                    "The cake is a lie",
                                    "A man chooses! A slave obeys!",
                                    "What do the numbers mean, Mason?",
                                    "You Have Died",
                                    "We all make choices in life, but in the end our choices make us.",
                                    "What is better? To be born good or to overcome your evil nature through great effort?",
                                    "The right man in the wrong place can make all the difference in the world.",
                                    "Stand in the ashes of a trillion dead souls, and asks the ghosts if honor matters. The silence is your answer.",
                                    "Bring me a bucket, and I'll show you a bucket!",
                                    "Smells vaguely of butts and death"};

        [Command("quote")]
        public async Task Quote()
        {

            int size = array.Length;
            Random rnd = new Random();
            int quote = rnd.Next(size);

            await ReplyAsync(array[quote]);
        }
    }
}
