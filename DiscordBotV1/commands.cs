using System;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace DiscordBotV1
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("ban")]
        public async Task BanAsync(IGuildUser user = null)
        {
            if (user == null)
            {
                await ReplyAsync("Specify a user");
            }
            else
            {
                await user.BanAsync();
            }
        }

        public class response : ModuleBase<SocketCommandContext>
        {
            [Command("ping")]
            public async Task PingAsync()
            {
                await Context.Channel.SendMessageAsync("I am a dysfunctional bot that finally works");
            }
        }
    }
}