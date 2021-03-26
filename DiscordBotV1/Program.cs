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
        public static void Main(string[] args)
            => new Program().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync()
        {
            
        }
    }
}