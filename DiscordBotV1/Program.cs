using System;
using System.Linq;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.Net;
using Discord.WebSocket;
using Discord.API;
using Discord.Rest;
using MemberInfo = System.Reflection.MemberInfo;

namespace DiscordBotV1
{
    class Program
    {
        /*[Command("kick"), Alias("Kick"), Summary("Kicks a user from the server")]
        public async Task Kick(SocketGuildUser userAccount, string reason)
        {
            var user = Context.User as SocketGuildUser;
            var role = (user as IGuildUser).Guild.Roles.FirstOrDefault(x => x.Name == "Admin");
            if (!userAccount.Roles.Contains(role))
            {
                if (user.GuildPermissions.KickMembers)
                {
                    await userAccount.KickAsync(reason);
                    await Context.Channel.SendMessageAsync($"The user `{userAccount}` has been kicked, for {reason}");
                }
                else
                {
                    await Context.Channel.SendMessageAsync("No permissions for kicking a user.");
                }
            }
            else
            {
                await Context.Channel.SendMessageAsync("This User can't be kicked, because the user has a admin role.");
            }
        }*/

        public static void Main(string[] args)
            => new Program().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync()
        {
            
        }
    }
}