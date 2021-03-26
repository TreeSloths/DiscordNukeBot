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
        private DiscordSocketClient _client;

        public static void Main(string[] args)
            => new Program().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync()
        {
            _client = new DiscordSocketClient();

            _client.Log += Log;
            var token = Environment.GetEnvironmentVariable("DISCORD_BOT_TOKEN");

            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();

            await Task.Delay(-1);
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
    }
}