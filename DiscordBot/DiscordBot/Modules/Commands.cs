using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace DiscordBot.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
  
        [Command("Hi")]
        public async Task Ping()
        {
            await ReplyAsync("Hello world!");
        }
        [Command("Hello")]
        public async Task Hello()
        {
            var user = Context.Guild.GetUser(Context.User.Id).Nickname;

            await ReplyAsync("Heyo " + user + "!");

        }

    }
}
